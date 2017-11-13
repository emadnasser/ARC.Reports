namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class ProductReports {
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.rgReport = new DevExpress.XtraEditors.RadioGroup();
            this.dsReports1 = new DevExpress.XtraPivotGrid.Demos.dsReports();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShippedYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductSales = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShippedQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShippedMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAverageSale = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMinimumSale = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcCategories = new DevExpress.XtraEditors.PanelControl();
            this.ceCategories = new DevExpress.XtraEditors.CheckEdit();
            this.pcDate = new DevExpress.XtraEditors.PanelControl();
            this.cbeDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.pcDrillDown = new DevExpress.XtraEditors.PanelControl();
            this.ceDrillDown = new DevExpress.XtraEditors.CheckEdit();
            this.controlPanel = new DevExpress.XtraEditors.PanelControl();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCategories)).BeginInit();
            this.pcCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCategories.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDate)).BeginInit();
            this.pcDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDrillDown)).BeginInit();
            this.pcDrillDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceDrillDown.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.rgReport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(4);
            this.panelControl1.Size = new System.Drawing.Size(699, 61);
            this.panelControl1.TabIndex = 2;
            // 
            // rgReport
            // 
            this.rgReport.Location = new System.Drawing.Point(11, 7);
            this.rgReport.Name = "rgReport";
            this.rgReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgReport.Properties.Appearance.Options.UseBackColor = true;
            this.rgReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgReport.Properties.Columns = 3;
            this.rgReport.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Category Sales"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Product Sales"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Interval Grouping"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Multiple Subtotals"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Average Sales"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Top 3 Products")});
            this.rgReport.Size = new System.Drawing.Size(400, 52);
            this.rgReport.TabIndex = 0;
            this.rgReport.SelectedIndexChanged += new System.EventHandler(this.rgReport_SelectedIndexChanged);
            // 
            // dsReports1
            // 
            this.dsReports1.DataSetName = "dsReports";
            this.dsReports1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pivotGridControl1.DataSource = this.dsReports1.ProductReports;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldShippedYear,
            this.fieldProductSales,
            this.fieldShippedQuarter,
            this.fieldShippedMonth,
            this.fieldAverageSale,
            this.fieldMinimumSale});
            pivotGridGroup1.Hierarchy = null;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(703, 251);
            this.pivotGridControl1.TabIndex = 3;
            this.pivotGridControl1.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl1_FieldValueImageIndex);
            this.pivotGridControl1.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl1_CellDoubleClick);
            this.pivotGridControl1.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGridControl1_FieldValueDisplayText);
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Width = 125;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Width = 171;
            // 
            // fieldShippedYear
            // 
            this.fieldShippedYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShippedYear.AreaIndex = 0;
            this.fieldShippedYear.Caption = "Shipped Year";
            this.fieldShippedYear.FieldName = "ShippedDate";
            this.fieldShippedYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldShippedYear.Name = "fieldShippedYear";
            this.fieldShippedYear.UnboundFieldName = "fieldShippedYear";
            // 
            // fieldProductSales
            // 
            this.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductSales.AreaIndex = 0;
            this.fieldProductSales.Caption = "Product Sales";
            this.fieldProductSales.CellFormat.FormatString = "c";
            this.fieldProductSales.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldProductSales.FieldName = "ProductSales";
            this.fieldProductSales.Name = "fieldProductSales";
            this.fieldProductSales.Width = 130;
            // 
            // fieldShippedQuarter
            // 
            this.fieldShippedQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShippedQuarter.AreaIndex = 1;
            this.fieldShippedQuarter.Caption = "Shipped Quarter";
            this.fieldShippedQuarter.FieldName = "ShippedDate";
            this.fieldShippedQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldShippedQuarter.Name = "fieldShippedQuarter";
            this.fieldShippedQuarter.UnboundFieldName = "fieldShippedQuarter";
            this.fieldShippedQuarter.ValueFormat.FormatString = "Qtr {0}";
            this.fieldShippedQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldShippedQuarter.Width = 130;
            // 
            // fieldShippedMonth
            // 
            this.fieldShippedMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShippedMonth.Caption = "Shipped Month";
            this.fieldShippedMonth.FieldName = "ShippedDate";
            this.fieldShippedMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldShippedMonth.Name = "fieldShippedMonth";
            this.fieldShippedMonth.UnboundFieldName = "fieldShippedMonth";
            this.fieldShippedMonth.Visible = false;
            this.fieldShippedMonth.Width = 120;
            // 
            // fieldAverageSale
            // 
            this.fieldAverageSale.Caption = "Average Sale";
            this.fieldAverageSale.CellFormat.FormatString = "c";
            this.fieldAverageSale.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAverageSale.FieldName = "ProductSales";
            this.fieldAverageSale.Name = "fieldAverageSale";
            this.fieldAverageSale.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldAverageSale.Visible = false;
            // 
            // fieldMinimumSale
            // 
            this.fieldMinimumSale.Caption = "Minimum Sale";
            this.fieldMinimumSale.CellFormat.FormatString = "c";
            this.fieldMinimumSale.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldMinimumSale.FieldName = "ProductSales";
            this.fieldMinimumSale.Name = "fieldMinimumSale";
            this.fieldMinimumSale.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            this.fieldMinimumSale.Visible = false;
            // 
            // pcCategories
            // 
            this.pcCategories.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcCategories.Controls.Add(this.ceCategories);
            this.pcCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcCategories.Location = new System.Drawing.Point(2, 91);
            this.pcCategories.Name = "pcCategories";
            this.pcCategories.Padding = new System.Windows.Forms.Padding(4);
            this.pcCategories.Size = new System.Drawing.Size(699, 28);
            this.pcCategories.TabIndex = 4;
            // 
            // ceCategories
            // 
            this.ceCategories.Location = new System.Drawing.Point(13, 4);
            this.ceCategories.Name = "ceCategories";
            this.ceCategories.Properties.Caption = "Show Categories";
            this.ceCategories.Size = new System.Drawing.Size(132, 19);
            this.ceCategories.TabIndex = 0;
            this.ceCategories.CheckedChanged += new System.EventHandler(this.ceCategories_CheckedChanged);
            // 
            // pcDate
            // 
            this.pcDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcDate.Controls.Add(this.cbeDate);
            this.pcDate.Controls.Add(this.label1);
            this.pcDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcDate.Location = new System.Drawing.Point(2, 119);
            this.pcDate.Name = "pcDate";
            this.pcDate.Padding = new System.Windows.Forms.Padding(4);
            this.pcDate.Size = new System.Drawing.Size(699, 28);
            this.pcDate.TabIndex = 5;
            // 
            // cbeDate
            // 
            this.cbeDate.EditValue = "";
            this.cbeDate.Location = new System.Drawing.Point(101, 4);
            this.cbeDate.Name = "cbeDate";
            this.cbeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeDate.Properties.Items.AddRange(new object[] {
            "by Years",
            "by Quarters",
            "by Months",
            "by Years, Quarters, Months"});
            this.cbeDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeDate.Size = new System.Drawing.Size(196, 20);
            this.cbeDate.TabIndex = 3;
            this.cbeDate.SelectedIndexChanged += new System.EventHandler(this.cbeDate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label1.Appearance.Options.UseBackColor = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grouping Layout: ";
            // 
            // pcDrillDown
            // 
            this.pcDrillDown.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcDrillDown.Controls.Add(this.ceDrillDown);
            this.pcDrillDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcDrillDown.Location = new System.Drawing.Point(2, 63);
            this.pcDrillDown.Name = "pcDrillDown";
            this.pcDrillDown.Padding = new System.Windows.Forms.Padding(4);
            this.pcDrillDown.Size = new System.Drawing.Size(699, 28);
            this.pcDrillDown.TabIndex = 11;
            // 
            // ceDrillDown
            // 
            this.ceDrillDown.EditValue = true;
            this.ceDrillDown.Location = new System.Drawing.Point(13, 4);
            this.ceDrillDown.Name = "ceDrillDown";
            this.ceDrillDown.Properties.Caption = "Show Drill Down Form on Cell Double Click";
            this.ceDrillDown.Size = new System.Drawing.Size(308, 19);
            this.ceDrillDown.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.AutoSize = true;
            this.controlPanel.Controls.Add(this.pcDate);
            this.controlPanel.Controls.Add(this.pcCategories);
            this.controlPanel.Controls.Add(this.pcDrillDown);
            this.controlPanel.Controls.Add(this.panelControl1);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(703, 149);
            this.controlPanel.TabIndex = 12;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.pivotGridControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 157);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(703, 251);
            this.mainPanel.TabIndex = 13;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 149);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(703, 8);
            this.paddingPanel.TabIndex = 14;
            // 
            // ProductReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "ProductReports";
            this.Size = new System.Drawing.Size(703, 408);
            this.Load += new System.EventHandler(this.ProductReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCategories)).EndInit();
            this.pcCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceCategories.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDate)).EndInit();
            this.pcDate.ResumeLayout(false);
            this.pcDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDrillDown)).EndInit();
            this.pcDrillDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceDrillDown.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).EndInit();
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraPivotGrid.Demos.dsReports dsReports1;
		private DevExpress.XtraEditors.RadioGroup rgReport;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShippedQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShippedYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductSales;
        private DevExpress.XtraEditors.PanelControl pcCategories;
        private DevExpress.XtraEditors.CheckEdit ceCategories;
        private DevExpress.XtraEditors.PanelControl pcDate;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeDate;
		private DevExpress.XtraPivotGrid.PivotGridField fieldShippedMonth;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAverageSale;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMinimumSale;
        private DevExpress.XtraEditors.PanelControl pcDrillDown;
        private DevExpress.XtraEditors.CheckEdit ceDrillDown;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl controlPanel;
		private DevExpress.XtraEditors.PanelControl mainPanel;
		private DevExpress.XtraEditors.PanelControl paddingPanel;

    }
}
