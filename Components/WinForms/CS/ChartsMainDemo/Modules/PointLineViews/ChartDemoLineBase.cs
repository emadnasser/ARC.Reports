using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
    public partial class ChartDemoLineBase : PointDemoBase {
        public ChartDemoLineBase() {
			InitializeComponent();
		}

		void checkEditShowMarkers_CheckedChanged(object sender, System.EventArgs e) {
            foreach (Series series in ProcessedSeries) {
                if (series != null) {
                    LineSeriesView view = series.View as LineSeriesView;
                    if (view != null)
                        view.MarkerVisibility = checkEditShowMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
                }
            }
			UpdateControls();
		}

        public override void UpdateControls() {
            base.UpdateControls();
            LineSeriesView view = seriesSelected != null ? seriesSelected.View as LineSeriesView : null;
            if (view == null) {
                checkEditShowMarkers.Checked = false;
                checkEditShowMarkers.Enabled = false;
                return;
            }
            checkEditShowMarkers.Enabled = true;
            checkEditShowMarkers.Checked = view.MarkerVisibility == DevExpress.Utils.DefaultBoolean.True;
            EnableMarkerControls(checkEditShowMarkers.Checked);            
        }
    }
}
