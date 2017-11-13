using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.FunnelViews {
    public partial class FunnelDemo : ChartDemoBase2D {
        public override ChartControl ChartControl { get { return chart; } }
        protected override DefaultBoolean ToolTipEnabled { get { return DefaultBoolean.True; } }
        FunnelSeriesLabel Label {
            get {
                if (chart.Series.Count == 0)
                    return null;
                return chart.Series[0].Label as FunnelSeriesLabel;
            }
        }
        FunnelSeriesView View {
            get {
                if (chart.Series.Count == 0)
                    return null;
                return chart.Series[0].View as FunnelSeriesView;
            }
        }

        public FunnelDemo() {
            InitializeComponent();
        }
        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
            cbHeightToWidthRatio.Properties.Items.AddRange(new double[] { 0.1, 0.25, 0.5, 0.75, 1, 2, 4, 6, 8, 10 });
            foreach (Series series in chart.Series)
                series.ToolTipPointPattern = "{A}: {V} ({VP:0.0%})";
        }
        void cbLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            if (Label != null) 
                Label.Position = (FunnelSeriesLabelPosition)cbLabelPosition.SelectedIndex;
        }
        void checkEditValueAsPercent_CheckedChanged(object sender, EventArgs e) {
            chart.Series[0].Label.TextPattern = "{A} : " + (this.checkEditValueAsPercent.Checked ? "{VP:P0}" : "{V:F0}");
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
                checkEditAlignToCenter.Checked = View.AlignToCenter;
                checkEditHeightToWidthRatioAuto.Checked = View.HeightToWidthRatioAuto;
                spinPointDistance.EditValue = View.PointDistance;
            }
        }
        void checkEditHeightToWidthRatioAuto_CheckedChanged(object sender, EventArgs e) {
            if (View != null) {
                View.HeightToWidthRatioAuto = checkEditHeightToWidthRatioAuto.Checked;
                cbHeightToWidthRatio.Enabled = !checkEditHeightToWidthRatioAuto.Checked;
            }
        }
        void checkEditAlignToCenter_CheckedChanged(object sender, EventArgs e) {
            if (View != null)
                View.AlignToCenter = checkEditAlignToCenter.Checked;
        }
        void cbHeightToWidthRatio_SelectedIndexChanged(object sender, EventArgs e) {
            if (View != null)
                View.HeightToWidthRatio = Convert.ToDouble(cbHeightToWidthRatio.SelectedItem);            
        }
        void spinPointDistance_EditValueChanged(object sender, EventArgs e) {
            if (View != null)
                View.PointDistance = Convert.ToInt32(spinPointDistance.Value);
        }        
    }
}

