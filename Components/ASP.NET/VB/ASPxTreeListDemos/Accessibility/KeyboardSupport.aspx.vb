Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Accessibility_KeyboardSupport
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			treeList.DataBind()
			treeList.ExpandToLevel(2)
		End If
	End Sub
End Class
