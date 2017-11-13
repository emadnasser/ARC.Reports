namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
	public partial class PolarPointDemo : PolarDemoBase {
		ChartControl chart;

		public override ChartControl ChartControl { get { return this.chart; } }

		public PolarPointDemo() {
			InitializeComponent();
		}

        protected override void InitControls() {
            base.InitControls();
            foreach (Series series in chart.Series)
                series.ToolTipPointPattern = "{A}: {V:F2}";
        }
    }
}
