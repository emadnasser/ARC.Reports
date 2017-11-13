namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class RunningTotal {
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing) {
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Designer generated code
		private void InitializeComponent() {
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldProductAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.controlPanel = new DevExpress.XtraEditors.PanelControl();
            this.ceAllowCrossGroupRunningTotals = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowRunningTotals = new DevExpress.XtraEditors.CheckEdit();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowCrossGroupRunningTotals.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowRunningTotals.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
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
            this.fieldOrderYear.UnboundFieldName = "pivotGridField1";
            // 
            // fieldOrderQuarter
            // 
            this.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderQuarter.AreaIndex = 1;
            this.fieldOrderQuarter.Caption = "Order Quarter";
            this.fieldOrderQuarter.FieldName = "OrderDate";
            this.fieldOrderQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldOrderQuarter.Name = "fieldOrderQuarter";
            this.fieldOrderQuarter.UnboundFieldName = "pivotGridField2";
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 39);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(700, 8);
            this.paddingPanel.TabIndex = 7;
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductAmount,
            this.fieldProductName,
            this.fieldOrderYear,
            this.fieldOrderQuarter});
            pivotGridGroup1.Fields.Add(this.fieldOrderYear);
            pivotGridGroup1.Fields.Add(this.fieldOrderQuarter);
            pivotGridGroup1.Hierarchy = null;
            this.pivotGridControl.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl.Size = new System.Drawing.Size(700, 353);
            this.pivotGridControl.TabIndex = 0;
            // 
            // fieldProductAmount
            // 
            this.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductAmount.AreaIndex = 0;
            this.fieldProductAmount.Caption = "Product Sales";
            this.fieldProductAmount.CellFormat.FormatString = "c";
            this.fieldProductAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldProductAmount.FieldName = "ProductAmount";
            this.fieldProductAmount.Name = "fieldProductAmount";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 0;
            this.fieldProductName.Caption = "Product";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.ceAllowCrossGroupRunningTotals);
            this.controlPanel.Controls.Add(this.ceShowRunningTotals);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(700, 39);
            this.controlPanel.TabIndex = 6;
            // 
            // ceAllowCrossGroupRunningTotals
            // 
            this.ceAllowCrossGroupRunningTotals.Location = new System.Drawing.Point(362, 10);
            this.ceAllowCrossGroupRunningTotals.Name = "ceAllowCrossGroupRunningTotals";
            this.ceAllowCrossGroupRunningTotals.Properties.Caption = "Allow Cross-Group Running Totals Accumulation";
            this.ceAllowCrossGroupRunningTotals.Size = new System.Drawing.Size(254, 19);
            this.ceAllowCrossGroupRunningTotals.TabIndex = 4;
            this.ceAllowCrossGroupRunningTotals.CheckedChanged += new System.EventHandler(this.ceAllowCrossGroupRunningTotals_CheckedChanged);
            // 
            // ceShowRunningTotals
            // 
            this.ceShowRunningTotals.Location = new System.Drawing.Point(12, 10);
            this.ceShowRunningTotals.Name = "ceShowRunningTotals";
            this.ceShowRunningTotals.Properties.AutoWidth = true;
            this.ceShowRunningTotals.Properties.Caption = "Include Previous Quarter Sales into the Values of the Next Quarter";
            this.ceShowRunningTotals.Size = new System.Drawing.Size(344, 19);
            this.ceShowRunningTotals.TabIndex = 3;
            this.ceShowRunningTotals.CheckedChanged += new System.EventHandler(this.ceShowRunningTotals_CheckedChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.pivotGridControl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 47);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(700, 353);
            this.mainPanel.TabIndex = 8;
            // 
            // RunningTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "RunningTotal";
            this.Size = new System.Drawing.Size(700, 400);
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).EndInit();
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowCrossGroupRunningTotals.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowRunningTotals.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private DevExpress.XtraEditors.PanelControl paddingPanel;
		private PivotGridControl pivotGridControl;
		private PivotGridField fieldProductAmount;
		private PivotGridField fieldProductName;
		private DevExpress.XtraEditors.PanelControl controlPanel;
		private DevExpress.XtraEditors.PanelControl mainPanel;
		private DevExpress.XtraEditors.CheckEdit ceShowRunningTotals;
		private PivotGridField fieldOrderYear;
		private PivotGridField fieldOrderQuarter;
        private DevExpress.XtraEditors.CheckEdit ceAllowCrossGroupRunningTotals;
	}
}
