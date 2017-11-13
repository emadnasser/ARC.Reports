using System;
using System.IO;
using System.Web.UI;
using DevExpress.Web.Demos;

public partial class Features_DataValidation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack) {
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "DataValidation.xlsx");
            Spreadsheet.Open(filePath);
        }
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
        SpreadsheetDemoUtils.HideFormulasTab(Spreadsheet);
        SpreadsheetDemoUtils.HidePageLayoutTab(Spreadsheet);
    }
}
