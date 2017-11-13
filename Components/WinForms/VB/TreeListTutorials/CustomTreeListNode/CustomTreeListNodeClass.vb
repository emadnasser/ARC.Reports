Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	'<treeList1>
	Public Class CustomTLNode
		Inherits TreeListNode
		Public Sub New(ByVal id As Integer, ByVal owner As TreeListNodes)
			MyBase.New(id, owner)
		End Sub
		Private Function NodeParameters() As String
			Dim s As String = "Node " & Me.Id.ToString()
			If Me.HasChildren Then
				s &= "; ChildNodes Count = " & Me.Nodes.Count
				If Me.Expanded Then
					s &= "; Expanded"
				End If
			End If
			If Not Me.Tag Is Nothing AndAlso (Not Me.Tag.Equals("")) Then
				s &= "; Tag: " & Me.Tag.ToString()
			End If
			Return s
		End Function
		Public Overrides Default Property Item(ByVal columnID As Object) As Object
			Get
				Return NodeParameters()
			End Get
			Set
				If columnID.Equals(Me.TreeList.Columns(0)) Then
					Me.Tag = Value
					Me.TreeList.LayoutChanged()
				End If
			End Set
		End Property
	End Class
	'</treeList1>

	Public Class CustomTreeList
		Inherits TreeList
		'returns a CustomTLNode object
        Protected Overrides Function CreateNode(ByVal nodeID As Integer, ByVal owner As TreeListNodes, ByVal tag As Object) As TreeListNode
            Return New CustomTLNode(nodeID, owner)
        End Function
		Protected Overrides Sub RaiseCellValueChanged(ByVal e As CellValueChangedEventArgs)
			Dim node As CustomTLNode = TryCast(e.Node, CustomTLNode)
            If e.Column Is Columns(0) Then
                node(e.Column) = e.Value
                RefreshRowsInfo()
            End If
			MyBase.RaiseCellValueChanged(e)
		End Sub
		Protected Overrides Function CreateHelper() As DevExpress.XtraEditors.Container.EditorContainerHelper
			Return New CustomTreeListContainerHelper(Me)
		End Function
	End Class

	Public Class CustomTreeListContainerHelper
		Inherits TreeListContainerHelper
		Public Sub New(ByVal owner As TreeList)
			MyBase.New(owner)
		End Sub
		Public Overrides Sub ActivateEditor(ByVal ritem As DevExpress.XtraEditors.Repository.RepositoryItem, ByVal args As DevExpress.XtraEditors.Container.UpdateEditorInfoArgs)
			args = New DevExpress.XtraEditors.Container.UpdateEditorInfoArgs(args.MakeReadOnly, args.Bounds, args.Appearance, Owner.FocusedNode.Tag, args.LookAndFeel, args.ErrorText)
			MyBase.ActivateEditor(ritem, args)
		End Sub
	End Class
End Namespace
