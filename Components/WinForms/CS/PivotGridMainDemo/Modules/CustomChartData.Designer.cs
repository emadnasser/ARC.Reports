namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class CustomChartData{
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboChartType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkShowPointLabels = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.seCellZeroValueThreshold = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbRowFieldValuesExportRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboChartType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPointLabels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seCellZeroValueThreshold.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRowFieldValuesExportRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldYear
            // 
            this.fieldYear.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "OrderDate";
            this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.fieldYear.Options.ShowCustomTotals = false;
            this.fieldYear.Options.ShowGrandTotal = false;
            this.fieldYear.Options.ShowTotals = false;
            this.fieldYear.UnboundFieldName = "fieldYear";
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Quarter";
            this.fieldQuarter.FieldName = "OrderDate";
            this.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.Options.ShowCustomTotals = false;
            this.fieldQuarter.Options.ShowGrandTotal = false;
            this.fieldQuarter.Options.ShowTotals = false;
            this.fieldQuarter.UnboundFieldName = "fieldQuarter";
            this.fieldQuarter.ValueFormat.FormatString = "Qtr {0}";
            this.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldMonth
            // 
            this.fieldMonth.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
            this.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMonth.AreaIndex = 2;
            this.fieldMonth.Caption = "Month";
            this.fieldMonth.FieldName = "OrderDate";
            this.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldMonth.Name = "fieldMonth";
            this.fieldMonth.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            this.fieldMonth.Options.ShowCustomTotals = false;
            this.fieldMonth.Options.ShowGrandTotal = false;
            this.fieldMonth.Options.ShowTotals = false;
            this.fieldMonth.UnboundFieldName = "fieldMonth";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.comboChartType);
            this.groupControl2.Controls.Add(this.checkShowPointLabels);
            this.groupControl2.Location = new System.Drawing.Point(353, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(246, 85);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chart Settings";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Chart Type:";
            // 
            // comboChartType
            // 
            this.comboChartType.EditValue = "Line";
            this.comboChartType.Location = new System.Drawing.Point(80, 31);
            this.comboChartType.Name = "comboChartType";
            this.comboChartType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboChartType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboChartType.Size = new System.Drawing.Size(154, 20);
            this.comboChartType.TabIndex = 21;
            this.comboChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit2_SelectedIndexChanged);
            // 
            // checkShowPointLabels
            // 
            this.checkShowPointLabels.Location = new System.Drawing.Point(14, 56);
            this.checkShowPointLabels.Name = "checkShowPointLabels";
            this.checkShowPointLabels.Properties.Caption = "Show Point Labels";
            this.checkShowPointLabels.Size = new System.Drawing.Size(109, 19);
            this.checkShowPointLabels.TabIndex = 22;
            this.checkShowPointLabels.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.seCellZeroValueThreshold);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbRowFieldValuesExportRule);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(347, 85);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Pivot Grid Settings";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(241, 59);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "as Zero Values";
            // 
            // seCellZeroValueThreshold
            // 
            this.seCellZeroValueThreshold.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seCellZeroValueThreshold.Location = new System.Drawing.Point(167, 56);
            this.seCellZeroValueThreshold.Name = "seCellZeroValueThreshold";
            this.seCellZeroValueThreshold.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seCellZeroValueThreshold.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seCellZeroValueThreshold.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seCellZeroValueThreshold.Properties.IsFloatValue = false;
            this.seCellZeroValueThreshold.Properties.Mask.EditMask = "N00";
            this.seCellZeroValueThreshold.Size = new System.Drawing.Size(60, 20);
            this.seCellZeroValueThreshold.TabIndex = 25;
            this.seCellZeroValueThreshold.EditValueChanged += new System.EventHandler(this.seCellZeroValueThreshold_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(139, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Export Cell Values Less than:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Row Field Values Export Rule:";
            // 
            // cbRowFieldValuesExportRule
            // 
            this.cbRowFieldValuesExportRule.EditValue = "";
            this.cbRowFieldValuesExportRule.Location = new System.Drawing.Point(167, 31);
            this.cbRowFieldValuesExportRule.Name = "cbRowFieldValuesExportRule";
            this.cbRowFieldValuesExportRule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRowFieldValuesExportRule.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbRowFieldValuesExportRule.Size = new System.Drawing.Size(157, 20);
            this.cbRowFieldValuesExportRule.TabIndex = 22;
            this.cbRowFieldValuesExportRule.SelectedIndexChanged += new System.EventHandler(this.cbRowFieldValuesExportRule_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(707, 92);
            this.panelControl1.TabIndex = 3;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 92);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.pivotGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.chartControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(707, 378);
            this.splitContainerControl1.SplitterPosition = 164;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldExtendedPrice,
            this.fieldMonth,
            this.fieldYear,
            this.fieldProductName,
            this.fieldQuarter});
            pivotGridGroup1.Caption = "DateTimeFields";
            pivotGridGroup1.Fields.Add(this.fieldYear);
            pivotGridGroup1.Fields.Add(this.fieldQuarter);
            pivotGridGroup1.Fields.Add(this.fieldMonth);
            pivotGridGroup1.Hierarchy = null;
            this.pivotGridControl.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings;
            this.pivotGridControl.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value;
            this.pivotGridControl.OptionsChartDataSource.ProvideColumnCustomTotals = false;
            this.pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = false;
            this.pivotGridControl.OptionsChartDataSource.ProvideColumnTotals = false;
            this.pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = false;
            this.pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = false;
            this.pivotGridControl.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl.OptionsView.ShowRowTotals = false;
            this.pivotGridControl.Size = new System.Drawing.Size(707, 209);
            this.pivotGridControl.TabIndex = 20;
            this.pivotGridControl.CustomChartDataSourceData += new DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventHandler(this.pivotGridControl1_CustomChartDataSourceData);
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.fieldCategoryName.Options.ShowCustomTotals = false;
            this.fieldCategoryName.Options.ShowGrandTotal = false;
            this.fieldCategoryName.Options.ShowTotals = false;
            this.fieldCategoryName.Width = 155;
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.CellFormat.FormatString = "c";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            this.fieldExtendedPrice.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldProductName
            // 
            this.fieldProductName.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "ProductName";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            // 
            // chartControl
            // 
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = XtraCharts.DateTimeGridAlignment.Year;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = XtraCharts.DateTimeMeasureUnit.Year;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = true;           
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
            this.chartControl.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl.SeriesTemplate.Label = pointSeriesLabel1;
            this.chartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl.SeriesTemplate.View = lineSeriesView1;
            this.chartControl.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:c}";
            this.chartControl.Size = new System.Drawing.Size(707, 164);
            this.chartControl.TabIndex = 30;
            // 
            // CustomChartData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "CustomChartData";
            this.Size = new System.Drawing.Size(707, 470);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboChartType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPointLabels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seCellZeroValueThreshold.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRowFieldValuesExportRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
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

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private PivotGridControl pivotGridControl;
        private PivotGridField fieldCategoryName;
        private PivotGridField fieldExtendedPrice;
        private PivotGridField fieldMonth;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private PivotGridField fieldYear;
        private PivotGridField fieldProductName;
        private PivotGridField fieldQuarter;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit checkShowPointLabels;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboChartType;
        private DevExpress.XtraEditors.ComboBoxEdit cbRowFieldValuesExportRule;
        private DevExpress.XtraEditors.SpinEdit seCellZeroValueThreshold;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
