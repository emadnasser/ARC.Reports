Imports DevExpress.XtraBars.Navigation
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel

Namespace DevExpress.DevAV.Presenters

    Public Class EmployeeFilterPanePresenter
        Inherits FilterPanePresenter(Of DevAV.Employee, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As EmployeesFilterTreeViewModel)
            MyBase.New(navigationBar, viewModel)
        End Sub
        Public Shadows ReadOnly Property CollectionViewModel() As EmployeeCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, EmployeeCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub BindAllFoldersItem(ByVal allFoldersItem As NavigationBarItem)
            allFoldersItem.BindCommand(Sub() CollectionViewModel.ShowAllFolders(), CollectionViewModel)
        End Sub
    End Class
    Public Class CustomerFilterPanePresenter
        Inherits FilterPanePresenter(Of DevAV.Customer, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As CustomersFilterTreeViewModel)
            MyBase.New(navigationBar, viewModel)
        End Sub
        Public Shadows ReadOnly Property CollectionViewModel() As CustomerCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, CustomerCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub BindAllFoldersItem(ByVal allFoldersItem As NavigationBarItem)
            allFoldersItem.BindCommand(Sub() CollectionViewModel.ShowAllFolders(), CollectionViewModel)
        End Sub
    End Class
    Public Class ProductFilterPanePresenter
        Inherits FilterPanePresenter(Of DevAV.Product, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As ProductsFilterTreeViewModel)
            MyBase.New(navigationBar, viewModel)
        End Sub
        Public Shadows ReadOnly Property CollectionViewModel() As ProductCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, ProductCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub BindAllFoldersItem(ByVal allFoldersItem As NavigationBarItem)
            allFoldersItem.BindCommand(Sub() CollectionViewModel.ShowAllFolders(), CollectionViewModel)
        End Sub
    End Class
    Public Class OrderFilterPanePresenter
        Inherits FilterPanePresenter(Of DevAV.Order, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As OrdersFilterTreeViewModel)
            MyBase.New(navigationBar, viewModel)
        End Sub
        Public Shadows ReadOnly Property CollectionViewModel() As OrderCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, OrderCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub BindAllFoldersItem(ByVal allFoldersItem As NavigationBarItem)
            allFoldersItem.BindCommand(Sub() CollectionViewModel.ShowAllFolders(), CollectionViewModel)
        End Sub
    End Class
    Public Class QuoteFilterPanePresenter
        Inherits FilterPanePresenter(Of DevAV.Quote, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As QuotesFilterTreeViewModel)
            MyBase.New(navigationBar, viewModel)
        End Sub
        Public Shadows ReadOnly Property CollectionViewModel() As QuoteCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, QuoteCollectionViewModel)
            End Get
        End Property
        Protected Overrides Sub BindAllFoldersItem(ByVal allFoldersItem As NavigationBarItem)
            allFoldersItem.BindCommand(Sub() CollectionViewModel.ShowAllFolders(), CollectionViewModel)
        End Sub
    End Class
End Namespace
