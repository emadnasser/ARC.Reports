using System;
using DevExpress.XtraScheduler;

public partial class Reporting_MonthlyStyle : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {        
        MonthlyStyleReport report = new MonthlyStyleReport();
        report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter;
        report.SchedulerAdapter.TimeInterval = new TimeInterval(SchedulerDemoUtils.BaseDate, SchedulerDemoUtils.BaseDate.AddMonths(1));

        ReportViewer.Report = report;
        ApplyOptions(report);
	}

    void ApplyOptions(MonthlyStyleReport report) {
        report.CompressWeekEnd = chkCompressWeekend.Checked;
        report.DontPrintWeekends = chkDontPrintWeekends.Checked;
        report.PrintExactlyOneMonth = chkExactlyOneMonth.Checked;
        report.ResourceCount = (int)cbResourceCount.Value;
        report.ColumnCount = (int)cbLayout.Value;

    }
}
