using System;
using DevExpress.XtraScheduler;

public partial class Reporting_DailyStyle : System.Web.UI.Page {
    DateTime Start { get { return (DateTime)edtStart.Value; } }
    DateTime End { get { return (DateTime)edtEnd.Value; } }
    protected void Page_Load(object sender, EventArgs e) {        
        DailyStyleReport report = new DailyStyleReport();
        report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter;
        ReportViewer.Report = report;

        InitializeControlValues();
        ApplyOptions(report);
    }
    void InitializeControlValues() {
        if (!IsPostBack) {            
            this.edtStart.Value = SchedulerDemoUtils.BaseDate;
            this.edtEnd.Value = SchedulerDemoUtils.BaseDate.AddDays(10);
        }
    }    
    void ApplyOptions(DailyStyleReport report) {
        report.SchedulerAdapter.TimeInterval = new TimeInterval(Start, End);

        report.DayCount = (int)cbDayCount.Value;
        report.ResourceCount = (int)cbResourceCount.Value;
        report.TimeScale = TimeSpan.FromMinutes((int)cbTimeScale.Value);
        report.PrintAllAppointments = chkPrintAllAppointments.Checked;
    }
}
