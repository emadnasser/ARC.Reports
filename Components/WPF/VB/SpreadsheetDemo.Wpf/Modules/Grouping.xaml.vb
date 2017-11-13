Imports System
Imports DevExpress.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class Grouping
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()

            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("OutlineGrouping_template.xlsx"), DocumentFormat.Xlsx)

            ribbonControl1.SelectedPage = pageData
        End Sub
    End Class
End Namespace
