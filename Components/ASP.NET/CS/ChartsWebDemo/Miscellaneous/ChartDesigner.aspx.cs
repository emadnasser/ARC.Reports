using System;
using System.Data;
using System.IO;
using System.Web.SessionState;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class ChartDesigner : ChartBasePage {

    static void SaveChartToSession(WebChartControl chart, HttpSessionState session) {
        session["ChartLayout"] = chart.SaveToXml();
        session["ChartWidth"] = chart.Width;
        session["ChartHeight"] = chart.Height;
    }

    void CreateChart() {
        Series areaSeries = new Series("Area", ViewType.Bar);
        FillAreaSeries(areaSeries);
        Series populationSeries = new Series("Population", ViewType.Bar);
        FillPopulationSeries(populationSeries);        
        chart.Series.Add(areaSeries);
        chart.Series.Add(populationSeries);
        var diagram = ((XYDiagram)chart.Diagram);
        SecondaryAxisY secondaryYAxis = new SecondaryAxisY("Population Axis");
        secondaryYAxis.Title.Text = "Population estimates";
        secondaryYAxis.Title.Visibility = DefaultBoolean.True;
        secondaryYAxis.Label.TextPattern = "{V:0,,}M";
        diagram.SecondaryAxesY.Add(secondaryYAxis);
        ((BarSeriesView)populationSeries.View).AxisY = secondaryYAxis;
        diagram.AxisY.Title.Text = "Area, km²";
        diagram.AxisY.Title.Visibility = DefaultBoolean.True;
        diagram.AxisY.Label.TextPattern = "{V:0,,}M";
        var title = new ChartTitle() { Text = "Largest Countries <br> by Area and Population" };
        chart.Titles.Add(title);
        chart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
        chart.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside;
        chart.Legend.Direction = LegendDirection.LeftToRight;
        chart.Legend.Border.Visibility = DefaultBoolean.False;
    }
    void FillAreaSeries(Series series) {
        series.Points.Add(new SeriesPoint("Russia", 17098242));
        series.Points.Add(new SeriesPoint("Canada", 9984670));
        series.Points.Add(new SeriesPoint("USA", 9519431));
        series.Points.Add(new SeriesPoint("China", 9596960));
        series.Points.Add(new SeriesPoint("Brazil", 8514877));
        series.Points.Add(new SeriesPoint("Australia", 7692024));
        series.Points.Add(new SeriesPoint("India", 3287263));
        series.Points.Add(new SeriesPoint("Argentina", 2766890));
        series.Points.Add(new SeriesPoint("Kazakhstan", 2724902));
        series.Points.Add(new SeriesPoint("Algeria", 2381740));
    }
    void FillPopulationSeries(Series series) {
        series.Points.Add(new SeriesPoint("Russia", 146267288));
        series.Points.Add(new SeriesPoint("Canada", 35675834));
        series.Points.Add(new SeriesPoint("USA", 321348000));
        series.Points.Add(new SeriesPoint("China", 1366499000));
        series.Points.Add(new SeriesPoint("Brazil", 201009622));
        series.Points.Add(new SeriesPoint("Australia", 23130931));
        series.Points.Add(new SeriesPoint("India", 1220800359));
        series.Points.Add(new SeriesPoint("Argentina", 42610981));
        series.Points.Add(new SeriesPoint("Kazakhstan", 17439271));
        series.Points.Add(new SeriesPoint("Algeria", 38087812));
    }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            if (Session["ChartLayout"] == null) {
                CreateChart();
            }
            else {
                var xmlLayout = (string)Session["ChartLayout"];
                chart.LoadFromXml(xmlLayout);              
            }
        }
    }
    protected void ShowDesignerButton_Click(object sender, EventArgs e) {
        SaveChartToSession(chart, Session);
        Response.Redirect("~/ChartDesignerPage.aspx");
    }

    public override WebChartControl FindWebChartControl() {
        return chart;
    }
}
