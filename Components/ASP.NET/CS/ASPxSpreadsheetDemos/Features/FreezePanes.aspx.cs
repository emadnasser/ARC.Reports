using System;
using System.IO;
using System.Web.UI;
using DevExpress.Spreadsheet;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class Features_FreezePanes : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!Page.IsPostBack) {
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "EmployeeInformation.xlsx");
            Spreadsheet.Open(filePath);
        }
        SpreadsheetDemoUtils.HideAllTabsExceptHomeAndView(Spreadsheet);
    }
}
