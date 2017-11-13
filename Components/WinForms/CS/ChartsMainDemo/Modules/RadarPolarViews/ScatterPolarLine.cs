using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
    public partial class ScatterPolarLineDemo : RadarPolarDemoBase {
        ChartControl chart;

        Series PolarSeries { get { return this.seriesSelected; } }
        ScatterPolarLineSeriesView PolarSeriesView { get { return PolarSeries != null ? PolarSeries.View as ScatterPolarLineSeriesView : null; } }
        
        protected override bool SeriesSelection { get { return false; } }
        protected override bool ShowMarkers {
            get { return PolarSeriesView != null ? PolarSeriesView.MarkerVisibility != DefaultBoolean.False : base.ShowMarkers; }
            set {
                if (PolarSeriesView != null)
                    PolarSeriesView.MarkerVisibility = value ? DefaultBoolean.True : DefaultBoolean.False;
            }
        }

        public override ChartControl ChartControl { get { return this.chart; } }

        public ScatterPolarLineDemo() {
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
            PolarSeries.Points.Clear();
            DegreeScatterFunctionCalculator functionCalculator = new DegreeScatterFunctionCalculator();
            SeriesPoint[] points = functionCalculator.GenerateScatterFunctionPoints(comboBoxEditFunctionType.SelectedIndex);
            PolarSeries.Points.AddRange(points);
            ChartControl.Animate();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            SetSeriesSelected();
            checkEditShowMarkers.Enabled = true;
            if (PolarSeriesView != null)
                checkEditShowMarkers.Checked = PolarSeriesView.MarkerVisibility != DefaultBoolean.False;
            EnableMarkerControls(checkEditShowMarkers.Checked);
        }
    }
}
