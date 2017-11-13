using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
	public partial class PolarLineDemo : PolarDemoBase {
		ChartControl chart;

		protected override bool ShowMarkers {
			get {
                return this.seriesSelected != null && seriesSelected.View is RadarLineSeriesView ?
                    ((RadarLineSeriesView)this.seriesSelected.View).MarkerVisibility != DefaultBoolean.False :
                    base.ShowMarkers;
			}
			set {
                if (this.seriesSelected == null && !(seriesSelected.View is RadarLineSeriesView))
					return;
                ((RadarLineSeriesView)this.seriesSelected.View).MarkerVisibility = value ? DefaultBoolean.True : DefaultBoolean.False;
            }
		}

		public override ChartControl ChartControl { get { return this.chart; } }

		public PolarLineDemo() {
			InitializeComponent();
            foreach (Series series in chart.Series)
                series.ToolTipPointPattern = "{A}: {V:F2}";
        }

        void checkEditShowMarkers_CheckedChanged(object sender, EventArgs e) {
            if (seriesSelected == null)
                return;
            PolarLineSeriesView view = seriesSelected.View as PolarLineSeriesView;
            if (view != null)
                view.MarkerVisibility = checkEditShowMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            UpdateControls();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (seriesSelected == null) {
                checkEditShowMarkers.Checked = false;
                checkEditShowMarkers.Enabled = false;
            }
            else {
                PolarLineSeriesView view = seriesSelected.View as PolarLineSeriesView;
                if (view != null) {
                    checkEditShowMarkers.Enabled = true;
                    checkEditShowMarkers.Checked = view.MarkerVisibility != DefaultBoolean.False;
                    EnableMarkerControls(checkEditShowMarkers.Checked);
                }
            }
        }
	}
}
