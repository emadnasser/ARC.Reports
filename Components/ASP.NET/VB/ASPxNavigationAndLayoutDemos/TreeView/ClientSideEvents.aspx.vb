Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class TreeView_ClientSideEvents
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		treeView.ExpandAll()
	End Sub
End Class
