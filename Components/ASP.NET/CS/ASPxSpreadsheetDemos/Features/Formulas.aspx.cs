using System;
using System.IO;
using System.Web.UI;
using DevExpress.Spreadsheet;
using DevExpress.Web.Demos;

public partial class Features_Formulas: OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
        if(!Page.IsPostBack) {
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"SampleDocuments\\OrderAccounting.xlsx");
            Spreadsheet.Open(filePath);
            Spreadsheet.Document.Worksheets[0].Cells["G3"].Select();

            if(Spreadsheet.Document.Worksheets.Count == 1)
                Spreadsheet.Document.Worksheets.Add();
            Spreadsheet.Document.Worksheets.ActiveWorksheet = Spreadsheet.Document.Worksheets[0];
            SpreadsheetInvoiceHelper.PrepareSpreadsheet(Spreadsheet, 1);
            Spreadsheet.Document.History.Clear();
        }
    }
}
