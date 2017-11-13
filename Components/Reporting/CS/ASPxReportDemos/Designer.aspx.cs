using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web;
using DevExpress.XtraReports.Web.Extensions;

public partial class Designer : Page {
    string reportName;

    protected void Page_Init(object sender, EventArgs e) {

        Header.Title = Utils.GetCurrentDemoPageTitle();

        reportName = Request.QueryString["reportName"];
        redirectValue.Value = Request.QueryString["redirectUrl"];
        if(!IsRelativeUrl(redirectValue.Value) || string.IsNullOrEmpty(reportName)) {
            Response.Redirect("~/");
        }

        if(!IsPostBack) {
            reportDesigner.OpenReport(reportName);
        }
    }

    static bool IsRelativeUrl(string url) {
        Uri ignore = null;
        return Uri.TryCreate(url, UriKind.Relative, out ignore);
    }
}

