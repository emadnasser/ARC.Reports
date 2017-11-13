namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class CustomerReports {
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
			this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOrderQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.rgReport = new DevExpress.XtraEditors.RadioGroup();
			this.dsReports1 = new DevExpress.XtraPivotGrid.Demos.dsReports();
			this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.fieldCompanyName = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldProductAmount = new DevExpress.XtraPivotGrid.PivotGridField();
			this.pcYear = new DevExpress.XtraEditors.PanelControl();
			this.cbeQuarter = new DevExpress.XtraEditors.ComboBoxEdit();
			this.label2 = new DevExpress.XtraEditors.LabelControl();
			this.cbeYear = new DevExpress.XtraEditors.ComboBoxEdit();
			this.label1 = new DevExpress.XtraEditors.LabelControl();
			this.pcSplitter = new DevExpress.XtraEditors.PanelControl();
			this.mainPanel = new DevExpress.XtraEditors.PanelControl();
			this.controlPanel = new DevExpress.XtraEditors.PanelControl();
			this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsReports1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcYear)).BeginInit();
			this.pcYear.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbeQuarter.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbeYear.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcSplitter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.controlPanel)).BeginInit();
			this.controlPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
			this.SuspendLayout();
			// 
			// fieldOrderYear
			// 
			this.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldOrderYear.AreaIndex = 0;
			this.fieldOrderYear.Caption = "Order Year";
			this.fieldOrderYear.FieldName = "OrderDate";
			this.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldOrderYear.Name = "fieldOrderYear";
			this.fieldOrderYear.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldOrderYear.UnboundFieldName = "fieldOrderYear";
			// 
			// fieldOrderQuarter
			// 
			this.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldOrderQuarter.AreaIndex = 1;
			this.fieldOrderQuarter.Caption = "Order Quarter";
			this.fieldOrderQuarter.FieldName = "OrderDate";
			this.fieldOrderQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
			this.fieldOrderQuarter.Name = "fieldOrderQuarter";
			this.fieldOrderQuarter.UnboundFieldName = "fieldOrderQuarter";
			this.fieldOrderQuarter.ValueFormat.FormatString = "Qtr {0}";
			this.fieldOrderQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			// 
			// panelControl1
			// 
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.rgReport);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(2, 2);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Padding = new System.Windows.Forms.Padding(4);
			this.panelControl1.Size = new System.Drawing.Size(698, 63);
			this.panelControl1.TabIndex = 2;
			// 
			// rgReport
			// 
			this.rgReport.Location = new System.Drawing.Point(12, 7);
			this.rgReport.Name = "rgReport";
			this.rgReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.rgReport.Properties.Appearance.Options.UseBackColor = true;
			this.rgReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.rgReport.Properties.Columns = 2;
			this.rgReport.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Customers"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Products(filtering)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Top 2 Products"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Top 10 Customers")});
			this.rgReport.Size = new System.Drawing.Size(280, 54);
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
			this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pivotGridControl1.DataSource = this.dsReports1.CustomerReports;
			this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCompanyName,
            this.fieldProductName,
            this.fieldProductAmount,
            this.fieldOrderYear,
            this.fieldOrderQuarter});
			pivotGridGroup1.Fields.Add(this.fieldOrderYear);
			pivotGridGroup1.Fields.Add(this.fieldOrderQuarter);
			pivotGridGroup1.Hierarchy = null;
			this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
			this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.pivotGridControl1.Name = "pivotGridControl1";
			this.pivotGridControl1.Size = new System.Drawing.Size(702, 306);
			this.pivotGridControl1.TabIndex = 3;
			// 
			// fieldCompanyName
			// 
			this.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldCompanyName.AreaIndex = 0;
			this.fieldCompanyName.Caption = "Customer";
			this.fieldCompanyName.FieldName = "CompanyName";
			this.fieldCompanyName.Name = "fieldCompanyName";
			this.fieldCompanyName.Width = 150;
			// 
			// fieldProductName
			// 
			this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldProductName.AreaIndex = 1;
			this.fieldProductName.Caption = "Product Name";
			this.fieldProductName.FieldName = "ProductName";
			this.fieldProductName.Name = "fieldProductName";
			this.fieldProductName.Width = 186;
			// 
			// fieldProductAmount
			// 
			this.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldProductAmount.AreaIndex = 0;
			this.fieldProductAmount.Caption = "Product Amount";
			this.fieldProductAmount.CellFormat.FormatString = "c";
			this.fieldProductAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldProductAmount.FieldName = "ProductAmount";
			this.fieldProductAmount.Name = "fieldProductAmount";
			this.fieldProductAmount.Width = 130;
			// 
			// pcYear
			// 
			this.pcYear.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pcYear.Controls.Add(this.cbeQuarter);
			this.pcYear.Controls.Add(this.label2);
			this.pcYear.Controls.Add(this.cbeYear);
			this.pcYear.Controls.Add(this.label1);
			this.pcYear.Dock = System.Windows.Forms.DockStyle.Top;
			this.pcYear.Location = new System.Drawing.Point(2, 65);
			this.pcYear.Name = "pcYear";
			this.pcYear.Padding = new System.Windows.Forms.Padding(4);
			this.pcYear.Size = new System.Drawing.Size(698, 25);
			this.pcYear.TabIndex = 4;
			// 
			// cbeQuarter
			// 
			this.cbeQuarter.EditValue = "";
			this.cbeQuarter.Location = new System.Drawing.Point(274, 0);
			this.cbeQuarter.Name = "cbeQuarter";
			this.cbeQuarter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbeQuarter.Properties.Items.AddRange(new object[] {
            "(All)"});
			this.cbeQuarter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.cbeQuarter.Size = new System.Drawing.Size(144, 20);
			this.cbeQuarter.TabIndex = 3;
			this.cbeQuarter.SelectedIndexChanged += new System.EventHandler(this.cbeQuarter_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(216, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Quarter: ";
            this.label2.BackColor = System.Drawing.Color.Transparent;
			// 
			// cbeYear
			// 
			this.cbeYear.EditValue = "";
			this.cbeYear.Location = new System.Drawing.Point(56, 0);
			this.cbeYear.Name = "cbeYear";
			this.cbeYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbeYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.cbeYear.Size = new System.Drawing.Size(144, 20);
			this.cbeYear.TabIndex = 1;
			this.cbeYear.SelectedIndexChanged += new System.EventHandler(this.cbeYear_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Year: ";
            this.label1.BackColor = System.Drawing.Color.Transparent;
			// 
			// pcSplitter
			// 
			this.pcSplitter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pcSplitter.Dock = System.Windows.Forms.DockStyle.Top;
			this.pcSplitter.Location = new System.Drawing.Point(2, 90);
			this.pcSplitter.Name = "pcSplitter";
			this.pcSplitter.Size = new System.Drawing.Size(698, 2);
			this.pcSplitter.TabIndex = 10;
			// 
			// mainPanel
			// 
			this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.mainPanel.Controls.Add(this.pivotGridControl1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 102);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(702, 306);
			this.mainPanel.TabIndex = 11;
			// 
			// controlPanel
			// 
			this.controlPanel.AutoSize = true;
			this.controlPanel.Controls.Add(this.pcSplitter);
			this.controlPanel.Controls.Add(this.pcYear);
			this.controlPanel.Controls.Add(this.panelControl1);
			this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.controlPanel.Location = new System.Drawing.Point(0, 0);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.Size = new System.Drawing.Size(702, 94);
			this.controlPanel.TabIndex = 12;
			// 
			// paddingPanel
			// 
			this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.paddingPanel.Location = new System.Drawing.Point(0, 94);
			this.paddingPanel.Name = "paddingPanel";
			this.paddingPanel.Size = new System.Drawing.Size(702, 8);
			this.paddingPanel.TabIndex = 16;
			// 
			// CustomerReports
			// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.paddingPanel);
			this.Controls.Add(this.controlPanel);
			this.Name = "CustomerReports";
			this.Size = new System.Drawing.Size(702, 408);
			this.Load += new System.EventHandler(this.CustomerReports_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsReports1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcYear)).EndInit();
			this.pcYear.ResumeLayout(false);
			this.pcYear.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbeQuarter.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbeYear.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcSplitter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.controlPanel)).EndInit();
			this.controlPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraPivotGrid.Demos.dsReports dsReports1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCompanyName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductAmount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderQuarter;
        private DevExpress.XtraEditors.PanelControl pcYear;
        private DevExpress.XtraEditors.ComboBoxEdit cbeYear;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeQuarter;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.PanelControl pcSplitter;
		private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl mainPanel;
		private DevExpress.XtraEditors.PanelControl controlPanel;
		private DevExpress.XtraEditors.RadioGroup rgReport;
		private DevExpress.XtraEditors.PanelControl paddingPanel;

    }
}
