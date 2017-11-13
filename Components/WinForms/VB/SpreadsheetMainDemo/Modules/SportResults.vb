Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports System.Globalization
Imports DevExpress.Spreadsheet.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class SportResultsModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Public Sub New()
			InitializeComponent()
			Me.spreadsheetControl1.Options.Culture = DefaultCulture
			Dim book As IWorkbook = spreadsheetControl1.Document
			GenerateDocument(book)
			book.History.Clear()
		End Sub
		Private Sub GenerateDocument(ByVal book As IWorkbook)
			spreadsheetControl1.BeginUpdate()
			Try
				Dim generator As New SportResultsDocumentGenerator(book)
				generator.Generate()
			Finally
				spreadsheetControl1.EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
