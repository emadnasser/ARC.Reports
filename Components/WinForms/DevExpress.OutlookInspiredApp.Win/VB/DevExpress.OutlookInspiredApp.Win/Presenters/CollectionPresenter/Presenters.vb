Imports DevExpress.XtraGrid.Views.Layout.Events
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel
Imports System.Collections.Generic

Namespace DevExpress.DevAV.Presenters

    Public Class EmployeeCollectionPresenter
        Inherits CollectionPresenter(Of DevAV.Employee, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridControl As GridControl, ByVal viewModel As EmployeeCollectionViewModel, ByVal updateUIAction As System.Action(Of Integer))
            MyBase.New(gridControl, viewModel, updateUIAction)
        End Sub
        Protected Shadows ReadOnly Property ViewModel() As EmployeeCollectionViewModel
            Get
                Return TryCast(MyBase.ViewModel, EmployeeCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub SubscribeViewModelEvents()
            MyBase.SubscribeViewModelEvents()
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
        End Sub
        Protected Overrides Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            MyBase.UnsubscribeViewModelEvents()
        End Sub
        Protected Overrides Sub InitMouseClickBehavior()
            MyBase.InitMouseClickBehavior()
            AddHandler GridView.RowCellClick, AddressOf GridView_RowCellClick
            AddHandler LayoutView.FieldValueClick, AddressOf LayoutView_FieldValueClick
        End Sub
        Protected Overrides Sub ReleaseMouseClickBehavior()
            RemoveHandler GridView.RowCellClick, AddressOf GridView_RowCellClick
            RemoveHandler LayoutView.FieldValueClick, AddressOf LayoutView_FieldValueClick
            MyBase.ReleaseMouseClickBehavior()
        End Sub
        Protected Overrides Sub SetSelection(ByVal selection As IEnumerable(Of DevAV.Employee))
            ViewModel.Selection = selection
        End Sub
        Protected Overrides Function GetKey(ByVal entity As DevAV.Employee) As Long
            Return entity.Id
        End Function
        Private Sub GridView_RowCellClick(ByVal sender As Object, ByVal e As RowCellClickEventArgs)
            MailTo(e.RowHandle, e.Column, e.CellValue)
        End Sub
        Private Sub LayoutView_FieldValueClick(ByVal sender As Object, ByVal e As FieldValueClickEventArgs)
            MailTo(e.RowHandle, e.Column, e.FieldValue)
        End Sub
        Private Sub MailTo(ByVal rowHandle As Integer, ByVal column As GridColumn, ByVal value As Object)
            If rowHandle > -1 AndAlso column.FieldName = "Email" Then
                EmployeeContactsViewModel.ExecuteMailTo(GetService(Of DevExpress.Mvvm.IMessageBoxService)(), DirectCast(value, String))
            End If
        End Sub
    End Class
    Public Class CustomerCollectionPresenter
        Inherits CollectionPresenter(Of DevAV.Customer, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridControl As GridControl, ByVal viewModel As CustomerCollectionViewModel, ByVal updateUIAction As System.Action(Of Integer))
            MyBase.New(gridControl, viewModel, updateUIAction)
            AddHandler Me.GridControl.FocusedViewChanged, AddressOf gridControl_FocusedViewChanged
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler GridControl.FocusedViewChanged, AddressOf gridControl_FocusedViewChanged
            MyBase.OnDisposing()
        End Sub
        Private Sub gridControl_FocusedViewChanged(ByVal sender As Object, ByVal e As ViewFocusEventArgs)
            If e.View IsNot Nothing AndAlso e.View.IsDetailView Then
                Dim parentView = TryCast(e.View.ParentView, DevExpress.XtraGrid.Views.Base.ColumnView)
                If parentView IsNot Nothing Then
                    parentView.FocusedRowHandle = e.View.SourceRowHandle
                End If
            End If
        End Sub
        Protected Shadows ReadOnly Property ViewModel() As CustomerCollectionViewModel
            Get
                Return TryCast(MyBase.ViewModel, CustomerCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub SubscribeViewModelEvents()
            MyBase.SubscribeViewModelEvents()
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
        End Sub
        Protected Overrides Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            MyBase.UnsubscribeViewModelEvents()
        End Sub
        Protected Overrides Sub SetSelection(ByVal selection As IEnumerable(Of DevAV.Customer))
            ViewModel.Selection = selection
        End Sub
        Protected Overrides Function GetKey(ByVal entity As DevAV.Customer) As Long
            Return entity.Id
        End Function
    End Class
    Public Class ProductCollectionPresenter
        Inherits CollectionPresenter(Of DevAV.Product, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridControl As GridControl, ByVal viewModel As ProductCollectionViewModel, ByVal updateUIAction As System.Action(Of Integer))
            MyBase.New(gridControl, viewModel, updateUIAction)
        End Sub
        Protected Shadows ReadOnly Property ViewModel() As ProductCollectionViewModel
            Get
                Return TryCast(MyBase.ViewModel, ProductCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub SubscribeViewModelEvents()
            MyBase.SubscribeViewModelEvents()
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
        End Sub
        Protected Overrides Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            MyBase.UnsubscribeViewModelEvents()
        End Sub
        Protected Overrides Sub SetSelection(ByVal selection As IEnumerable(Of DevAV.Product))
            ViewModel.Selection = selection
        End Sub
        Protected Overrides Function GetKey(ByVal entity As DevAV.Product) As Long
            Return entity.Id
        End Function
    End Class
    Public Class OrderCollectionPresenter
        Inherits CollectionPresenter(Of DevAV.Order, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridControl As GridControl, ByVal viewModel As OrderCollectionViewModel, ByVal updateUIAction As System.Action(Of Integer))
            MyBase.New(gridControl, viewModel, updateUIAction)
            AddHandler Me.GridControl.FocusedViewChanged, AddressOf gridControl_FocusedViewChanged
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler GridControl.FocusedViewChanged, AddressOf gridControl_FocusedViewChanged
            MyBase.OnDisposing()
        End Sub
        Private Sub gridControl_FocusedViewChanged(ByVal sender As Object, ByVal e As ViewFocusEventArgs)
            If e.View IsNot Nothing AndAlso e.View.IsDetailView Then
                Dim parentView = TryCast(e.View.ParentView, DevExpress.XtraGrid.Views.Base.ColumnView)
                If parentView IsNot Nothing Then
                    parentView.FocusedRowHandle = e.View.SourceRowHandle
                End If
            End If
        End Sub
        Protected Shadows ReadOnly Property ViewModel() As OrderCollectionViewModel
            Get
                Return TryCast(MyBase.ViewModel, OrderCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub SubscribeViewModelEvents()
            MyBase.SubscribeViewModelEvents()
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
        End Sub
        Protected Overrides Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            MyBase.UnsubscribeViewModelEvents()
        End Sub
        Protected Overrides Sub SetSelection(ByVal selection As IEnumerable(Of DevAV.Order))
        End Sub
        Protected Overrides Function GetKey(ByVal entity As DevAV.Order) As Long
            Return entity.Id
        End Function
    End Class
End Namespace
