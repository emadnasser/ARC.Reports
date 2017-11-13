Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for DragDrop.
	''' </summary>
	Public Partial Class DragDrop
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub InitData()
			Dim xv As DevExpress.XtraTreeList.Design.XViews = New DevExpress.XtraTreeList.Design.XViews(treeList1)
            checkBox1.Checked = treeList1.OptionsDragAndDrop.DragNodesMode <> DragNodesMode.None
		End Sub

		'<checkBox1>
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            If checkBox1.Checked Then
                treeList1.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Single
            Else
                treeList1.OptionsDragAndDrop.DragNodesMode = DragNodesMode.None
            End If
        End Sub
		'</checkBox1>

		Private Function GetDragNode(ByVal data As IDataObject) As DevExpress.XtraTreeList.Nodes.TreeListNode
			Return TryCast(data.GetData(GetType(DevExpress.XtraTreeList.Nodes.TreeListNode)), DevExpress.XtraTreeList.Nodes.TreeListNode)
		End Function

		'<listBox1>
		Private Function GetStringByNode(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode) As String
			Dim ret As String = ""
			Dim i As Integer = 0
			Do While i < treeList1.Columns.Count
				If i < treeList1.Columns.Count - 1 Then
					ret &= node.GetDisplayText(i) + ("; ")
				Else
					ret &= node.GetDisplayText(i) + (".")
				End If
				i += 1
			Loop
			Return ret
		End Function

		Private Sub listBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listBox1.DragEnter
			If Not GetDragNode(e.Data) Is Nothing Then
				e.Effect = DragDropEffects.Copy
			End If
		End Sub

		Private Sub listBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listBox1.DragDrop
			Dim lb As DevExpress.XtraEditors.ListBoxControl = TryCast(sender, DevExpress.XtraEditors.ListBoxControl)
			Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode = GetDragNode(e.Data)
			If Not node Is Nothing Then
				Dim dragString As String = GetStringByNode(node)
				Dim ind As Integer = lb.IndexFromPoint(lb.PointToClient(New Point(e.X, e.Y)))
				If ind = -1 Then
					lb.Items.Add(dragString)
				Else
					lb.Items.Insert(ind, dragString)
				End If
			End If
		End Sub
		'</listBox1>
	End Class
End Namespace
