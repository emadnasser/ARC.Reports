using System;
using System.Collections.Generic;
using System.Globalization;

namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    public partial class MovingAverageDemo : ChartDemoBase2D {
        ChartControl chart;

        List<MovingAverage> MovingAverageIndicators {
            get {
                if (Series == null)
                    return null;
                XYDiagram2DSeriesViewBase view = Series.View as XYDiagram2DSeriesViewBase;
                if (view == null)
                    return null;
                List<MovingAverage> movingAverageIndicators = new List<MovingAverage>();
                foreach (Indicator indicator in view.Indicators) {
                    MovingAverage movingAverage = indicator as MovingAverage;
                    if (movingAverage != null)
                        movingAverageIndicators.Add(movingAverage);
                }
                if (movingAverageIndicators != null)
                    return movingAverageIndicators;
                return null;
            }
        }

        public override ChartControl ChartControl { get { return this.chart; } }
        Series Series { get { return ChartControl.Series.Count > 0 ? ChartControl.Series[0] : null; } }

		public MovingAverageDemo() {
			InitializeComponent();
		}

        void SetVisibleIndicator() {
            if(MovingAverageIndicators == null)
                return;
            switch ((string)cbType.SelectedItem) {
                case "Simple":
                    foreach (MovingAverage indicator in MovingAverageIndicators)
                        indicator.Visible = indicator is SimpleMovingAverage;
                    break;
                case "Exponential":
                    foreach (MovingAverage indicator in MovingAverageIndicators)
                        indicator.Visible = indicator is ExponentialMovingAverage;
                    break;
                case "Weighted":
                    foreach (MovingAverage indicator in MovingAverageIndicators)
                        indicator.Visible = indicator is WeightedMovingAverage;
                    break;
                case "Triangular":
                    foreach (MovingAverage indicator in MovingAverageIndicators)
                        indicator.Visible = indicator is TriangularMovingAverage;
                    break;
                case "Triple Exponential (TEMA)":
                    foreach (MovingAverage indicator in MovingAverageIndicators)
                        indicator.Visible = indicator is TripleExponentialMovingAverageTema;
                    break;
                default:
                    foreach (MovingAverage indicator in MovingAverageIndicators)
                        indicator.Visible = indicator is SimpleMovingAverage;
                    break;
            }
        }
        void cbType_SelectedIndexChanged(object sender, EventArgs e) {
            SetVisibleIndicator();
        }
        void spnPointsCount_EditValueChanged(object sender, EventArgs e) {
            if(MovingAverageIndicators == null)
                return;
            foreach (MovingAverage indicator in MovingAverageIndicators)
                indicator.PointsCount = Convert.ToInt32(spnPointsCount.EditValue);
        }
        void cbKind_SelectedIndexChanged(object sender, EventArgs e) {
            if(MovingAverageIndicators == null)
                return;
            foreach (MovingAverage indicator in MovingAverageIndicators)
                indicator.Kind = (MovingAverageKind)cbKind.SelectedIndex;
            UpdateControls();
        }
        void spnEnvelopPercent_EditValueChanged(object sender, EventArgs e) {
            if(MovingAverageIndicators == null)
                return;
            foreach (MovingAverage indicator in MovingAverageIndicators)
                indicator.EnvelopePercent = Convert.ToDouble(spnEnvelopPercent.EditValue);
        }
        void chart_BoundDataChanged(object sender, EventArgs e) {
            if (Series != null && Series.Points.Count > 0) {
                spnPointsCount.Properties.MaxValue = Series.Points.Count;
                if (MovingAverageIndicators.Count > 0)
                    if (MovingAverageIndicators[0] != null) {
                        cbKind.SelectedIndex = (int)MovingAverageIndicators[0].Kind;
                        spnPointsCount.EditValue = MovingAverageIndicators[0].PointsCount;
                        spnEnvelopPercent.EditValue = MovingAverageIndicators[0].EnvelopePercent;
                    }
            }
        }

        protected override void InitControls() {
            base.InitControls();
            ShowLabels = false;
            Series.DataSource = MarketPrices.GetGoogleStockPrices();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            SetVisibleIndicator();
            bool enableEnvelopPercent = cbKind.SelectedItem.ToString() != "Moving Average";
            lblEnvelopPercent.Enabled = enableEnvelopPercent;
            spnEnvelopPercent.Enabled = enableEnvelopPercent;
        }

        private void lblKind_Click(object sender, EventArgs e) {

        }
    }
}
