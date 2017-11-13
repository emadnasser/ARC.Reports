Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports DevExpress.DXperience.Demos
Imports System.Globalization
Imports DevExpress.Spreadsheet.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class LoanAmortizationScheduleModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Private book As IWorkbook
		Private generator As LoanAmortizationScheduleDocumentGenerator

		Public Sub New()
			InitializeComponent()
			Me.spreadsheetControl1.Options.Culture = DefaultCulture
			InitializeDocument()
			Me.spreadsheetControl1.Document.History.Clear()
		End Sub

		Private Sub InitializeDocument()
			spreadsheetControl1.BeginUpdate()
			book = spreadsheetControl1.Document
			generator = New LoanAmortizationScheduleDocumentGenerator(book)
			generator.Generate()
			spreadsheetControl1.EndUpdate()
		End Sub

		Protected Overrides Sub spreadsheetControl1_CellValueChangedOverride(ByVal sender As Object, ByVal e As SpreadsheetCellEventArgs)
			If generator Is Nothing Then
				Return
			End If

			If (e.ColumnIndex = 4) AndAlso ((e.RowIndex >= 3) AndAlso (e.RowIndex <= 8)) Then
				spreadsheetControl1.BeginUpdate()
				generator.Generate()
				spreadsheetControl1.EndUpdate()
			End If
		End Sub

		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			If radioGroup1.SelectedIndex = 1 Then
				generator.AnnuityPayments = False
			Else
				generator.AnnuityPayments = True
			End If
			spreadsheetControl1.BeginUpdate()
			generator.Generate()
			spreadsheetControl1.EndUpdate()
		End Sub

		Protected Overrides Sub spreadsheetControl1_CellEndEditOverride(ByVal sender As Object, ByVal e As SpreadsheetCellValidatingEventArgs)
			If e.ColumnIndex = 4 AndAlso e.RowIndex = 5 Then
				Dim value As Integer
				If (Not Integer.TryParse(e.EditorText, value)) OrElse value < 1 OrElse value > 10 Then
					System.Windows.Forms.MessageBox.Show("Please enter a whole number of years from 1 to 10")
					e.Cancel = True
				End If
			End If
		End Sub
	End Class
End Namespace
