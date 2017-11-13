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
  ''' Represents the single Quote object view model.
  ''' </summary>
  Public Partial Class QuoteViewModel
    Inherits SingleObjectViewModel(Of Quote, long, IDevAVDbUnitOfWork)    
    ''' <summary>
    ''' Creates a new instance of QuoteViewModel as a POCO view model.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing) As QuoteViewModel
      Return ViewModelSource.Create(Function() New QuoteViewModel(unitOfWorkFactory))
    End Function    
    ''' <summary>
    ''' Initializes a new instance of the QuoteViewModel class.
    ''' This constructor is declared protected to avoid undesired instantiation of the QuoteViewModel type without the POCO proxy factory.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing)
      MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Quotes, Function(ByVal x) x.Number)
    End Sub    
    ''' <summary>
    ''' The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
    ''' </summary>
    Public ReadOnly Property LookUpCustomers As IEntitiesViewModel(Of Customer)
      Get
        Return GetLookUpEntitiesViewModel(Function(ByVal x As QuoteViewModel) x.LookUpCustomers, Function(ByVal x) x.Customers)
      End Get
    End Property    
    ''' <summary>
    ''' The view model that contains a look-up collection of CustomerStores for the corresponding navigation property in the view.
    ''' </summary>
    Public ReadOnly Property LookUpCustomerStores As IEntitiesViewModel(Of CustomerStore)
      Get
        Return GetLookUpEntitiesViewModel(Function(ByVal x As QuoteViewModel) x.LookUpCustomerStores, Function(ByVal x) x.CustomerStores)
      End Get
    End Property    
    ''' <summary>
    ''' The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
    ''' </summary>
    Public ReadOnly Property LookUpEmployees As IEntitiesViewModel(Of Employee)
      Get
        Return GetLookUpEntitiesViewModel(Function(ByVal x As QuoteViewModel) x.LookUpEmployees, Function(ByVal x) x.Employees)
      End Get
    End Property    
    ''' <summary>
    ''' The view model for the QuoteQuoteItems detail collection.
    ''' </summary>
    Public ReadOnly Property QuoteQuoteItemsDetails As CollectionViewModel(Of QuoteItem, long, IDevAVDbUnitOfWork)
      Get
        Return GetDetailsCollectionViewModel(Function(ByVal x As QuoteViewModel) x.QuoteQuoteItemsDetails, Function(ByVal x) x.QuoteItems, Function(ByVal x) x.QuoteId, Sub(ByVal x, ByVal key) x.QuoteId = key)
      End Get
    End Property
  End Class
End Namespace
