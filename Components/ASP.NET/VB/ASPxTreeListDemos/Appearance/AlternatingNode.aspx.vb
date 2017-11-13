Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Appearance_AlternatingNode
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			DataBind()
			treeList.ExpandToLevel(2)
		End If
	End Sub
End Class
