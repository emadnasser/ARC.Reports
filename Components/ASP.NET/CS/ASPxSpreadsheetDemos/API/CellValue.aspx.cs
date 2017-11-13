using System;
using System.Drawing;
using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.Web.Demos;

public partial class API_CellValue : OfficeDemoPage {
    Worksheet worksheet;

    protected void Page_Load(object sender, EventArgs e) {
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
        if(!IsPostBack) {
            worksheet = Spreadsheet.Document.Worksheets[0];
            PrepareTitleRange();
            PrepareHeaderCells();
            InitializeDataCellsValues();
            Spreadsheet.Document.Options.Culture = CultureInfo.InvariantCulture;
            Spreadsheet.Document.History.Clear();
        }
    }

    void PrepareTitleRange() {
        worksheet.Cells["B1"].FillColor = Color.LightBlue;
        worksheet.Cells["B1"].Value = "Cell value types";
        Range range = worksheet.Range["A1:B1"];
        range.Style = worksheet.Workbook.Styles["Title"];
        range.Merge();
    }
    void PrepareHeaderCells() {
        Range header = worksheet.Range["A2:B2"];
        header[0].Value = "Type";
        header[1].Value = "Value";
        header.ColumnWidthInCharacters = 25;
        header.Style = worksheet.Workbook.Styles["Heading 2"];
    }
    void InitializeDataCellsValues() {
        // Add data of different types to cells.
        worksheet.Cells["B3"].Value = DateTime.Now;
        worksheet.Cells["B4"].Value = Math.PI;
        worksheet.Cells["B5"].Value = "Have a nice day!";
        worksheet.Cells["B6"].Value = CellValue.ErrorReference;
        worksheet.Cells["B7"].Value = true;
        worksheet.Cells["B8"].Value = float.MaxValue;
        worksheet.Cells["B9"].Value = 'a';
        worksheet.Cells["B10"].Value = Int32.MaxValue;

        worksheet.Cells["A3"].Value = "dateTime";
        worksheet.Cells["A4"].Value = "double";
        worksheet.Cells["A5"].Value = "string";
        worksheet.Cells["A6"].Value = "error constant";
        worksheet.Cells["A7"].Value = "boolean";
        worksheet.Cells["A8"].Value = "float";
        worksheet.Cells["A9"].Value = "char";
        worksheet.Cells["A10"].Value = "int32";
        worksheet.Cells["A13"].Value = "fill range";

        // Fill all cells of the range with 10.
        worksheet.Range["B13:C13"].Value = 10;
    }
}
