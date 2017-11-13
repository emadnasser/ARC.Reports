Imports System
Imports System.Globalization
Imports DevExpress.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class Hyperlinks
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            InitializeWorkbook()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            Me.spreadsheetControl1.Options.View.ShowPrintArea = False
            ribbonControl1.SelectedPage = pageInsert
        End Sub
        Private Sub InitializeWorkbook()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            workbook.LoadDocument(DemoUtils.GetRelativePath("Hyperlinks_template.xlsx"))
        End Sub
    End Class
End Namespace
