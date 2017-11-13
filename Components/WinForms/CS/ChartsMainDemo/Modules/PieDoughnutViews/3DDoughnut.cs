using System;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.PieDoughnutViews {
	public partial class Doughnut3dDemo : ChartDemoBase3D {
		ChartControl chart;
		CheckEdit checkEditValueAsPercent;

		public override ChartControl ChartControl { get { return chart; } }

		public Doughnut3dDemo() {
			InitializeComponent();
			InitExplodeModeComboBox();
            cbLabelPosition.EditValue = "Radial";
            ShowLabels = true;
		}

        void InitExplodeModeComboBox() {
            if (ChartControl.Series.Count > 0)
			    cbExplodeMode.Properties.Items.AddRange(PieExplodingHelper.CreateModeList(ChartControl.Series[0].Points, false));
			cbExplodeMode.SelectedIndex = 0;
		}
        void checkEditValueAsPercent_CheckedChanged(object sender, System.EventArgs e) {
            if (ChartControl.Series.Count > 0)
                ChartControl.Series[0].Label.TextPattern = this.checkEditValueAsPercent.Checked ? "{VP:P0}" : "{V:F1}";
        }
		void SelectedIndexChanged(object sender, EventArgs e) {
            if (ChartControl.Series.Count > 0) {
                Doughnut3DSeriesLabel label = ChartControl.Series[0].Label as Doughnut3DSeriesLabel;
                if (label != null)
                    label.Position = (PieSeriesLabelPosition)cbLabelPosition.SelectedIndex;
            }
		}
        void txtHoleRadius_EditValueChanged(object sender, EventArgs e) {
            if (ChartControl.Series.Count > 0 && ChartControl.Series[0].View is Doughnut3DSeriesView)
                ((Doughnut3DSeriesView)ChartControl.Series[0].View).HoleRadiusPercent = Convert.ToInt32(txtHoleRadius.EditValue);
        }
		void cbExplodeMode_SelectedIndexChanged(object sender, EventArgs e) {
            if (ChartControl.Series.Count > 0) {
                Doughnut3DSeriesView view = ChartControl.Series[0].View as Doughnut3DSeriesView;
                if (view != null) {
                    string mode = (string)cbExplodeMode.SelectedItem;
                    PieExplodingHelper.ApplyMode(view, mode);
                }
            }
		}

        protected override void UpdateRotationAngles(Diagram3D diagram) {
            diagram.RotationOrder = RotationOrder.ZXY;
            diagram.RotationAngleX = -35;
            diagram.RotationAngleY = 0;
            diagram.RotationAngleZ = 15;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (ChartControl.Series.Count > 0) {
                Doughnut3DSeriesLabel label = ChartControl.Series[0].Label as Doughnut3DSeriesLabel;
                if (label != null)
                    cbLabelPosition.SelectedIndex = (int)label.Position;
                checkEditValueAsPercent.Checked = ChartControl.Series[0].Label.TextPattern.Contains("VP");
                cbLabelPosition.Enabled = ShowLabels;
                labelPosition.Enabled = ShowLabels;
                checkEditValueAsPercent.Enabled = ShowLabels;
                if (ChartControl.Series[0].View is Doughnut3DSeriesView)
                    txtHoleRadius.EditValue = ((Doughnut3DSeriesView)ChartControl.Series[0].View).HoleRadiusPercent;
            }
        }
	}
}
