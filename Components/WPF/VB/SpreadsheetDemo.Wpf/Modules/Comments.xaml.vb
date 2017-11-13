Imports System
Imports DevExpress.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class Comments
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()

            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("Comments_template.xlsx"), DocumentFormat.Xlsx)

            ribbonControl1.SelectedPage = pageReview
        End Sub
    End Class
End Namespace
