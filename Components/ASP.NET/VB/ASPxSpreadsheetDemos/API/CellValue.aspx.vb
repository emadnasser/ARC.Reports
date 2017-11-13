Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Demos

Partial Public Class API_CellValue
	Inherits OfficeDemoPage
	Private worksheet As Worksheet

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
		If (Not IsPostBack) Then
			worksheet = Spreadsheet.Document.Worksheets(0)
			PrepareTitleRange()
			PrepareHeaderCells()
			InitializeDataCellsValues()
			Spreadsheet.Document.Options.Culture = CultureInfo.InvariantCulture
			Spreadsheet.Document.History.Clear()
		End If
	End Sub

	Private Sub PrepareTitleRange()
		worksheet.Cells("B1").FillColor = Color.LightBlue
		worksheet.Cells("B1").Value = "Cell value types"
		Dim range As Range = worksheet.Range("A1:B1")
		range.Style = worksheet.Workbook.Styles("Title")
		range.Merge()
	End Sub
	Private Sub PrepareHeaderCells()
		Dim header As Range = worksheet.Range("A2:B2")
		header(0).Value = "Type"
		header(1).Value = "Value"
		header.ColumnWidthInCharacters = 25
		header.Style = worksheet.Workbook.Styles("Heading 2")
	End Sub
	Private Sub InitializeDataCellsValues()
		' Add data of different types to cells.
		worksheet.Cells("B3").Value = DateTime.Now
		worksheet.Cells("B4").Value = Math.PI
		worksheet.Cells("B5").Value = "Have a nice day!"
		worksheet.Cells("B6").Value = CellValue.ErrorReference
		worksheet.Cells("B7").Value = True
		worksheet.Cells("B8").Value = Single.MaxValue
		worksheet.Cells("B9").Value = "a"c
		worksheet.Cells("B10").Value = Int32.MaxValue

		worksheet.Cells("A3").Value = "dateTime"
		worksheet.Cells("A4").Value = "double"
		worksheet.Cells("A5").Value = "string"
		worksheet.Cells("A6").Value = "error constant"
		worksheet.Cells("A7").Value = "boolean"
		worksheet.Cells("A8").Value = "float"
		worksheet.Cells("A9").Value = "char"
		worksheet.Cells("A10").Value = "int32"
		worksheet.Cells("A13").Value = "fill range"

		' Fill all cells of the range with 10.
		worksheet.Range("B13:C13").Value = 10
	End Sub
End Class
