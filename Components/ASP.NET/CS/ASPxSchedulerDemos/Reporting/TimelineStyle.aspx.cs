using System;
using DevExpress.XtraScheduler;

public partial class Reporting_TimelineStyle : System.Web.UI.Page {
    DateTime Start { get { return (DateTime)edtStart.Value; } }
    DateTime End { get { return (DateTime)edtEnd.Value; } }

    protected void Page_Load(object sender, EventArgs e) {
        TimelineStyleReport report = new TimelineStyleReport();
        report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter;
        ReportViewer.Report = report;

        InitializeControlValues(report);
        ApplyOptions(report);
    }
    void InitializeControlValues(TimelineStyleReport report) {
        InitializeTimeIntervalControls();
    }
    void InitializeTimeIntervalControls() {
        if(!IsPostBack) {
            this.edtStart.Value = SchedulerDemoUtils.BaseDate;
            this.edtEnd.Value = SchedulerDemoUtils.BaseDate.AddMonths(1);
        }
    }
    void ApplyOptions(TimelineStyleReport report) {
        report.SchedulerAdapter.TimeInterval = new TimeInterval(Start, End);
        report.TimeIntervalCount = (int)cbIntervalCount.Value;
        report.ResourceCount = (int)cbResourceCount.Value;

        switch((int)cbTimeScale.Value) {
            case 0: {
                    report.FirstLevelTimeScale = "Year";
                    report.SecondLevelTimeScale = "Month";
                    break;
                }
            case 1: {
                    report.FirstLevelTimeScale = "Month";
                    report.SecondLevelTimeScale = "Week";
                    break;
                }
            case 2: {
                    report.FirstLevelTimeScale = "Week";
                    report.SecondLevelTimeScale = "Day";
                    break;
                }
        }
    }
}
