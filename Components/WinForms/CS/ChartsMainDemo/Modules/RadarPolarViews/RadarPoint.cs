using System;

namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
	public partial class RadarPointDemo : RadarDemoBase {
		ChartControl chart;

		public override ChartControl ChartControl { get { return this.chart; } }

		public RadarPointDemo() {
			InitializeComponent();
		}
		private void chart_VisibleChanged(object sender, EventArgs e) {
			if(this.chart.Series.Count > 0)
				chart.SetObjectSelection(this.chart.Series[0]);
		}        
	}
}
