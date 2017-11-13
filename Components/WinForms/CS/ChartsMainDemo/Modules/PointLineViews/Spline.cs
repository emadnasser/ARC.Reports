using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
    public partial class SplineDemo : ChartDemoLineBase {
        ChartControl chart;

        public override ChartControl ChartControl { get { return this.chart; } }
        protected override bool SeriesSelection { get { return true; } }

        public SplineDemo() {
            InitializeComponent();
        }

        void chart_BoundDataChanged(object sender, EventArgs e) {
            if (this.chart.Series.Count > 0)
                chart.SetObjectSelection(this.chart.Series[0]);
            chart.Animate();
        }
        void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.seriesSelected != null) {
                SplineSeriesView splineSeriesView = seriesSelected.View as SplineSeriesView;
                if (splineSeriesView != null)
                    splineSeriesView.LineTensionPercent = int.Parse((string)this.comboBoxLineTension.SelectedItem);
            }
        }

        protected override void checkEditShowLabels_CheckedChanged(object sender, EventArgs e) {
            if (seriesSelected != null && seriesSelected.Label != null)
                seriesSelected.LabelsVisibility = this.checkEditShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            UpdateControls();
        }
        protected override void InitControls() {
            base.InitControls();
            ChartControl.DataSource = PowerConsumption.GetData();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            SplineSeriesView view = seriesSelected != null ? seriesSelected.View as SplineSeriesView : null;
            if (view == null) {
                labelLineTension.Enabled = false;
                comboBoxLineTension.Enabled = false;
                checkEditShowLabels.Enabled = false;
                comboBoxLineTension.SelectedItem = null;
                checkEditShowLabels.Checked = false;
                return;
            }
            labelLineTension.Enabled = true;
            comboBoxLineTension.Enabled = true;
            checkEditShowLabels.Enabled = true;
            comboBoxLineTension.SelectedItem = view.LineTensionPercent.ToString();
            if (seriesSelected.Label == null || seriesSelected.LabelsVisibility != DefaultBoolean.True)
                checkEditShowLabels.Checked = false;
            else
                checkEditShowLabels.Checked = true;
        }
    }
}
