Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Demos

Partial Public Class API_CellStyle
	Inherits OfficeDemoPage
	Private worksheet As Worksheet

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
		If (Not IsPostBack) Then
			worksheet = Spreadsheet.Document.Worksheets(0)
			Dim cell As Cell = worksheet.Cells("B1")
			cell.Value = "Test"
			cell.Select()
			FormatCell(cell)
			FormatBorders()
			Spreadsheet.Document.History.Clear()
		End If
	End Sub

	Private Sub FormatCell(ByVal cell As Cell)
		' Specify font settings (font name, color, size and style).
		cell.Font.Name = "MV Boli"
		cell.Font.Color = Color.Blue
		cell.Font.Size = 14
		cell.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold

		' Specify cell background color.
		cell.Fill.BackgroundColor = Color.LightSkyBlue

		' Specify text alignment in the cell. 
		cell.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
		cell.Alignment.Horizontal = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment.Center
	End Sub
	Private Sub FormatBorders()
		' Set all borders for the range of cells in one step.
		Dim rangeB8F13 As Range = worksheet.Range("B8:F13")
		rangeB8F13.Borders.SetAllBorders(Color.Green, BorderLineStyle.Double)

		' Set all inside and outside borders separately for the range of cells.
		Dim rangeI6L10 As Range = worksheet.Range("I6:L10")
		rangeI6L10.SetInsideBorders(Color.SkyBlue, BorderLineStyle.MediumDashed)
		rangeI6L10.Borders.SetOutsideBorders(Color.DeepSkyBlue, BorderLineStyle.Medium)

		' Set all horizontal and vertical borders separately for the range of cells.
		Dim rangeC3E5 As Range = worksheet.Range("C3:E5")
		Dim rangeC3C5Formatting As Formatting = rangeC3E5.BeginUpdateFormatting()
		Dim rangeC3C5Borders As Borders = rangeC3C5Formatting.Borders
		rangeC3C5Borders.InsideHorizontalBorders.LineStyle = BorderLineStyle.MediumDashDot
		rangeC3C5Borders.InsideHorizontalBorders.Color = Color.DarkBlue
		rangeC3C5Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.MediumDashDotDot
		rangeC3C5Borders.InsideVerticalBorders.Color = Color.Blue
		rangeC3E5.EndUpdateFormatting(rangeC3C5Formatting)
	End Sub
End Class
