﻿using System;
using System.Globalization;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Model;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.Office.NumberConverters;
using DevExpress.XtraRichEdit.Services;
using DevExpress.Utils;

namespace DevExpress.XtraRichEdit.Demos {
    #region AutoCorrectModule
    public partial class AutoCorrectModule : DevExpress.XtraRichEdit.Demos.TutorialControl {

        public AutoCorrectModule() {
            InitializeComponent();
            ChildRibbon.SelectedPage = ChildRibbon.Pages["AutoCorrect"];
            SpellCheckerHelper.AddDictionaries(sharedDictionaryStorage1);
            OpenXmlLoadHelper.Load("AutoCorrect.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();

            richEditControl.Options.AutoCorrect.CorrectTwoInitialCapitals = true;
            richEditControl.Options.AutoCorrect.UseSpellCheckerSuggestions = true;

            IAutoCorrectService service = richEditControl.GetService<IAutoCorrectService>();
            if (service != null) {
                AutoCorrectReplaceInfoCollection replaceTable = new AutoCorrectReplaceInfoCollection();
                replaceTable.Add("(C)", "©");
                replaceTable.Add(new AutoCorrectReplaceInfo(":)", ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraRichEdit.Demos.smile.png", GetType().Assembly)));
                replaceTable.Add("pctus", "Please do not hesitate to contact us again in case of any further questions.");
                replaceTable.Add("wnwd", "well-nourished, well-developed");
                service.SetReplaceTable(replaceTable);
            }

            richEditControl.Focus();
        }

        #region Properties
        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }
        #endregion

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }

        void replaceAsYouTypeBarItem_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            richEditControl.Options.AutoCorrect.ReplaceTextAsYouType = replaceAsYouTypeBarItem.Checked;
            richEditControl.Focus();
        }
        void detectUrlsBarItem_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            richEditControl.Options.AutoCorrect.DetectUrls = detectUrlsBarItem.Checked;
            richEditControl.Focus();
        }
        void correctTwoInitialCapitalsBarItem_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            richEditControl.Options.AutoCorrect.CorrectTwoInitialCapitals = correctTwoInitialCapitalsBarItem.Checked;
            richEditControl.Focus();
        }
        void useSpellCheckerSuggestionsBarItem_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            richEditControl.Options.AutoCorrect.UseSpellCheckerSuggestions = useSpellCheckerSuggestionsBarItem.Checked;
            richEditControl.Focus();
        }
        void richEditControl_AutoCorrect(object sender, AutoCorrectEventArgs e) {
            AutoCorrectInfo info = e.AutoCorrectInfo;
            e.AutoCorrectInfo = null;

            if (!customAutoCorrectBarItem.Checked)
                return;

            if (info.Text.Length <= 0 || !info.Text.Contains("%"))
                return;
            int characterPosition = info.Text.IndexOf("%");
            int decrementCount = info.Text.Length - characterPosition - 1;
            for (int i = 0; i < decrementCount; i++) info.DecrementEndPosition();

            for (; ; ) {
                if (!info.DecrementStartPosition())
                    return;

                if (IsSeparator(info.Text[0]))
                    return;

                if (info.Text[0] == '%') {
                    string replaceString = CalculateFunction(info.Text);
                    if (!String.IsNullOrEmpty(replaceString)) {
                        info.ReplaceWith = replaceString;
                        e.AutoCorrectInfo = info;
                    }
                    return;
                }
            }
        }

        string CalculateFunction(string name) {
            name = name.ToLower();

            if (name.Length > 2 && name[0] == '%' && name.EndsWith("%")) {
                int value;
                if (Int32.TryParse(name.Substring(1, name.Length - 2), out value)) {
                    OrdinalBasedNumberConverter converter = OrdinalBasedNumberConverter.CreateConverter(NumberingFormat.CardinalText, LanguageId.English);
                    return converter.ConvertNumber(value);
                }
            }

            switch (name) {
                case "%date%":
                    return DateTime.Now.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);
                case "%time%":
                    return DateTime.Now.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern);
                case "%bye%":
                    return "Yours sincerely,\r\nDavid B. Smith";
                default:
                    return String.Empty;
            }
        }
        bool IsSeparator(char ch) {
            return ch != '%' && (ch == '\r' || ch == '\n' || Char.IsPunctuation(ch) || Char.IsSeparator(ch) || Char.IsWhiteSpace(ch));
        }
    }
    #endregion
}
