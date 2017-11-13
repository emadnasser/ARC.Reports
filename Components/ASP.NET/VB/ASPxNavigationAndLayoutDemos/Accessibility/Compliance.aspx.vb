Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Common_Compliance
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			treeView.DataBind()
			treeView.ExpandAll()
		End If
	End Sub
End Class
