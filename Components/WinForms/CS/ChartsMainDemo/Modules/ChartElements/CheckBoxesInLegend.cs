using System;
using System.Collections.Generic;
using System.Drawing;

namespace DevExpress.XtraCharts.Demos.ChartElements {
    public partial class CheckBoxesInLegendDemo : ChartDemoBase {
        const int StripColorAlpha = 55;

        public override ChartControl ChartControl { get { return this.chart; } }

        public CheckBoxesInLegendDemo() {
            InitializeComponent();
            this.chart.DataSource = ChartData.GetData();
        }

        void CreateRegressionLines() {
            for (int i = 0; i < chart.Series.Count; i++) {
                Series series = chart.Series[i];
                XYDiagram2DSeriesViewBase view = (XYDiagram2DSeriesViewBase)series.View;
                RegressionLine regressionLine = new RegressionLine(series.Name + " Trend");
                regressionLine.ShowInLegend = true;
                regressionLine.Color = chart.PaletteRepository[chart.PaletteName][i].Color;
                regressionLine.CheckedInLegend = false;
                view.Indicators.Add(regressionLine);
            }
        }
        void CreateStrips() {
            XYDiagram2D diagram = (XYDiagram2D)chart.Diagram;
            Axis2D axisY = diagram.GetAllAxesY()[0];
            PaletteEntry[] paletteEntries = chart.GetPaletteEntries(this.chart.Series.Count);
            int counter = 0;
            foreach (Series series in chart.Series) {
                double firstValue = series.Points[0].Values[0];
                double minValue = firstValue;
                double maxValue = firstValue;
                foreach (SeriesPoint seriesPoint in series.Points) {
                    if (seriesPoint.Values[0] > maxValue)
                        maxValue = seriesPoint.Values[0];
                    if (seriesPoint.Values[0] < minValue)
                        minValue = seriesPoint.Values[0];
                }
                Strip strip = new Strip(series.Name + " Range", minValue, maxValue);
                Color stripColor = paletteEntries[counter].Color;
                stripColor = Color.FromArgb(StripColorAlpha, stripColor);
                strip.Color = stripColor;
                strip.ShowInLegend = true;
                strip.CheckedInLegend = false;
                axisY.Strips.Add(strip);
                counter++;
            }
        }
        void checkEditUseCheckBoxes_CheckedChanged(object sender, System.EventArgs e) {
            chart.Legend.UseCheckBoxes = !chart.Legend.UseCheckBoxes;
            checkEdit2.Enabled = chart.Legend.UseCheckBoxes;
        }
        void checkEdit2_CheckedChanged(object sender, System.EventArgs e) {
            foreach (Series series in chart.Series) {
                Indicator indicator = ((XYDiagram2DSeriesViewBase)series.View).Indicators[0];
                indicator.CheckableInLegend = !indicator.CheckableInLegend;
            }
        }
        void chart_BoundDataChanged(object sender, EventArgs e) {
            CreateRegressionLines();
            CreateStrips();
        }
    }

    class ChartData {
        public class ChartDataItem {
            public string Series { get; private set; }
            public DateTime Year { get; private set; }
            public double Value { get; private set; }
            public ChartDataItem(string series, DateTime year, double value) {
                this.Series = series;
                this.Year = year;
                this.Value = value;
            }
        }

        public static List<ChartDataItem> GetData() {
            int itemsCount = 6;
            double[] values = { 46900D, 43658D, 42658D, 41235D, 42568D, 41888D, 68953D, 67456D, 67986D, 65326D, 63255D, 60223D, 10569D, 15786D, 19300D, 18756D, 18749D, 20112D, 65897D, 62102D, 61325D, 55400D, 62359D, 65212D, 45356D, 46893D, 50326D, 43268D, 43265D, 63262D };
            string[] series = { "Beverages", "Dairy Products", "Ice Cream", "Refrigerated Meat", "Sausage" };
            DateTime currentDate = DateTime.Now;
            List<ChartDataItem> data = new List<ChartDataItem>();
            for (int s = 0; s < series.Length; s++)
                for (int d = 0; d < itemsCount; d++)
                    data.Add(new ChartDataItem(series[s], currentDate.AddYears(-d), values[(s * itemsCount + d) % values.Length]));
            return data;
        }
    }
}
