using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSpellChecker.Rules;
using System.Collections.Generic;
using DevExpress.XtraBars;
using System.Globalization;
using System.IO;
using DevExpress.Utils.Zip;

namespace DevExpress.XtraSpellChecker.Demos {
	/// <summary>
	/// Summary description for Employees.
	/// </summary>
	public partial class CheckRichEditControl : BaseTutorialControl {
        public CheckRichEditControl() {
			InitializeComponent();

            spellChecker1.UseSharedDictionaries = false;
            LoadDocument();
		}

        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);
            if (Visible)
                MergeRibbon();
            else
                UnMergeRibbon();
        }
        void UnMergeRibbon() {
            if (ParentFormMain == null)
                return;
            DevExpress.XtraBars.Ribbon.RibbonControl parentRibbon = ParentFormMain.Ribbon;
            parentRibbon.UnMergeRibbon();
            parentRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            parentRibbon.SelectedPage = parentRibbon.Pages[0];
        }
        void MergeRibbon() {
            if (ParentFormMain == null)
                return;
            DevExpress.XtraBars.Ribbon.RibbonControl parentRibbon = ParentFormMain.Ribbon;
            parentRibbon.MergeRibbon(this.ribbonControl1);
            parentRibbon.Pages[0].Text = "Demo";
            parentRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            parentRibbon.SelectedPage = parentRibbon.MergedPages["Review"];
        }
        private void LoadDocument() {
            string path = DemoUtils.GetRelativePath("SpellChecker.rtf");
            if (!String.IsNullOrEmpty(path))
                richEditControl1.LoadDocument(path, DevExpress.XtraRichEdit.DocumentFormat.Rtf);
        }
		protected override Control GetActiveControl() {
			return richEditControl1;
		}
        protected void OnEditControlKeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            OnEditorKeyDown(sender, e);
        }
        private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e) {
            this.spellChecker1.SpellCheckMode = (sender as BarCheckItem).Checked ? SpellCheckMode.AsYouType : SpellCheckMode.OnDemand;
        }
	}
}
