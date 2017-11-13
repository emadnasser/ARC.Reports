using System;
using System.Web.UI;
using DevExpress.XtraScheduler;

public partial class ReportTemplates : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        /*
            The following code utilizes the DataHelper class, which is implemented
            solely for the ASPxScheduler Demo project.
            It is intended to hide unnecessary details and clarify the main idea.
            For the recommended data binding techniques, please refer to the
            Data Binding section modules:
              ~/DataBinding/BoundMode.aspx for MS Access database
              ~/DataBinding/ListBoundMode.aspx for the object with IBindingList interface.
              ~/DataBinding/XPOBoundMode.aspx for XPO data framework.
        */
        SchedulerDemoUtils.ApplyDefaults(this, ASPxScheduler1);
        DataHelper.SetupCustomEventsMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource);
        DataSource1.AttachTo(ASPxScheduler1);

        if(!IsPostBack) {
            TimeInterval interval = ASPxScheduler1.ActiveView.GetVisibleIntervals().Interval;
            ASPxDateEdit1.Date = interval.Start;
            ASPxDateEdit2.Date = interval.End;
        }
        PrepareReportPreview(PreviewPanel);

    }
    protected void ASPxCallbackPanel1_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e) {
        PreviewPanel.Visible = true;
    }
    void PrepareReportPreview(Control cp) {
        ASPxSchedulerControlPrintAdapter1.TimeInterval = GetPrintTimeInterval();

        Reporting_ReportPreview reportPreview = (Reporting_ReportPreview)Page.LoadControl("ReportPreview.ascx");
        reportPreview.ControlAdapter = ASPxSchedulerControlPrintAdapter1;
        string reportName = ReportTemplateCombo.Text;
        reportPreview.ReportTemplateFileName = "SchedulerReportTemplates\\" + reportName;


        ASPxSchedulerControlPrintAdapter1.EnableSmartSync = reportName.ToLower().Contains("trifold");

        cp.Controls.Clear();
        cp.Controls.Add(reportPreview);
    }
    TimeInterval GetPrintTimeInterval() {
        DateTime start = ASPxDateEdit1.Date;
        DateTime end = ASPxDateEdit2.Date;
        return (start <= end) ? new TimeInterval(start, end) : new TimeInterval(end, start);
    }

}
