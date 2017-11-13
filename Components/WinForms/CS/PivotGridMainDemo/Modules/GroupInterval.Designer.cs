namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class GroupInterval {
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
			this.ceProductInterval = new DevExpress.XtraEditors.CheckEdit();
			this.icbGroupInterval = new DevExpress.XtraEditors.ImageComboBoxEdit();
			this.label1 = new DevExpress.XtraEditors.LabelControl();
			this.pcSplitter = new DevExpress.XtraEditors.PanelControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.fieldProductAlphabetical = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
			((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ceProductInterval.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.icbGroupInterval.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcSplitter)).BeginInit();
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
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.ceProductInterval);
			this.panelControl1.Controls.Add(this.icbGroupInterval);
			this.panelControl1.Controls.Add(this.label1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(703, 63);
			this.panelControl1.TabIndex = 1;
			// 
			// ceProductInterval
			// 
			this.ceProductInterval.Location = new System.Drawing.Point(19, 37);
			this.ceProductInterval.Name = "ceProductInterval";
			this.ceProductInterval.Properties.Caption = "Show Product Alphabetically";
			this.ceProductInterval.Size = new System.Drawing.Size(224, 18);
			this.ceProductInterval.TabIndex = 3;
			this.ceProductInterval.CheckedChanged += new System.EventHandler(this.ceProductInterval_CheckedChanged);
			// 
			// icbGroupInterval
			// 
			this.icbGroupInterval.EditValue = "imageComboBoxEdit1";
			this.icbGroupInterval.Location = new System.Drawing.Point(221, 11);
			this.icbGroupInterval.Name = "icbGroupInterval";
			this.icbGroupInterval.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.icbGroupInterval.Size = new System.Drawing.Size(160, 20);
			this.icbGroupInterval.TabIndex = 2;
			this.icbGroupInterval.SelectedIndexChanged += new System.EventHandler(this.icbGroupInterval_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Group Interval for the OrderDate field: ";
            this.label1.BackColor = System.Drawing.Color.Transparent;
			// 
			// pcSplitter
			// 
			this.pcSplitter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pcSplitter.Dock = System.Windows.Forms.DockStyle.Top;
			this.pcSplitter.Location = new System.Drawing.Point(0, 63);
			this.pcSplitter.Name = "pcSplitter";
			this.pcSplitter.Size = new System.Drawing.Size(703, 2);
			this.pcSplitter.TabIndex = 9;
			// 
			// panelControl2
			// 
			this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl2.Location = new System.Drawing.Point(0, 65);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(703, 8);
			this.panelControl2.TabIndex = 14;
			// 
			// pivotGridControl1
			// 
			this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
			this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductAlphabetical,
            this.fieldProductName,
            this.fieldExtendedPrice,
            this.fieldOrderDate});
			this.pivotGridControl1.Location = new System.Drawing.Point(0, 73);
			this.pivotGridControl1.Name = "pivotGridControl1";
			this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
			this.pivotGridControl1.Size = new System.Drawing.Size(703, 343);
			this.pivotGridControl1.TabIndex = 15;
			this.pivotGridControl1.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGridControl1_FieldValueDisplayText);
			// 
			// fieldProductAlphabetical
			// 
			this.fieldProductAlphabetical.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.fieldProductAlphabetical.Appearance.Header.Options.UseFont = true;
			this.fieldProductAlphabetical.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldProductAlphabetical.AreaIndex = 0;
			this.fieldProductAlphabetical.Caption = "Product Alphabetical";
			this.fieldProductAlphabetical.FieldName = "ProductName";
			this.fieldProductAlphabetical.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Alphabetical;
			this.fieldProductAlphabetical.Name = "fieldProductAlphabetical";
			this.fieldProductAlphabetical.UnboundFieldName = "fieldProductAlphabetical";
			this.fieldProductAlphabetical.Width = 170;
			// 
			// fieldProductName
			// 
			this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldProductName.AreaIndex = 1;
			this.fieldProductName.Caption = "Product Name";
			this.fieldProductName.FieldName = "ProductName";
			this.fieldProductName.Name = "fieldProductName";
			this.fieldProductName.Width = 155;
			// 
			// fieldExtendedPrice
			// 
			this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldExtendedPrice.AreaIndex = 0;
			this.fieldExtendedPrice.CellFormat.FormatString = "c";
			this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldExtendedPrice.FieldName = "Extended Price";
			this.fieldExtendedPrice.Name = "fieldExtendedPrice";
			// 
			// fieldOrderDate
			// 
			this.fieldOrderDate.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.fieldOrderDate.Appearance.Header.Options.UseFont = true;
			this.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldOrderDate.AreaIndex = 0;
			this.fieldOrderDate.Caption = "Order Date";
			this.fieldOrderDate.FieldName = "OrderDate";
			this.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldOrderDate.Name = "fieldOrderDate";
			this.fieldOrderDate.UnboundFieldName = "fieldOrderDate";
			// 
			// GroupInterval
			// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pivotGridControl1);
			this.Controls.Add(this.panelControl2);
			this.Controls.Add(this.pcSplitter);
			this.Controls.Add(this.panelControl1);
			this.Name = "GroupInterval";
			this.Size = new System.Drawing.Size(703, 416);
			this.Load += new System.EventHandler(this.GroupInterval_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ceProductInterval.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.icbGroupInterval.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcSplitter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
		private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbGroupInterval;
        private DevExpress.XtraEditors.CheckEdit ceProductInterval;
        private DevExpress.XtraEditors.PanelControl pcSplitter;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private PivotGridControl pivotGridControl1;
		private PivotGridField fieldProductAlphabetical;
		private PivotGridField fieldProductName;
		private PivotGridField fieldExtendedPrice;
		private PivotGridField fieldOrderDate;

    }
}
