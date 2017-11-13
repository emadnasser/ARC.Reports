namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class OrderReports {
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
            this.fieldOrderID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProduct = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiscount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSum = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.rgReport = new DevExpress.XtraEditors.RadioGroup();
            this.pcOrder = new DevExpress.XtraEditors.PanelControl();
            this.cbeOrder = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.dsReports1 = new DevExpress.XtraPivotGrid.Demos.dsReports();
            this.controlPanel = new DevExpress.XtraEditors.PanelControl();
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcOrder)).BeginInit();
            this.pcOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fieldOrderID
            // 
            this.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOrderID.AreaIndex = 0;
            this.fieldOrderID.Caption = "Order";
            this.fieldOrderID.FieldName = "OrderID";
            this.fieldOrderID.Name = "fieldOrderID";
            this.fieldOrderID.Width = 105;
            // 
            // fieldProduct
            // 
            this.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProduct.AreaIndex = 1;
            this.fieldProduct.Caption = "Product Name";
            this.fieldProduct.FieldName = "ProductName";
            this.fieldProduct.Name = "fieldProduct";
            this.fieldProduct.Width = 185;
            // 
            // fieldUnitPrice
            // 
            this.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitPrice.AreaIndex = 0;
            this.fieldUnitPrice.Caption = "Unit Price";
            this.fieldUnitPrice.CellFormat.FormatString = "c";
            this.fieldUnitPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldUnitPrice.FieldName = "UnitPrice";
            this.fieldUnitPrice.Name = "fieldUnitPrice";
            this.fieldUnitPrice.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldUnitPrice.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 1;
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            this.fieldQuantity.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldDiscount
            // 
            this.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDiscount.AreaIndex = 2;
            this.fieldDiscount.FieldName = "Discount";
            this.fieldDiscount.Name = "fieldDiscount";
            this.fieldDiscount.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldDiscount.TotalCellFormat.FormatString = "P";
            this.fieldDiscount.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldDiscount.Width = 99;
            // 
            // fieldSum
            // 
            this.fieldSum.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSum.AreaIndex = 3;
            this.fieldSum.CellFormat.FormatString = "c";
            this.fieldSum.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldSum.FieldName = "Extended Price";
            this.fieldSum.Name = "fieldSum";
            this.fieldSum.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldSum.Width = 120;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.rgReport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(4);
            this.panelControl1.Size = new System.Drawing.Size(700, 61);
            this.panelControl1.TabIndex = 2;
            // 
            // rgReport
            // 
            this.rgReport.Location = new System.Drawing.Point(11, 7);
            this.rgReport.Name = "rgReport";
            this.rgReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgReport.Properties.Appearance.Options.UseBackColor = true;
            this.rgReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgReport.Properties.Columns = 2;
            this.rgReport.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Orders"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Orders (filtering)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Quantity"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Average Unit Price")});
            this.rgReport.Size = new System.Drawing.Size(241, 53);
            this.rgReport.TabIndex = 0;
            this.rgReport.SelectedIndexChanged += new System.EventHandler(this.rgReport_SelectedIndexChanged);
            // 
            // pcOrder
            // 
            this.pcOrder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcOrder.Controls.Add(this.cbeOrder);
            this.pcOrder.Controls.Add(this.label1);
            this.pcOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcOrder.Location = new System.Drawing.Point(2, 63);
            this.pcOrder.Name = "pcOrder";
            this.pcOrder.Padding = new System.Windows.Forms.Padding(4);
            this.pcOrder.Size = new System.Drawing.Size(700, 30);
            this.pcOrder.TabIndex = 3;
            // 
            // cbeOrder
            // 
            this.cbeOrder.EditValue = "";
            this.cbeOrder.Location = new System.Drawing.Point(63, 4);
            this.cbeOrder.Name = "cbeOrder";
            this.cbeOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeOrder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeOrder.Size = new System.Drawing.Size(144, 20);
            this.cbeOrder.TabIndex = 1;
            this.cbeOrder.SelectedIndexChanged += new System.EventHandler(this.cbeOrder_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label1.Appearance.Options.UseBackColor = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderID: ";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pivotGridControl1.DataSource = this.dsReports1.OrderReports;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOrderID,
            this.fieldProduct,
            this.fieldUnitPrice,
            this.fieldQuantity,
            this.fieldDiscount,
            this.fieldSum});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(704, 305);
            this.pivotGridControl1.TabIndex = 4;
            // 
            // dsReports1
            // 
            this.dsReports1.DataSetName = "dsReports";
            this.dsReports1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controlPanel
            // 
            this.controlPanel.AutoSize = true;
            this.controlPanel.Controls.Add(this.pcOrder);
            this.controlPanel.Controls.Add(this.panelControl1);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(704, 95);
            this.controlPanel.TabIndex = 11;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 95);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(704, 8);
            this.paddingPanel.TabIndex = 12;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.pivotGridControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 103);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(704, 305);
            this.mainPanel.TabIndex = 13;
            // 
            // OrderReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "OrderReports";
            this.Size = new System.Drawing.Size(704, 408);
            this.Load += new System.EventHandler(this.OrderReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcOrder)).EndInit();
            this.pcOrder.ResumeLayout(false);
            this.pcOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).EndInit();
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProduct;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDiscount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSum;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.Demos.dsReports dsReports1;
		private DevExpress.XtraEditors.RadioGroup rgReport;
        private DevExpress.XtraEditors.PanelControl pcOrder;
		private DevExpress.XtraEditors.ComboBoxEdit cbeOrder;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl controlPanel;
		private DevExpress.XtraEditors.PanelControl paddingPanel;
		private DevExpress.XtraEditors.PanelControl mainPanel;

    }
}
