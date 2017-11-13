Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DashboardDemos.Core

Namespace FinancialDemo.Web
	Partial Public Class DatabaseGenerationForm
		Inherits System.Web.UI.Page
		Protected Overrides Sub OnInit(ByVal e As EventArgs)
			Dim dashboardStorageConnectionString As String = DashboardDemosUtils.DashboardStorageConnectionString
			If String.IsNullOrEmpty(dashboardStorageConnectionString) Then
				Dim phContent As Control = Form.FindControl("Content")
				If phContent IsNot Nothing Then
					Dim div As New LiteralControl("This demo requires SQL Server Express installed to automatically create a sample database. Alternatively, you can manually specify a connection string to the server where the database should be created. You can do this in the connections.config file.")
					phContent.Controls.RemoveAt(1)
					phContent.Controls.AddAt(1, div)
				End If
			End If
		End Sub
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

	End Class
End Namespace
