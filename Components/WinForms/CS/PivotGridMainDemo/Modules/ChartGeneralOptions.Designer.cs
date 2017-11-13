namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class ChartGeneralOptions {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.seUpdateDelay = new DevExpress.XtraEditors.SpinEdit();
            this.lblUpdateDelay = new DevExpress.XtraEditors.LabelControl();
            this.ceShowRowGrandTotals = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowColumnGrandTotals = new DevExpress.XtraEditors.CheckEdit();
            this.ceSelectionOnly = new DevExpress.XtraEditors.CheckEdit();
            this.ceChartDataVertical = new DevExpress.XtraEditors.CheckEdit();
            this.checkShowPointLabels = new DevExpress.XtraEditors.CheckEdit();
            this.comboChartType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seUpdateDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowRowGrandTotals.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowColumnGrandTotals.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelectionOnly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChartDataVertical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPointLabels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboChartType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.seUpdateDelay);
            this.panelControl1.Controls.Add(this.lblUpdateDelay);
            this.panelControl1.Controls.Add(this.ceShowRowGrandTotals);
            this.panelControl1.Controls.Add(this.ceShowColumnGrandTotals);
            this.panelControl1.Controls.Add(this.ceSelectionOnly);
            this.panelControl1.Controls.Add(this.ceChartDataVertical);
            this.panelControl1.Controls.Add(this.checkShowPointLabels);
            this.panelControl1.Controls.Add(this.comboChartType);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(690, 67);
            this.panelControl1.TabIndex = 0;
            // 
            // seUpdateDelay
            // 
            this.seUpdateDelay.EditValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.seUpdateDelay.Location = new System.Drawing.Point(184, 37);
            this.seUpdateDelay.Name = "seUpdateDelay";
            this.seUpdateDelay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seUpdateDelay.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seUpdateDelay.Properties.IsFloatValue = false;
            this.seUpdateDelay.Properties.Mask.EditMask = "N00";
            this.seUpdateDelay.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.seUpdateDelay.Size = new System.Drawing.Size(48, 20);
            this.seUpdateDelay.TabIndex = 10;
            this.seUpdateDelay.ToolTip = "Sets the Chart update delay when PivotGrid selection changes.";
            this.seUpdateDelay.EditValueChanged += new System.EventHandler(this.seUpdateDelay_EditValueChanged);
            // 
            // lblUpdateDelay
            // 
            this.lblUpdateDelay.Location = new System.Drawing.Point(107, 40);
            this.lblUpdateDelay.Name = "lblUpdateDelay";
            this.lblUpdateDelay.Size = new System.Drawing.Size(69, 13);
            this.lblUpdateDelay.TabIndex = 13;
            this.lblUpdateDelay.Text = "Update Delay:";
            // 
            // ceShowRowGrandTotals
            // 
            this.ceShowRowGrandTotals.EditValue = true;
            this.ceShowRowGrandTotals.Location = new System.Drawing.Point(412, 10);
            this.ceShowRowGrandTotals.Name = "ceShowRowGrandTotals";
            this.ceShowRowGrandTotals.Properties.AutoWidth = true;
            this.ceShowRowGrandTotals.Properties.Caption = "Show Row Grand Totals";
            this.ceShowRowGrandTotals.Size = new System.Drawing.Size(137, 19);
            this.ceShowRowGrandTotals.TabIndex = 7;
            this.ceShowRowGrandTotals.ToolTip = "Toggles whether row grand total values are shown in the Chart control";
            this.ceShowRowGrandTotals.CheckedChanged += new System.EventHandler(this.ceShowRowGrandTotals_CheckedChanged);
            // 
            // ceShowColumnGrandTotals
            // 
            this.ceShowColumnGrandTotals.Location = new System.Drawing.Point(412, 37);
            this.ceShowColumnGrandTotals.Name = "ceShowColumnGrandTotals";
            this.ceShowColumnGrandTotals.Properties.AutoWidth = true;
            this.ceShowColumnGrandTotals.Properties.Caption = "Show Column Grand Totals";
            this.ceShowColumnGrandTotals.Size = new System.Drawing.Size(151, 19);
            this.ceShowColumnGrandTotals.TabIndex = 13;
            this.ceShowColumnGrandTotals.ToolTip = "Toggles whether column grand total values are shown in the Chart control";
            this.ceShowColumnGrandTotals.CheckedChanged += new System.EventHandler(this.ceShowColumnGrandTotals_CheckedChanged);
            // 
            // ceSelectionOnly
            // 
            this.ceSelectionOnly.EditValue = true;
            this.ceSelectionOnly.Location = new System.Drawing.Point(10, 37);
            this.ceSelectionOnly.Name = "ceSelectionOnly";
            this.ceSelectionOnly.Properties.AutoWidth = true;
            this.ceSelectionOnly.Properties.Caption = "Selection Only";
            this.ceSelectionOnly.Size = new System.Drawing.Size(91, 19);
            this.ceSelectionOnly.TabIndex = 9;
            this.ceSelectionOnly.ToolTip = "Toggles whether all PivotGrid cells or selected cells only should be represented " +
                "in the Chart";
            this.ceSelectionOnly.CheckedChanged += new System.EventHandler(this.ceSelectionOnly_CheckedChanged);
            // 
            // ceChartDataVertical
            // 
            this.ceChartDataVertical.Location = new System.Drawing.Point(238, 37);
            this.ceChartDataVertical.Name = "ceChartDataVertical";
            this.ceChartDataVertical.Properties.AutoWidth = true;
            this.ceChartDataVertical.Properties.Caption = "Generate Series from Columns";
            this.ceChartDataVertical.Size = new System.Drawing.Size(168, 19);
            this.ceChartDataVertical.TabIndex = 12;
            this.ceChartDataVertical.ToolTip = "Toggles whether series in a chart control are created based on PivotGrid columns " +
                "or rows";
            this.ceChartDataVertical.CheckedChanged += new System.EventHandler(this.ceChartDataVertical_CheckedChanged);
            // 
            // checkShowPointLabels
            // 
            this.checkShowPointLabels.Location = new System.Drawing.Point(238, 10);
            this.checkShowPointLabels.Name = "checkShowPointLabels";
            this.checkShowPointLabels.Properties.AutoWidth = true;
            this.checkShowPointLabels.Properties.Caption = "Show Point Labels";
            this.checkShowPointLabels.Size = new System.Drawing.Size(109, 19);
            this.checkShowPointLabels.TabIndex = 4;
            this.checkShowPointLabels.ToolTip = "Toggles whether value labels are shown in the Chart control";
            this.checkShowPointLabels.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // comboChartType
            // 
            this.comboChartType.EditValue = "Line";
            this.comboChartType.Location = new System.Drawing.Point(78, 10);
            this.comboChartType.Name = "comboChartType";
            this.comboChartType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboChartType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboChartType.Size = new System.Drawing.Size(154, 20);
            this.comboChartType.TabIndex = 3;
            this.comboChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit2_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Chart Type:";
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 67);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(690, 8);
            this.paddingPanel.TabIndex = 4;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 75);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.pivotGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.chartControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(690, 395);
            this.splitContainerControl1.SplitterPosition = 176;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName,
            this.fieldExtendedPrice,
            this.fieldOrderMonth,
            this.fieldOrderYear});
            this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings;
            this.pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = false;
            this.pivotGridControl.OptionsChartDataSource.UpdateDelay = 500;
            this.pivotGridControl.Size = new System.Drawing.Size(690, 214);
            this.pivotGridControl.TabIndex = 2;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 0;
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
            this.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderMonth.AreaIndex = 0;
            this.fieldOrderMonth.Caption = "Order Month";
            this.fieldOrderMonth.FieldName = "OrderDate";
            this.fieldOrderMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldOrderMonth.Name = "fieldOrderDate";
            this.fieldOrderMonth.UnboundFieldName = "fieldOrderDate";
            // 
            // chartControl
            // 
            xyDiagram1.AxisX.Label.Staggered = true;            
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";            
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.MaxHorizontalPercentage = 30;
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.RuntimeHitTesting = false;
            this.chartControl.SeriesDataMember = "Series";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.SeriesTemplate.ArgumentDataMember = "Arguments";
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl.SeriesTemplate.Label = pointSeriesLabel1;
            this.chartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl.SeriesTemplate.View = lineSeriesView1;
            this.chartControl.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:c}";
            this.chartControl.Size = new System.Drawing.Size(690, 176);
            this.chartControl.TabIndex = 3;
            // 
            // pivotGridField1
            // 
            this.fieldOrderYear.AreaIndex = 0;
            this.fieldOrderYear.Caption = "Order Year";
            this.fieldOrderYear.FieldName = "OrderDate";
            this.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderYear.Name = "pivotGridField1";
            this.fieldOrderYear.Options.IsFilterRadioMode = DevExpress.Utils.DefaultBoolean.True;
            this.fieldOrderYear.UnboundFieldName = "pivotGridField1";
            // 
            // ChartGeneralOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.panelControl1);
            this.Name = "ChartGeneralOptions";
            this.Size = new System.Drawing.Size(690, 470);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seUpdateDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowRowGrandTotals.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowColumnGrandTotals.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelectionOnly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChartDataVertical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPointLabels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboChartType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.ComboBoxEdit comboChartType;
		private DevExpress.XtraEditors.CheckEdit checkShowPointLabels;
		private DevExpress.XtraEditors.PanelControl paddingPanel;
		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private PivotGridControl pivotGridControl;
		private PivotGridField fieldProductName;
		private PivotGridField fieldExtendedPrice;
		private PivotGridField fieldOrderMonth;
        private PivotGridField fieldOrderYear;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraEditors.CheckEdit ceSelectionOnly;
        private DevExpress.XtraEditors.CheckEdit ceChartDataVertical;
		private DevExpress.XtraEditors.CheckEdit ceShowRowGrandTotals;
        private DevExpress.XtraEditors.CheckEdit ceShowColumnGrandTotals;
        private DevExpress.XtraEditors.LabelControl lblUpdateDelay;
        private DevExpress.XtraEditors.SpinEdit seUpdateDelay;
	}
}
