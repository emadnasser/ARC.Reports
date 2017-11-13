namespace DevExpress.XtraCharts.Demos.AreaViews {
    public partial class StackedSplineArea3dDemo : Area3dDemoBase {
        ChartControl chart;

        public override ChartControl ChartControl { get { return this.chart; } }

        public StackedSplineArea3dDemo() {
            InitializeComponent();
        }
        protected override void InitControls() {
            base.InitControls();
            ChartControl.DataSource = DevAV.GetSalesByLast10Years();
        }
    }
}

