Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for UnboundMode.
	''' </summary>
	Public Partial Class UnboundMode
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub UnboundMode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			RowsCreator.CreateRows(0, vGridControl1)
			treeView1.ExpandAll()
		End Sub

		Private Sub treeView1_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterExpand
			If e.Node.Nodes.Count > 0 Then
			e.Node.SelectedImageIndex = 2
			e.Node.ImageIndex = e.Node.SelectedImageIndex
			End If
		End Sub

		Private Sub treeView1_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterCollapse
			If e.Node.Nodes.Count > 0 Then
			e.Node.SelectedImageIndex = 1
			e.Node.ImageIndex = e.Node.SelectedImageIndex
			End If
		End Sub

		Private Sub treeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterSelect
			If e.Node.Nodes.Count = 0 Then
				For Each node As TreeNode In treeView1.Nodes(0).Nodes
					node.SelectedImageIndex = 0
					node.ImageIndex = node.SelectedImageIndex
				Next node
				e.Node.SelectedImageIndex = 3
				e.Node.ImageIndex = e.Node.SelectedImageIndex
				RowsCreator.CreateRows(e.Node.Index, vGridControl1)
			End If
		End Sub
	End Class
End Namespace
