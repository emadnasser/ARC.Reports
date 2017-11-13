using DevExpress.Web;
using DevExpress.Web.Demos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MobileViewer : System.Web.UI.Page
{
    public bool isPollingReport {
        get {
            return Request.QueryString["reportName"] == "XtraReportsDemos.PollingReport.PollingReport";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Header.Title = Utils.GetCurrentDemoPageTitle();
        if(isPollingReport) {
            webDocumentViewer.OpenReport(ReportStorageHelper.LoadReport(Request.QueryString["reportName"], Session));
        }
        else {
            webDocumentViewer1.OpenReport(ReportStorageHelper.LoadReport(Request.QueryString["reportName"], Session));
        }
    }
}
