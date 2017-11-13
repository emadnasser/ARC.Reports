using System;
using System.Web.UI;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Reporting;

public partial class Reporting_AutoHeight : Page {

    protected void Page_Load(object sender, EventArgs e) {
        InitializeControlValues();

        XtraSchedulerReport report = CreateReport();
        report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter;
        report.SchedulerAdapter.TimeInterval = new TimeInterval(new DateTime(2016, 10, 10), TimeSpan.FromDays(14));
        ReportViewer.Report = report;
        ApplyOptions(report);

    }
    void InitializeControlValues() {
        if(!IsPostBack) {
            this.rbView.Value = 0;
        }
    }
    XtraSchedulerReport CreateReport() {
        if((int)rbView.Value == 0)
            return new AutoHeightMonth();
        else
            return new AutoHeightTimeline();
    }
    void ApplyOptions(XtraSchedulerReport report) {
        IAutoHeightReport autoHeightReport = (IAutoHeightReport)report;
        autoHeightReport.CellsCanGrow = chkCanGrow.Checked;
        autoHeightReport.CellsCanShrink = chkCanShrink.Checked;
        autoHeightReport.CellsHeight = (float)(spinHeight.Number);
    }
}
