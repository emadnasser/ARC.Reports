namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class SingleTotal {
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
            DevExpress.XtraPivotGrid.PivotGridCustomTotal pivotGridCustomTotal1 = new DevExpress.XtraPivotGrid.PivotGridCustomTotal();
            this.dsSalesPerson1 = new DevExpress.XtraPivotGrid.Demos.dsSalesPerson();
            this.pcSummary = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.clbOptions = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.pcSplitter = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.icbSummaryType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.icbField = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiscount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSummary)).BeginInit();
            this.pcSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbSummaryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSalesPerson1
            // 
            this.dsSalesPerson1.DataSetName = "dsSalesPerson";
            this.dsSalesPerson1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pcSummary
            // 
            this.pcSummary.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcSummary.Controls.Add(this.groupControl2);
            this.pcSummary.Controls.Add(this.pcSplitter);
            this.pcSummary.Controls.Add(this.groupControl1);
            this.pcSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcSummary.Location = new System.Drawing.Point(0, 0);
            this.pcSummary.Name = "pcSummary";
            this.pcSummary.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pcSummary.Size = new System.Drawing.Size(706, 88);
            this.pcSummary.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.clbOptions);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(215, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(4);
            this.groupControl2.Size = new System.Drawing.Size(491, 86);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "View Options";
            // 
            // clbOptions
            // 
            this.clbOptions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clbOptions.CheckOnClick = true;
            this.clbOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbOptions.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.clbOptions.ItemHeight = 17;
            this.clbOptions.Location = new System.Drawing.Point(6, 26);
            this.clbOptions.MultiColumn = true;
            this.clbOptions.Name = "clbOptions";
            this.clbOptions.Size = new System.Drawing.Size(479, 54);
            this.clbOptions.TabIndex = 0;
            this.clbOptions.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.clbOptions_ItemCheck);
            // 
            // pcSplitter
            // 
            this.pcSplitter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcSplitter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcSplitter.Location = new System.Drawing.Point(213, 0);
            this.pcSplitter.Name = "pcSplitter";
            this.pcSplitter.Size = new System.Drawing.Size(2, 86);
            this.pcSplitter.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.icbSummaryType);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.icbField);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(213, 86);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "DataField Summary Settings";
            // 
            // icbSummaryType
            // 
            this.icbSummaryType.EditValue = "imageComboBoxEdit1";
            this.icbSummaryType.Location = new System.Drawing.Point(93, 53);
            this.icbSummaryType.Name = "icbSummaryType";
            this.icbSummaryType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbSummaryType.Properties.DropDownRows = 10;
            this.icbSummaryType.Size = new System.Drawing.Size(104, 20);
            this.icbSummaryType.TabIndex = 6;
            this.icbSummaryType.SelectedIndexChanged += new System.EventHandler(this.icbSummaryType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Summary Type:";
            // 
            // icbField
            // 
            this.icbField.EditValue = "imageComboBoxEdit1";
            this.icbField.Location = new System.Drawing.Point(93, 29);
            this.icbField.Name = "icbField";
            this.icbField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbField.Size = new System.Drawing.Size(104, 20);
            this.icbField.TabIndex = 0;
            this.icbField.SelectedIndexChanged += new System.EventHandler(this.icbField_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Field:";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 88);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(706, 8);
            this.panelControl2.TabIndex = 13;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldYear,
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldQuarter,
            this.fieldUnitPrice,
            this.fieldQuantity,
            this.fieldDiscount,
            this.fieldExtendedPrice});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 96);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea;
            this.pivotGridControl1.OptionsDataField.AreaIndex = 2;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(706, 320);
            this.pivotGridControl1.TabIndex = 14;
            this.pivotGridControl1.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl1_FieldValueImageIndex);
            this.pivotGridControl1.CustomDrawFieldHeader += new DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventHandler(this.pivotGridControl1_CustomDrawFieldHeader);
            this.pivotGridControl1.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGridControl1_CustomSummary);
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "OrderDate";
            this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.UnboundFieldName = "fieldYear";
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Width = 135;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Width = 170;
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Quarter";
            this.fieldQuarter.FieldName = "OrderDate";
            this.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.TotalValueFormat.FormatString = "Quarter {0} Total";
            this.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuarter.UnboundFieldName = "fieldQuarter";
            this.fieldQuarter.ValueFormat.FormatString = "Quarter {0}";
            this.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldUnitPrice
            // 
            this.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitPrice.AreaIndex = 0;
            this.fieldUnitPrice.Caption = "Unit Price";
            this.fieldUnitPrice.CellFormat.FormatString = "c";
            this.fieldUnitPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            pivotGridCustomTotal1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            pivotGridCustomTotal1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.StdDev;
            this.fieldUnitPrice.CustomTotals.AddRange(new DevExpress.XtraPivotGrid.PivotGridCustomTotal[] {
            pivotGridCustomTotal1});
            this.fieldUnitPrice.FieldName = "UnitPrice";
            this.fieldUnitPrice.Name = "fieldUnitPrice";
            this.fieldUnitPrice.Options.ShowSummaryTypeName = true;
            this.fieldUnitPrice.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.fieldUnitPrice.ValueFormat.FormatString = "c";
            this.fieldUnitPrice.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 1;
            this.fieldQuantity.Caption = "Quantity";
            this.fieldQuantity.CellFormat.FormatString = "#.##";
            this.fieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            this.fieldQuantity.Options.ShowSummaryTypeName = true;
            this.fieldQuantity.ValueFormat.FormatString = "#.##";
            this.fieldQuantity.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldDiscount
            // 
            this.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDiscount.AreaIndex = 2;
            this.fieldDiscount.Caption = "Discount";
            this.fieldDiscount.CellFormat.FormatString = "p";
            this.fieldDiscount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldDiscount.FieldName = "Discount";
            this.fieldDiscount.Name = "fieldDiscount";
            this.fieldDiscount.Options.ShowSummaryTypeName = true;
            this.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldDiscount.ValueFormat.FormatString = "p";
            this.fieldDiscount.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 3;
            this.fieldExtendedPrice.Caption = "Extended Price";
            this.fieldExtendedPrice.CellFormat.FormatString = "c";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            this.fieldExtendedPrice.Options.ShowInCustomizationForm = false;
            this.fieldExtendedPrice.ValueFormat.FormatString = "c";
            this.fieldExtendedPrice.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.Visible = false;
            // 
            // SingleTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.pcSummary);
            this.Name = "SingleTotal";
            this.Size = new System.Drawing.Size(706, 416);
            this.Load += new System.EventHandler(this.SingleTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSummary)).EndInit();
            this.pcSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbSummaryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
		private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbField;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl pcSplitter;
        private DevExpress.XtraEditors.PanelControl pcSummary;
        private DevExpress.XtraEditors.CheckedListBoxControl clbOptions;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.ImageComboBoxEdit icbSummaryType;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private PivotGridControl pivotGridControl1;
		private PivotGridField fieldYear;
		private PivotGridField fieldCategoryName;
		private PivotGridField fieldProductName;
		private PivotGridField fieldQuarter;
		private PivotGridField fieldUnitPrice;
		private PivotGridField fieldQuantity;
		private PivotGridField fieldDiscount;
		private PivotGridField fieldExtendedPrice;

    }
}
