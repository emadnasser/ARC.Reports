Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public Class EmployeesFilterTreeViewModel
        Inherits FilterTreeViewModel(Of Employee, Long, IDevAVDbUnitOfWork)

        Public Shared Function Create(ByVal collectionViewModel As EmployeeCollectionViewModel) As EmployeesFilterTreeViewModel
            Return ViewModelSource.Create(Function() New EmployeesFilterTreeViewModel(collectionViewModel))
        End Function
        Protected Sub New(ByVal collectionViewModel As EmployeeCollectionViewModel)
            MyBase.New(collectionViewModel, New FilterTreeModelPageSpecificSettings(Of My.Settings)(My.Settings.Default, StaticFiltersName, Function(x) x.EmployeesStaticFilters, Function(x) x.EmployeesCustomFilters, Function(x) x.EmployeesGroupFilters))
        End Sub
        Protected Shadows ReadOnly Property CollectionViewModel() As EmployeeCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, EmployeeCollectionViewModel)
            End Get
        End Property
    End Class
End Namespace
