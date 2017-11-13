using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.Demos;

public partial class SampleDocuments_ExpenseReport : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
        if(!IsPostBack) {
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"SampleDocuments\\ExpenseReport.xlsx");
            Spreadsheet.Open(filePath);
        }
    }
}
