using System;
using System.IO;
using DevExpress.Web.Demos;

public partial class SampleDocuments_LeaseVsBuyCalculator : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
        if(!IsPostBack) {
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"SampleDocuments\\CarLeaseVsBuyCalculator.xlsx");
            Spreadsheet.Open(filePath);
        }
    }
}
