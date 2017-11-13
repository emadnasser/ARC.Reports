using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.PieDoughnutViews {
	public partial class PieDemo : ChartDemoBase2D {
        ChartControl chart;
        CheckEdit checkEditValueAsPercent;

        protected override DefaultBoolean ToolTipEnabled { get { return DefaultBoolean.True; } }

        public override ChartControl ChartControl { get { return this.chart; } }

		public PieDemo() {
			InitializeComponent();
            InitExplodeModeComboBox();
            cbLabelPosition.EditValue = "Radial";
		}

        void InitExplodeModeComboBox() {
            if (ChartControl.Series.Count > 0)
                cbExplodeMode.Properties.Items.AddRange(PieExplodingHelper.CreateModeList(ChartControl.Series[0].Points, true));
            cbExplodeMode.SelectedIndex = 0;
        }
		void checkEditValueAsPercent_CheckedChanged(object sender, EventArgs e) {
            if (ChartControl.Series.Count > 0)
                chart.Series[0].Label.TextPattern = this.checkEditValueAsPercent.Checked ? "{VP:P0}" : "{V:F1}";
		}
        void cbLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            if (ChartControl.Series.Count == 0)
                return;
            PieSeriesLabel label = chart.Series[0].Label as PieSeriesLabel;
            if (label != null) {
                label.Position = (PieSeriesLabelPosition)cbLabelPosition.SelectedIndex;
                label.TextColor = (label.Position == PieSeriesLabelPosition.Outside || label.Position == PieSeriesLabelPosition.TwoColumns) ? Color.Empty : Color.Black;
            }
        }
        void cbExplodeMode_SelectedIndexChanged(object sender, EventArgs e) {
            if (ChartControl.Series.Count == 0)
                return;
            PieSeriesView view = chart.Series[0].View as PieSeriesView;
            if (view != null) {
                string mode = (string)cbExplodeMode.SelectedItem;
                PieExplodingHelper.ApplyMode(view, mode);
            }
        }
        void chart_PieSeriesPointExploded(object sender, PieSeriesPointExplodedEventArgs e) {
            if (e.Dragged)
                cbExplodeMode.SelectedItem = PieExplodingHelper.Custom;
        }
        
        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
            foreach (Series series in chart.Series)
                series.ToolTipPointPattern = "{A}: {V:0.0}M km" + (char)178;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (ChartControl.Series.Count == 0)
                return;
            PieSeriesLabel label = chart.Series[0].Label as PieSeriesLabel;
            if (label != null) {
                cbLabelPosition.SelectedIndex = (int)label.Position;
                if (chart.Series[0].Label.TextPattern != null)
                    checkEditValueAsPercent.Checked = chart.Series[0].Label.TextPattern.Contains("VP");
                else
                    checkEditValueAsPercent.Checked = false;
                checkEditValueAsPercent.Enabled = ShowLabels;
                cbLabelPosition.Enabled = ShowLabels;
                labelPosition.Enabled = ShowLabels;
            }
        }
    }
}
