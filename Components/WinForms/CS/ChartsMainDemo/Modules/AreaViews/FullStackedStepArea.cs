using System;

namespace DevExpress.XtraCharts.Demos.AreaViews {
	public partial class FullStackedStepAreaDemo : ChartDemoBase2D {
        Series FirstSeries { get { return chart.Series.Count > 0 ? chart.Series[0] : null; } }
        public override ChartControl ChartControl { get { return chart; } }

        public FullStackedStepAreaDemo() {
			InitializeComponent();
            SetSeriesLabelTextPattern(this.checkEditInverted.Checked);
		}
        void checkValueAsPercent_CheckedChanged(object sender, EventArgs e) {
            SetSeriesLabelTextPattern(this.checkValueAsPercent.Checked);
        }
        void checkEditInverted_CheckedChanged(object sender, EventArgs e) {
            if (FirstSeries != null) {
                FullStackedStepAreaSeriesView view = FirstSeries.View as FullStackedStepAreaSeriesView;
                if (view != null)
                    view.InvertedStep = this.checkEditInverted.Checked;
            }
        }
        void SetSeriesLabelTextPattern(bool isInPercent) {
            foreach (Series series in this.chart.Series) {
                FullStackedStepAreaSeriesView view = series.View as FullStackedStepAreaSeriesView;
                if (view != null)
                    series.Label.TextPattern = isInPercent ? "{VP:P0}" : "{V:F1}";
            }
        }
        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (FirstSeries != null && FirstSeries.View is FullStackedStepAreaSeriesView) {
                checkEditInverted.Enabled = true;
                checkEditInverted.Checked = ((FullStackedStepAreaSeriesView)FirstSeries.View).InvertedStep;
            }
            else {
                checkEditInverted.Checked = false;
                checkEditInverted.Enabled = false;
            }
            checkValueAsPercent.Enabled = ShowLabels;
        }
	}
}
