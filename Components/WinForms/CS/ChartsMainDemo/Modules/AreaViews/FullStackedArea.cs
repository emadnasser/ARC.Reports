using System;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.AreaViews {
	public partial class FullStackedAreaDemo : ChartDemoBase2D {
		ChartControl chart;
		CheckEdit checkValueAsPercent;

		public override ChartControl ChartControl { get { return this.chart; } }
		
        public FullStackedAreaDemo() {
			InitializeComponent();
		}

        void checkEditValueAsPercent_CheckedChanged(object sender, EventArgs e) {
            ChartControl.SeriesTemplate.Label.TextPattern = this.checkValueAsPercent.Checked ? "{VP:P0}" : "${V}M";
        }

		protected override void InitControls() {
			base.InitControls();
            this.checkValueAsPercent.Checked = true;
            ShowLabels = true;
            ChartControl.DataSource = DevAV.GetBranchesSales();
        }

		public override void UpdateControls() {
			base.UpdateControls();
			this.checkValueAsPercent.Enabled = ShowLabels;
		}
	}
}
