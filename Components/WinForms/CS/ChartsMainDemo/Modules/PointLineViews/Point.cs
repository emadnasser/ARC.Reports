using System;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
	public partial class PointDemo : PointDemoBase {
		SimpleButton simpleButtonRandom;

		protected ChartControl chart;

        protected override bool SeriesSelection { get { return true; } }
        protected override DefaultBoolean CrosshairEnabled { get { return DefaultBoolean.False; } }

        public override ChartControl ChartControl { get { return this.chart; } }

		public PointDemo() {
			InitializeComponent();
		}

		void InitSeries() {            
            if (chart.Series.Count > 2 && chart.Series[0].View.GetType().Equals(typeof(PointSeriesView))) {
                Random random = new Random();
                this.chart.Series[0].Points.Clear();
                this.chart.Series[0].Points.AddRange(RandomPointCalculator.Calculate(random, 20, 1, 8, 5, 12));
                this.chart.Series[1].Points.Clear();
                this.chart.Series[1].Points.AddRange(RandomPointCalculator.Calculate(random, 20, 9, 16, 1, 8));
                this.chart.Series[2].Points.Clear();
                this.chart.Series[2].Points.AddRange(RandomPointCalculator.Calculate(random, 20, 6, 13, 14, 21));
                chart.SetObjectSelection(this.chart.Series[0]);
            }
		}
        void UpdateLabelAngleComboBox(PointSeriesLabel seriesLabel) {
            comboBoxEditLabelAngle.Enabled = ShowLabels && seriesLabel.Position == PointLabelPosition.Outside;
        }
		void simpleButtonRandom_Click(object sender, EventArgs e) {
			InitSeries();
            ChartControl.Animate();
		}
		void chart_VisibleChanged(object sender, EventArgs e) {
			InitSeries();
		}
        void cbeLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbeLabelPosition.SelectedIndex == -1 || chart.Series.Count == 0 || seriesSelected == null)
                return;
            PointSeriesLabel label = seriesSelected.Label as PointSeriesLabel;
            if (label != null) {
                label.Position = (PointLabelPosition)cbeLabelPosition.SelectedIndex;
                UpdateLabelAngleComboBox(label);
            }
        }
        protected override void InitControls() {
            base.InitControls();
            cbeLabelPosition.SelectedIndex = (int)((PointSeriesLabel)chart.Series[0].Label).Position;
        }
        public override void UpdateControls() {
            base.UpdateControls();
            if (seriesSelected == null) {
                cbeLabelPosition.SelectedIndex = -1;
                cbeLabelPosition.Enabled = false;
            }
            else {
                cbeLabelPosition.Enabled = lblLabelPosition.Enabled = ShowLabels;
                PointSeriesLabel label = seriesSelected.Label as PointSeriesLabel;
                if (label != null) {
                    cbeLabelPosition.SelectedIndex = (int)label.Position;
                    UpdateLabelAngleComboBox(label);
                }
            }
        }
	}
}

