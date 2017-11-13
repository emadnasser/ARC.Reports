using System;

namespace DevExpress.XtraCharts.Demos.BarViews {
	public partial class BarDemo : ChartDemoBase2D {
        ChartControl chart;

		public override ChartControl ChartControl { get { return this.chart; } }

		public BarDemo() {
			InitializeComponent();
		}

        void cbTextOrientation_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (Series series in chart.Series) {
                if (series.Label != null)
                    series.Label.TextOrientation = (TextOrientation)cbTextOrientation.SelectedIndex;
            }
        }
        void cbLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (Series series in chart.Series) {
                SideBySideBarSeriesLabel label = series.Label as SideBySideBarSeriesLabel;
                if (label != null) {
                    switch ((string)cbLabelPosition.SelectedItem) {
                        case "Auto":
                            label.Position = BarSeriesLabelPosition.Auto;
                            break;
                        case "Top":
                            label.Position = BarSeriesLabelPosition.Top;
                            break;
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
                            label.Position = BarSeriesLabelPosition.Auto;
                            break;
                    }
                    UpdateControls();
                }
            }
        }
        void spnLabelIndent_EditValueChanged(object sender, EventArgs e) {
            foreach (Series series in chart.Series) {
                SideBySideBarSeriesLabel label = series.Label as SideBySideBarSeriesLabel;
                if (label != null)
                    label.Indent = Convert.ToInt32(spnLabelIndent.EditValue);
            }
        }        

        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
            ChartControl.DataSource = DevAV.GetSales();
            ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries;
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
        }
	}
}
