using System;
using System.Drawing;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;

public partial class Trendlines : ChartBasePage {
    XYDiagramSeriesViewBase View { get { return (XYDiagramSeriesViewBase)WebChartControl1.Series[0].View; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            FillDefaultTrendlines();
        }
    }
    void FillDefaultTrendlines() {
        TrendLine trendline1 = new TrendLine("Trendline 2");
        trendline1.Point1.Argument = new DateTime(2016, 4, 15);
        trendline1.Point1.ValueLevel = ValueLevel.High;
        trendline1.Point2.Argument = new DateTime(2016, 6, 12);
        trendline1.Point2.ValueLevel = ValueLevel.High;
        trendline1.ExtrapolateToInfinity = false;
        View.Indicators.Add(trendline1);

        TrendLine trendline2 = new TrendLine("Trendline 1");
        trendline2.Point1.Argument = new DateTime(2016, 6, 23);
        trendline2.Point1.ValueLevel = ValueLevel.High;
        trendline2.Point2.Argument = new DateTime(2016, 10, 11);
        trendline2.Point2.ValueLevel = ValueLevel.High;
        View.Indicators.Add(trendline2);

        TrendLine trendline3 = new TrendLine("Trendline 3");
        trendline3.Point1.Argument = new DateTime(2016, 3, 20);
        trendline3.Point1.ValueLevel = ValueLevel.Low;
        trendline3.Point2.Argument = new DateTime(2016, 5, 13);
        trendline3.Point2.ValueLevel = ValueLevel.Low;
        trendline3.ExtrapolateToInfinity = false;
        View.Indicators.Add(trendline3);

        TrendLine trendline4 = new TrendLine("Trendline 4");
        trendline4.Point1.Argument = new DateTime(2016, 6, 27);
        trendline4.Point1.ValueLevel = ValueLevel.Low;
        trendline4.Point2.Argument = new DateTime(2016, 10, 31);
        trendline4.Point2.ValueLevel = ValueLevel.Low;
        View.Indicators.Add(trendline4);
    }
}
