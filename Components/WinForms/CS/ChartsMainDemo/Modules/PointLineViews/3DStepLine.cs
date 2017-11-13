using System;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
    public partial class StepLine3dDemo : ChartDemoBase3D {
        const string DefaultPerspective = "Default";
        
        ChartControl chartControl;
        ComboBoxEdit comboBoxEditPerspective;

        public override ChartControl ChartControl { get { return chartControl; } }
        protected Series Series { get { return ChartControl.Series.Count > 0 ? ChartControl.Series[0] : null; } }

        public StepLine3dDemo() {
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
        void checkEditInverted_CheckedChanged(object sender, EventArgs e) {
            StepLine3DSeriesView line = Series.View as StepLine3DSeriesView;
            if (line != null) {
                line.InvertedStep = this.checkEditInverted.Checked;
                return;
            }
            StepArea3DSeriesView area = Series.View as StepArea3DSeriesView;
            if (area != null)
                area.InvertedStep = this.checkEditInverted.Checked;
        }
        
        protected override void InitControls() {
            base.InitControls();
            string[] perspectiveArray = new string[] { DefaultPerspective, "0", "30", "45", "60", "90", "120", "135", "150" };
            comboBoxEditPerspective.Properties.Items.AddRange(perspectiveArray);
            comboBoxEditPerspective.Text = DefaultPerspective;
            StepLine3DSeriesView view = Series.View as StepLine3DSeriesView;
            if (view != null)
                checkEditInverted.Checked = view.InvertedStep;
            Series.DataSource = SourceOfEnergy.GetGasolinePrices();
            ShowLabels = false;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            StepLine3DSeriesView view = Series.View as StepLine3DSeriesView;
            if (view != null)
                checkEditInverted.Checked = view.InvertedStep;
        }
    }
}
