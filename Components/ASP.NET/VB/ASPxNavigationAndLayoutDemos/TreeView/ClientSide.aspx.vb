Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class TreeView_ClientSide
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		treeView.DataBind()
		treeView.ExpandAll()
		Dim tvNodes As ASPxTreeView = TryCast(ddNodes.FindControl("tvNodes"), ASPxTreeView)
		tvNodes.DataBind()
		tvNodes.ExpandAll()
		tvNodes.SelectedNode = tvNodes.Nodes(0)
		ddNodes.Text = tvNodes.SelectedNode.Text
		ddNodes.KeyValue = tvNodes.SelectedNode.Name
	End Sub

End Class
