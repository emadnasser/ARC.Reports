using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.RangeViews {
    public partial class SideBySideRangeBarDemo : ChartDemoBase2D {
        ChartControl chart;

        public override ChartControl ChartControl { get { return chart; } }
        protected override DefaultBoolean CrosshairEnabled { get { return DefaultBoolean.False; } }
        protected override DefaultBoolean ToolTipEnabled { get { return DefaultBoolean.True; } }

        public SideBySideRangeBarDemo() {
            InitializeComponent();
        }

        protected override void InitControls() {
            base.InitControls();
            ShowLabels = false;
            ChartControl.Series[0].DataSource = SourceOfEnergy.GetEuropeBrentPrices();
            ChartControl.Series[1].DataSource = SourceOfEnergy.GetOkWtiPrices();
        }

    }
}
