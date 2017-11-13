Imports DevExpress.Spreadsheet
Imports System

Namespace SpreadsheetDemo
    Partial Public Class TwoWayBinding
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            spreadsheet.Options.Culture = DefaultCulture
            spreadsheet.LoadDocument(DemoUtils.GetRelativePath("Expenses_template.xlsx"), DocumentFormat.Xlsx)
        End Sub

        Private Sub spreadsheet_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            Dim workbook As IWorkbook = Me.spreadsheet.Document
            Dim sheet As Worksheet = workbook.Worksheets(0)
            Dim expenses As Table = sheet.Tables(0)
            Dim options As New RangeDataSourceOptions()
            options.PreserveFormulas = True
            options.SkipHiddenRows = True
            grid.ItemsSource = expenses.DataRange.GetDataSource(options)
        End Sub
    End Class
End Namespace
