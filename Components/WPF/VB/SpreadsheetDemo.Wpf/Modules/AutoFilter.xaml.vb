Imports System
Imports DevExpress.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class AutoFilter
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()

            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("AutoFilter_template.xlsx"))
            ribbonControl1.SelectedPage = pageData
        End Sub
    End Class
End Namespace
