Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Data_Hierarchical
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			DataBind()
			treeList.ExpandToLevel(1)
		End If
	End Sub
End Class
