Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class TreeView_ServerSide
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			FillNodesComboBox(treeView.Nodes)
			cbNodes.SelectedIndex = 0
			InitializePropertiesEditors()
		End If
	End Sub

	Protected Sub FillNodesComboBox(ByVal nodes As TreeViewNodeCollection)
		For Each node As TreeViewNode In nodes
			Dim itemText As String = If(node.Nodes.Count > 0, node.Text, "-"c + node.Text)
			cbNodes.Items.Add(New ListEditItem(itemText, node.Name))
			If node.Nodes.Count > 0 Then
				FillNodesComboBox(node.Nodes)
			End If
		Next node
	End Sub

	Protected Function GetCurrentNode() As TreeViewNode
		Return treeView.Nodes.FindByName(cbNodes.SelectedItem.Value.ToString())
	End Function

	Protected Sub cbNodes_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		InitializePropertiesEditors()
	End Sub

	Private Sub InitializePropertiesEditors()
		Dim node As TreeViewNode = GetCurrentNode()
		chbEnabled.Checked = node.Enabled
		chbVisible.Checked = node.Visible
		chbSelected.Checked = treeView.SelectedNode Is node
		chbChecked.Checked = node.Checked
		chbChecked.Enabled = node.AllowCheck
		chbExpanded.Checked = node.Expanded
		chbExpanded.Enabled = node.Nodes.Count > 0
	End Sub

	Protected Sub chbEnabled_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		GetCurrentNode().Enabled = chbEnabled.Checked
	End Sub

	Protected Sub chbVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		GetCurrentNode().Visible = chbVisible.Checked
	End Sub

	Protected Sub chbSelected_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim node As TreeViewNode = If(chbSelected.Checked, GetCurrentNode(), Nothing)
		treeView.SelectedNode = node
	End Sub

	Protected Sub chbChecked_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		GetCurrentNode().Checked = chbChecked.Checked
	End Sub

	Protected Sub chbExpanded_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		GetCurrentNode().Expanded = chbExpanded.Checked
	End Sub

	Protected Sub treeView_NodeClick(ByVal sender As Object, ByVal e As TreeViewNodeEventArgs)
		EventMonitor.TraceEvent(sender, e, "NodeClick")
		cbNodes.Value = e.Node.Name
		InitializePropertiesEditors()
	End Sub

	Protected Sub treeView_ExpandedChanged(ByVal sender As Object, ByVal e As TreeViewNodeEventArgs)
		If e.Node Is GetCurrentNode() Then
			chbExpanded.Checked = e.Node.Expanded
		End If
		EventMonitor.TraceEvent(sender, e, "ExpandedChanged")
	End Sub

	Protected Sub treeView_ExpandedChanging(ByVal sender As Object, ByVal e As TreeViewNodeCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "ExpandedChanging")
	End Sub

	Protected Sub treeView_CheckedChanged(ByVal sender As Object, ByVal e As TreeViewNodeEventArgs)
		If e.Node Is GetCurrentNode() Then
			chbChecked.Checked = e.Node.Checked
		End If
		EventMonitor.TraceEvent(sender, e, "CheckedChanged")
	End Sub
End Class
