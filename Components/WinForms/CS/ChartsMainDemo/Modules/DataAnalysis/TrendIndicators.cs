using DevExpress.XtraEditors;
using System;
using System.Globalization;

namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    public partial class TrendIndicatorsDemo : ChartDemoBase2D {
        public override ChartControl ChartControl { get { return chart; } }
        public override bool AnimateChartControlOnDemoAppear { get { return false; } }

        public TrendIndicatorsDemo() {
            InitializeComponent();
            try {
                this.chart.DataSource = CsvReader.ReadFinancialData("USDJPYDaily.csv");
            }
            catch (Exception e) {
                XtraMessageBox.Show(LookAndFeel.ActiveLookAndFeel, e.Message, "Data Loading Error");
            }
            var diagram = (XYDiagram)this.chart.Diagram;
            var minValue = new DateTime(2014, 7, 1);
            var maxValue = new DateTime(2014, 12, 31);
            diagram.AxisX.WholeRange.SetMinMaxValues(minValue, maxValue);
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day;
            diagram.AxisX.WholeRange.SideMarginsValue = 0.7;
        }

        double CalculateOffsetToMonday() {
            var currentDayOfWeekIndex = (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
            return ((int)DayOfWeek.Monday) - currentDayOfWeekIndex;
        }
    }
}
