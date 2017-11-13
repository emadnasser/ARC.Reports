using System;

namespace DevExpress.XtraCharts.Demos.BarViews {
    public partial class StackedBarSideBySide3dDemo : ChartDemoBase3D {
        const string DefaultPerspective = "Default";

        public override ChartControl ChartControl { get { return chart; } }

        public StackedBarSideBySide3dDemo() {
            InitializeComponent();
            string[] perspectiveArray = new string[] { DefaultPerspective, "0", "30", "45", "60", "90", "120", "135", "150" };
            comboBoxEditPerspective.Properties.Items.AddRange(perspectiveArray);
            comboBoxEditPerspective.Text = DefaultPerspective;
            radioGroup.SelectedIndex = 0;
        }

        void GroupSeries(int seriesIndex, string group) {
            if (seriesIndex < chart.Series.Count) {
                ISupportStackedGroup view = chart.Series[seriesIndex].View as ISupportStackedGroup;
                if (view != null)
                    view.StackedGroup = group;
            }
        }
        void radioGroup_SelectedIndexChanged(object sender, EventArgs e) {
            ChartControl.RefreshData();
        }
        void comboBoxEditPerspective_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditPerspective.SelectedIndex == -1)
                return;
            string perspectiveText = comboBoxEditPerspective.Text;
            int perspectiveAngle = perspectiveText == DefaultPerspective ? 50 : Int32.Parse(perspectiveText);
            Diagram3D diagram = chart.Diagram as Diagram3D;
            if (diagram != null)
                diagram.PerspectiveAngle = perspectiveAngle;
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
            ShowLabels = chart.SeriesTemplate.ActualLabelsVisibility;
            ChartControl.DataSource = AgeStructure.GetDataByAgeAndGender();
        }
    }
}

