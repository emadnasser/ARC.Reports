Imports System
Imports DevExpress.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class DataValidation
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()

            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.Options.Behavior.Drawing.Move = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
            spreadsheetControl1.Options.Behavior.Drawing.Resize = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
            spreadsheetControl1.Options.Behavior.Drawing.Rotate = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataValidation_template.xlsx"), DocumentFormat.Xlsx)

            ribbonControl1.SelectedPage = pageData
        End Sub
    End Class
End Namespace
