Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Threading

Partial Public Class TreeView_EnableCallbacks
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			treeView.DataBind()
			treeView.Nodes(0).Expanded = True
			treeView.Nodes(1).Expanded = True
		End If
		If IsCallback Then
			' Intentionally pauses server-side processing, 
			' to demonstrate the Loading Panel functionality.
			Thread.Sleep(1000)
		End If
	End Sub
End Class
