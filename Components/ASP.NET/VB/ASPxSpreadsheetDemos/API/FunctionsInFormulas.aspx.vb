Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Demos

Partial Public Class API_FunctionsInFormulas
	Inherits OfficeDemoPage
	Private worksheet As Worksheet

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
		If (Not IsPostBack) Then
			worksheet = Spreadsheet.Document.Worksheets(0)
			PrepareHeaderCells()
			ProvideStaticDataForFunctions()
			FillCellsWithFormulas()
			FormatCellsValues()
			worksheet.Range("B1:C1").AutoFitColumns()
			Spreadsheet.Document.History.Clear()
		End If
	End Sub

	Private Sub PrepareHeaderCells()
		Dim header As Range = worksheet.Range("A1:C1")
		header(0).Value = "Data:"
		header(1).Value = "Formula text:"
		header(2).Value = "Formula result:"
		header.Style = worksheet.Workbook.Styles("Heading 2")
		worksheet("A1:A7").Alignment.Indent = 1
	End Sub
	Private Sub ProvideStaticDataForFunctions()
		worksheet.Cells("A2").Value = 15
		worksheet.Range("A3:A5").Value = 3
		worksheet.Cells("A6").Value = 20
		worksheet.Cells("A7").Value = 15.12345
	End Sub
	Private Sub FillCellsWithFormulas()
		' If a number in cell A2 is less than 10, the formula returns "Normal" 
		' and this text is displayed in cell B2. Otherwise, cell B2 displays "Excess".
		worksheet.Cells("C2").Formula = "= IF(A2<10, ""Normal"", ""Excess"")"

		' Calculate an average value of cell values of the "A2:A7" range.
		worksheet.Cells("C3").Formula = "=AVERAGE(A2:A7)"

		' Add values contained in cells A3 through A5, then add the value contained in cell A6, 
		' and then add 100 to that result.
		worksheet.Cells("C4").Formula = "=SUM(A3:A5,A6,100)"

		' Use a nested function in a formula. 
		' Round the sum of the values contained in cells A6 and A7 to two decimal places.
		worksheet.Cells("C5").Formula = "=ROUND(SUM(A6,A7),2)"

		' Add the current date to cell B6.
		worksheet.Cells("C6").Formula = "= Today()"
		worksheet.Cells("C6").NumberFormat = "m/d/yy"

		' Convert the specified text to uppercase.
		worksheet.Cells("C7").Formula = "=UPPER(""formula"")"
	End Sub
	Private Sub FormatCellsValues()
		Dim rangeWithFormulas As Range = worksheet.Range("C2:C7")
		Dim rangeWithFormulaDescription As Range = worksheet.Range("B2:B7")

		For index As Integer = rangeWithFormulas.RowCount - 1 To 0 Step -1
			rangeWithFormulaDescription(index).Value = "'" & rangeWithFormulas(index).Formula
		Next index
	End Sub
End Class
