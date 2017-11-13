using DevExpress.XtraEditors;
namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class SummaryVariation {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dsSalesPerson1 = new DevExpress.XtraPivotGrid.Demos.dsSalesPerson();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkShowOriginalDataField = new DevExpress.XtraEditors.CheckEdit();
            this.rgSummaryDisplayTypeGroup = new DevExpress.XtraEditors.RadioGroup();
            this.checkHideEmptyVariationItems = new DevExpress.XtraEditors.CheckEdit();
            this.checkAllowCrossGroupVariation = new DevExpress.XtraEditors.CheckEdit();
            this.icbSummaryDisplayType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowOriginalDataField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSummaryDisplayTypeGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkHideEmptyVariationItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllowCrossGroupVariation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSummaryDisplayType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSalesPerson1
            // 
            this.dsSalesPerson1.DataSetName = "dsSalesPerson";
            this.dsSalesPerson1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkShowOriginalDataField);
            this.panelControl1.Controls.Add(this.rgSummaryDisplayTypeGroup);
            this.panelControl1.Controls.Add(this.checkHideEmptyVariationItems);
            this.panelControl1.Controls.Add(this.checkAllowCrossGroupVariation);
            this.panelControl1.Controls.Add(this.icbSummaryDisplayType);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(706, 122);
            this.panelControl1.TabIndex = 2;
            // 
            // checkShowOriginalDataField
            // 
            this.checkShowOriginalDataField.EditValue = true;
            this.checkShowOriginalDataField.Location = new System.Drawing.Point(9, 84);
            this.checkShowOriginalDataField.Name = "checkShowOriginalDataField";
            this.checkShowOriginalDataField.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.checkShowOriginalDataField.Properties.Appearance.Options.UseBackColor = true;
            this.checkShowOriginalDataField.Properties.Caption = "Show Raw Values";
            this.checkShowOriginalDataField.Size = new System.Drawing.Size(156, 19);
            this.checkShowOriginalDataField.TabIndex = 9;
            this.checkShowOriginalDataField.CheckedChanged += new System.EventHandler(this.checkShowOriginalDataField_CheckedChanged);
            // 
            // rgSummaryDisplayTypeGroup
            // 
            this.rgSummaryDisplayTypeGroup.Location = new System.Drawing.Point(11, 7);
            this.rgSummaryDisplayTypeGroup.Name = "rgSummaryDisplayTypeGroup";
            this.rgSummaryDisplayTypeGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgSummaryDisplayTypeGroup.Properties.Appearance.Options.UseBackColor = true;
            this.rgSummaryDisplayTypeGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgSummaryDisplayTypeGroup.Properties.Columns = 4;
            this.rgSummaryDisplayTypeGroup.Size = new System.Drawing.Size(473, 32);
            this.rgSummaryDisplayTypeGroup.TabIndex = 0;
            this.rgSummaryDisplayTypeGroup.SelectedIndexChanged += new System.EventHandler(this.rgSummaryDisplayTypeGroup_SelectedIndexChanged);
            // 
            // checkHideEmptyVariationItems
            // 
            this.checkHideEmptyVariationItems.Location = new System.Drawing.Point(341, 58);
            this.checkHideEmptyVariationItems.Name = "checkHideEmptyVariationItems";
            this.checkHideEmptyVariationItems.Properties.Caption = "Hide Empty Variation Items";
            this.checkHideEmptyVariationItems.Size = new System.Drawing.Size(153, 19);
            this.checkHideEmptyVariationItems.TabIndex = 8;
            this.checkHideEmptyVariationItems.Visible = false;
            this.checkHideEmptyVariationItems.CheckedChanged += new System.EventHandler(this.checkHideEmptyVariationItems_CheckedChanged);
            // 
            // checkAllowCrossGroupVariation
            // 
            this.checkAllowCrossGroupVariation.Location = new System.Drawing.Point(341, 84);
            this.checkAllowCrossGroupVariation.Name = "checkAllowCrossGroupVariation";
            this.checkAllowCrossGroupVariation.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.checkAllowCrossGroupVariation.Properties.Appearance.Options.UseBackColor = true;
            this.checkAllowCrossGroupVariation.Properties.Caption = "Allow Cross-Group Variation";
            this.checkAllowCrossGroupVariation.Size = new System.Drawing.Size(156, 19);
            this.checkAllowCrossGroupVariation.TabIndex = 7;
            this.checkAllowCrossGroupVariation.Visible = false;
            this.checkAllowCrossGroupVariation.CheckedChanged += new System.EventHandler(this.checkAllowCrossGroupVariation_CheckedChanged);
            // 
            // icbSummaryDisplayType
            // 
            this.icbSummaryDisplayType.EditValue = "imageComboBoxEdit1";
            this.icbSummaryDisplayType.Location = new System.Drawing.Point(138, 58);
            this.icbSummaryDisplayType.Name = "icbSummaryDisplayType";
            this.icbSummaryDisplayType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbSummaryDisplayType.Size = new System.Drawing.Size(179, 20);
            this.icbSummaryDisplayType.TabIndex = 5;
            this.icbSummaryDisplayType.SelectedIndexChanged += new System.EventHandler(this.icbSummaryDisplayType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Summary Display Type: ";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 130);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.AllowCrossGroupVariation = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(706, 286);
            this.pivotGridControl1.TabIndex = 11;
            this.pivotGridControl1.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl1_FieldValueImageIndex);
            this.pivotGridControl1.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGridControl1_CustomDrawCell);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 122);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(706, 8);
            this.panelControl2.TabIndex = 12;
            // 
            // SummaryVariation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "SummaryVariation";
            this.Size = new System.Drawing.Size(706, 416);
            this.Load += new System.EventHandler(this.SummaryVariation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowOriginalDataField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSummaryDisplayTypeGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkHideEmptyVariationItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllowCrossGroupVariation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSummaryDisplayType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
		private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.RadioGroup rgSummaryDisplayTypeGroup;
        private DevExpress.XtraEditors.LabelControl label2;
		private DevExpress.XtraEditors.ImageComboBoxEdit icbSummaryDisplayType;
		private System.ComponentModel.IContainer components = null;
        private PivotGridControl pivotGridControl1;
		private CheckEdit checkAllowCrossGroupVariation;
        private CheckEdit checkHideEmptyVariationItems;
        private PanelControl panelControl2;
        private CheckEdit checkShowOriginalDataField;

    }
}
