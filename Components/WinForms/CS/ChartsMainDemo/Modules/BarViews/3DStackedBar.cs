using System;

namespace DevExpress.XtraCharts.Demos.BarViews {
	public partial class StackedBar3dDemo : ChartDemoBase3D {
		const string DefaultPerspective = "Default";
        const string DefaultBar3DModel = "Box";
        
		ChartControl chart;

		public override ChartControl ChartControl { get { return chart; } }

		public StackedBar3dDemo() {
			InitializeComponent();
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
        void comboBoxBar3DModel_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxBar3DModel.SelectedIndex == -1)
                return;
            int bar3DModelIndex = comboBoxBar3DModel.SelectedIndex;
            Bar3DModel barModel = (Bar3DModel)bar3DModelIndex;
            Bar3DSeriesView seriesView = ChartControl.SeriesTemplate.View as Bar3DSeriesView;
            if (seriesView != null)
                seriesView.Model = barModel;
            checkEditShowFacet.Enabled = IsFacetEnabled(barModel);
        }
        void checkEditShowFacet_CheckedChanged(object sender, EventArgs e) {
            Bar3DSeriesView seriesView = ChartControl.SeriesTemplate.View as Bar3DSeriesView;
            if (seriesView != null)
                seriesView.ShowFacet = checkEditShowFacet.Checked;
        }

		protected override void InitControls() {
			base.InitControls();
			string[] perspectiveArray = new string[] { DefaultPerspective, "0", "30", "45", "60", "90", "120", "135", "150" };
			comboBoxEditPerspective.Properties.Items.AddRange(perspectiveArray);
			comboBoxEditPerspective.Text = DefaultPerspective;
            string[] bar3DModelArray = new string[] { DefaultBar3DModel, "Cylinder", "Cone", "Pyramid" };
            comboBoxBar3DModel.Properties.Items.AddRange(bar3DModelArray);
            comboBoxBar3DModel.Text = DefaultBar3DModel;
            checkEditShowFacet.Checked = true;
            ShowLabels = true;
            ChartControl.DataSource = AgeStructure.GetDataByFemaleAge();
        }
    }
}