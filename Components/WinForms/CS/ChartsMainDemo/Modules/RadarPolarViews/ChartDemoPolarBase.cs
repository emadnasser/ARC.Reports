using System;

namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
	public partial class PolarDemoBase : RadarPolarDemoBase {
        const int defaultPointsCount = 72;
		protected override bool SeriesSelection { get { return false; } }

		public PolarDemoBase() {
			InitializeComponent();
		}

		void comboBoxEditFunctionType_SelectedIndexChanged(object sender, EventArgs e) {
            if (ChartControl.Series.Count > 0 && ChartControl.Diagram is PolarDiagram) {
                SeriesPoint[] points = PolarDiagramPointsGenerator.GenerateFunctionPoints((PolarDiagramFunctions)comboBoxEditFunctionType.SelectedIndex, 1);
                ChartControl.Series[0].Points.Clear();
                ChartControl.Series[0].Points.AddRange(points);
                ChartControl.Animate();
            }
		}
        protected override void InitControls() {
            base.InitControls();
            this.seriesSelected = ChartControl.Series[0];
            foreach (PolarDiagramFunctions function in Enum.GetValues(typeof(PolarDiagramFunctions)))
                comboBoxEditFunctionType.Properties.Items.Add(function.ToString());
            comboBoxEditFunctionType.SelectedIndex = 2;
        }

	}
}
