using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
	public partial class RadarAreaDemo : RadarDemoBase {
		ChartControl chart;

		protected override bool ShowMarkers {
			get {
                return seriesSelected != null && seriesSelected.View is RadarAreaSeriesView ?
                    ((RadarAreaSeriesView)seriesSelected.View).MarkerVisibility != DefaultBoolean.False :
                    base.ShowMarkers;
			}
			set {
                if (seriesSelected == null && !(seriesSelected.View is RadarAreaSeriesView))
					return;
                ((RadarAreaSeriesView)seriesSelected.View).MarkerVisibility = value ? DefaultBoolean.True : DefaultBoolean.False;
            }
		}

		public override ChartControl ChartControl { get { return this.chart; } }

		public RadarAreaDemo() {
			InitializeComponent();
		}

		void chart_VisibleChanged(object sender, EventArgs e) {
			if(this.chart.Series.Count > 0)
				chart.SetObjectSelection(this.chart.Series[0]);
		}
        void checkEditShowMarkers_CheckedChanged(object sender, EventArgs e) {
            if (seriesSelected == null)
                return;
            RadarAreaSeriesView view = seriesSelected.View as RadarAreaSeriesView;
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
                RadarAreaSeriesView view = seriesSelected.View as RadarAreaSeriesView;
                if (view != null) {
                    checkEditShowMarkers.Enabled = true;
                    checkEditShowMarkers.Checked = view.MarkerVisibility != DefaultBoolean.False;
                    EnableMarkerControls(checkEditShowMarkers.Checked);
                }
            }
        }        
	}
}
