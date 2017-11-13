Imports DevExpress.Mvvm.POCO
Imports System.Collections.Generic
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV
Imports System.Linq
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public Class OrdersReportViewModel
        Inherits ReportViewModelBase(Of SalesReportType, Order, Long, IDevAVDbUnitOfWork)

        Private unitOfWork As IDevAVDbUnitOfWork

        Public Shared Function Create() As OrdersReportViewModel
            Return ViewModelSource.Create(Function() New OrdersReportViewModel())
        End Function
        Protected Sub New()
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork()
        End Sub
        Public Function GetOrderItems() As IList(Of OrderItem)
            Return unitOfWork.OrderItems.ToList()
        End Function
    End Class
End Namespace
