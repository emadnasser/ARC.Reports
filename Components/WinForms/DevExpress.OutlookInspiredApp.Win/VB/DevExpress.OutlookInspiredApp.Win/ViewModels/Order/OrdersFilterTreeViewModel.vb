Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public Class OrdersFilterTreeViewModel
        Inherits FilterTreeViewModel(Of Order, Long, IDevAVDbUnitOfWork)

        Public Shared Function Create(ByVal collectionViewModel As OrderCollectionViewModel) As OrdersFilterTreeViewModel
            Return ViewModelSource.Create(Function() New OrdersFilterTreeViewModel(collectionViewModel))
        End Function
        Protected Sub New(ByVal collectionViewModel As OrderCollectionViewModel)
            MyBase.New(collectionViewModel, New FilterTreeModelPageSpecificSettings(Of My.Settings)(My.Settings.Default, StaticFiltersName, Function(x) x.OrdersStaticFilters, Function(x) x.OrdersCustomFilters, Function(x) x.OrdersGroupFilters))
        End Sub
        Protected Shadows ReadOnly Property CollectionViewModel() As OrderCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, OrderCollectionViewModel)
            End Get
        End Property
        Protected Overrides ReadOnly Property EnableGroups() As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
