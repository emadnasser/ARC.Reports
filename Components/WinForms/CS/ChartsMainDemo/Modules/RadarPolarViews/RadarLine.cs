using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
	public partial class RadarLineDemo : RadarDemoBase {
		ChartControl chart;

		protected override bool ShowMarkers {
			get {
                return this.seriesSelected != null && seriesSelected.View is RadarLineSeriesView ?
                    ((RadarLineSeriesView)seriesSelected.View).MarkerVisibility != DefaultBoolean.False :
                    base.ShowMarkers;
			}
			set {
                if (this.seriesSelected == null && !(seriesSelected.View is RadarLineSeriesView))
					return;
                ((RadarLineSeriesView)this.seriesSelected.View).MarkerVisibility = value ? DefaultBoolean.True : DefaultBoolean.False;
            }
		}

		public override ChartControl ChartControl { get { return this.chart; } }

		public RadarLineDemo() {
			InitializeComponent();
		}

        void checkEditShowMarkers_CheckedChanged(object sender, EventArgs e) {
            if (seriesSelected == null) 
                return;
            RadarLineSeriesView view = seriesSelected.View as RadarLineSeriesView;
            if (view != null)
                view.MarkerVisibility = checkEditShowMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            UpdateControls();
        }
        void chart_VisibleChanged(object sender, System.EventArgs e) {
			if(this.chart.Series.Count > 0)
				chart.SetObjectSelection(this.chart.Series[0]);
		}

        public override void UpdateControls() {
            base.UpdateControls();
            if (seriesSelected == null) {
                checkEditShowMarkers.Checked = false;
                checkEditShowMarkers.Enabled = false;
            }
            else {
                RadarLineSeriesView view = seriesSelected.View as RadarLineSeriesView;
                if (view != null) {
                    checkEditShowMarkers.Enabled = true;
                    checkEditShowMarkers.Checked = view.MarkerVisibility != DefaultBoolean.False;
                    EnableMarkerControls(checkEditShowMarkers.Checked);
                }
            }
        }       
	}
}
