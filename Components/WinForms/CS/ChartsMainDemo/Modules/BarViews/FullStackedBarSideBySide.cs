using System;

namespace DevExpress.XtraCharts.Demos.BarViews {
    public partial class FullStackedBarSideBySideDemo : ChartDemoBase2D {

        public override ChartControl ChartControl { get { return this.chart; } }

        public FullStackedBarSideBySideDemo() {
            InitializeComponent();
            radioGroup.SelectedIndex = 0;
            checkValueAsPercent.Checked = true;
        }

        void radioGroup_SelectedIndexChanged(object sender, EventArgs e) {
            ChartControl.RefreshData();
        }
        void checkValueAsPercent_CheckedChanged(object sender, EventArgs e) {
            foreach (Series series in this.chart.Series) {
                FullStackedBarSeriesView view = series.View as FullStackedBarSeriesView;
                if (view != null)
                    series.Label.TextPattern = this.checkValueAsPercent.Checked ? "{VP:P0}" : "{V:0,,.00}";
            }
        }
        void chart_BoundDataChanged(object sender, EventArgs e) {
            foreach (Series series in ChartControl.Series) {
                ISupportStackedGroup view = series.View as ISupportStackedGroup;
                GenderAgeInfo genderAge = (GenderAgeInfo)series.Tag;
                if (view != null)
                    view.StackedGroup = radioGroup.SelectedIndex == 0 ? genderAge.Gender : genderAge.Age;
            }
        }
        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
            ChartControl.DataSource = AgeStructure.GetDataByAgeAndGender();
        }
        public override void UpdateControls() {
            base.UpdateControls();
            this.checkValueAsPercent.Enabled = ShowLabels;
        }

    }
}
