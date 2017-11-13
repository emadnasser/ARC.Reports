Imports DevExpress.XtraTreeList
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Modules
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.Common.DataModel
Imports System.Windows.Forms

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class FilterTreeListPresenter(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})
        Inherits BasePresenter(Of FilterTreeViewModel(Of TEntity, TID, TUnitOfWork))

        Public Sub New(ByVal treeList As TreeList, ByVal viewModel As FilterTreeViewModel(Of TEntity, TID, TUnitOfWork))
            MyBase.New(viewModel)
            Me.treeListCore = treeList
            If CollectionViewModel IsNot Nothing Then
                SubscribeCollectionViewModelEvents()
            End If
            If treeListCore IsNot Nothing Then
                InitTreeListFocusedNodeSynchronization()
                InitTreeListNodeMenu()
                InitTreeListNodesDragDrop()
                BindTreeList()
            End If
        End Sub
        Protected Overrides Sub OnDisposing()
            If CollectionViewModel IsNot Nothing Then
                UnsubscribeCollectionViewModelEvents()
            End If
            If treeListCore IsNot Nothing Then
                UnbindTreeList()
                ReleaseTreeListNodesDragDrop()
                ReleaseTreeListNodeMenu()
                ReleaseTreeListFocusedNodeSynchronization()
            End If
            Me.treeListCore = Nothing
            MyBase.OnDisposing()
        End Sub
        Private treeListCore As TreeList
        Protected ReadOnly Property TreeList() As TreeList
            Get
                Return treeListCore
            End Get
        End Property
        Public ReadOnly Property CollectionViewModel() As CollectionViewModel(Of TEntity, TID, TUnitOfWork)
            Get
                Return ViewModel.CollectionViewModel
            End Get
        End Property
        Protected Overridable Sub SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.EntitiesCountChanged, AddressOf CollectionViewModel_EntitiesCountChanged
        End Sub
        Protected Overridable Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.EntitiesCountChanged, AddressOf CollectionViewModel_EntitiesCountChanged
        End Sub
        Private Sub CollectionViewModel_EntitiesCountChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            TreeList.RefreshDataSource()
        End Sub
        Protected Sub CollectionViewModel_CustomFilter(ByVal sender As Object, ByVal e As System.EventArgs)
            ViewModel.[New]()
        End Sub
        Protected Sub CollectionViewModel_CustomGroup(ByVal sender As Object, ByVal e As System.EventArgs)
            ViewModel.NewGroup()
        End Sub
        Protected Sub CollectionViewModel_CustomGroupFromSelection(ByVal sender As Object, ByVal e As GroupEventArgs(Of TEntity))
            ViewModel.NewGroupFromSelection(e.Entities)
        End Sub
        #Region "TreeList Binding"
        Private Sub BindTreeList()
            AddHandler TreeList.VirtualTreeGetChildNodes, AddressOf treeList_VirtualTreeGetChildNodes
            AddHandler TreeList.VirtualTreeGetCellValue, AddressOf treeList_VirtualTreeGetCellValue
            TreeList.Columns.AddField("Name").Visible = True
            TreeList.DataSource = ViewModel
            TreeList.ExpandAll()
            Dim helper = New FilterTreeListHelper(Of TEntity, TID, TUnitOfWork)(TreeList)
            TreeList.FocusedNode = helper.FindNode(ViewModel.SelectedItem)
        End Sub
        Private Sub UnbindTreeList()
            RemoveHandler TreeList.VirtualTreeGetChildNodes, AddressOf treeList_VirtualTreeGetChildNodes
            RemoveHandler TreeList.VirtualTreeGetCellValue, AddressOf treeList_VirtualTreeGetCellValue
        End Sub
        Private Sub treeList_VirtualTreeGetChildNodes(ByVal sender As Object, ByVal e As VirtualTreeGetChildNodesInfo)
            e.Children = ViewModel.GetСhildren(e.Node)
        End Sub
        Private Sub treeList_VirtualTreeGetCellValue(ByVal sender As Object, ByVal e As VirtualTreeGetCellValueInfo)
            e.CellData = ViewModel.GetFilterName(e.Node, TryCast(e.Node, FilterItemBase))
        End Sub
        #End Region
        #Region "TreeList Node Menu"
        Private Sub InitTreeListNodeMenu()
            AddHandler TreeList.PopupMenuShowing, AddressOf treeList_PopupMenuShowing
            AddHandler TreeList.MouseDoubleClick, AddressOf treeList_MouseDoubleClick
        End Sub
        Private Sub ReleaseTreeListNodeMenu()
            RemoveHandler TreeList.PopupMenuShowing, AddressOf treeList_PopupMenuShowing
            RemoveHandler TreeList.MouseDoubleClick, AddressOf treeList_MouseDoubleClick
        End Sub
        Private Sub treeList_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hi = TreeList.CalcHitInfo(e.Location)
            Dim helper = New FilterTreeListHelper(Of TEntity, TID, TUnitOfWork)(TreeList)
            helper.ModifyFilter(hi.Node, ViewModel)
        End Sub
        Private Sub treeList_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.Menu.MenuType = XtraTreeList.Menu.TreeListMenuType.Node Then
                Dim hi = TreeList.CalcHitInfo(e.Point)
                Dim helper = New FilterTreeListHelper(Of TEntity, TID, TUnitOfWork)(TreeList)
                If Not helper.PopulateFiltersMenu(e.Menu, hi.Node, ViewModel) Then
                    e.Allow = False
                End If
            End If
        End Sub
        #End Region
        #Region "Nodes Drag&Drop"
        Private Sub InitTreeListNodesDragDrop()
            AddHandler TreeList.BeforeDragNode, AddressOf treeList_BeforeDragNode
            AddHandler TreeList.DragOver, AddressOf treeList_DragOver
            AddHandler TreeList.DragDrop, AddressOf treeList_DragDrop
            AddHandler TreeList.CalcNodeDragImageIndex, AddressOf treeList_CalcNodeDragImageIndex
        End Sub
        Private Sub ReleaseTreeListNodesDragDrop()
            RemoveHandler TreeList.BeforeDragNode, AddressOf treeList_BeforeDragNode
            RemoveHandler TreeList.DragOver, AddressOf treeList_DragOver
            RemoveHandler TreeList.DragDrop, AddressOf treeList_DragDrop
            RemoveHandler TreeList.CalcNodeDragImageIndex, AddressOf treeList_CalcNodeDragImageIndex
        End Sub
        Private Sub treeList_BeforeDragNode(ByVal sender As Object, ByVal e As BeforeDragNodeEventArgs)
            If e.Node.ParentNode Is Nothing Then
                e.CanDrag = False
            End If
        End Sub
        Private Sub treeList_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
            Dim ea As DXDragEventArgs = TreeList.GetDXDragEventArgs(e)
            If Not Object.Equals(ea.RootNode, ea.TargetRootNode) Then
                e.Effect = DragDropEffects.None
            Else
                e.Effect = DragDropEffects.Move
            End If
        End Sub
        Private Sub treeList_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            Dim ea As DXDragEventArgs = TreeList.GetDXDragEventArgs(e)
            If ea.TargetNode IsNot Nothing Then
                TreeList.SetNodeIndex(ea.Node, TreeList.GetNodeIndex(ea.TargetNode))
                e.Effect = DragDropEffects.None
            End If
        End Sub
        Private Sub treeList_CalcNodeDragImageIndex(ByVal sender As Object, ByVal e As CalcNodeDragImageIndexEventArgs)
            Dim ea As DXDragEventArgs = TreeList.GetDXDragEventArgs(e.DragArgs)
            If Not Object.Equals(ea.RootNode, ea.TargetRootNode) Then
                e.ImageIndex = -1
            Else
                e.ImageIndex = 1
            End If
        End Sub
        #End Region
        #Region "Focused Node Synchronization"
        Private Sub InitTreeListFocusedNodeSynchronization()
            AddHandler ViewModel.SelectedItemChanged, AddressOf ViewModel_SelectedItemChanged
            AddHandler ViewModel.FilterTreeChanged, AddressOf ViewModel_FilterTreeChanged
            AddHandler TreeList.FocusedNodeChanged, AddressOf treeList_FocusedNodeChanged
            AddHandler TreeList.BeforeFocusNode, AddressOf treeList_BeforeFocusNode
        End Sub
        Private Sub ReleaseTreeListFocusedNodeSynchronization()
            RemoveHandler ViewModel.SelectedItemChanged, AddressOf ViewModel_SelectedItemChanged
            RemoveHandler ViewModel.FilterTreeChanged, AddressOf ViewModel_FilterTreeChanged
            RemoveHandler TreeList.FocusedNodeChanged, AddressOf treeList_FocusedNodeChanged
            RemoveHandler TreeList.BeforeFocusNode, AddressOf treeList_BeforeFocusNode
        End Sub
        Private Sub treeList_BeforeFocusNode(ByVal sender As Object, ByVal e As BeforeFocusNodeEventArgs)
            e.CanFocus = (TypeOf TreeList.GetDataRecordByNode(e.Node) Is FilterItemBase)
        End Sub
        Private Sub ViewModel_FilterTreeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            TreeList.RefreshDataSource()
            TreeList.ExpandAll()
        End Sub
        Private lockFocusedNodeChanged As Integer = 0
        Private Sub treeList_FocusedNodeChanged(ByVal sender As Object, ByVal e As FocusedNodeChangedEventArgs)
            lockFocusedNodeChanged += 1
            Try
                Dim filterItem = TryCast(TreeList.GetDataRecordByNode(e.Node), FilterItemBase)
                ViewModel.SelectedItem = filterItem
                TreeList.RefreshNode(e.Node)
                TreeList.RefreshNode(e.OldNode)
            Finally
                lockFocusedNodeChanged -= 1
            End Try
        End Sub
        Private Sub ViewModel_SelectedItemChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If lockFocusedNodeChanged = 0 Then
                Dim helper = New FilterTreeListHelper(Of TEntity, TID, TUnitOfWork)(TreeList)
                TreeList.FocusedNode = helper.FindNode(ViewModel.SelectedItem)
            End If
        End Sub
        #End Region
    End Class
End Namespace
