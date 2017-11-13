using System;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
	public partial class StackedLineDemo : LineDemo {
        public override ChartControl ChartControl { get { return this.chart; } }

        public StackedLineDemo() {
			InitializeComponent();
		}

        void chart_BoundDataChanged(object sender, EventArgs e) {
            if (chart.Series.Count > 0)
                chart.SetObjectSelection(this.chart.Series[0]);
            chart.Animate();
        }

        protected override void InitControls() {
            base.InitControls();
            ChartControl.DataSource = DevAV.GetSalesByLast10Years();
        }
    }
}
