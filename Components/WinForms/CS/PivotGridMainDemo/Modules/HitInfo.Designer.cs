namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class HitInfo {
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
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.headersAreaInfo1 = new DevExpress.XtraPivotGrid.Demos.Modules.HeadersAreaInfo();
            this.valueInfo1 = new DevExpress.XtraPivotGrid.Demos.Modules.ValueInfo();
            this.cellInfo1 = new DevExpress.XtraPivotGrid.Demos.Modules.CellInfo();
            this.lbHitTest = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSalesPerson1
            // 
            this.dsSalesPerson1.DataSetName = "dsSalesPerson";
            this.dsSalesPerson1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 86);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(706, 8);
            this.paddingPanel.TabIndex = 10;
            this.paddingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paddingPanel_Paint);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldSalesPerson,
            this.fieldCountry,
            this.fieldQuantity,
            this.fieldExtendedPrice});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 94);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(706, 322);
            this.pivotGridControl1.TabIndex = 11;
            this.pivotGridControl1.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl1_FieldValueImageIndex);
            this.pivotGridControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pivotGridControl1_MouseMove);
            this.pivotGridControl1.MouseLeave += new System.EventHandler(this.pivotGridControl1_MouseLeave);
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Width = 160;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Width = 180;
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesPerson.AreaIndex = 1;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            this.fieldSalesPerson.Width = 140;
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.FieldName = "Country";
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 0;
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 1;
            this.fieldExtendedPrice.Caption = "Order Amount";
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.headersAreaInfo1);
            this.panelControl1.Controls.Add(this.valueInfo1);
            this.panelControl1.Controls.Add(this.cellInfo1);
            this.panelControl1.Controls.Add(this.lbHitTest);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(4);
            this.panelControl1.Size = new System.Drawing.Size(706, 86);
            this.panelControl1.TabIndex = 12;
            // 
            // headersAreaInfo1
            // 
            this.headersAreaInfo1.Location = new System.Drawing.Point(272, 2);
            this.headersAreaInfo1.Name = "headersAreaInfo1";
            this.headersAreaInfo1.Size = new System.Drawing.Size(134, 75);
            this.headersAreaInfo1.TabIndex = 9;
            // 
            // valueInfo1
            // 
            this.valueInfo1.Location = new System.Drawing.Point(412, 3);
            this.valueInfo1.Name = "valueInfo1";
            this.valueInfo1.Size = new System.Drawing.Size(154, 74);
            this.valueInfo1.TabIndex = 8;
            // 
            // cellInfo1
            // 
            this.cellInfo1.Location = new System.Drawing.Point(572, 2);
            this.cellInfo1.Name = "cellInfo1";
            this.cellInfo1.Size = new System.Drawing.Size(129, 72);
            this.cellInfo1.TabIndex = 7;
            // 
            // lbHitTest
            // 
            this.lbHitTest.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lbHitTest.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbHitTest.Appearance.Options.UseBackColor = true;
            this.lbHitTest.Appearance.Options.UseFont = true;
            this.lbHitTest.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbHitTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbHitTest.Location = new System.Drawing.Point(6, 6);
            this.lbHitTest.Name = "lbHitTest";
            this.lbHitTest.Size = new System.Drawing.Size(133, 74);
            this.lbHitTest.TabIndex = 6;
            this.lbHitTest.Text = "None";
            // 
            // HitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.panelControl1);
            this.Name = "HitInfo";
            this.Size = new System.Drawing.Size(706, 416);
            this.Load += new System.EventHandler(this.HitInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl paddingPanel;
		private PivotGridControl pivotGridControl1;
		private PivotGridField fieldCategoryName;
		private PivotGridField fieldProductName;
		private PivotGridField fieldSalesPerson;
		private PivotGridField fieldCountry;
		private PivotGridField fieldQuantity;
		private PivotGridField fieldExtendedPrice;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraPivotGrid.Demos.Modules.HeadersAreaInfo headersAreaInfo1;
        private DevExpress.XtraPivotGrid.Demos.Modules.ValueInfo valueInfo1;
        private DevExpress.XtraPivotGrid.Demos.Modules.CellInfo cellInfo1;
        private DevExpress.XtraEditors.LabelControl lbHitTest;

    }
}
