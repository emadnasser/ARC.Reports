Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV
Imports System.Linq
Imports System.Collections.Generic

Namespace DevExpress.DevAV.ViewModels

    Public Class CustomersReportViewModel
        Inherits ReportViewModelBase(Of CustomerReportType, Customer, Long, IDevAVDbUnitOfWork)

        Private unitOfWork As IDevAVDbUnitOfWork

        Public Shared Function Create() As CustomersReportViewModel
            Return ViewModelSource.Create(Function() New CustomersReportViewModel())
        End Function
        Protected Sub New()
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork()
        End Sub
        Public ReadOnly Property CustomerEmployees() As IList(Of CustomerEmployee)
            Get
                Return unitOfWork.CustomerEmployees.ToList()
            End Get
        End Property
        Public ReadOnly Property CustomerStores() As IList(Of CustomerStore)
            Get
                Return unitOfWork.CustomerStores.ToList()
            End Get
        End Property
    End Class
End Namespace
