using System;
using System.Globalization;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class GanttSeries : ChartBasePage {
    static readonly DateTime rightAxisLimit = new System.DateTime(2006, 11, 13);

    Series PlannedSeries { get { return WebChartControl1.GetSeriesByName("Planned"); } }
    Series CompletedSeries { get { return WebChartControl1.GetSeriesByName("Completed"); } }
    ConstantLine ProgressLine { get { return ((XYDiagram)WebChartControl1.Diagram).AxisY.ConstantLines[0]; } }
    protected void Page_Load(object sender, EventArgs e) {
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "Palette" || e.Parameter == "Appearance")
            return;
        DateTime date = Convert.ToDateTime(e.Parameter, CultureInfo.InvariantCulture);
        SetProgressState(date);
    }
    void SetProgressState(DateTime dateTime) {
        if (dateTime > rightAxisLimit)
            dateTime = rightAxisLimit;
        CompletedSeries.Points.BeginUpdate();
        CompletedSeries.Points.Clear();
        foreach (SeriesPoint point in PlannedSeries.Points) {
            DateTime plannedStartDate = point.DateTimeValues[0];
            if (System.DateTime.Compare(plannedStartDate, dateTime) >= 0)
                continue;
            DateTime plannedFinishDate = point.DateTimeValues[1];
            DateTime completedFinishDate;
            if (System.DateTime.Compare(dateTime, plannedFinishDate) > 0)
                completedFinishDate = plannedFinishDate;
            else
                completedFinishDate = dateTime;
            CompletedSeries.Points.Add(new SeriesPoint(point.Argument, new DateTime[] { plannedStartDate, completedFinishDate }));
        }
        CompletedSeries.Points.EndUpdate();
        ProgressLine.AxisValue = dateTime;
    }
}
