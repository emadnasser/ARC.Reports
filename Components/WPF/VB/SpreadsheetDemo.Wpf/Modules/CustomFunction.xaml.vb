Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Office
Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Spreadsheet
Imports DevExpress.Spreadsheet.Demos

Namespace SpreadsheetDemo
    Partial Public Class CustomFunction
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            Dim book As IWorkbook = spreadsheetControl1.Document
            GenerateDocument(book)
            AddHandler spreadsheetControl1.CellValueChanged, AddressOf spreadsheetControl1_CellValueChanged
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

        Private Sub spreadsheetControl1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs)
            Dim sheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
            If e.SheetName = sheet.Name AndAlso e.RowIndex = 3 AndAlso e.ColumnIndex = 2 Then
                sheet.Columns(2).AutoFit()
                sheet.Columns(4).AutoFit()
            End If
        End Sub
    End Class
End Namespace
