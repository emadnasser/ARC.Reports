Imports Microsoft.VisualBasic
Imports System

Partial Public Class Accessibility_RightToLeft
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			NewsGroupDataProvider.Restore()
			Me.treeList.DataBind()
			Me.treeList.ExpandAll()
			Me.treeList.StartEdit("2")
		End If
	End Sub
End Class
