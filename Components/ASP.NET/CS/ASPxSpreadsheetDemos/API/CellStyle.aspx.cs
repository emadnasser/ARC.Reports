using System;
using System.Drawing;
using DevExpress.Spreadsheet;
using DevExpress.Web.Demos;

public partial class API_CellStyle : OfficeDemoPage {
    Worksheet worksheet;

    protected void Page_Load(object sender, EventArgs e) {
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
        if(!IsPostBack) {
            worksheet = Spreadsheet.Document.Worksheets[0];
            Cell cell = worksheet.Cells["B1"];
            cell.Value = "Test";
            cell.Select();
            FormatCell(cell);
            FormatBorders();
            Spreadsheet.Document.History.Clear();
        }
    }

    void FormatCell(Cell cell) {
        // Specify font settings (font name, color, size and style).
        cell.Font.Name = "MV Boli";
        cell.Font.Color = Color.Blue;
        cell.Font.Size = 14;
        cell.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold;

        // Specify cell background color.
        cell.Fill.BackgroundColor = Color.LightSkyBlue;

        // Specify text alignment in the cell. 
        cell.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
        cell.Alignment.Horizontal = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment.Center;
    }
    void FormatBorders() {
        // Set all borders for the range of cells in one step.
        Range rangeB8F13 = worksheet.Range["B8:F13"];
        rangeB8F13.Borders.SetAllBorders(Color.Green, BorderLineStyle.Double);

        // Set all inside and outside borders separately for the range of cells.
        Range rangeI6L10 = worksheet.Range["I6:L10"];
        rangeI6L10.SetInsideBorders(Color.SkyBlue, BorderLineStyle.MediumDashed);
        rangeI6L10.Borders.SetOutsideBorders(Color.DeepSkyBlue, BorderLineStyle.Medium);

        // Set all horizontal and vertical borders separately for the range of cells.
        Range rangeC3E5 = worksheet.Range["C3:E5"];
        Formatting rangeC3C5Formatting = rangeC3E5.BeginUpdateFormatting();
        Borders rangeC3C5Borders = rangeC3C5Formatting.Borders;
        rangeC3C5Borders.InsideHorizontalBorders.LineStyle = BorderLineStyle.MediumDashDot;
        rangeC3C5Borders.InsideHorizontalBorders.Color = Color.DarkBlue;
        rangeC3C5Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.MediumDashDotDot;
        rangeC3C5Borders.InsideVerticalBorders.Color = Color.Blue;
        rangeC3E5.EndUpdateFormatting(rangeC3C5Formatting);
    }
}
