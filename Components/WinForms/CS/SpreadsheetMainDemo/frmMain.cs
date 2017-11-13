using System;
using DevExpress.Utils;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.Utils.About;


namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        public frmMain() {
            InitializeComponent();
        }

        #region Properties
        protected override string DemoName { get { return "XtraSpreadsheet Main Demo (" + DemoUtils.GetLanguageString() + " code)"; } }
        #endregion

        protected override void ShowAbout() {
            SpreadsheetControl.About();
        }
        protected override string ProductName { get { return "XtraSpreadsheet"; } }
        protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResources("AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new SpreadsheetRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl groupControl, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.DoShowModule(name, groupControl, caption, RibbonMenuManager as SpreadsheetRibbonMenuManager);
        }

        private void frmMain_Load(object sender, EventArgs e) {
            //CultureInfo culture = CultureInfo.InvariantCulture;
            //sharedDictionaryStorage.Dictionaries.Clear();
            //SpellCheckerISpellDictionary dictionary = new SpellCheckerISpellDictionary(DemoUtils.GetRelativePath("american.xlg"), DemoUtils.GetRelativePath("english.aff"), culture);
            //dictionary.AlphabetPath = DemoUtils.GetRelativePath("EnglishAlphabet.txt");
            //sharedDictionaryStorage.Dictionaries.Add(dictionary);
            //SpellCheckerCustomDictionary customDictionary = new SpellCheckerCustomDictionary(DemoUtils.GetRelativePath("CustomEnglish.dic"), culture);
            //sharedDictionaryStorage.Dictionaries.Add(customDictionary);
        }
    }

    public class SpreadsheetRibbonMenuManager : RibbonMenuManager {
        public SpreadsheetRibbonMenuManager(RibbonMainForm form)
            : base(form) {
        }
    }
}
