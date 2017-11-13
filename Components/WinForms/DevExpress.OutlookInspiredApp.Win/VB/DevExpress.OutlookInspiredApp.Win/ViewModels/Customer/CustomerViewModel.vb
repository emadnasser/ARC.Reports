Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.Common.DataModel
Imports DevExpress.DevAV
Imports DevExpress.DevAV.Common.ViewModel
Namespace DevExpress.DevAV.ViewModels
  ''' <summary>
  ''' Represents the single Customer object view model.
  ''' </summary>
  Public Partial Class CustomerViewModel
    Inherits SingleObjectViewModel(Of Customer, long, IDevAVDbUnitOfWork)    
    ''' <summary>
    ''' Creates a new instance of CustomerViewModel as a POCO view model.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing) As CustomerViewModel
      Return ViewModelSource.Create(Function() New CustomerViewModel(unitOfWorkFactory))
    End Function    
    ''' <summary>
    ''' Initializes a new instance of the CustomerViewModel class.
    ''' This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing)
      MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Customers, Function(ByVal x) x.Name)
    End Sub    
    ''' <summary>
    ''' The view model for the CustomerEmployees detail collection.
    ''' </summary>
    Public ReadOnly Property CustomerEmployeesDetails As CollectionViewModel(Of CustomerEmployee, long, IDevAVDbUnitOfWork)
      Get
        Return GetDetailsCollectionViewModel(Function(ByVal x As CustomerViewModel) x.CustomerEmployeesDetails, Function(ByVal x) x.CustomerEmployees, Function(ByVal x) x.CustomerId, Sub(ByVal x, ByVal key) x.CustomerId = key)
      End Get
    End Property    
    ''' <summary>
    ''' The view model for the CustomerOrders detail collection.
    ''' </summary>
    Public ReadOnly Property CustomerOrdersDetails As CollectionViewModel(Of Order, long, IDevAVDbUnitOfWork)
      Get
        Return GetDetailsCollectionViewModel(Function(ByVal x As CustomerViewModel) x.CustomerOrdersDetails, Function(ByVal x) x.Orders, Function(ByVal x) x.CustomerId, Sub(ByVal x, ByVal key) x.CustomerId = key, Function(ByVal query) query.ActualOrders())
      End Get
    End Property    
    ''' <summary>
    ''' The view model for the CustomerQuotes detail collection.
    ''' </summary>
    Public ReadOnly Property CustomerQuotesDetails As CollectionViewModel(Of Quote, long, IDevAVDbUnitOfWork)
      Get
        Return GetDetailsCollectionViewModel(Function(ByVal x As CustomerViewModel) x.CustomerQuotesDetails, Function(ByVal x) x.Quotes, Function(ByVal x) x.CustomerId, Sub(ByVal x, ByVal key) x.CustomerId = key, Function(ByVal query) query.ActualQuotes())
      End Get
    End Property    
    ''' <summary>
    ''' The view model for the CustomerCustomerStores detail collection.
    ''' </summary>
    Public ReadOnly Property CustomerCustomerStoresDetails As CollectionViewModel(Of CustomerStore, long, IDevAVDbUnitOfWork)
      Get
        Return GetDetailsCollectionViewModel(Function(ByVal x As CustomerViewModel) x.CustomerCustomerStoresDetails, Function(ByVal x) x.CustomerStores, Function(ByVal x) x.CustomerId, Sub(ByVal x, ByVal key) x.CustomerId = key)
      End Get
    End Property
  End Class
End Namespace
