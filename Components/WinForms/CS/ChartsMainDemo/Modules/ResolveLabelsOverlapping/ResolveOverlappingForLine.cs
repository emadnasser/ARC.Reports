using System;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.ResolveLabelsOverlapping {
    public partial class ResolveOverlappingForLineDemo : ChartDemoBase2D {
        PointSeriesLabel Label { 
            get {
                if (chart.Series.Count != 0)
                    return chart.Series[0].Label as PointSeriesLabel;
                else
                    return null;
            } 
        }

        public override ChartControl ChartControl { get { return chart; } }
        
        public ResolveOverlappingForLineDemo() {
            InitializeComponent();
            CheckEditShowLabelsVisible = false;            
        }

        void spinLineLength_EditValueChanged(object sender, EventArgs e) {
            if (Label != null)
                Label.LineLength = Convert.ToInt32(spinLineLength.EditValue);
        }
        void spinAngle_EditValueChanged(object sender, EventArgs e) {
            if (Label != null)
                Label.Angle = Convert.ToInt32(spinAngle.EditValue);
        }
        void cbMode_SelectedIndexChanged(object sender, EventArgs e) {
            if (Label != null) {
                try {
                    Label.ResolveOverlappingMode = (ResolveOverlappingMode)cbMode.SelectedIndex;
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(LookAndFeel.ActiveLookAndFeel, exception.Message, "Resolve Overlapping Mode");
                }
                UpdateControls();
            }
        }
        void spinIndent_EditValueChanged(object sender, EventArgs e) {
            if (Label != null)
                Label.ResolveOverlappingMinIndent = Convert.ToInt32(spinIndent.EditValue);
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (Label != null) {
                labelIndent.Enabled = Label.ResolveOverlappingMode != ResolveOverlappingMode.None;
                spinIndent.Enabled = labelIndent.Enabled;
                spinIndent.EditValue = Label.ResolveOverlappingMinIndent;
                cbMode.SelectedIndex = (int)Label.ResolveOverlappingMode;
                spinLineLength.Value = Label.LineLength;
                spinAngle.Value = Label.Angle;
                bool angleDisabled = Label.ResolveOverlappingMode == ResolveOverlappingMode.JustifyAllAroundPoint;
                spinAngle.Enabled = !angleDisabled;
                labelControlAngle.Enabled = !angleDisabled;
            }
        }        
    }
}
