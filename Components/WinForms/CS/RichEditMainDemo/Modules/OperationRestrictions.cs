using System;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;

namespace DevExpress.XtraRichEdit.Demos {
    #region OperationRestrictionsModule
    public partial class OperationRestrictionsModule : DevExpress.XtraRichEdit.Demos.TutorialControl {

        public OperationRestrictionsModule() {
            InitializeComponent();
            InitializeZoomFactors();
            RtfLoadHelper.Load("TextWithImages.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
            richEditControl.Focus();
        }

        #region Properties
        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }
        public bool IsHideDisabled { get { return edtHideDisabled.Checked; } }
        #endregion

        void InitializeZoomFactors() {
            richEditControl.Options.Behavior.MaxZoomFactor = (float)edtMaxZoomFactor.Value;
            richEditControl.Options.Behavior.MinZoomFactor = (float)edtMinZoomFactor.Value;
        }
        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
        #region Handlers
        void AllowCutCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.Cut = GetOptionValue(sender);
        }
        void AllowCopyCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.Copy = GetOptionValue(sender);
        }
        void AllowPasteCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.Paste = GetOptionValue(sender);
        }
        void AllowDragCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.Drag = GetOptionValue(sender);
        }
        void AllowDropCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.Drop = GetOptionValue(sender);
        }
        void AllowSaveCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.Save = GetOptionValue(sender);
        }
        void AllowSaveAsCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.SaveAs = GetOptionValue(sender);
        }
        void AllowPrintingCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.Printing = GetOptionValue(sender);
        }
        void AllowCreateNewCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.CreateNew = GetOptionValue(sender);
        }
        void AllowOpenCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.Open = GetOptionValue(sender);
        }
        void AllowZoomCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.Zooming = GetOptionValue(sender);

            edtMaxZoomFactor.Enabled = ((CheckEdit)sender).Checked;
            edtMinZoomFactor.Enabled = ((CheckEdit)sender).Checked;
        }
        void OnMinZoomFactorValueChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.MinZoomFactor = (float)((SpinEdit)sender).Value;
            ((SpinEdit)sender).Value = (decimal)richEditControl.Options.Behavior.MinZoomFactor;
        }
        void OnMaxZoomFactorValueChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.MaxZoomFactor = (float)((SpinEdit)sender).Value;
            ((SpinEdit)sender).Value = (decimal)richEditControl.Options.Behavior.MaxZoomFactor;
        }
        void OnShowPopupMenuCheckedChanged(object sender, EventArgs e) {
            richEditControl.Options.Behavior.ShowPopupMenu = GetOptionValue(sender);
        }
        #endregion

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
        private void edtHideDisabled_CheckedChanged(object sender, EventArgs e) {
            richEditControl.BeginUpdate();
            try {
                richEditControl.Options.Behavior.Cut = UpdateBarItemVisibility(this.edtAllowCut.Checked);
                richEditControl.Options.Behavior.Copy = UpdateBarItemVisibility(this.edtAllowCopy.Checked);
                richEditControl.Options.Behavior.Paste = UpdateBarItemVisibility(this.edtAllowPaste.Checked);
                richEditControl.Options.Behavior.Drag = UpdateBarItemVisibility(this.edtAllowDrag.Checked);
                richEditControl.Options.Behavior.Drop = UpdateBarItemVisibility(this.edtAllowDrop.Checked);
                richEditControl.Options.Behavior.Save = UpdateBarItemVisibility(this.edtSave.Checked);
                richEditControl.Options.Behavior.SaveAs = UpdateBarItemVisibility(this.edtAllowSaveAs.Checked);
                richEditControl.Options.Behavior.Printing = UpdateBarItemVisibility(this.edtAllowPrinting.Checked);
                richEditControl.Options.Behavior.CreateNew = UpdateBarItemVisibility(this.edtAllowCreateNew.Checked);
                richEditControl.Options.Behavior.Open = UpdateBarItemVisibility(this.edtAllowOpen.Checked);
                richEditControl.Options.Behavior.Zooming = UpdateBarItemVisibility(this.edtAllowZoom.Checked);
            }
            finally {
                richEditControl.EndUpdate();
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            richEditControl.ReadOnly = ((CheckEdit)sender).Checked;
        }
    }
    #endregion
}
