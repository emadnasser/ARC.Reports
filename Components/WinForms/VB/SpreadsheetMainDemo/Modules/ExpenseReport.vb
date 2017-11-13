Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Docs.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class ExpenseReportModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Private book As IWorkbook
		Private culture As CultureInfo
		Private generator As ExpenseReportDocumentGenerator

		Public Sub New()
			Me.culture = DefaultCulture
			InitializeComponent()
			Me.spreadsheetControl1.Options.Culture = culture
			spreadsheetControl1.BeginUpdate()
			book = spreadsheetControl1.Document
			generator = New ExpenseReportDocumentGenerator(book)
			book = generator.Generate()
			spreadsheetControl1.EndUpdate()
			spreadsheetControl1.Document.History.Clear()
		End Sub
	End Class
End Namespace
