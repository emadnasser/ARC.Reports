using System;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.PieDoughnutViews {
	public partial class Pie3dDemo : ChartDemoBase3D {
		ChartControl chart;
		CheckEdit checkEditValueAsPercent;

		public override ChartControl ChartControl { get { return this.chart; } }

		public Pie3dDemo() {
			InitializeComponent();
			InitExplodeModeComboBox();
            cbLabelPosition.EditValue = "Radial";
            ShowLabels = true;
		}

        void InitExplodeModeComboBox() {
			cbExplodeMode.Properties.Items.AddRange(PieExplodingHelper.CreateModeList(ChartControl.Series[0].Points, false));
			cbExplodeMode.SelectedIndex = 0;
		}
        void checkEditValueAsPercent_CheckedChanged(object sender, System.EventArgs e) {
            if (chart.Series.Count == 0)
                return;
            chart.Series[0].Label.TextPattern = this.checkEditValueAsPercent.Checked ? "{VP:P0}" : "{V:F1}";
        }
		void SelectedIndexChanged(object sender, System.EventArgs e) {
            if (chart.Series.Count == 0)
                return;
            Pie3DSeriesLabel label = chart.Series[0].Label as Pie3DSeriesLabel;
            if (label != null)
                label.Position = (PieSeriesLabelPosition)cbLabelPosition.SelectedIndex;
		}
		void cbExplodeMode_SelectedIndexChanged(object sender, EventArgs e) {
            if (chart.Series.Count == 0)
                return;
            Pie3DSeriesView view = chart.Series[0].View as Pie3DSeriesView;
            if (view != null) {
                string mode = (string)cbExplodeMode.SelectedItem;
                PieExplodingHelper.ApplyMode(view, mode);
                txtDistance.Enabled = mode != PieExplodingHelper.None;
            }
		}
		void txtDistance_EditValueChanged(object sender, EventArgs e) {
            if (chart.Series.Count == 0)
                return;
            Pie3DSeriesView view = chart.Series[0].View as Pie3DSeriesView;
            if (view != null)
			    view.ExplodedDistancePercentage = Convert.ToDouble(this.txtDistance.EditValue);
		}

        protected override void UpdateRotationAngles(Diagram3D diagram) {
            diagram.RotationOrder = RotationOrder.ZXY;
            diagram.RotationAngleX = -35;
            diagram.RotationAngleY = 0;
            diagram.RotationAngleZ = 15;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (chart.Series.Count == 0)
                return;
            Pie3DSeriesLabel label = chart.Series[0].Label as Pie3DSeriesLabel;
            if (label != null) {
                cbLabelPosition.SelectedIndex = (int)label.Position;
                checkEditValueAsPercent.Checked = ChartControl.Series[0].Label.TextPattern.Contains("VP");
            }
            cbLabelPosition.Enabled = ShowLabels;
            labelPosition.Enabled = ShowLabels;
            checkEditValueAsPercent.Enabled = ShowLabels;
            Pie3DSeriesView view = chart.Series[0].View as Pie3DSeriesView;
            if (view != null)
                txtDistance.EditValue = view.ExplodedDistancePercentage;
        }        
	}
}
