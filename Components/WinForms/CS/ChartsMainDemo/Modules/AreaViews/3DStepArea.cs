using DevExpress.XtraCharts.Demos.PointLineViews;

namespace DevExpress.XtraCharts.Demos.AreaViews {
    public partial class StepArea3dDemo : StepLine3dDemo {
        ChartControl chart;

        public override ChartControl ChartControl { get { return chart; } }

        public StepArea3dDemo() {
            InitializeComponent();
        }
        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            StepArea3DSeriesView view = Series.View as StepArea3DSeriesView;
            if (view != null)
                this.checkEditInverted.Checked = view.InvertedStep;
        }
    }
}
