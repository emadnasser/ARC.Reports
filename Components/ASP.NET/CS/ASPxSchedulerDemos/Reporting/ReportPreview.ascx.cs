using System;
using DevExpress.Web.ASPxScheduler.Reporting;
using DevExpress.XtraScheduler.Reporting;

public partial class Reporting_ReportPreview : System.Web.UI.UserControl {
    string reportTemplateFileName;
    ASPxSchedulerControlPrintAdapter controlAdapter;

    public string ReportTemplateFileName { get { return reportTemplateFileName; } set { reportTemplateFileName = value; } }
    public ASPxSchedulerControlPrintAdapter ControlAdapter { get { return controlAdapter; } set { controlAdapter = value; } }

    protected void Page_Load(object sender, EventArgs e) {
        XtraSchedulerReport rpt = new XtraSchedulerReport();
        rpt.LoadLayout(Page.MapPath("~/App_Data/" + ReportTemplateFileName));
        rpt.SchedulerAdapter = ControlAdapter.SchedulerAdapter;
        ReportViewer.Report = rpt;
    }
}
