Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Nodes.Operations

Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class MultiDragAndDrop
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			tl1ClassView.DataSource = ClassViewHelper.GetClassView1()
			tl2ClassView.DataSource = ClassViewHelper.GetClassView2()
			InitTreeList(tl1ClassView)
			InitTreeList(tl2ClassView)
		End Sub
		Private Sub InitTreeList(ByVal treeList As TreeList)
            treeList.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Multiple
			treeList.OptionsDragAndDrop.AcceptOuterNodes = True
			AddHandler treeList.CustomizeNewNodeFromOuterData, AddressOf OnTLCustomizeNewNodeFromOuterData
			AddHandler treeList.BeforeDropNode, AddressOf OnTLBeforeDropNode
			AddHandler treeList.BeforeDragNode, AddressOf OnTLBeforeDragNode
			AddHandler treeList.DragOver, AddressOf OnTLDragOver
			AddHandler treeList.DragDrop, AddressOf OnTLDragDrop
			AddHandler treeList.DragLeave, AddressOf OnTLDragLeave
			AddHandler treeList.GiveFeedback, AddressOf OnTLGiveFeedback
			AddHandler treeList.CalcNodeDragImageIndex, AddressOf OnTLCalcNodeDragImageIndex
			treeList.ExpandAll()
		End Sub

		Private Sub OnTLCalcNodeDragImageIndex(ByVal sender As Object, ByVal e As CalcNodeDragImageIndexEventArgs)
			Dim args As DXDragEventArgs = e.DragArgs.GetDXDragEventArgs(TryCast(sender, TreeList))
			Dim provider As IDragNodesProvider = TryCast(args.Data.GetData(GetType(IDragNodesProvider)), IDragNodesProvider)
			If provider Is Nothing Then
				Return
			End If
			If Not AllowDropNodes(args, provider) Then
				e.ImageIndex = -1
			End If
		End Sub
		Private Sub OnTLGiveFeedback(ByVal sender As Object, ByVal e As GiveFeedbackEventArgs)
			e.UseDefaultCursors = False
		End Sub
		Private Sub OnTLDragLeave(ByVal sender As Object, ByVal e As EventArgs)
			SetDefaultCursor()
		End Sub
		Private Sub OnTLDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
			SetDefaultCursor()
		End Sub
		Private Sub OnTLDragOver(ByVal sender As Object, ByVal e As DragEventArgs)
			Dim provider As IDragNodesProvider = TryCast(e.Data.GetData(GetType(IDragNodesProvider)), IDragNodesProvider)
			If provider Is Nothing Then
				e.Effect = DragDropEffects.None
			Else
				Dim args As DXDragEventArgs = e.GetDXDragEventArgs(CType(sender, TreeList))
				e.Effect = GetDragDropEffect(args, provider)
			End If
			SetDragCursor(e.Effect)
		End Sub
		Private Function GetDragDropEffect(ByVal e As DXDragEventArgs, ByVal provider As IDragNodesProvider) As DragDropEffects
			Return If(AllowDropNodes(e, provider), e.Effect, DragDropEffects.None)
		End Function
		Private Function AllowDropNodes(ByVal e As DXDragEventArgs, ByVal provider As IDragNodesProvider) As Boolean
			If e.HitInfo.HitTest.RowInfo Is Nothing Then
				Return True
			End If
			Dim destNode As TreeListNode = e.HitInfo.HitTest.RowInfo.Node
			If destNode Is Nothing Then
				Return True
			End If
			If e.DragInsertPosition = DragInsertPosition.None Then
				Return True
			End If
			Dim destLevel As Integer = If(e.DragInsertPosition = DragInsertPosition.AsChild, destNode.Level + 1, destNode.Level)
			For Each node As TreeListNode In provider.DragNodes
                If Object.Equals(destNode.ParentNode, node.ParentNode) Then
                    Return False
                End If
                If destLevel <> node.Level Then
                    Return False
                End If
            Next node
			Return True
		End Function
		Private Function HasAsParent(ByVal node1 As TreeListNode, ByVal node2 As TreeListNode) As TreeListNode
			If node1.Level > node2.Level Then
				Return If(node1.HasAsParent(node2), node1, Nothing)
			End If
			If node1.Level < node2.Level Then
				Return If(node2.HasAsParent(node1), node2, Nothing)
			End If
			Return Nothing
		End Function
		Private Sub OnTLBeforeDragNode(ByVal sender As Object, ByVal e As BeforeDragNodeEventArgs)
            If e.Nodes.Count <= 1 Then
                Return
            End If
			Dim i As Integer = 0, j As Integer = i + 1
			Dim nonDragNodes As New List(Of TreeListNode)()
            Do While i <> e.Nodes.Count - 1
                Dim nonDragNode As TreeListNode = HasAsParent(e.Nodes(i), e.Nodes(j))
                If nonDragNode IsNot Nothing Then
                    nonDragNodes.Add(nonDragNode)
                End If
                If j = e.Nodes.Count - 1 Then
                    i += 1
                    j = i + 1
                Else
                    j += 1
                End If
            Loop
			If nonDragNodes.Count = 0 Then
				Return
			End If
			For Each node As TreeListNode In nonDragNodes
                e.Nodes.Remove(node)
			Next node
		End Sub
		Private Function AllowDropNode(ByVal sourceNode As TreeListNode, ByVal nodes As TreeListNodes) As Boolean
			For Each node As TreeListNode In nodes
				Dim value1 As Object = sourceNode.GetValue("Name")
				Dim value2 As Object = node.GetValue("Name")
				If Object.Equals(value1, value2) Then
					Return True
				End If
			Next node
			Return False
		End Function
		Private Sub OnTLBeforeDropNode(ByVal sender As Object, ByVal e As BeforeDropNodeEventArgs)
			If e.IsCopy Then
				Return
			End If
			Dim nodes As TreeListNodes = If(e.DestinationNode Is Nothing, (CType(sender, TreeList)).Nodes, e.DestinationNode.Nodes)
			e.Cancel = AllowDropNode(e.SourceNode, nodes)
		End Sub
		Private Function CalcAllNodesCount(ByVal treeList As TreeList) As Integer
			Dim countNodes As TreeListOperationCount = New TreeListOperationFullCount(treeList.Nodes)
			treeList.NodesIterator.DoOperation(countNodes)
			Return countNodes.Count
		End Function
		Private Sub OnTLCustomizeNewNodeFromOuterData(ByVal sender As Object, ByVal e As CustomizeNewNodeFromOuterDataEventArgs)
			Dim treeList As TreeList = CType(sender, TreeList)
			e.NewData(treeList.ParentFieldName) = If(e.DestinationNode Is Nothing, 0, e.DestinationNode(treeList.KeyFieldName))
			e.NewData(treeList.KeyFieldName) = CalcAllNodesCount(treeList)
			e.NewData(treeList.ImageIndexFieldName) = e.SourceNode(treeList.ImageIndexFieldName)
		End Sub

        Private Sub ceAcceptOuterNodesChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAcceptOuterNodes.CheckedChanged
            tl2ClassView.OptionsDragAndDrop.AcceptOuterNodes = ceAcceptOuterNodes.Checked
            tl1ClassView.OptionsDragAndDrop.AcceptOuterNodes = tl2ClassView.OptionsDragAndDrop.AcceptOuterNodes
        End Sub
        Private Sub ceMultipleNodesDragAndDropChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceMultipleNodesDragAndDrop.CheckedChanged
            tl2ClassView.OptionsDragAndDrop.DragNodesMode = If(ceMultipleNodesDragAndDrop.Checked, DragNodesMode.Multiple, DragNodesMode.Single)
            tl1ClassView.OptionsDragAndDrop.DragNodesMode = tl2ClassView.OptionsDragAndDrop.DragNodesMode
            tl2ClassView.OptionsSelection.MultiSelect = ceMultipleNodesDragAndDrop.Checked
            tl1ClassView.OptionsSelection.MultiSelect = tl2ClassView.OptionsSelection.MultiSelect
        End Sub
		Private Sub SetDefaultCursor()
			Cursor = Cursors.Default
		End Sub
		Private Sub SetDragCursor(ByVal e As DragDropEffects)
            If e = DragDropEffects.Move Then
                Cursor = New Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("move.ico"))
            End If
            If e = DragDropEffects.Copy Then
                Cursor = New Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("copy.ico"))
            End If
            If e = DragDropEffects.None Then
                Cursor = Cursors.No
            End If
		End Sub
    End Class
End Namespace
