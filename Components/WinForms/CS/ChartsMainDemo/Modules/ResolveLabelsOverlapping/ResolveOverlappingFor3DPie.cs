using System;

namespace DevExpress.XtraCharts.Demos.ResolveLabelsOverlapping {
    public partial class ResolveOverlappingFor3dPieDemo : ChartDemoBase3D {
        SeriesLabelBase Label {
            get {
                if (chart.Series.Count != 0)
                    return chart.Series[0].Label;
                else
                    return null;
            }            
        }

        public override ChartControl ChartControl { get { return chart; } }
        
        public ResolveOverlappingFor3dPieDemo() {
            InitializeComponent();
            CheckEditShowLabelsVisible = false;            
        }

        void checkEditResolveOverlapping_CheckedChanged(object sender, EventArgs e) {
            if (Label != null) {
                if (checkEditResolveOverlapping.Checked)
                    Label.ResolveOverlappingMode = ResolveOverlappingMode.Default;
                else
                    Label.ResolveOverlappingMode = ResolveOverlappingMode.None;
            }
            UpdateControls();
        }
        void spinIndent_EditValueChanged(object sender, EventArgs e) {
            if (Label != null)
                Label.ResolveOverlappingMinIndent = Convert.ToInt32(spinIndent.EditValue);            
        }

        protected override void UpdateRotationAngles(Diagram3D diagram) {
            diagram.RotationAngleX = -50;
            diagram.RotationAngleY = 170;
            diagram.RotationAngleZ = -25;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (Label != null) {
                checkEditResolveOverlapping.Checked = Label.ResolveOverlappingMode == ResolveOverlappingMode.Default;
                labelIndent.Enabled = Label.ResolveOverlappingMode != ResolveOverlappingMode.None;
                spinIndent.Enabled = labelIndent.Enabled;
                spinIndent.EditValue = Label.ResolveOverlappingMinIndent;
            }
        }
    }
}
