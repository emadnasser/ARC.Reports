Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Docking_LayoutManagement_EditLayout
	Inherits Page
	Private Const LayoutSessionKey As String = "1e38ba85-292e-494e-8f3e-5c8654a9dfef"
	Private saveLayout As Boolean = False

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Protected Sub btnRestore_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.dockManager.ResetLayoutToInitial()
	End Sub

	Protected Sub dockManager_ClientLayout(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClientLayoutArgs)
		If e.LayoutMode = ClientLayoutMode.Saving AndAlso Me.saveLayout Then
			Session(LayoutSessionKey) = e.LayoutData
		End If
		If e.LayoutMode = ClientLayoutMode.Loading Then
			e.LayoutData = TryCast(Session(LayoutSessionKey), String)
		End If
	End Sub

	Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
		Response.Redirect("~/Docking/LayoutManagement.aspx", True)
	End Sub

	Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.saveLayout = True
		Response.Redirect("~/Docking/LayoutManagement.aspx", False)
	End Sub
End Class
