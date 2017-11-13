Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports DevExpress.Docs.Demos
Imports DevExpress.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class ExpenseReport
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            Initialize()
        End Sub

        Private Sub Initialize()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.BeginUpdate()
            Dim book As IWorkbook = spreadsheetControl1.Document
            Dim generator As New ExpenseReportDocumentGenerator(book)
            book = generator.Generate()
            spreadsheetControl1.EndUpdate()
            spreadsheetControl1.Document.History.Clear()
            ribbonControl1.SelectedPage = pageHome
        End Sub
    End Class
End Namespace
