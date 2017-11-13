using System;
using System.IO;
using DevExpress.Web.Demos;

public partial class SampleDocuments_ProfitAndLoss : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);

        if(!IsPostBack) {
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"SampleDocuments\\ProfitAndLoss.xlsx");
            Spreadsheet.Open(filePath);
        }
    }
}
