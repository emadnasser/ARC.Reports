Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Office
Imports DevExpress.Spreadsheet
Imports System.Drawing
Imports SpreadsheetFormatting = DevExpress.Spreadsheet.Formatting
Imports System.Globalization
Imports DevExpress.Spreadsheet.Functions
Imports DevExpress.Docs.Text

Namespace DevExpress.Spreadsheet.Demos
	Public Class HighlightTextDocumentGenerator
		Private book As IWorkbook
		Private path As String

		Public Sub New()
			Me.book = New Workbook()
			InitCultureParams()
		End Sub
		Public Sub New(ByVal book As IWorkbook)
			Me.book = book
			InitCultureParams()
		End Sub
		Private Sub InitCultureParams()
			Dim culture As CultureInfo = CultureInfo.CurrentCulture
			Me.book.Options.Culture = culture
		End Sub
		Public Function Generate(ByVal path As String) As IWorkbook
			Me.path = path
			InitializeBook()
			Return book
		End Function

		Private Sub InitializeBook()
			InitWorkbook()
		End Sub
		Private Sub InitWorkbook()
			book.Unit = DevExpress.Office.DocumentUnit.Point
			book.Styles.DefaultStyle.Font.Name = "Calibri"
			book.Styles.DefaultStyle.Font.Size = 11
			book.LoadDocument(Me.path)
		End Sub
	End Class
End Namespace
