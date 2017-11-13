using System;

namespace DevExpress.XtraCharts.Demos.AreaViews {
	public partial class StackedStepAreaDemo : ChartDemoBase2D {
        Series FirstSeries { get { return chart.Series.Count > 0 ? chart.Series[0] : null; } }
        public override ChartControl ChartControl { get { return chart; } }

        public StackedStepAreaDemo() {
			InitializeComponent();
		}

        void checkEditInverted_CheckedChanged(object sender, EventArgs e) {
            if (FirstSeries != null) {
                StackedStepAreaSeriesView view = FirstSeries.View as StackedStepAreaSeriesView;
                if (view != null)
                    view.InvertedStep = checkEditInverted.Checked;
            }
        }

        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (FirstSeries != null && FirstSeries.View is StackedStepAreaSeriesView) {
                checkEditInverted.Enabled = true;
                checkEditInverted.Checked = ((StackedStepAreaSeriesView)FirstSeries.View).InvertedStep;
            }
            else {
                checkEditInverted.Checked = false;
                checkEditInverted.Enabled = false;
            }
        }
	}
}
