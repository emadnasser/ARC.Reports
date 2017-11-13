using System;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.AreaViews {
	public partial class FullStackedArea3dDemo : Area3dDemoBase {
		ChartControl chart;
		CheckEdit checkValueAsPercent;

		public override ChartControl ChartControl { get { return this.chart; } }

        public FullStackedArea3dDemo() {
			InitializeComponent();
		}

		void checkEditValueAsPercent_CheckedChanged(object sender, EventArgs e) {
            ChartControl.SeriesTemplate.Label.TextPattern = this.checkValueAsPercent.Checked ? "{VP:P0}" : "${V}M";
        }

        protected override void InitControls() {
            base.InitControls();
            this.checkValueAsPercent.Checked = true;
            ChartControl.DataSource = DevAV.GetBranchesSales();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            this.checkValueAsPercent.Enabled = ShowLabels;
        }        
	}
}
