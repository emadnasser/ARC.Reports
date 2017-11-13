Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Docs.Demos
Imports DevExpress.Docs.Text
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.Spreadsheet.Functions

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class CustomFunctionModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Private sheet As Worksheet

		Public Sub New()
			InitializeComponent()
			Dim book As IWorkbook = spreadsheetControl1.Document
			GenerateDocument(book)
			sheet = book.Worksheets(0)
			AutoFitColumns()
			AddHandler spreadsheetControl1.CellValueChanged, AddressOf spreadsheetControl1_CellValueChanged
			spreadsheetControl1.Options.Behavior.Selection.MoveActiveCellMode = MoveActiveCellModeOnEnterPress.None
			book.History.Clear()
		End Sub
		Private Sub GenerateDocument(ByVal book As IWorkbook)
			spreadsheetControl1.BeginUpdate()
			Try
				Dim generator As New CustomFunctionDocumentGenerator(book)
				generator.Generate()
			Finally
				spreadsheetControl1.EndUpdate()
			End Try
		End Sub

		Private Sub spreadsheetControl1_CellValueChanged(ByVal sender As Object, ByVal e As SpreadsheetCellEventArgs)
			If e.SheetName = sheet.Name AndAlso e.RowIndex = 3 AndAlso e.ColumnIndex = 2 Then
				AutoFitColumns()
			End If
		End Sub
		Private Sub AutoFitColumns()
			sheet.Columns(2).AutoFit()
			sheet.Columns(4).AutoFit()
		End Sub
	End Class
End Namespace
