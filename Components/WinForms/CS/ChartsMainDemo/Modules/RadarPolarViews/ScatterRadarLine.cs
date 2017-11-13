using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
    public partial class ScatterRadarLineDemo : RadarPolarDemoBase {
		ChartControl chart;

        Series RadarSeries { get { return this.seriesSelected; } }
        ScatterRadarLineSeriesView RadarSeriesView { get { return RadarSeries != null ? RadarSeries.View as ScatterRadarLineSeriesView : null; } }
        
        protected override bool SeriesSelection { get { return false; } }
        protected override bool ShowMarkers {
            get { return RadarSeriesView != null ? RadarSeriesView.MarkerVisibility != DefaultBoolean.False : base.ShowMarkers;  }
            set {
                if (RadarSeriesView != null)
                    RadarSeriesView.MarkerVisibility = value ? DefaultBoolean.True : DefaultBoolean.False;
            }
        }
		
        public override ChartControl ChartControl { get { return this.chart; } }

        public ScatterRadarLineDemo() {
			InitializeComponent();
            SetSeriesSelected();
            this.comboBoxEditFunctionType.SelectedIndex = 0;
		}
        void SetSeriesSelected() {
            this.seriesSelected = chart.Series.Count > 0 ? chart.Series[0] : null;
        }
        void checkEditShowMarkers_CheckedChanged(object sender, EventArgs e) {
            ShowMarkers = checkEditShowMarkers.Checked;
            UpdateControls();
        }
        void comboBoxEditFunctionType_SelectedIndexChanged(object sender, EventArgs e) {
            RadarSeries.Points.Clear();
            RadianScatterFunctionCalculator functionCalculator = new RadianScatterFunctionCalculator();
            SeriesPoint[] points = functionCalculator.GenerateScatterFunctionPoints(comboBoxEditFunctionType.SelectedIndex);
            RadarSeries.Points.AddRange(points);
            ChartControl.Animate();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            SetSeriesSelected();
            checkEditShowMarkers.Enabled = true;
            if (RadarSeriesView != null)
                checkEditShowMarkers.Checked = RadarSeriesView.MarkerVisibility != DefaultBoolean.False;
            EnableMarkerControls(checkEditShowMarkers.Checked);
        }
	}
}
