namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class TopValues {
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
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition1 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition2 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition3 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            this.dsSalesPerson1 = new DevExpress.XtraPivotGrid.Demos.dsSalesPerson();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ceTopValuesShowOthers = new DevExpress.XtraEditors.CheckEdit();
            this.icbField = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.seTop = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.pcSplitter = new DevExpress.XtraEditors.PanelControl();
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldOrderID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceTopValuesShowOthers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
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
            this.panelControl1.Controls.Add(this.ceTopValuesShowOthers);
            this.panelControl1.Controls.Add(this.icbField);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.seTop);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(706, 74);
            this.panelControl1.TabIndex = 1;
            // 
            // ceTopValuesShowOthers
            // 
            this.ceTopValuesShowOthers.Location = new System.Drawing.Point(16, 45);
            this.ceTopValuesShowOthers.Name = "ceTopValuesShowOthers";
            this.ceTopValuesShowOthers.Properties.Caption = "TopValuesShowOthers";
            this.ceTopValuesShowOthers.Size = new System.Drawing.Size(224, 19);
            this.ceTopValuesShowOthers.TabIndex = 2;
            this.ceTopValuesShowOthers.CheckedChanged += new System.EventHandler(this.ceTopValuesShowOthers_CheckedChanged);
            // 
            // icbField
            // 
            this.icbField.EditValue = "imageComboBoxEdit1";
            this.icbField.Location = new System.Drawing.Point(264, 16);
            this.icbField.Name = "icbField";
            this.icbField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbField.Size = new System.Drawing.Size(168, 20);
            this.icbField.TabIndex = 1;
            this.icbField.SelectedIndexChanged += new System.EventHandler(this.icbField_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(154, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Values for the Field: ";
            // 
            // seTop
            // 
            this.seTop.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.seTop.Location = new System.Drawing.Point(76, 16);
            this.seTop.Name = "seTop";
            this.seTop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seTop.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seTop.Properties.IsFloatValue = false;
            this.seTop.Properties.Mask.EditMask = "N00";
            this.seTop.Properties.MaxValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.seTop.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seTop.Size = new System.Drawing.Size(72, 20);
            this.seTop.TabIndex = 0;
            this.seTop.EditValueChanged += new System.EventHandler(this.seTop_EditValueChanged);
            // 
            // label2
            // 
            this.label2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Show Top:";
            // 
            // pcSplitter
            // 
            this.pcSplitter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcSplitter.Location = new System.Drawing.Point(0, 74);
            this.pcSplitter.Name = "pcSplitter";
            this.pcSplitter.Size = new System.Drawing.Size(706, 2);
            this.pcSplitter.TabIndex = 9;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 76);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(706, 8);
            this.paddingPanel.TabIndex = 11;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOrderID,
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldSalesPerson,
            this.fieldExtendedPrice});
            pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition1.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition1.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition1.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            pivotGridStyleFormatCondition1.FieldName = "";
            pivotGridStyleFormatCondition1.Value1 = 10000;
            pivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue;
            pivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition2.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition2.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition2.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            pivotGridStyleFormatCondition2.FieldName = "";
            pivotGridStyleFormatCondition2.Value1 = 350;
            pivotGridStyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Green;
            pivotGridStyleFormatCondition3.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition3.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition3.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition3.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            pivotGridStyleFormatCondition3.FieldName = "";
            pivotGridStyleFormatCondition3.Value1 = 0.1F;
            this.pivotGridControl1.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1,
            pivotGridStyleFormatCondition2,
            pivotGridStyleFormatCondition3});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 84);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(706, 332);
            this.pivotGridControl1.TabIndex = 12;
            this.pivotGridControl1.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl1_FieldValueImageIndex);
            this.pivotGridControl1.CustomDrawFieldValue += new DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventHandler(this.pivotGridControl1_CustomDrawFieldValue);
            // 
            // fieldOrderID
            // 
            this.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOrderID.AreaIndex = 0;
            this.fieldOrderID.Caption = "Order ID";
            this.fieldOrderID.FieldName = "OrderID";
            this.fieldOrderID.Name = "fieldOrderID";
            this.fieldOrderID.SortBySummaryInfo.Field = this.fieldExtendedPrice;
            this.fieldOrderID.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Order Amount";
            this.fieldExtendedPrice.CellFormat.FormatString = "c";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            this.fieldExtendedPrice.Width = 120;
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 1;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.SortBySummaryInfo.Field = this.fieldExtendedPrice;
            this.fieldCategoryName.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldCategoryName.Width = 160;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 3;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.SortBySummaryInfo.Field = this.fieldExtendedPrice;
            this.fieldProductName.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldProductName.Width = 180;
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson.AreaIndex = 2;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            this.fieldSalesPerson.SortBySummaryInfo.Field = this.fieldExtendedPrice;
            this.fieldSalesPerson.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldSalesPerson.Width = 140;
            // 
            // TopValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.pcSplitter);
            this.Controls.Add(this.panelControl1);
            this.Name = "TopValues";
            this.Size = new System.Drawing.Size(706, 416);
            this.Load += new System.EventHandler(this.TopValues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceTopValuesShowOthers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
		private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl pcSplitter;
        private DevExpress.XtraEditors.LabelControl label2;
		private DevExpress.XtraEditors.ImageComboBoxEdit icbField;
        private DevExpress.XtraEditors.SpinEdit seTop;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.CheckEdit ceTopValuesShowOthers;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl paddingPanel;
		private PivotGridControl pivotGridControl1;
		private PivotGridField fieldOrderID;
		private PivotGridField fieldExtendedPrice;
		private PivotGridField fieldCategoryName;
		private PivotGridField fieldProductName;
		private PivotGridField fieldSalesPerson;

    }
}
