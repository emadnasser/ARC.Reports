Imports System
Imports System.Globalization
Imports DevExpress.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class UnitConverter
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            InitializeWorkbook()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
        End Sub
        Private Sub InitializeWorkbook()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            workbook.LoadDocument(DemoUtils.GetRelativePath("UnitConverter_template.xlsx"))
        End Sub
    End Class
End Namespace
