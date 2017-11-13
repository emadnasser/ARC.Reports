Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports DevExpress.Spreadsheet
Imports System.Drawing
Imports System.Globalization

Namespace DevExpress.Docs.Demos
	Public Class SimplifiedMultiplicationTableDocumentGenerator
		Private culture As CultureInfo
		Public Sub New(ByVal culture As CultureInfo)
			Me.culture = culture
		End Sub

		Private privateTableCount As Integer
		Public Property TableCount() As Integer
			Get
				Return privateTableCount
			End Get
			Set(ByVal value As Integer)
				privateTableCount = value
			End Set
		End Property
		Private privateColumnCount As Integer
		Public Property ColumnCount() As Integer
			Get
				Return privateColumnCount
			End Get
			Set(ByVal value As Integer)
				privateColumnCount = value
			End Set
		End Property
		Private privateFitToPage As Boolean
		Public Property FitToPage() As Boolean
			Get
				Return privateFitToPage
			End Get
			Set(ByVal value As Boolean)
				privateFitToPage = value
			End Set
		End Property

		Public Function Generate() As IWorkbook
			Dim book As New Workbook()
			book.Options.Culture = culture
			book.Worksheets(0).DefaultColumnWidthInCharacters = TableCount.ToString().Length + 1
			book.DocumentSettings.R1C1ReferenceStyle = True
			CreateFormula(book)
			book.Worksheets(0).PrintOptions.FitToPage = FitToPage
			Return book
		End Function
		Private Sub CreateFormula(ByVal book As Workbook)
			For i As Integer = 1 To TableCount
				CreateSingleTable(book, i)
			Next i
		End Sub
		Private Sub CreateSingleTable(ByVal book As Workbook, ByVal multiplier As Integer)
			Dim hMultiplier As Integer = If(multiplier Mod ColumnCount = 0, ColumnCount, multiplier Mod ColumnCount)
			Dim vMultiplier As Integer = If(multiplier Mod ColumnCount = 0, CInt(Fix(multiplier / ColumnCount)), CInt(Fix(multiplier / ColumnCount)) + 1)
			Dim startRowIndex As Integer = vMultiplier * 11 - 11
			Dim endRowIndex As Integer = startRowIndex + 9
			Dim startColumnIndex As Integer = hMultiplier * 7 - 7
			Dim endColumnIndex As Integer = startColumnIndex + 4

			Dim range As Range = book.Worksheets(0).Range.FromLTRB(startColumnIndex, startRowIndex, endColumnIndex, endRowIndex)
			range.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin)
			range.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			range.Value = multiplier

			book.Worksheets(0).Range.FromLTRB(startColumnIndex + 1, startRowIndex, startColumnIndex + 1, endRowIndex).Value = "x"
			book.Worksheets(0).Range.FromLTRB(startColumnIndex + 3, startRowIndex, startColumnIndex + 3, endRowIndex).Value = "="

			range = book.Worksheets(0).Range.FromLTRB(startColumnIndex + 4, startRowIndex, startColumnIndex + 4, endRowIndex)
			range.Formula = "=RC[-4]*RC[-2]"
			range.Font.Color = Color.Red

			For i As Integer = startRowIndex To endRowIndex
				book.Worksheets(0).Cells(i, startColumnIndex + 2).Value = i - startRowIndex + 1
			Next i
		End Sub
	End Class
End Namespace
