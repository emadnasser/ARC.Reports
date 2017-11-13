using System;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
	public partial class FullStackedLineDemo : LineDemo {

        public override ChartControl ChartControl { get { return this.chart; } }

        public FullStackedLineDemo() {
            InitializeComponent();
        }
        
        void chart_BoundDataChanged(object sender, EventArgs e) {
            if (chart.Series.Count > 0)
                chart.SetObjectSelection(this.chart.Series[0]);
            chart.Animate();
        }
        void checkValueAsPercent_CheckedChanged(object sender, EventArgs e) {
            if (seriesSelected != null) {
                seriesSelected.Label.TextPattern = this.checkValueAsPercent.Checked ? "{VP:P0}" : "${V}M";
            }
        }

        protected override void InitControls() {
            base.InitControls();
            checkValueAsPercent.Checked = true;
            ChartControl.DataSource = DevAV.GetBranchesSales();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            checkValueAsPercent.Enabled = false;
            if (seriesSelected != null) {
                checkValueAsPercent.Enabled = ShowLabels;
                checkValueAsPercent.Checked = seriesSelected.Label.TextPattern != null && seriesSelected.Label.TextPattern.Contains("VP");
            }
        }
    }
}
