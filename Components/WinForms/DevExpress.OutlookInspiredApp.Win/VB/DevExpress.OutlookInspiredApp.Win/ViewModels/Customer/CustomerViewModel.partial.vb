Imports DevExpress.Mvvm
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV
Imports System.Linq
Imports System.Collections.Generic

Namespace DevExpress.DevAV.ViewModels

    Partial Public Class CustomerViewModel
        Public Event EntityChanged As System.EventHandler
        Protected Overrides Sub OnEntityChanged()
            MyBase.OnEntityChanged()
            Dim handler As System.EventHandler = EntityChangedEvent
            If handler IsNot Nothing Then
                handler(Me, System.EventArgs.Empty)
            End If
        End Sub
        Public Function GetSalesStores(Optional ByVal period As Period = Period.Lifetime) As IEnumerable(Of CustomerStore)
            Return QueriesHelper.GetDistinctStoresForPeriod(UnitOfWork.Orders, Entity.Id, period)
        End Function
        Public Function GetSales(Optional ByVal period As Period = Period.Lifetime) As IEnumerable(Of DevAV.MapItem)
            Return QueriesHelper.GetSaleMapItemsByCustomer(UnitOfWork.OrderItems, Entity.Id, period)
        End Function
        Public Function GetSalesByCity(ByVal city As String, Optional ByVal period As Period = Period.Lifetime) As IEnumerable(Of DevAV.MapItem)
            Return QueriesHelper.GetSaleMapItemsByCustomerAndCity(UnitOfWork.OrderItems, Entity.Id, city, period)
        End Function
        Public Overrides Sub Delete()
            MessageBoxService.ShowMessage("To ensure data integrity, the Customers module doesn't allow records to be deleted. Record deletion is supported by the Employees module.", "Delete Customer", MessageButton.OK)
        End Sub
    End Class
    Partial Public Class SynchronizedCustomerViewModel
        Inherits CustomerViewModel

        Protected Overrides ReadOnly Property EnableSelectedItemSynchronization() As Boolean
            Get
                Return True
            End Get
        End Property
        Protected Overrides ReadOnly Property EnableEntityChangedSynchronization() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
