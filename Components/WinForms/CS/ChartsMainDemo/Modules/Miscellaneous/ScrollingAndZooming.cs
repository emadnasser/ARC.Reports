using System;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
	public partial class ScrollingAndZoomingDemo : ChartDemoBase2D {
		ChartControl chart;
        TimeSpan AxisXRangeSpan;
        double AxisYRangeSpan;

        XYDiagram Diagram { get { return chart.Diagram as XYDiagram; } }
        
        public override ChartControl ChartControl { get { return this.chart; } }

		public ScrollingAndZoomingDemo() {
			InitializeComponent();
		}

		void btnRestoreView_Click(object sender, EventArgs e) {
            if (Diagram != null) {
                Diagram.AxisX.VisualRange.MinValue = Diagram.AxisX.WholeRange.MinValue;
                Diagram.AxisX.VisualRange.MaxValue = (DateTime)Diagram.AxisX.WholeRange.MinValue + AxisXRangeSpan;
                Diagram.AxisY.VisualRange.MinValue = Diagram.AxisY.WholeRange.MinValue;
                Diagram.AxisY.VisualRange.MaxValue = (double)Diagram.AxisY.WholeRange.MinValue + AxisYRangeSpan;
            }
		}
		void cbHorAlign_SelectedIndexChanged(object sender, EventArgs e) {
            if (Diagram != null)
                Diagram.DefaultPane.ScrollBarOptions.XAxisScrollBarAlignment = (ScrollBarAlignment)cbHorAlign.SelectedIndex;
		}
		void cbVertAlign_SelectedIndexChanged(object sender, EventArgs e) {
            if (Diagram != null)
                Diagram.DefaultPane.ScrollBarOptions.YAxisScrollBarAlignment = (ScrollBarAlignment)cbVertAlign.SelectedIndex;
		}
        void cbEnableAxisXScrolling_CheckedChanged(object sender, EventArgs e) {
            if (Diagram != null) {
                Diagram.EnableAxisXScrolling = cbEnableAxisXScrolling.Checked;
                lblHorizontal.Enabled = Diagram.EnableAxisXScrolling;
                cbHorAlign.Enabled = Diagram.EnableAxisXScrolling;
            }
        }
        void cbEnableAxisXZooming_CheckedChanged(object sender, EventArgs e) {
            if (Diagram != null)
                Diagram.EnableAxisXZooming = cbEnableAxisXZooming.Checked;
        }
        void cbEnableAxisYScrolling_CheckedChanged(object sender, EventArgs e) {
            if (Diagram != null) {
                Diagram.EnableAxisYScrolling = cbEnableAxisYScrolling.Checked;
                lblVertical.Enabled = Diagram.EnableAxisYScrolling;
                cbVertAlign.Enabled = Diagram.EnableAxisYScrolling;
            }
        }
        void cbEnableAxisYZooming_CheckedChanged(object sender, EventArgs e) {
            if (Diagram != null)
                Diagram.EnableAxisYZooming = cbEnableAxisYZooming.Checked;
        }
        protected override void InitControls() {
            base.InitControls();
            ChartControl.Series[0].DataSource = SourceOfEnergy.GetGasPrices();
            Diagram.AxisX.VisualRange.MaxValue = new DateTime(2009, 6, 10);
            Diagram.AxisY.VisualRange.MaxValue = 10.6;
            AxisXRangeSpan = (DateTime)Diagram.AxisX.VisualRange.MaxValue - (DateTime)Diagram.AxisX.VisualRange.MinValue;
            AxisYRangeSpan = (double)Diagram.AxisY.VisualRange.MaxValue - (double)Diagram.AxisY.VisualRange.MinValue;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (Diagram != null) {
                cbEnableAxisXScrolling.Checked = Diagram.EnableAxisXScrolling;
                cbEnableAxisYScrolling.Checked = Diagram.EnableAxisYScrolling;
                cbEnableAxisXZooming.Checked = Diagram.EnableAxisXZooming;
                cbEnableAxisYZooming.Checked = Diagram.EnableAxisYZooming;
                cbVertAlign.SelectedIndex = (int)Diagram.DefaultPane.ScrollBarOptions.YAxisScrollBarAlignment;
                cbHorAlign.SelectedIndex = (int)Diagram.DefaultPane.ScrollBarOptions.XAxisScrollBarAlignment;
                lblHorizontal.Enabled = Diagram.EnableAxisXScrolling;
                cbHorAlign.Enabled = Diagram.EnableAxisXScrolling;
                lblVertical.Enabled = Diagram.EnableAxisYScrolling;
                cbVertAlign.Enabled = Diagram.EnableAxisYScrolling;
            }
        }
    }
}
