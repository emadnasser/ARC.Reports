using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class LegendCheckboxesDemo : ChartBasePage {
    const int seriesCount = 5;
    const string indicatorPaletteName = "SameAsChartPaletteIndicatorpalette";
    const int stripColorAlpha = 55;

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            CreteRegressionLines();
            CreateStrips();
        }
    }

    void CreteRegressionLines() {
        foreach (Series series in WebChartControl1.Series) {
            XYDiagram2DSeriesViewBase view = (XYDiagram2DSeriesViewBase)series.View;
            RegressionLine regressionLine = new RegressionLine(series.Name + " Trend");
            regressionLine.ShowInLegend = true;
            regressionLine.Color = series.View.Color;
            regressionLine.CheckedInLegend = false;
            view.Indicators.Add(regressionLine);
        }
    }
    void CreateStrips() {
        XYDiagram2D diagram = (XYDiagram2D)WebChartControl1.Diagram;
        Axis2D axisY = diagram.GetAllAxesY()[0];
        PaletteEntry[] paletteEntries = WebChartControl1.GetPaletteEntries(seriesCount);
        int counter = 0;
        foreach (Series series in WebChartControl1.Series) {
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
            stripColor = Color.FromArgb(stripColorAlpha, stripColor);
            strip.Color = stripColor;
            strip.ShowInLegend = true;
            strip.CheckedInLegend = false;
            axisY.Strips.Add(strip);
            counter++;
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ChangeUseCheckboxes")
            WebChartControl1.Legend.UseCheckBoxes = !WebChartControl1.Legend.UseCheckBoxes;
        else if (e.Parameter == "ChangeIndicatorsCheckability")
            foreach (Series series in WebChartControl1.Series) {
                Indicator indicator = ((XYDiagram2DSeriesViewBase)series.View).Indicators[0];
                indicator.CheckableInLegend = !indicator.CheckableInLegend;
            }
    }
}
