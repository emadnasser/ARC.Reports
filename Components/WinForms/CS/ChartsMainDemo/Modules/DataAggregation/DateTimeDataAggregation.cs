using System;
using System.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.DataAggregation {
    public partial class DateTimeDataAggregationDemo : ChartDemoBase {
        const int PointCount = 50000;

        Series Series { get { return chart.Series.Count > 0 ? chart.Series[0] : null; } }
        XYDiagram Diagram { get { return chart.Diagram as XYDiagram; } }

        public override ChartControl ChartControl { get { return chart; } }
        public override bool AnimateChartControlOnDemoAppear { get { return false; } }

        public DateTimeDataAggregationDemo() {
            InitializeComponent();
        }

        void LoadPoints() {
            if (Series != null) {
                double value = 0;
                DateTime argument = DateTime.Now.AddDays(-PointCount);
                Random random = new Random();
                Series.Points.BeginUpdate();
                Series.Points.Clear();
                for (double i = 0; i < PointCount; i++) {
                    Series.Points.Add(new SeriesPoint(argument.AddDays(i), Math.Abs(value)));
                    value += (random.NextDouble() * 10.0 - 5.0);
                }
                Series.Points.EndUpdate();
            }
        }

        protected override void InitControls() {
            base.InitControls();
            using (WaitDialogForm dlg = new WaitDialogForm("Please Wait", "Loading Data...", new Size(200, 50), ParentForm)) {
                LoadPoints();
            }
        }
    }
}
