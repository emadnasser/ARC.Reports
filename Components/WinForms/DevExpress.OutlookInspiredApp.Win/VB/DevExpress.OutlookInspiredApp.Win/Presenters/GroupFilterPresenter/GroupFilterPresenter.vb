Imports DevExpress.XtraGrid.Views.WinExplorer
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.Common.DataModel
Imports DevExpress.Data.Utils
Imports DevExpress.Data.Filtering
Imports System.Linq
Imports System.Collections.Generic

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class GroupFilterPresenter(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})
        Inherits BasePresenter(Of GroupFilterViewModel)

        Private winExplorerView As WinExplorerView
        Public Sub New(ByVal winExplorerView As WinExplorerView, ByVal viewModel As GroupFilterViewModel)
            MyBase.New(viewModel)
            Me.winExplorerView = winExplorerView
            If winExplorerView IsNot Nothing Then
                AddHandler winExplorerView.ItemClick, AddressOf winExplorerView_ItemClick
                AddHandler winExplorerView.CustomUnboundColumnData, AddressOf winExplorerView_CustomUnboundColumnData
                AddHandler winExplorerView.GridControl.Load, Sub(s, e) GridHelper.SetFindControlImages(winExplorerView.GridControl, False)
            End If
            AddHandler Me.ViewModel.QueryFilterCriteria, AddressOf ViewModel_QueryFilterCriteria
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.QueryFilterCriteria, AddressOf ViewModel_QueryFilterCriteria
            If winExplorerView IsNot Nothing Then
                RemoveHandler winExplorerView.ItemClick, AddressOf winExplorerView_ItemClick
                RemoveHandler winExplorerView.CustomUnboundColumnData, AddressOf winExplorerView_CustomUnboundColumnData
                winExplorerView = Nothing
            End If
            MyBase.OnDisposing()
        End Sub
        Public Sub Load()
            Dim expression = FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).GetFilterExpression(ViewModel.FilterCriteria)

            Dim collectionViewModel_Renamed = GetParentViewModel(Of CollectionViewModel(Of TEntity, TID, TUnitOfWork))()
            If expression IsNot Nothing Then
                For Each entity As TEntity In collectionViewModel_Renamed.GetEntities(expression)
                    selection.Add(GetEntityKey(entity))
                Next entity
            End If
            winExplorerView.GridControl.DataSource = collectionViewModel_Renamed.GetEntities().ToList()
        End Sub
        Private selection As New HashSet(Of TID)()
        Protected MustOverride Function GetEntityKey(ByVal entity As TEntity) As TID
        Private Function GetIsSelected(ByVal entity As TEntity) As Boolean
            Return selection.Contains(GetEntityKey(entity))
        End Function
        Private Sub ViewModel_QueryFilterCriteria(ByVal sender As Object, ByVal e As QueryFilterCriteriaEventArgs)
            e.FilterCriteria = New InOperator("Id", selection)
        End Sub
        Private Sub SetIsSelected(ByVal entity As TEntity, ByVal selected As Boolean)
            If selected Then
                selection.Add(GetEntityKey(entity))
            Else
                selection.Remove(GetEntityKey(entity))
            End If
        End Sub
        Private Sub winExplorerView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs)
            If e.IsSetData Then
                SetIsSelected(CType(e.Row, TEntity), CBool(e.Value))
            End If
            If e.IsGetData Then
                e.Value = GetIsSelected(CType(e.Row, TEntity))
            End If
        End Sub
        Private Sub winExplorerView_ItemClick(ByVal sender As Object, ByVal e As WinExplorerViewItemClickEventArgs)
            Dim entity As TEntity = TryCast(e.ItemInfo.Row.RowKey, TEntity)
            If entity IsNot Nothing Then
                SetIsSelected(entity, (Not e.ItemInfo.IsChecked))
                winExplorerView.RefreshData()
            End If
        End Sub
    End Class
End Namespace
