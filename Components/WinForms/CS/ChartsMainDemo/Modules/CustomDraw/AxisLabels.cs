using System;
using System.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.CustomDraw {
	public partial class AxisLabelsDemo : ChartDemoBase2D {
		public override ChartControl ChartControl { get { return chart; } }

		public AxisLabelsDemo() {
			InitializeComponent();
		}

		void checkEditCustomDraw_CheckedChanged(object sender, EventArgs e) {
			ChartControl.RefreshData();
		}
        void chart_CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e) {
            if (checkEditCustomDraw.Checked) {
                AxisBase axis = e.Item.Axis;
                if (axis is AxisY || axis is AxisY3D || axis is RadarAxisY) {
                    double axisValue = (double)e.Item.AxisValue;
                    if (axisValue < 0)
                        e.Item.TextColor = Color.Red;
                    else if (axisValue > 0) {
                        e.Item.Text = "+" + e.Item.Text;
                        e.Item.TextColor = Color.Green;
                    }
                    e.Item.Font = new Font(e.Item.Font.FontFamily, e.Item.Font.Size + (float)Math.Abs(axisValue), FontStyle.Bold);
                    e.Item.EnableAntialiasing = DefaultBoolean.True;
                }
            }
        }

        protected override void InitControls() {
            base.InitControls();
            checkEditCustomDraw.Checked = true;
            ShowLabels = true;
        }
	}
}

