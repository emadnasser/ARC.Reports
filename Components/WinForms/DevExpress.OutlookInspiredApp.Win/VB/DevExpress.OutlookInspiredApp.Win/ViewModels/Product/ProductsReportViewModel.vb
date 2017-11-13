Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV
Imports System.Linq
Imports System.Collections.Generic

Namespace DevExpress.DevAV.ViewModels

    Public Class ProductsReportViewModel
        Inherits ReportViewModelBase(Of ProductReportType, Product, Long, IDevAVDbUnitOfWork)

        Private unitOfWork As IDevAVDbUnitOfWork

        Public Shared Function Create() As ProductsReportViewModel
            Return ViewModelSource.Create(Function() New ProductsReportViewModel())
        End Function
        Protected Sub New()
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork()
        End Sub
        Public Function GetOrderItems(ByVal productId As Long) As IList(Of OrderItem)
            Return GetOrderItems(unitOfWork, productId).ToList()
        End Function
        Private Shared Function GetOrderItems(ByVal unitOfWork As IDevAVDbUnitOfWork, ByVal productId As Long) As IQueryable(Of OrderItem)
            Return From oi In unitOfWork.OrderItems
                   Where oi.ProductId IsNot Nothing AndAlso oi.ProductId = productId
                   Select oi
        End Function
        Public Function GetStates() As IList(Of State)
            Return unitOfWork.States.ToList()
        End Function
    End Class
End Namespace
