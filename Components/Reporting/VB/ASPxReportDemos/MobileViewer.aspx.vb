Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports DevExpress.Web.Demos
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class MobileViewer
	Inherits System.Web.UI.Page
	Public ReadOnly Property isPollingReport() As Boolean
		Get
			Return Request.QueryString("reportName") = "XtraReportsDemos.PollingReport.PollingReport"
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Header.Title = Utils.GetCurrentDemoPageTitle()
		If isPollingReport Then
			webDocumentViewer.OpenReport(ReportStorageHelper.LoadReport(Request.QueryString("reportName"), Session))
		Else
			webDocumentViewer1.OpenReport(ReportStorageHelper.LoadReport(Request.QueryString("reportName"), Session))
		End If
	End Sub
End Class
