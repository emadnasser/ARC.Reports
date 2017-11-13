using System;
using DevExpress.XtraScheduler;

public partial class Reporting_WeeklyStyle : System.Web.UI.Page {
    DateTime Start { get { return (DateTime)edtStart.Value; } }
    DateTime End { get { return (DateTime)edtEnd.Value; } }

    protected void Page_Load(object sender, EventArgs e) {
        WeeklyStyleReport report = new WeeklyStyleReport();
        report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter;

        ReportViewer.Report = report;
        InitializeControlValues();
        ApplyOptions(report);
    }
    void InitializeControlValues() {
        if(!IsPostBack) {
            this.edtStart.Value = SchedulerDemoUtils.BaseDate;
            this.edtEnd.Value = SchedulerDemoUtils.BaseDate.AddDays(14);
        }
    }
    void ApplyOptions(WeeklyStyleReport report) {
        report.SchedulerAdapter.TimeInterval = new TimeInterval(Start, End);
        report.ResourceCount = (int)cbResourceCount.Value;
        report.ColumnCount = (int)cbLayout.Value;
    }
}
