Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList
Imports DevExpress.Utils.Menu
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Common.DataModel

Namespace DevExpress.DevAV.Modules

    Friend Class FilterTreeListHelper(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})
        Private treeList As TreeList
        Public Sub New(ByVal treeList As XtraTreeList.TreeList)
            Me.treeList = treeList
        End Sub
        Public Sub ModifyFilter(ByVal node As TreeListNode, ByVal viewModel As FilterTreeViewModel(Of TEntity, TID, TUnitOfWork))
            If node IsNot Nothing AndAlso node.ParentNode IsNot Nothing Then
                If MatchHierarchy(node, viewModel.CustomFilters) Then
                    viewModel.Modify(GetRow(Of FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).FilterItem)(node))
                End If
                If MatchHierarchy(node, viewModel.Groups) Then
                    viewModel.ModifyGroup(GetRow(Of FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).FilterItem)(node))
                End If
            End If
        End Sub
        Public Function PopulateFiltersMenu(ByVal nodeMenu As DXPopupMenu, ByVal node As TreeListNode, ByVal viewModel As FilterTreeViewModel(Of TEntity, TID, TUnitOfWork)) As Boolean
            If MatchHierarchy(node, viewModel.CustomFilters) Then
                Dim newItem = New DXMenuItem()
                newItem.Caption = "New..."
                newItem.BindCommand(Sub() viewModel.[New](), viewModel)
                nodeMenu.Items.Add(newItem)
                If node.ParentNode IsNot Nothing Then
                    Dim filterItem = GetRow(Of FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).FilterItem)(node)
                    Dim editItem = New DXMenuItem()
                    editItem.Caption = "Modify..."
                    editItem.BindCommand(Sub(f) viewModel.Modify(f), viewModel, Function() filterItem)
                    nodeMenu.Items.Add(editItem)
                    Dim deleteItem = New DXMenuItem()
                    deleteItem.Caption = "Delete"
                    deleteItem.BindCommand(Sub(f) viewModel.Delete(f), viewModel, Function() filterItem)
                    nodeMenu.Items.Add(deleteItem)
                End If
                Return True
            End If
            If MatchHierarchy(node, viewModel.Groups) Then
                Dim newItem = New DXMenuItem()
                newItem.Caption = "New Group..."
                newItem.BindCommand(Sub() viewModel.NewGroup(), viewModel)
                nodeMenu.Items.Add(newItem)
                If node.ParentNode IsNot Nothing Then
                    Dim filterItem = GetRow(Of FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).FilterItem)(node)
                    Dim editItem = New DXMenuItem()
                    editItem.Caption = "Modify Group..."
                    editItem.BindCommand(Sub(f) viewModel.ModifyGroup(f), viewModel, Function() filterItem)
                    nodeMenu.Items.Add(editItem)
                    Dim deleteItem = New DXMenuItem()
                    deleteItem.Caption = "Delete Group"
                    deleteItem.BindCommand(Sub(f) viewModel.DeleteGroup(f), viewModel, Function() filterItem)
                    nodeMenu.Items.Add(deleteItem)
                End If
                Return True
            End If
            Return False
        End Function
        Public Function FindNode(ByVal dataItem As Object) As TreeListNode
            Return treeList.FindNode(Function(node) Match(node, dataItem))
        End Function
        Public Function Match(ByVal node As TreeListNode, ByVal dataItem As Object) As Boolean
            Return treeList.GetDataRecordByNode(node) Is dataItem
        End Function
        Public Function MatchHierarchy(ByVal node As TreeListNode, ByVal dataItem As Object) As Boolean
            Do While node IsNot Nothing
                If Match(node, dataItem) Then
                    Return True
                End If
                node = node.ParentNode
            Loop
            Return False
        End Function
        Public Function GetRow(Of T As Class)(ByVal node As TreeListNode) As T
            Return TryCast(treeList.GetDataRecordByNode(node), T)
        End Function
    End Class
End Namespace
