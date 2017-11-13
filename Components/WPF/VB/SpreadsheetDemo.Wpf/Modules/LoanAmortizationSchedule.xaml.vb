Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports DevExpress.Docs.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.Xpf.Core

Namespace SpreadsheetDemo
    Partial Public Class LoanAmortizationSchedule
        Inherits SpreadsheetDemoModule

        Private book As IWorkbook
        Private generator As LoanAmortizationScheduleDocumentGenerator

        Public Sub New()
            InitializeComponent()
            Me.spreadsheetControl.Options.Culture = DefaultCulture
            InitializeDocument()
            Me.spreadsheetControl.Document.History.Clear()
        End Sub

        Private ReadOnly Property ShouldUseAnnuityPayments() As Boolean
            Get
                Return If(rbAnnuityPayments.IsChecked.HasValue, rbAnnuityPayments.IsChecked.Value, False)
            End Get
        End Property

        Private Sub InitializeDocument()
            spreadsheetControl.BeginUpdate()
            book = spreadsheetControl.Document
            generator = New LoanAmortizationScheduleDocumentGenerator(book)
            generator.AnnuityPayments = ShouldUseAnnuityPayments
            generator.Generate()
            spreadsheetControl.EndUpdate()
        End Sub


        Private Sub RadioButton_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            generator.AnnuityPayments = ShouldUseAnnuityPayments
            spreadsheetControl.BeginUpdate()
            generator.Generate()
            spreadsheetControl.EndUpdate()
        End Sub

        Private Sub spreadsheetControl_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs)
            If (e.ColumnIndex = 4) AndAlso ((e.RowIndex >= 3) AndAlso (e.RowIndex <= 8)) Then
                spreadsheetControl.BeginUpdate()
                generator.Generate()
                spreadsheetControl.EndUpdate()
            End If
        End Sub

        Private Sub spreadsheetControl_CellEndEdit(ByVal sender As Object, ByVal e As DevExpress.XtraSpreadsheet.SpreadsheetCellValidatingEventArgs)
            If e.ColumnIndex = 4 AndAlso e.RowIndex = 5 Then
                Dim value As Integer = Nothing
                If (Not Integer.TryParse(e.EditorText, value)) OrElse value < 1 OrElse value > 10 Then
                    DXMessageBox.Show("Please enter a whole number of years from 1 to 10")
                    e.Cancel = True
                End If
            End If
        End Sub
    End Class
End Namespace
