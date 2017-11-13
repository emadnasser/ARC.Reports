using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
	public partial class PolarAreaDemo : PolarDemoBase {
		ChartControl chart;

		protected override bool ShowMarkers {
			get {
                return this.seriesSelected != null && seriesSelected.View is RadarAreaSeriesView ?
                    ((RadarAreaSeriesView)seriesSelected.View).MarkerVisibility != DefaultBoolean.False :
                    base.ShowMarkers;
			}
			set {
				if (seriesSelected == null)
					return;
                RadarAreaSeriesView view = seriesSelected.View as RadarAreaSeriesView;
                if (view != null)
                    view.MarkerVisibility = value ? DefaultBoolean.True : DefaultBoolean.False;
            }
		}
		
        public override ChartControl ChartControl { get { return this.chart; } }

		public PolarAreaDemo() {
			InitializeComponent();
		}

        void checkEditShowMarkers_CheckedChanged(object sender, EventArgs e) {
            if (seriesSelected != null) {
                PolarAreaSeriesView view = seriesSelected.View as PolarAreaSeriesView;
                if (view != null)
                    view.MarkerVisibility = checkEditShowMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            }
            UpdateControls();
        }

        protected override void InitControls() {
            base.InitControls();
            foreach (Series series in chart.Series)
                series.ToolTipPointPattern = "{A}: {V:F2}";

        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (seriesSelected == null) {
                checkEditShowMarkers.Checked = false;
                checkEditShowMarkers.Enabled = false;
            }
            else {
                PolarAreaSeriesView view = seriesSelected.View as PolarAreaSeriesView;
                if (view != null) {
                    checkEditShowMarkers.Enabled = true;
                    checkEditShowMarkers.Checked = view.MarkerVisibility != DefaultBoolean.False;
                    EnableMarkerControls(checkEditShowMarkers.Checked);
                }
            }
        }        
	}
}
