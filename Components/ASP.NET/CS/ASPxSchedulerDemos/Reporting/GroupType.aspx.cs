using System;
using DevExpress.XtraScheduler;

public partial class Reporting_GroupType : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

        GroupTypeReport report = new GroupTypeReport();
        report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter;
        report.SchedulerAdapter.TimeInterval = new TimeInterval(SchedulerDemoUtils.BaseDate, SchedulerDemoUtils.BaseDate.AddMonths(2));

        ReportViewer.Report = report;
        ApplyOptions(report);

    }

    void ApplyOptions(GroupTypeReport report) {
        report.GroupType = (SchedulerGroupType)rbGroupType.Value;
    }
}
