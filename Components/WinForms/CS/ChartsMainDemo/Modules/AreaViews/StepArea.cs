using DevExpress.XtraCharts.Demos.PointLineViews;

namespace DevExpress.XtraCharts.Demos.AreaViews {
	public partial class StepAreaDemo : ChartDemoLineBase {
		ChartControl chart;

		public override ChartControl ChartControl { get { return this.chart; } }

        public StepAreaDemo() {
			InitializeComponent();
        }
        protected override void InitControls() {
            base.InitControls();
            this.seriesSelected = ChartControl.Series[0];
            this.seriesSelected.DataSource = SourceOfEnergy.GetFuelPrices();
        }
        void chart_BoundDataChanged(object sender, System.EventArgs e) {
            ChartControl.Animate();
        }
    }
}

