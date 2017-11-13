using System;

namespace DevExpress.XtraCharts.Demos.PieDoughnutViews {
    public partial class NestedDoughnutDemo : ChartDemoBase2D {
        ChartControl chart;       
        SeriesBase SeriesTemplate { get { return ChartControl.SeriesTemplate; } }
        NestedDoughnutSeriesView SeriesTemplateView { get { return ((NestedDoughnutSeriesView)SeriesTemplate.View); } }
        public override ChartControl ChartControl { get { return chart; } }
        
        public NestedDoughnutDemo() {
            InitializeComponent();
            ChartControl.DataSource = AgeStructure.GetPopulationAgeStructure();
        }

        void spinHoleRadius_EditValueChanged(object sender, EventArgs e) {
            SeriesTemplateView.HoleRadiusPercent = Convert.ToInt32(spinHoleRadius.EditValue);
        }
        void comboInnerIndent_EditValueChanged(object sender, EventArgs e) {
            SeriesTemplateView.InnerIndent = Convert.ToDouble(cbInnerIndent.EditValue);
        }
        void chart_BoundDataChanged(object sender, EventArgs e) {
            ChartControl chart = (ChartControl)sender;
            if (chart.Series.Count > 0) {
                chart.Series[0].ShowInLegend = true;
                foreach (Series series in chart.Series) {
                    NestedDoughnutSeriesView nestedView = series.View as NestedDoughnutSeriesView;
                    AgePopulation population = series.Points[0].Tag as AgePopulation;
                    if (population != null && nestedView != null) {
                        string name = population.Name;
                        nestedView.Group = name;
                        nestedView.Titles.Clear();
                        nestedView.Titles.Add(new SeriesTitle() { Text = name });
                    }
                }
            }
            chart.Animate();
        }
        void radioGroup_SelectedIndexChanged(object sender, EventArgs e) {
            chart.BeginInit();
            try {
                if (radioGroup.SelectedIndex == 0)
                    GroupBySex();
                else
                    GroupByAge();
            }
            finally {
                chart.EndInit();
            }
        }
        void GroupByAge() {
            ChartControl.SeriesDataMember = "CountryAgeKey";
            string argumentDataMember = "Gender";
            ChartControl.Titles[0].Text = "Population: " + argumentDataMember + " Structure";
            ChartControl.SeriesTemplate.ToolTipHintDataMember = "Age";
            ChartControl.SeriesTemplate.ArgumentDataMember = argumentDataMember;
        }
        void GroupBySex() {
            ChartControl.SeriesDataMember = "CountryGenderKey";
            string argumentDataMember = "Age";
            ChartControl.Titles[0].Text = "Population: " + argumentDataMember + " Structure";
            ChartControl.SeriesTemplate.ToolTipHintDataMember = "Gender";
            ChartControl.SeriesTemplate.ArgumentDataMember = argumentDataMember;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            spinHoleRadius.EditValue = SeriesTemplateView.HoleRadiusPercent;
            cbInnerIndent.EditValue = SeriesTemplateView.InnerIndent;
        }
    }
}
