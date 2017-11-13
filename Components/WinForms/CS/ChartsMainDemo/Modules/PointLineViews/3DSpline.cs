using System;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
    public partial class Spline3dDemo : ChartDemoBase3D {
        const string DefaultPerspective = "Default";

        ChartControl chart;
        ComboBoxEdit comboBoxEditPerspective;

        public override ChartControl ChartControl { get { return chart; } }

        public Spline3dDemo() {
            InitializeComponent();
        }

        void comboBoxEditPerspective_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditPerspective.SelectedIndex == -1)
                return;
            string perspectiveText = comboBoxEditPerspective.Text;
            int perspectiveAngle = perspectiveText == DefaultPerspective ? 50 : Int32.Parse(perspectiveText);
            Diagram3D diagram = ChartControl.Diagram as Diagram3D;
            if (diagram != null)
                diagram.PerspectiveAngle = perspectiveAngle;
        }

        protected override void InitControls() {
            base.InitControls();
            string[] perspectiveArray = new string[] { DefaultPerspective, "0", "30", "45", "60", "90", "120", "135", "150" };
            this.comboBoxEditPerspective.Properties.Items.AddRange(perspectiveArray);
            this.comboBoxEditPerspective.Text = DefaultPerspective;
            ShowLabels = false;
            foreach (Series series in ChartControl.Series)
                series.DataSource = SourceOfEnergy.GetCoalProduction();
        }
    }
}
