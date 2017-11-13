using System;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.BarViews {
    public partial class FullStackedBarDemo : ChartDemoBase2D {
        ChartControl chart;
        CheckEdit checkEditValueAsPercent;

        public override ChartControl ChartControl { get { return this.chart; } }

        public FullStackedBarDemo() {
            InitializeComponent();
        }

        void checkEditValueAsPercent_CheckedChanged(object sender, EventArgs e) {
            ChartControl.SeriesTemplate.Label.TextPattern = this.checkEditValueAsPercent.Checked ? "{VP:P0}" : "{V:F1}K";
        }
        void cbTextOrientation_SelectedIndexChanged(object sender, EventArgs e) {
            ChartControl.SeriesTemplate.Label.TextOrientation = (TextOrientation)cbTextOrientation.SelectedIndex;
        }
        void cbLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            StackedBarSeriesLabel label = ChartControl.SeriesTemplate.Label as StackedBarSeriesLabel;
            if (label != null) {
                switch ((string)cbLabelPosition.SelectedItem) {
                    case "Top Inside":
                        label.Position = BarSeriesLabelPosition.TopInside;
                        break;
                    case "Center":
                        label.Position = BarSeriesLabelPosition.Center;
                        break;
                    case "Bottom Inside":
                        label.Position = BarSeriesLabelPosition.BottomInside;
                        break;
                    default:
                        label.Position = BarSeriesLabelPosition.Center;
                        break;
                }
                UpdateControls();
            }
        }
        void spnLabelIndent_EditValueChanged(object sender, EventArgs e) {
            StackedBarSeriesLabel label = ChartControl.SeriesTemplate.Label as StackedBarSeriesLabel;
            if (label != null)
                label.Indent = Convert.ToInt32(spnLabelIndent.EditValue);
        }

        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
            ChartControl.DataSource = DevAV.GetSalesMixByRegion();
            this.checkEditValueAsPercent.Checked = true;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            labelPosition.Enabled = ShowLabels;
            cbLabelPosition.Enabled = ShowLabels;
            bool indentEnabled = ShowLabels && ((string)cbLabelPosition.SelectedItem == "Top Inside" ||
                (string)cbLabelPosition.SelectedItem == "Bottom Inside");
            labelIndent.Enabled = indentEnabled;
            spnLabelIndent.Enabled = indentEnabled;
            labelTextOrientation.Enabled = ShowLabels;
            cbTextOrientation.Enabled = ShowLabels;
            this.checkEditValueAsPercent.Enabled = ShowLabels;
        }
    }
}
