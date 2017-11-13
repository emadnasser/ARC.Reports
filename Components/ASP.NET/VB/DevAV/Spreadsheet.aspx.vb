Imports System
Imports DevExpress.Web
Imports DevExpress.Web.Office

Partial Public Class Spreadsheet
    Inherits System.Web.UI.Page

    Private Const LoadReportArgsKey As String = "ReportArgs"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If DemoUtils.IsSiteMode Then
            SpreadsheetControl.CreateDefaultRibbonTabs(True)
            SpreadsheetControl.RibbonTabs.RemoveAt(0)
        End If
        DemoUtils.ClearSpreadsheetTempFolder()
        If Not IsPostBack Then
            LoadSpreadsheetDocument()
        End If
    End Sub

    Protected Sub LoadSpreadsheetDocument()
        Dim report = DemoUtils.CreateReport(Request.QueryString(LoadReportArgsKey))
        If report Is Nothing Then
            Return
        End If
        DemoUtils.LoadSpreadsheetFile(Sub(filePath)
            report.ExportToXlsx(filePath)
            SpreadsheetControl.Open(filePath)
        End Sub)
    End Sub

    Protected Sub SpreadsheetControl_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
        If e.Parameter = "Close" Then
            DocumentManager.CloseDocument(SpreadsheetControl.DocumentId)
        End If
    End Sub
End Class
