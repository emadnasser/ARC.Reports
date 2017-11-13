using System;
using System.IO;
using DevExpress.Web.Demos;

public partial class Features_Printing : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            SpreadsheetDemoUtils.HideAllTabsExceptFileAndPageLayout(Spreadsheet);
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "TrendlineAnalysis_template.xlsx");
            Spreadsheet.Open(filePath);
        }
    }
}
