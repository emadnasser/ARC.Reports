using System;
using DevExpress.XtraEditors;

namespace DevExpress.XtraRichEdit.Demos {
    #region DocumentRestrictionsModule
    public partial class DocumentRestrictionsModule : DevExpress.XtraRichEdit.Demos.TutorialControl {

        public DocumentRestrictionsModule() {
            InitializeComponent();
            RtfLoadHelper.Load("TextWithImages.rtf", richEditControl);
            richEditControl.Focus();
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        #region Properties
        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }
        public bool IsHideDisabled { get { return edtHideDisabled.Checked; } }
        public bool IsReloadDocument { get { return true; } }
        public string CurrentFileName { get { return richEditControl.Options.DocumentSaveOptions.CurrentFileName; } }
        #endregion

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }

        #region Hendlers
        void OnAllowCharacterFormatting(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.CharacterFormatting = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowCharacterStyle(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.CharacterStyle = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowParagraph(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.Paragraphs = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowParagraphPraperties(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.ParagraphFormatting = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowParagraphStyle(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.ParagraphStyle = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowParagraphTabs(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.ParagraphTabs = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowHyperlinks(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.Hyperlinks = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowBookmarks(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.Bookmarks = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowBulletNumbering(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.Numbering.Bulleted = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowSimpleNumbering(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.Numbering.Simple = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowMultiLevelNumbering(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.Numbering.MultiLevel = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowPicture(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.InlinePictures = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowSymbolTabs(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.TabSymbol = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowSections(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.Sections = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnAllowHeadersFooters(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.HeadersFooters = GetOptionValue(sender);
            ReloadDocument();
        }
        void OnApplyRestrictions(object sender, EventArgs e) {
            ReloadDocument();
        }
        void OnEdtAllowTables(object sender, EventArgs e) {
            richEditControl.Options.DocumentCapabilities.Tables = GetOptionValue(sender);
            ReloadDocument();
        }
        #endregion

        void ReloadDocument() {
            if (IsReloadDocument && !String.IsNullOrEmpty(CurrentFileName))
                richEditControl.LoadDocument(CurrentFileName);
        }
        DocumentCapability GetOptionValue(object sender) {
            if (((CheckEdit)sender).Checked)
                return DocumentCapability.Enabled;
            if (IsHideDisabled)
                return DocumentCapability.Hidden;
            return DocumentCapability.Disabled;
        }
        public DocumentCapability UpdateBarItemVisibility(bool capabilityCheckBoxChecked) {
            if (capabilityCheckBoxChecked)
                return DocumentCapability.Enabled;
            return (IsHideDisabled) ? DocumentCapability.Hidden : DocumentCapability.Disabled;
        }
        void edtHideDisabled_CheckedChanged(object sender, EventArgs e) {
            richEditControl.BeginUpdate();
            try {
                richEditControl.Options.DocumentCapabilities.CharacterFormatting = UpdateBarItemVisibility(this.edtAllowCharacterFormatting.Checked);
                richEditControl.Options.DocumentCapabilities.CharacterStyle = UpdateBarItemVisibility(this.edtAllowCharacterStyle.Checked);
                richEditControl.Options.DocumentCapabilities.Paragraphs = UpdateBarItemVisibility(this.edtAllowParagraph.Checked);
                richEditControl.Options.DocumentCapabilities.ParagraphFormatting = UpdateBarItemVisibility(this.edtAllowParagraphPraperties.Checked);
                richEditControl.Options.DocumentCapabilities.ParagraphStyle = UpdateBarItemVisibility(this.edtAllowParagraphStyle.Checked);
                richEditControl.Options.DocumentCapabilities.ParagraphTabs = UpdateBarItemVisibility(this.edtAllowParagraphTabs.Checked);
                richEditControl.Options.DocumentCapabilities.Hyperlinks = UpdateBarItemVisibility(this.edtAllowHyperlinks.Checked);
                richEditControl.Options.DocumentCapabilities.Bookmarks = UpdateBarItemVisibility(this.edtAllowBookmarks.Checked);
                richEditControl.Options.DocumentCapabilities.Numbering.Bulleted = UpdateBarItemVisibility(this.edtAllowBulletNumbering.Checked);
                richEditControl.Options.DocumentCapabilities.Numbering.Simple = UpdateBarItemVisibility(this.edtAllowSimpleNumbering.Checked);
                richEditControl.Options.DocumentCapabilities.Numbering.MultiLevel = UpdateBarItemVisibility(this.edtAllowMultiLevelNumbering.Checked);
                richEditControl.Options.DocumentCapabilities.InlinePictures = UpdateBarItemVisibility(this.edtAllowPicture.Checked);
                richEditControl.Options.DocumentCapabilities.TabSymbol = UpdateBarItemVisibility(this.edtAllowSymbolTabs.Checked);
                richEditControl.Options.DocumentCapabilities.Sections = UpdateBarItemVisibility(this.edtAllowSections.Checked);
                richEditControl.Options.DocumentCapabilities.HeadersFooters = UpdateBarItemVisibility(this.edtAllowHeadersFooters.Checked);
                richEditControl.Options.DocumentCapabilities.Tables = UpdateBarItemVisibility(this.edtAllowTables.Checked);
                ReloadDocument();
            }
            finally {
                richEditControl.EndUpdate();
            }
        }
    }
    #endregion
}
