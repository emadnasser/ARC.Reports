using System;

namespace DevExpress.XtraCharts.Demos.AreaViews {
    public partial class Area3dDemoBase : ChartDemoBase3D {
        const string DefaultPerspective = "Default";

        public Area3dDemoBase() {
            InitializeComponent();
        }

        void comboTransparencies_SelectedIndexChanged(object sender, EventArgs e) {
            byte transp = Convert.ToByte(comboTransparencies.Text);
            Area3DSeriesView view = ChartControl.SeriesTemplate.View as Area3DSeriesView;
            if (view != null)
                view.Transparency = transp;
        }
        void comboBoxEditPerspective_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.comboBoxEditPerspective.SelectedIndex == -1)
                return;
            string perspectiveText = this.comboBoxEditPerspective.Text;
            int perspectiveAngle = perspectiveText == DefaultPerspective ? 50 : Int32.Parse(perspectiveText);
            Diagram3D diagram = ChartControl.Diagram as Diagram3D;
            if (diagram != null)
                diagram.PerspectiveAngle = perspectiveAngle;
        }

        protected override void InitControls() {
            base.InitControls();
            this.comboTransparencies.Properties.Items.AddRange(new string[] { "0", "45", "90", "135", "180", "225", "255" });
            this.comboBoxEditPerspective.Properties.Items.AddRange(new string[] { DefaultPerspective, "0", "30", "45", "60", "90", "120", "135", "150" });
            this.comboBoxEditPerspective.Text = DefaultPerspective;

            Area3DSeriesView view;
            if (ChartControl.Series.Count > 0) {
                ShowLabels = ChartControl.Series[0].LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
                view = ChartControl.Series[0].View as Area3DSeriesView;
            }
            else {
                ShowLabels = ChartControl.SeriesTemplate.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
                view = ChartControl.SeriesTemplate.View as Area3DSeriesView;
            }
            if (view != null)
                this.comboTransparencies.Text = view.Transparency.ToString();
        }
    }
}
