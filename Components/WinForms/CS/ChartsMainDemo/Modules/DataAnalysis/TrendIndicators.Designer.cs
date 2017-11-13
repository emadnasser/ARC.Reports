namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    partial class TrendIndicatorsDemo {
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
            DevExpress.XtraCharts.TextAnnotation textAnnotation1 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.PaneAnchorPoint paneAnchorPoint1 = new DevExpress.XtraCharts.PaneAnchorPoint();
            DevExpress.XtraCharts.RelativePosition relativePosition1 = new DevExpress.XtraCharts.RelativePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.XYDiagramPane xyDiagramPane1 = new DevExpress.XtraCharts.XYDiagramPane();
            DevExpress.XtraCharts.XYDiagramPane xyDiagramPane2 = new DevExpress.XtraCharts.XYDiagramPane();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.ConstantLine constantLine1 = new DevExpress.XtraCharts.ConstantLine();
            DevExpress.XtraCharts.ConstantLine constantLine2 = new DevExpress.XtraCharts.ConstantLine();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY2 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Legend legend1 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.Legend legend2 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StockSeriesLabel stockSeriesLabel1 = new DevExpress.XtraCharts.StockSeriesLabel();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView1 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.BollingerBands bollingerBands1 = new DevExpress.XtraCharts.BollingerBands();
            DevExpress.XtraCharts.MassIndex massIndex1 = new DevExpress.XtraCharts.MassIndex();
            DevExpress.XtraCharts.StandardDeviation standardDeviation1 = new DevExpress.XtraCharts.StandardDeviation();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView2 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bollingerBands1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(massIndex1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(standardDeviation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Size = new System.Drawing.Size(703, 66);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(702, 12);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.Visible = false;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(703, 74);
            this.panelRoot.Visible = false;
            // 
            // chart
            // 
            paneAnchorPoint1.AxisXCoordinate.AxisValueSerializable = "";
            paneAnchorPoint1.AxisYCoordinate.AxisValueSerializable = "";
            paneAnchorPoint1.PaneName = "StDevPane";
            textAnnotation1.AnchorPoint = paneAnchorPoint1;
            textAnnotation1.Name = "Text Annotation 1";
            textAnnotation1.ShapePosition = relativePosition1;
            this.chart.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation1});
            this.chart.CrosshairOptions.ShowOnlyInFocusedPane = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOnly = true;
            xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOptions.Holidays.AddRange(new DevExpress.XtraCharts.KnownDate[] {
            new DevExpress.XtraCharts.KnownDate("Christmas Day", new System.DateTime(2007, 12, 25, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("New Year\'s Day", new System.DateTime(2008, 1, 1, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("Martin Luther King Day", new System.DateTime(2008, 1, 21, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("Presidents\' Day", new System.DateTime(2008, 2, 18, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("Good Friday", new System.DateTime(2008, 3, 21, 0, 0, 0, 0))});
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.Label.TextPattern = "{A: d}";
            xyDiagram1.AxisX.Title.Text = "";
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "1";
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far;
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Title.Text = "US Dollars";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0.5D;
            xyDiagram1.DefaultPane.Weight = 2D;
            xyDiagramPane1.Name = "MassIndexPane";
            xyDiagramPane1.PaneID = 0;
            xyDiagramPane2.Name = "StDevPane";
            xyDiagramPane2.PaneID = 1;
            xyDiagram1.Panes.AddRange(new DevExpress.XtraCharts.XYDiagramPane[] {
            xyDiagramPane1,
            xyDiagramPane2});
            secondaryAxisY1.AxisID = 0;
            constantLine1.AxisValueSerializable = "26.5";
            constantLine1.Name = "26.5";
            constantLine1.ShowInLegend = false;
            constantLine1.Title.Alignment = DevExpress.XtraCharts.ConstantLineTitleAlignment.Far;
            constantLine1.Title.ShowBelowLine = true;
            constantLine2.AxisValueSerializable = "27";
            constantLine2.Name = "27";
            constantLine2.ShowInLegend = false;
            constantLine2.Title.Alignment = DevExpress.XtraCharts.ConstantLineTitleAlignment.Far;
            secondaryAxisY1.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] {
            constantLine1,
            constantLine2});
            secondaryAxisY1.GridLines.MinorVisible = true;
            secondaryAxisY1.GridLines.Visible = true;
            secondaryAxisY1.Name = "MassIndexAxisY";
            secondaryAxisY1.Title.Text = "Mass Index";
            secondaryAxisY1.VisibleInPanesSerializable = "0";
            secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = false;
            secondaryAxisY2.AxisID = 1;
            secondaryAxisY2.GridLines.MinorVisible = true;
            secondaryAxisY2.GridLines.Visible = true;
            secondaryAxisY2.Name = "StDevAxisY";
            secondaryAxisY2.VisibleInPanesSerializable = "1";
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1,
            secondaryAxisY2});
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            legend1.DockTargetName = "MassIndexPane";
            legend1.Name = "Legend1";
            legend2.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            legend2.DockTargetName = "StDevPane";
            legend2.Name = "Legend2";
            this.chart.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend1,
            legend2});
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "DateTimeArgument";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            stockSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            series1.Label = stockSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "USDJPY Daily";
            series1.ValueDataMembersSerializable = "LowValue;HighValue;OpenValue;CloseValue";
            bollingerBands1.Name = "Bollinger Bands";
            bollingerBands1.ShowInLegend = true;
            massIndex1.AxisYName = "MassIndexAxisY";
            massIndex1.LegendName = "Legend1";
            massIndex1.LineStyle.Thickness = 2;
            massIndex1.Name = "Mass Index";
            massIndex1.PaneName = "MassIndexPane";
            massIndex1.ShowInLegend = true;
            standardDeviation1.AxisYName = "StDevAxisY";
            standardDeviation1.LegendName = "Legend2";
            standardDeviation1.LineStyle.Thickness = 2;
            standardDeviation1.Name = "Standard Deviation";
            standardDeviation1.PaneName = "StDevPane";
            standardDeviation1.ShowInLegend = true;
            stockSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            bollingerBands1,
            massIndex1,
            standardDeviation1});
            stockSeriesView1.LevelLineLength = 0.3D;
            series1.View = stockSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.View = stockSeriesView2;
            this.chart.Size = new System.Drawing.Size(703, 426);
            this.chart.TabIndex = 3;
            chartTitle1.Text = "USDJPY Daily";
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // TrendIndicatorsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "TrendIndicatorsDemo";
            this.Size = new System.Drawing.Size(703, 500);
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bollingerBands1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(massIndex1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(standardDeviation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
    }
}
