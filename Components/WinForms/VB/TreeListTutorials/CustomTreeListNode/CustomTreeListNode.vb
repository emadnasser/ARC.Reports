Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for CustomTreeListNode.
	''' </summary>
	Public Partial Class CustomTreeListNode
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
            InitializeComponent()
            Dim aNode As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
            treeList1.AppendNode(Nothing, aNode)
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
		Private Sub treeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles treeList1.FocusedNodeChanged
            button3.Enabled = Not e.Node Is Nothing
			button2.Enabled = button3.Enabled
		End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Dim aNode As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
            treeList1.FocusedNode = treeList1.AppendNode(Nothing, aNode)
        End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			If Not treeList1.FocusedNode Is Nothing Then
				treeList1.FocusedNode = treeList1.AppendNode(Nothing, treeList1.FocusedNode)
			End If
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
			If Not treeList1.FocusedNode Is Nothing Then
				treeList1.DeleteNode(treeList1.FocusedNode)
			End If
		End Sub
	End Class
End Namespace
