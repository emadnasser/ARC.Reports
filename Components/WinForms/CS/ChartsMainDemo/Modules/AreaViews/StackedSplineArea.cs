namespace DevExpress.XtraCharts.Demos.AreaViews {
    public partial class StackedSplineAreaDemo : ChartDemoBase2D {
        ChartControl chart;

        public override ChartControl ChartControl { get { return this.chart; } }

        public StackedSplineAreaDemo() {
            InitializeComponent();
        }
        protected override void InitControls() {
            base.InitControls();
            ChartControl.DataSource = DevAV.GetSalesByLast10Years();
        }
    }
}
