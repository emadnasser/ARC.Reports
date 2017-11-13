namespace DevExpress.XtraCharts.Demos.AreaViews {
    public partial class SplineArea3dDemo : Area3dDemoBase {
        ChartControl chart;

        public override ChartControl ChartControl { get { return this.chart; } }

        public SplineArea3dDemo() {
            InitializeComponent();
        }
        protected override void InitControls() {
            base.InitControls();
            ChartControl.DataSource = DevAV.GetOutsideVendorCosts();
        }
    }
}

