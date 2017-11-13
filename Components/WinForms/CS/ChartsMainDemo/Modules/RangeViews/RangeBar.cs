namespace DevExpress.XtraCharts.Demos.RangeViews {
    public partial class RangeBarDemo : ChartDemoBase2D {
        public override ChartControl ChartControl { get { return chart; } }
        
        public RangeBarDemo() {
            InitializeComponent();
        }
        protected override void InitControls() {
            base.InitControls();
            ChartControl.Series[0].DataSource = SourceOfEnergy.GetEuropeBrentPrices();
            ChartControl.Series[1].DataSource = SourceOfEnergy.GetOkWtiPrices();
        }
    }
}

