namespace DevExpress.XtraCharts.Demos.AdvancedViews {
	public partial class CandleStickDemo : FinancialSeriesViewDemoBase {
		ChartControl chart;
		
        public override ChartControl ChartControl { get { return this.chart; } }

		public CandleStickDemo() {
			InitializeComponent();
            if (this.chart.Series.Count > 0)
			    this.seriesSelected = this.chart.Series[0];
            ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries;
        }
	}
}

