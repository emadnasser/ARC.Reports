using System;
using System.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.DataAggregation {
    public partial class NumericDataAggregationDemo : ChartDemoBase {
        const int PointCount = 500000;

        Series Series { get { return chart.Series.Count > 0 ? chart.Series[0] : null; } }
        XYDiagram Diagram { get { return chart.Diagram as XYDiagram; } }
        
        public override ChartControl ChartControl { get { return chart; } }
        public override bool AnimateChartControlOnDemoAppear { get { return false; } }

        public NumericDataAggregationDemo() {
            InitializeComponent();
        }

        void LoadPoints() {
            if (Series != null) {
                double value = 0;
                double argument = 0;
                Random random = new Random();
                Series.Points.BeginUpdate();
                Series.Points.Clear();
                for (double i = 0; i < PointCount; i++) {
                    Series.Points.Add(new SeriesPoint(argument, value));
                    value += (random.NextDouble() * 10.0 - 5.0);
                    argument += random.NextDouble();
                }
                Series.Points.EndUpdate();
            }
        }

        protected override void InitControls() {
            base.InitControls();
            using (WaitDialogForm dlg = new WaitDialogForm("Please Wait", "Loading Data...", new Size(200, 50), ParentForm)) {
                LoadPoints();
            }
            Diagram.AxisX.NumericScaleOptions.ScaleMode = ScaleMode.Automatic;
            CrosshairFreePosition crosshairPosition = new CrosshairFreePosition();
            crosshairPosition.DockTarget = ((XYDiagram2D)ChartControl.Diagram).DefaultPane;
            crosshairPosition.DockCorner = DockCorner.LeftTop;
            ChartControl.CrosshairOptions.CommonLabelPosition = crosshairPosition;
            foreach (Series series in chart.Series)
                series.CrosshairLabelPattern = "{A} : {V:F2}";
        }
    }
}
