using System;

namespace DevExpress.XtraCharts.Demos.FunnelViews {
    public partial class Funnel3dDemo : ChartDemoBase3D {       
        FunnelSeriesLabel Label {
            get {
                if (chart.Series.Count == 0)
                    return null;
                return chart.Series[0].Label as FunnelSeriesLabel;
            }
        }
        Funnel3DSeriesView View {
            get {
                if (chart.Series.Count == 0)
                    return null;
                return chart.Series[0].View as Funnel3DSeriesView;
            }
        }

        public override ChartControl ChartControl { get { return chart; } }
        
        public Funnel3dDemo() {
            InitializeComponent();
        }

        void spinPointDistance_EditValueChanged(object sender, EventArgs e) {
            if (View != null)
                View.PointDistance = Convert.ToInt32(spinPointDistance.Value);
        }
        void cbHeightToWidthRatio_SelectedIndexChanged(object sender, EventArgs e) {
            if (View != null)
                View.HeightToWidthRatio = Convert.ToDouble(cbHeightToWidthRatio.SelectedItem);
        }
        void spinHoleRadius_EditValueChanged(object sender, EventArgs e) {
            if (View != null)
                View.HoleRadiusPercent = Convert.ToInt32(spinHoleRadius.EditValue);
        }
        void cbLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            if (Label != null)
                Label.Position = (FunnelSeriesLabelPosition)cbLabelPosition.SelectedIndex;
        }
        void checkEditValueAsPercent_CheckedChanged(object sender, EventArgs e) {
            chart.Series[0].Label.TextPattern = this.checkEditValueAsPercent.Checked ? "{VP:P0}" : "{V:F0}";
        }

        protected override void UpdateRotationAngles(Diagram3D diagram) {
            diagram.RotationOrder = RotationOrder.ZXY;
            diagram.RotationAngleX = 15;
            diagram.RotationAngleY = 0;
            diagram.RotationAngleZ = 0;
        }
        protected override void InitControls() {
            base.InitControls();
            cbHeightToWidthRatio.Properties.Items.AddRange(new double[] { 0.1, 0.25, 0.5, 0.75, 1, 2, 4, 6, 8, 10 });
            ShowLabels = true;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (Label != null) {
                cbLabelPosition.SelectedIndex = (int)Label.Position;
                checkEditValueAsPercent.Checked = chart.Series[0].Label.TextPattern.Contains("VP");
                cbLabelPosition.Enabled = ShowLabels;
                labelPosition.Enabled = ShowLabels;
                checkEditValueAsPercent.Enabled = ShowLabels;
            }
            if (View != null) {
                cbHeightToWidthRatio.EditValue = View.HeightToWidthRatio;
                spinPointDistance.EditValue = View.PointDistance;
                spinHoleRadius.EditValue = View.HoleRadiusPercent;
            }
        }
    }
}
