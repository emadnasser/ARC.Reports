Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm
Imports System

Namespace DevExpress.DevAV.ViewModels

    Partial Public Class OrderViewModel
        Public Event EntityChanged As EventHandler
        Protected Overrides Sub OnEntityChanged()
            MyBase.OnEntityChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.Customize())
            RaiseEntityChanged()
        End Sub
        Public Event CustomizeFilter As EventHandler
        <Command>
        Public Sub Customize()
            RaiseCustomizeFilter()
        End Sub
        Public Function CanCustomize() As Boolean
            Return Entity IsNot Nothing
        End Function
        Private Sub RaiseEntityChanged()
            Dim handler As EventHandler = EntityChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private Sub RaiseCustomizeFilter()
            Dim handler As EventHandler = CustomizeFilterEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Public Overrides Sub Delete()
            MessageBoxService.ShowMessage("To ensure data integrity, the Sales module doesn't allow records to be deleted. Record deletion is supported by the Employees module.", "Delete Sale", MessageButton.OK)
        End Sub
    End Class
    Partial Public Class SynchronizedOrderViewModel
        Inherits OrderViewModel

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
