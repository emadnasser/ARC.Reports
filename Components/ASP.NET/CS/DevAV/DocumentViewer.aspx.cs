using System;

public partial class DocumentViewer : System.Web.UI.Page {
    const string LoadReportArgsKey = "ReportArgs";
    protected void Page_Load(object sender, EventArgs e) {
        var report = DemoUtils.CreateReport(Request.QueryString[LoadReportArgsKey]);
        if(report != null)
            DocumentViewerControl.Report = report;
    }
}
