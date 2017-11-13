namespace DevExpress.XtraCharts.Demos.PointLineViews {
    public partial class StackedLine3dDemo : Line3dDemo {
        ChartControl chart;

        public override ChartControl ChartControl { get { return chart; } }

        public StackedLine3dDemo() {
            InitializeComponent();
        }

        protected override void InitControls() {
            base.InitControls();
            ChartControl.DataSource = DevAV.GetSalesByLast10Years();
        }
    }
}
