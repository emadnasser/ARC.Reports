using System;
using DevExpress.Web;
using DevExpress.Web.Office;

public partial class Spreadsheet : System.Web.UI.Page {
    const string LoadReportArgsKey = "ReportArgs";

    protected void Page_Load(object sender, EventArgs e) {
        if(DemoUtils.IsSiteMode) {
            SpreadsheetControl.CreateDefaultRibbonTabs(true);
            SpreadsheetControl.RibbonTabs.RemoveAt(0);
        }
        DemoUtils.ClearSpreadsheetTempFolder();
        if(!IsPostBack)
            LoadSpreadsheetDocument();
    }

    protected void LoadSpreadsheetDocument() {
        var report = DemoUtils.CreateReport(Request.QueryString[LoadReportArgsKey]);
        if(report == null)
            return;
        DemoUtils.LoadSpreadsheetFile(filePath => {
            report.ExportToXlsx(filePath);
            SpreadsheetControl.Open(filePath);
        });
    }

    protected void SpreadsheetControl_Callback(object sender, CallbackEventArgsBase e) {
        if(e.Parameter == "Close")
            DocumentManager.CloseDocument(SpreadsheetControl.DocumentId);
    }
}
