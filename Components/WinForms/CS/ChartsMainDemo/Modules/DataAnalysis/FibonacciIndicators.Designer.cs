namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    partial class FibonacciIndicatorsDemo {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.CrosshairFreePosition crosshairFreePosition1 = new DevExpress.XtraCharts.CrosshairFreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StockSeriesLabel stockSeriesLabel1 = new DevExpress.XtraCharts.StockSeriesLabel();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView1 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.FinancialSlideAnimation financialSlideAnimation1 = new DevExpress.XtraCharts.FinancialSlideAnimation();
            DevExpress.XtraCharts.FibonacciIndicator fibonacciIndicator1 = new DevExpress.XtraCharts.FibonacciIndicator();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView2 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.cheLevel23_6 = new DevExpress.XtraEditors.CheckEdit();
            this.cheLevel76_4 = new DevExpress.XtraEditors.CheckEdit();
            this.cheLevel0 = new DevExpress.XtraEditors.CheckEdit();
            this.cheLevel100 = new DevExpress.XtraEditors.CheckEdit();
            this.cheAdditionalLevels = new DevExpress.XtraEditors.CheckEdit();
            this.lblKind = new DevExpress.XtraEditors.LabelControl();
            this.cbeKind = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fibonacciIndicator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLevel23_6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLevel76_4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLevel0.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLevel100.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAdditionalLevels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeKind.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbeKind);
            this.panel.Controls.Add(this.lblKind);
            this.panel.Controls.Add(this.cheAdditionalLevels);
            this.panel.Controls.Add(this.cheLevel76_4);
            this.panel.Controls.Add(this.cheLevel0);
            this.panel.Controls.Add(this.cheLevel100);
            this.panel.Controls.Add(this.cheLevel23_6);
            this.panel.Controls.SetChildIndex(this.cheLevel23_6, 0);
            this.panel.Controls.SetChildIndex(this.cheLevel100, 0);
            this.panel.Controls.SetChildIndex(this.cheLevel0, 0);
            this.panel.Controls.SetChildIndex(this.cheLevel76_4, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.cheAdditionalLevels, 0);
            this.panel.Controls.SetChildIndex(this.lblKind, 0);
            this.panel.Controls.SetChildIndex(this.cbeKind, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.Visible = false;
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            crosshairFreePosition1.DockTargetName = "Default Pane";
            this.chart.CrosshairOptions.CommonLabelPosition = crosshairFreePosition1;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridSpacing = 0.5D;
            xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOptions.Holidays.AddRange(new DevExpress.XtraCharts.KnownDate[] {
            new DevExpress.XtraCharts.KnownDate("Christmas Day", new System.DateTime(2007, 12, 25, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("New Year\'s Day", new System.DateTime(2008, 1, 1, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("Martin Luther King Day", new System.DateTime(2008, 1, 21, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("Presidents\' Day", new System.DateTime(2008, 2, 18, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("Good Friday", new System.DateTime(2008, 3, 21, 0, 0, 0, 0))});
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 2D;
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Title.Text = "US Dollars";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Date";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            stockSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            series1.Label = stockSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Apple Inc.";
            series1.ValueDataMembersSerializable = "Low;High;Open;Close";
            financialSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromRight;
            stockSeriesView1.Animation = financialSlideAnimation1;
            fibonacciIndicator1.BaseLevelColor = System.Drawing.Color.Green;
            fibonacciIndicator1.Name = "Fibonacci Indicator 1";
            fibonacciIndicator1.Point1.ArgumentSerializable = "09/13/2016 00:00:00.000";
            fibonacciIndicator1.Point1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Low;
            fibonacciIndicator1.Point2.ArgumentSerializable = "07/10/2016 00:00:00.000";
            fibonacciIndicator1.Point2.ValueLevel = DevExpress.XtraCharts.ValueLevel.High;
            fibonacciIndicator1.ShowAdditionalLevels = false;
            fibonacciIndicator1.ShowLevel0 = true;
            fibonacciIndicator1.ShowLevel100 = true;
            fibonacciIndicator1.ShowLevel23_6 = false;
            fibonacciIndicator1.ShowLevel76_4 = false;
            stockSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            fibonacciIndicator1});
            series1.View = stockSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.View = stockSeriesView2;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 3;
            chartTitle1.Text = "Apple Inc. Stock Prices";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.quandl.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // cheLevel23_6
            // 
            this.cheLevel23_6.Location = new System.Drawing.Point(190, 37);
            this.cheLevel23_6.Name = "cheLevel23_6";
            this.cheLevel23_6.Properties.Caption = "Show Level 23.6%";
            this.cheLevel23_6.Size = new System.Drawing.Size(112, 19);
            this.cheLevel23_6.TabIndex = 2;
            this.cheLevel23_6.CheckedChanged += new System.EventHandler(this.cheLevel23_6_CheckedChanged);
            // 
            // cheLevel76_4
            // 
            this.cheLevel76_4.Location = new System.Drawing.Point(319, 37);
            this.cheLevel76_4.Name = "cheLevel76_4";
            this.cheLevel76_4.Properties.Caption = "Show Level 76.4%";
            this.cheLevel76_4.Size = new System.Drawing.Size(112, 19);
            this.cheLevel76_4.TabIndex = 3;
            this.cheLevel76_4.CheckedChanged += new System.EventHandler(this.cheLevel76_4_CheckedChanged);
            // 
            // cheLevel0
            // 
            this.cheLevel0.Location = new System.Drawing.Point(190, 9);
            this.cheLevel0.Name = "cheLevel0";
            this.cheLevel0.Properties.Caption = "Show Level 0%";
            this.cheLevel0.Size = new System.Drawing.Size(99, 19);
            this.cheLevel0.TabIndex = 4;
            this.cheLevel0.CheckedChanged += new System.EventHandler(this.cheLevel0_CheckedChanged);
            // 
            // cheLevel100
            // 
            this.cheLevel100.Location = new System.Drawing.Point(319, 9);
            this.cheLevel100.Name = "cheLevel100";
            this.cheLevel100.Properties.Caption = "Show Level 100%";
            this.cheLevel100.Size = new System.Drawing.Size(108, 19);
            this.cheLevel100.TabIndex = 5;
            this.cheLevel100.CheckedChanged += new System.EventHandler(this.cheLevel100_CheckedChanged);
            // 
            // cheAdditionalLevels
            // 
            this.cheAdditionalLevels.Location = new System.Drawing.Point(12, 37);
            this.cheAdditionalLevels.Name = "cheAdditionalLevels";
            this.cheAdditionalLevels.Properties.Caption = "Show Additional Levels";
            this.cheAdditionalLevels.Size = new System.Drawing.Size(132, 19);
            this.cheAdditionalLevels.TabIndex = 6;
            this.cheAdditionalLevels.CheckedChanged += new System.EventHandler(this.cheAdditionalLevels_CheckedChanged);
            // 
            // lblKind
            // 
            this.lblKind.Location = new System.Drawing.Point(12, 12);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(24, 13);
            this.lblKind.TabIndex = 7;
            this.lblKind.Text = "Kind:";
            // 
            // cbeKind
            // 
            this.cbeKind.EditValue = "Fibonacci Arcs";
            this.cbeKind.Location = new System.Drawing.Point(42, 9);
            this.cbeKind.Name = "cbeKind";
            this.cbeKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeKind.Properties.Items.AddRange(new object[] {
            "Fibonacci Arcs",
            "Fibonacci Fans",
            "Fibonacci Retracement"});
            this.cbeKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeKind.Size = new System.Drawing.Size(130, 20);
            this.cbeKind.TabIndex = 8;
            this.cbeKind.SelectedIndexChanged += new System.EventHandler(this.cbeKind_SelectedIndexChanged);
            // 
            // FibonacciIndicatorsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "FibonacciIndicatorsDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fibonacciIndicator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLevel23_6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLevel76_4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLevel0.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLevel100.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAdditionalLevels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeKind.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.CheckEdit cheLevel100;
        private DevExpress.XtraEditors.CheckEdit cheLevel0;
        private DevExpress.XtraEditors.CheckEdit cheLevel76_4;
        private DevExpress.XtraEditors.CheckEdit cheLevel23_6;
        private DevExpress.XtraEditors.ComboBoxEdit cbeKind;
        private DevExpress.XtraEditors.LabelControl lblKind;
        private DevExpress.XtraEditors.CheckEdit cheAdditionalLevels;
    }
}
