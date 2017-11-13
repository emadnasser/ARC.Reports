using System;

namespace DevExpress.XtraCharts.Demos.BarViews {
    public partial class StackedBarSideBySideDemo : ChartDemoBase2D {

        public override ChartControl ChartControl { get { return this.chart; } }

        public StackedBarSideBySideDemo() {
            InitializeComponent();
            radioGroup.SelectedIndex = 0;
        }

        void radioGroup_SelectedIndexChanged(object sender, EventArgs e) {
            ChartControl.RefreshData();
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
    }
}
