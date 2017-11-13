using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.PieDoughnutViews {
	public partial class DoughnutDemo : ChartDemoBase2D {
        ChartControl chart;
        CheckEdit checkEditValueAsPercent;

        protected override DefaultBoolean ToolTipEnabled { get { return DefaultBoolean.True; } }

		public override ChartControl ChartControl { get { return chart; } }
       
        public DoughnutDemo() {
			InitializeComponent();
            InitExplodeModeComboBox();
            cbLabelPosition.EditValue = "Radial";
		}

        void InitExplodeModeComboBox() {
            if (ChartControl.Series.Count > 0)
                cbExplodeMode.Properties.Items.AddRange(PieExplodingHelper.CreateModeList(ChartControl.Series[0].Points, true));
            cbExplodeMode.SelectedIndex = 0;
        }
		void checkEditValueAsPercent_CheckedChanged(object sender, System.EventArgs e) {
            if (ChartControl.Series.Count == 0)
                return;
            chart.Series[0].Label.TextPattern = this.checkEditValueAsPercent.Checked ? "{VP:P0}" : "{V:F1}";
		}
        void cbLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            if (ChartControl.Series.Count == 0 || !(ChartControl.Series[0].Label is DoughnutSeriesLabel))
                return;
            DoughnutSeriesLabel label = (DoughnutSeriesLabel)ChartControl.Series[0].Label;
            label.Position = (PieSeriesLabelPosition)cbLabelPosition.SelectedIndex;
            label.TextColor = (label.Position == PieSeriesLabelPosition.Outside || label.Position == PieSeriesLabelPosition.TwoColumns) ? Color.Empty : Color.Black;
        }
        void cbExplodeMode_SelectedIndexChanged(object sender, EventArgs e) {
            if (ChartControl.Series.Count > 0) {
                DoughnutSeriesView view = ChartControl.Series[0].View as DoughnutSeriesView;
                if (view != null) {
                    string mode = (string)cbExplodeMode.SelectedItem;
                    PieExplodingHelper.ApplyMode(view, mode);
                }
            }
        }
        void txtHoleRadius_EditValueChanged(object sender, EventArgs e) {
            if (ChartControl.Series.Count > 0) {
                DoughnutSeriesView view = ChartControl.Series[0].View as DoughnutSeriesView;
                if (view != null)
                    view.HoleRadiusPercent = Convert.ToInt32(txtHoleRadius.EditValue);
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
                series.ToolTipPointPattern = "{A}: {V:0.0} M km" + (char)178;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (ChartControl.Series.Count > 0) {
                DoughnutSeriesLabel label = ChartControl.Series[0].Label as DoughnutSeriesLabel;
                if (label != null) {
                    cbLabelPosition.SelectedIndex = (int)label.Position;
                    checkEditValueAsPercent.Checked = ChartControl.Series[0].Label.TextPattern.Contains("VP");
                    cbLabelPosition.Enabled = ShowLabels;
                    labelPosition.Enabled = ShowLabels;
                    checkEditValueAsPercent.Enabled = ShowLabels;
                    if (ChartControl.Series[0].View is DoughnutSeriesView)
                        txtHoleRadius.EditValue = ((DoughnutSeriesView)ChartControl.Series[0].View).HoleRadiusPercent;
                }
            }
        }        
	}
}
