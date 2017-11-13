Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DashboardDemos.Core
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters

Namespace FinancialDemo.Web
	Partial Public Class [Default]
		Inherits System.Web.UI.Page
		Private Const dashboardId As Integer = 1
		Private connectionString As String
		Protected Overrides Sub OnInit(ByVal e As EventArgs)
			MyBase.OnInit(e)
			connectionString = DashboardDemosUtils.FinancialDemoConnectionString
			If DashboardDemosUtils.ShouldRecreateDatabases(Nothing) Then
						  Response.Redirect("DatabaseGenerationForm.aspx")
			End If
		End Sub
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If IsPostBack Then
				Return
			End If
			If (Not String.IsNullOrEmpty(connectionString)) Then
				ASPxDashboardViewer1.DashboardId = "FinancialDashboard"
			End If
		End Sub

		Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionWebEventArgs)
			If e.ConnectionName = "FinanceDemoConnection" Then
				Dim connectionParams As New CustomStringConnectionParameters(connectionString)
				e.ConnectionParameters = connectionParams
			End If
		End Sub
		Protected Sub ASPxDashboardViewer1_DashboardLoading(ByVal sender As Object, ByVal e As DashboardLoadingEventArgs)
			Try
				Using stream As MemoryStream = DashboardDemosUtils.GetDashboardStream(DashboardDemosUtils.DashboardStorageConnectionString, dashboardId)
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
