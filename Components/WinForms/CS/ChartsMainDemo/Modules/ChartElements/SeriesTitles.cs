using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.ChartElements {
    public partial class SeriesTitlesDemo : ChartDemoBase2D {

		public override ChartControl ChartControl { get { return this.chart; } }

        public SeriesTitlesDemo() {
			InitializeComponent();
		}

        void chart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            if (chart.Series.Count > 0 && !chart.Series[0].Equals(e.Series))
                e.LegendText = "";
        }
        void comboBoxEditSeriesDataMember_SelectedIndexChanged(object sender, EventArgs e) {
            ViewType viewType;
            switch ((string)comboBoxViewType.SelectedItem) { 
                case "Pie 3D":
                    viewType = ViewType.Pie3D;
                    break;
                case "Doughnut":
                    viewType = ViewType.Doughnut;
                    break;
                case "Doughnut 3D":
                    viewType = ViewType.Doughnut3D;
                    break;
                default:
                    viewType = ViewType.Pie;
                    break;
            }
            chart.SeriesTemplate.ChangeView(viewType);
            Diagram3D diagram = chart.Diagram as Diagram3D;
            if (diagram != null) {
                diagram.RuntimeRotation = true;
                diagram.RuntimeScrolling = true;
                diagram.RuntimeZooming = true;
            }
        }

        protected override void InitControls() {
            base.InitControls();
            ChartControl.DataSource = DevAV.GetSalesMixByRegion();
        }
        protected override void checkEditShowLabels_CheckedChanged(object sender, EventArgs e) {
            this.chart.SeriesTemplate.LabelsVisibility = ShowLabels ? DefaultBoolean.True : DefaultBoolean.False;
        }
	}
}
