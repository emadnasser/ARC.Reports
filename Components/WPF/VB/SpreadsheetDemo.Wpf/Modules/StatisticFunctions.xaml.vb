Imports System
Imports DevExpress.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class StatisticFunctions
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("TrendlineAnalysis_template.xlsx"), DocumentFormat.Xlsx)
            ribbonControl1.SelectedPage = pageFormulas
        End Sub
    End Class
End Namespace
