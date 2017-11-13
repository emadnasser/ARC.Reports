Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class TreeView_NodeLinkMode
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		treeView1.ExpandAll()
		treeView2.ExpandAll()
		treeView1.SelectedNode = treeView1.Nodes(1)
	End Sub
End Class
