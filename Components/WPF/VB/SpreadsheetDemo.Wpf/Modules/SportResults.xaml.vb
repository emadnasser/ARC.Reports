Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports DevExpress.Docs.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos

Namespace SpreadsheetDemo
    Partial Public Class SportResults
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.BeginUpdate()
            Dim book As IWorkbook = spreadsheetControl1.Document
            Dim generator As New SportResultsDocumentGenerator(book)
            book = generator.Generate()
            spreadsheetControl1.EndUpdate()
            book.History.Clear()
            ribbonControl1.SelectedPage = pageHome
        End Sub
    End Class
End Namespace
