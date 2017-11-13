Imports System
Imports System.Globalization
Imports DevExpress.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class WorksheetProtection
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            InitializeWorkbook()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            Me.ribbonControl1.SelectedPage = pageReview
        End Sub
        Private Sub InitializeWorkbook()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            workbook.LoadDocument(DemoUtils.GetRelativePath("SimpleMonthlyBudget.xlsx"))
        End Sub
    End Class
End Namespace
