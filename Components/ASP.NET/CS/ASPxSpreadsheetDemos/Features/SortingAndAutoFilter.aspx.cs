using System;
using System.IO;
using System.Web.UI;
using DevExpress.Spreadsheet;
using DevExpress.Web.Demos;

public partial class Features_SortingAndAutoFilter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack) {
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "AutoFilter.xlsx");
            Spreadsheet.Open(filePath);
        }

        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
        SpreadsheetDemoUtils.HideFormulasTab(Spreadsheet);
        SpreadsheetDemoUtils.HidePageLayoutTab(Spreadsheet);
    }
}
