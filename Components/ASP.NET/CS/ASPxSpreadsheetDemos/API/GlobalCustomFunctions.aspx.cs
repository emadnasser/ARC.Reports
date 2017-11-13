using System;
using System.Collections.Generic;
using System.IO;
using DevExpress.Spreadsheet;
using DevExpress.Web.Demos;

public partial class ServerSideFunctionality_GlobalCustomFunctions : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
        if (!Page.IsPostBack) {
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "DiscountCustomFunction.xlsx");
            Spreadsheet.Open(filePath);
        }
    }
}
