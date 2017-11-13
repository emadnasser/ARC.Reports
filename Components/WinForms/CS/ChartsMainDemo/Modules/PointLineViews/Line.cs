using System;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
	public partial class LineDemo : ChartDemoLineBase {
		ChartControl chart;

		protected override bool SeriesSelection { get { return true; } }
        
        public override ChartControl ChartControl { get { return this.chart; } }

		public LineDemo() {
			InitializeComponent();
		}

        void chart_VisibleChanged(object sender, System.EventArgs e) {
            if (chart.Series.Count > 0)
                chart.SetObjectSelection(this.chart.Series[0]);
        }
        bool IsLabelVisisble {
            get {
                if (seriesSelected != null && seriesSelected.Label != null && seriesSelected.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True)
                    return true;
                else
                    return false;
            }
        }

        protected override void checkEditShowLabels_CheckedChanged(object sender, EventArgs e) {
            if (seriesSelected != null && seriesSelected.Label != null)
                seriesSelected.LabelsVisibility = checkEditShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
            UpdateControls();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            LineSeriesView view = seriesSelected != null ? seriesSelected.View as LineSeriesView : null;
            if (view == null) {
                checkEditShowLabels.Enabled = false;
                checkEditShowLabels.Checked = false;
                return;
            }
            checkEditShowLabels.Enabled = true;
            checkEditShowLabels.Checked = IsLabelVisisble;
        }
	}
}
