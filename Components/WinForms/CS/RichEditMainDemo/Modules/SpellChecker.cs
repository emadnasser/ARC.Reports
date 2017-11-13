using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.XtraSpellChecker;
using DevExpress.XtraSpellChecker.Native;
using DevExpress.XtraSpellChecker.Parser;
using DevExpress.XtraRichEdit.SpellChecker;
using DevExpress.XtraBars;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class SpellCheckerModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public SpellCheckerModule() {
            InitializeComponent();
            this.ribbonControl1.SelectedPage = this.ribbonControl1.Pages["Review"];
            if (!DesignMode)
                SpellCheckerHelper.AddDictionaries(this.spellChecker1);
            this.spellChecker1.UseSharedDictionaries = false;
            OpenXmlLoadHelper.Load("HunspellDictionaries.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
        private void barCheckItem1_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            this.spellChecker1.SpellCheckMode = (sender as BarCheckItem).Checked ? SpellCheckMode.AsYouType : SpellCheckMode.OnDemand;
        }
    }
}
