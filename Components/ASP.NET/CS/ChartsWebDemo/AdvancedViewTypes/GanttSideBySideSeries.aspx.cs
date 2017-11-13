using System;
using System.Globalization;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class GanttSideBySideSeries : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = WebChartControl1.Series[0].LabelsVisibility == DefaultBoolean.True;
        }
    }
    void PerformShowLabelsAction() {
        foreach(Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
    }
    void PerformCustomCallback(CustomCallbackEventArgs e) {
        if (e.Parameter == "Palette" || e.Parameter == "Appearance")
            return;
        string[] parameters = e.Parameter.Split(';');
        string seriesName = parameters[0];
        string argument = parameters[1];
        int valueIndex = Convert.ToInt32(parameters[2]);
        DateTime date = Convert.ToDateTime(parameters[3], CultureInfo.InvariantCulture);
        Series series = WebChartControl1.GetSeriesByName(seriesName);
        if(series == null)
            return;
        for(int i = 0; i < series.Points.Count; i++) {
            SeriesPoint point = series.Points[i];
            if(point.Argument == argument) {
                DateTime[] values = (DateTime[])point.DateTimeValues.Clone();
                values[valueIndex] = date;
                SeriesPoint modifiedPoint = new SeriesPoint(point.Argument, values);
                series.Points.RemoveAt(i);
                series.Points.Insert(i, modifiedPoint);
                return;
            }
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else
            PerformCustomCallback(e);
    }
}
