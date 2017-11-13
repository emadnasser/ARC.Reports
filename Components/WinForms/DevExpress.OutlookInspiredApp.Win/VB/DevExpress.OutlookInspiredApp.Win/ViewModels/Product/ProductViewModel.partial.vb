Imports DevExpress.Mvvm
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV
Imports System.Linq
Imports System.Collections.Generic

Namespace DevExpress.DevAV.ViewModels

    Partial Public Class ProductViewModel
        Public Event EntityChanged As System.EventHandler
        Protected Overrides Sub OnEntityChanged()
            MyBase.OnEntityChanged()
            Dim handler As System.EventHandler = EntityChangedEvent
            If handler IsNot Nothing Then
                handler(Me, System.EventArgs.Empty)
            End If
        End Sub
        Public Function GetSalesStores(Optional ByVal period As Period = Period.Lifetime) As IEnumerable(Of CustomerStore)
            Return QueriesHelper.GetSalesStoresForPeriod(UnitOfWork.Orders, period)
        End Function
        Public Function GetSales(Optional ByVal period As Period = Period.Lifetime) As IEnumerable(Of DevAV.MapItem)
            Return QueriesHelper.GetSaleMapItems(UnitOfWork.OrderItems, Entity.Id, period)
        End Function
        Public Function GetSalesByCity(ByVal city As String, Optional ByVal period As Period = Period.Lifetime) As IEnumerable(Of DevAV.MapItem)
            Return QueriesHelper.GetSaleMapItemsByCity(UnitOfWork.OrderItems, Entity.Id, city, period)
        End Function
        Public Overrides Sub Delete()
            MessageBoxService.ShowMessage("To ensure data integrity, the Products module doesn't allow records to be deleted. Record deletion is supported by the Employees module.", "Delete Product", MessageButton.OK)
        End Sub
    End Class
    Partial Public Class SynchronizedProductViewModel
        Inherits ProductViewModel

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