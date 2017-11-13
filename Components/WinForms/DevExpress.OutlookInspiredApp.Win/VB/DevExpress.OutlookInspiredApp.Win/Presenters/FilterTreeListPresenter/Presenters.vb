Imports DevExpress.XtraTreeList
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel

Namespace DevExpress.DevAV.Presenters

    Public Class EmployeeFilterTreeListPresenter
        Inherits FilterTreeListPresenter(Of DevAV.Employee, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal treeList As TreeList, ByVal viewModel As EmployeesFilterTreeViewModel)
            MyBase.New(treeList, viewModel)
        End Sub
        Public Shadows ReadOnly Property CollectionViewModel() As EmployeeCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, EmployeeCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub SubscribeCollectionViewModelEvents()
            MyBase.SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            AddHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            AddHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
        End Sub
        Protected Overrides Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            RemoveHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            RemoveHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
            MyBase.UnsubscribeCollectionViewModelEvents()
        End Sub
    End Class
    Public Class CustomerFilterTreeListPresenter
        Inherits FilterTreeListPresenter(Of DevAV.Customer, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal treeList As TreeList, ByVal viewModel As CustomersFilterTreeViewModel)
            MyBase.New(treeList, viewModel)
        End Sub
        Public Shadows ReadOnly Property CollectionViewModel() As CustomerCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, CustomerCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub SubscribeCollectionViewModelEvents()
            MyBase.SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            AddHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            AddHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
        End Sub
        Protected Overrides Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            RemoveHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            RemoveHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
            MyBase.UnsubscribeCollectionViewModelEvents()
        End Sub
    End Class
    Public Class ProductFilterTreeListPresenter
        Inherits FilterTreeListPresenter(Of DevAV.Product, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal treeList As TreeList, ByVal viewModel As ProductsFilterTreeViewModel)
            MyBase.New(treeList, viewModel)
        End Sub
        Public Shadows ReadOnly Property CollectionViewModel() As ProductCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, ProductCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub SubscribeCollectionViewModelEvents()
            MyBase.SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            AddHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            AddHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
        End Sub
        Protected Overrides Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            RemoveHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            RemoveHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
            MyBase.UnsubscribeCollectionViewModelEvents()
        End Sub
    End Class
    Public Class OrderFilterTreeListPresenter
        Inherits FilterTreeListPresenter(Of DevAV.Order, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal treeList As TreeList, ByVal viewModel As OrdersFilterTreeViewModel)
            MyBase.New(treeList, viewModel)
        End Sub
        Public Shadows ReadOnly Property CollectionViewModel() As OrderCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, OrderCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub SubscribeCollectionViewModelEvents()
            MyBase.SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
        End Sub
        Protected Overrides Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            MyBase.UnsubscribeCollectionViewModelEvents()
        End Sub
    End Class
    Public Class QuoteFilterTreeListPresenter
        Inherits FilterTreeListPresenter(Of DevAV.Quote, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal treeList As TreeList, ByVal viewModel As QuotesFilterTreeViewModel)
            MyBase.New(treeList, viewModel)
        End Sub
        Public Shadows ReadOnly Property CollectionViewModel() As QuoteCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, QuoteCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub SubscribeCollectionViewModelEvents()
            MyBase.SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
        End Sub
        Protected Overrides Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            MyBase.UnsubscribeCollectionViewModelEvents()
        End Sub
    End Class
End Namespace
