Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class TreeView_Features
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			treeView.ExpandToDepth(0)
		Else
			treeView.AllowSelectNode = cbAllowSelectNode.Checked
			treeView.AutoPostBack = cbAutoPostBack.Checked
			treeView.EnableAnimation = cbEnableAnimation.Checked
			treeView.EnableHotTrack = cbEnableHotTrack.Checked
			treeView.ShowTreeLines = cbShowTreeLines.Checked
			treeView.ShowExpandButtons = cbShowExpandButtons.Checked
			treeView.AllowCheckNodes = cbAllowCheckNodes.Checked
			treeView.CheckNodesRecursive = cbCheckNodesRecursive.Checked
		End If
	End Sub
	Protected Sub CheckNodesRecursiveChanged(ByVal sender As Object, ByVal e As EventArgs)
		RefreshTreeView(treeView.RootNode)
	End Sub
	Protected Sub RefreshTreeView(ByVal node As TreeViewNode)
		node.Checked = False
		node.Nodes.ForEach(AddressOf RefreshTreeView)
	End Sub
End Class
