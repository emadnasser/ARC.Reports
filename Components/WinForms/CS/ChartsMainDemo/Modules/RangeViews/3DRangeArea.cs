using System;
using DevExpress.XtraCharts.Demos.PointLineViews;

namespace DevExpress.XtraCharts.Demos.RangeViews {
    public partial class RangeArea3dDemo : Line3dDemo {
        ChartControl chart;

        public override ChartControl ChartControl { get { return chart; } }

        public RangeArea3dDemo() {
            InitializeComponent();
        }

        void comboBoxLabelKind_SelectedIndexChanged(object sender, EventArgs e) {
            if (chart.Series.Count == 0)
                return;
            RangeArea3DSeriesLabel label = chart.Series[0].Label as RangeArea3DSeriesLabel;
            if (label == null)
                return;
            switch ((string)comboBoxLabelKind.SelectedItem) {
                case "One Label":
                    label.Kind = RangeAreaLabelKind.OneLabel;
                    break;
                case "Two Labels":
                    label.Kind = RangeAreaLabelKind.TwoLabels;
                    break;
                case "Min Value Label":
                    label.Kind = RangeAreaLabelKind.MinValueLabel;
                    break;
                case "Max Value Label":
                    label.Kind = RangeAreaLabelKind.MaxValueLabel;
                    break;
                default:
                    label.Kind = RangeAreaLabelKind.TwoLabels;
                    break;
            }
            if (label.Kind == RangeAreaLabelKind.OneLabel)
                label.TextPattern ="{VD}";
            else
                label.TextPattern = "{V:G4}";
        }

        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
            UpdateControls();
        }
        protected override void InitDataSource() {
            ChartControl.Series[0].DataSource = SourceOfEnergy.GetOkWtiPrices();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            comboBoxLabelKind.Enabled = ShowLabels;
            labelLabelKind.Enabled = ShowLabels;
        } 
    }
}
