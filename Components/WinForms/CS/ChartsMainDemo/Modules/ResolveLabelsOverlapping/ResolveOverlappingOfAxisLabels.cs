using System;

namespace DevExpress.XtraCharts.Demos.ResolveLabelsOverlapping {
    public partial class ResolveOverlappingOfAxisLabelsDemo : ChartDemoBase2D {
        AxisLabel AxisLabel {
            get {
                XYDiagram diagram = chart.Diagram as XYDiagram;
                if (diagram != null && diagram.AxisX != null)
                    return diagram.AxisX.Label;
                else
                    return null;
            }
        }
        bool ResolveOverlappingEnabled {
            get {
                AxisLabel label = AxisLabel;
                if (label != null) {
                    return label.ResolveOverlappingOptions.AllowStagger && label.ResolveOverlappingOptions.AllowRotate && label.ResolveOverlappingOptions.AllowHide;
                }
                return false;
            }
        }

        public override ChartControl ChartControl { get { return chart; } }

        public ResolveOverlappingOfAxisLabelsDemo() {
            InitializeComponent();
            ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries;
        }

        void spinIndent_EditValueChanged(object sender, System.EventArgs e) {
            if (AxisLabel != null)
                AxisLabel.ResolveOverlappingOptions.MinIndent = Convert.ToInt32(spinIndent.EditValue);  
        }
        void checkEditResolveOverlapping_CheckedChanged(object sender, System.EventArgs e) {
            if (AxisLabel != null) {
                bool resolveOverlappingEnabled = checkEditResolveOverlapping.Checked;
                AxisLabel.ResolveOverlappingOptions.AllowStagger = resolveOverlappingEnabled;
                AxisLabel.ResolveOverlappingOptions.AllowRotate = resolveOverlappingEnabled;         
                AxisLabel.ResolveOverlappingOptions.AllowHide = resolveOverlappingEnabled;
            }
            UpdateControls();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (AxisLabel != null) {
                checkEditResolveOverlapping.Checked = ResolveOverlappingEnabled;
                labelIndent.Enabled = ResolveOverlappingEnabled;
                spinIndent.Enabled = labelIndent.Enabled;
                spinIndent.EditValue = AxisLabel.ResolveOverlappingOptions.MinIndent;
            }
        }
    }
}
