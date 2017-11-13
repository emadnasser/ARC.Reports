using System;

namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    public partial class FibonacciIndicatorsDemo : ChartDemoBase2D {
        FibonacciIndicator FibonacciIndicator {
            get {
                if (chart.Series.Count == 0)
                    return null;
                XYDiagram2DSeriesViewBase view = chart.Series[0].View as XYDiagram2DSeriesViewBase;
                if (view == null)
                    return null;
                foreach (Indicator indicator in view.Indicators) {
                    FibonacciIndicator fibIndicator = indicator as FibonacciIndicator;
                    if (fibIndicator != null)
                        return fibIndicator;
                }
                return null;
            }
        }
        
        public override ChartControl ChartControl { get { return chart; } }
        
        public FibonacciIndicatorsDemo() {
            InitializeComponent();
            UpdateControls();
        }

        void cbeKind_SelectedIndexChanged(object sender, EventArgs e) {
            FibonacciIndicator fibIndicator = FibonacciIndicator;
            if (fibIndicator != null) {
                fibIndicator.Kind = (FibonacciIndicatorKind)cbeKind.SelectedIndex;
                UpdateControls();
            }
        }
        void cheLevel0_CheckedChanged(object sender, EventArgs e) {
            FibonacciIndicator fibIndicator = FibonacciIndicator;
            if (fibIndicator != null)
                fibIndicator.ShowLevel0 = cheLevel0.Checked;
        }
        void cheLevel100_CheckedChanged(object sender, EventArgs e) {
            FibonacciIndicator fibIndicator = FibonacciIndicator;
            if (fibIndicator != null)
                fibIndicator.ShowLevel100 = cheLevel100.Checked;
        }
        void cheLevel23_6_CheckedChanged(object sender, EventArgs e) {
            FibonacciIndicator fibIndicator = FibonacciIndicator;
            if (fibIndicator != null)
                fibIndicator.ShowLevel23_6 = cheLevel23_6.Checked;
        }
        void cheLevel76_4_CheckedChanged(object sender, EventArgs e) {
            FibonacciIndicator fibIndicator = FibonacciIndicator;
            if (fibIndicator != null)
                fibIndicator.ShowLevel76_4 = cheLevel76_4.Checked;
        }
        void cheAdditionalLevels_CheckedChanged(object sender, EventArgs e) {
            FibonacciIndicator fibIndicator = FibonacciIndicator;
            if (fibIndicator != null)
                fibIndicator.ShowAdditionalLevels = cheAdditionalLevels.Checked;
        }
        protected override void InitControls() {
            base.InitControls();
            ChartControl.Series[0].DataSource = MarketPrices.GetAppleStockPrices();
        }
        public override void UpdateControls() {
            FibonacciIndicator fibIndicator = FibonacciIndicator;
            if (fibIndicator != null) {
                cbeKind.SelectedIndex = (int)fibIndicator.Kind;
                switch (fibIndicator.Kind) {
                    case FibonacciIndicatorKind.FibonacciArcs:
                        cheLevel0.Checked = false;
                        cheLevel0.Enabled = false;
                        cheLevel100.Enabled = true;
                        cheLevel100.Checked = fibIndicator.ShowLevel100;
                        cheAdditionalLevels.Checked = false;
                        cheAdditionalLevels.Enabled = false;
                        break;
                    case FibonacciIndicatorKind.FibonacciFans:
                        cheLevel0.Checked = fibIndicator.ShowLevel0;
                        cheLevel0.Enabled = true;
                        cheLevel100.Checked = false;
                        cheLevel100.Enabled = false;
                        cheAdditionalLevels.Checked = false;
                        cheAdditionalLevels.Enabled = false;
                        break;
                    case FibonacciIndicatorKind.FibonacciRetracement:
                        cheLevel0.Checked = fibIndicator.ShowLevel0;
                        cheLevel0.Checked = true;
                        cheLevel0.Enabled = false;
                        cheLevel100.Checked = true;
                        cheLevel100.Enabled = false;
                        cheAdditionalLevels.Enabled = true;
                        cheAdditionalLevels.Checked = fibIndicator.ShowAdditionalLevels;
                        break;
                }
                cheLevel23_6.Checked = fibIndicator.ShowLevel23_6;
                cheLevel76_4.Checked = fibIndicator.ShowLevel76_4;
            }
        }
    }
}
