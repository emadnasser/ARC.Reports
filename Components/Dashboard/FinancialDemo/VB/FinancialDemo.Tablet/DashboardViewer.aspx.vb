Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DashboardDemos.Core
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters


Namespace FinancialDemo.Tablet
	Partial Public Class DashboardViewer
		Inherits System.Web.UI.Page
		Private Const dashboardId As Integer = 1
		Private dashboardStorageConnectionString, financialDemoConnectionString As String
		Protected Overrides Sub OnPreInit(ByVal e As EventArgs)
			MyBase.OnPreInit(e)
			If Request.UserAgent IsNot Nothing AndAlso Request.UserAgent.IndexOf("AppleWebKit", StringComparison.CurrentCultureIgnoreCase) > -1 Then
				ClientTarget = "uplevel"
			End If
		End Sub

		Protected Overrides Sub OnInit(ByVal e As EventArgs)
			MyBase.OnInit(e)
			dashboardStorageConnectionString = DashboardDemosUtils.DashboardStorageConnectionString
			financialDemoConnectionString = DashboardDemosUtils.FinancialDemoConnectionString
		End Sub
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If IsPostBack Then
				Return
			End If
			If (Not String.IsNullOrEmpty(dashboardStorageConnectionString)) Then
			ASPxDashboardViewer1.DashboardId = "FinancialDashboard"
			End If
		End Sub

		Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionWebEventArgs)
			If e.ConnectionName = "FinanceDemoConnection" Then
				Dim connectionParams As New CustomStringConnectionParameters(financialDemoConnectionString)
				e.ConnectionParameters = connectionParams
			End If

		End Sub
		Protected Sub ASPxDashboardViewer1_DashboardLoading(ByVal sender As Object, ByVal e As DashboardLoadingEventArgs)
			Try
				Using stream As MemoryStream = DashboardDemosUtils.GetDashboardStream(dashboardStorageConnectionString, dashboardId)
					Using streamReader As New StreamReader(stream)
						e.DashboardXml = streamReader.ReadToEnd()
					End Using
				End Using
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
	End Class
End Namespace
