using System;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
    public partial class FullStackedLine3dDemo : Line3dDemo {
        ChartControl chart;

        public override ChartControl ChartControl { get { return chart; } }

        public FullStackedLine3dDemo() {
            InitializeComponent();
        }

        void checkEditValueAsPercent_CheckedChanged(object sender, EventArgs e) {
            ChartControl.SeriesTemplate.Label.TextPattern = this.checkValueAsPercent.Checked ? "{VP:P0}" : "${V}M";
        }

        protected override void InitControls() {
            base.InitControls();
            checkValueAsPercent.Checked = true;
            ShowLabels = false;
        }
        protected override void InitDataSource() {
            ChartControl.DataSource = DevAV.GetBranchesSales();
        }
        public override void UpdateControls() {
            base.UpdateControls();
            this.checkValueAsPercent.Enabled = ShowLabels;
        }        
    }
}
