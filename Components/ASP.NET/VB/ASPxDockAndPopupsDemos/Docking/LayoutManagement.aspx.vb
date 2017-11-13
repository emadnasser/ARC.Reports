Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Docking_LayoutManagement
	Inherits Page
	Private Const LayoutSessionKey As String = "1e38ba85-292e-494e-8f3e-5c8654a9dfef"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub

	Protected Sub btnEditLayout_Click(ByVal sender As Object, ByVal e As EventArgs)
		Response.Redirect("~/Docking/LayoutManagement/EditLayout.aspx", True)
	End Sub

	Protected Sub dockManager_ClientLayout(ByVal sender As Object, ByVal e As ASPxClientLayoutArgs)
		If e.LayoutMode = ClientLayoutMode.Loading Then
			e.LayoutData = TryCast(Session(LayoutSessionKey), String)
		End If
	End Sub
End Class
