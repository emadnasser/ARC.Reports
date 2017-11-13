Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.Docs.Demos
Imports DevExpress.Spreadsheet

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class ShiftScheduleModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Private book As IWorkbook
		Private culture As CultureInfo
		Private generator As ShiftScheduleGenerator

		Public Sub New()
			Me.culture = DefaultCulture
			InitializeComponent()
			Me.spreadsheetControl1.Options.Culture = culture
			spreadsheetControl1.BeginUpdate()
			book = spreadsheetControl1.Document
			generator = New ShiftScheduleGenerator(book)
			book = generator.Generate()
			spreadsheetControl1.EndUpdate()
			spreadsheetControl1.Document.History.Clear()
		End Sub
	End Class
End Namespace
