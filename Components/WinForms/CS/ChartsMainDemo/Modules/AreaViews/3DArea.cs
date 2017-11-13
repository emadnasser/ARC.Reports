namespace DevExpress.XtraCharts.Demos.AreaViews {
	public partial class Area3dDemo : Area3dDemoBase {
		ChartControl chart;

        public override ChartControl ChartControl { get { return this.chart; } }

		public Area3dDemo() {
			InitializeComponent();
		}
        protected override void InitControls() {
            base.InitControls();
            ChartControl.DataSource = DevAV.GetOutsideVendorCosts();
        }
    }
}
