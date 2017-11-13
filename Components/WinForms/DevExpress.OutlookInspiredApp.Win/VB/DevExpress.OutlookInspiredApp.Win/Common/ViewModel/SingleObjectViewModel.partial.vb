Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.Common.DataModel

Namespace DevExpress.DevAV.Common.ViewModel
    Partial Public Class SingleObjectViewModel(Of TEntity As Class, TPrimaryKey, TUnitOfWork As IUnitOfWork)
        Protected Overridable ReadOnly Property EnableSelectedItemSynchronization() As Boolean
            Get
                Return False
            End Get
        End Property
        Protected Overrides Sub OnInitializeInRuntime()
            MyBase.OnInitializeInRuntime()
            If EnableSelectedItemSynchronization Then
                SubscribeSelectedItemSynchronizationMessage()
            End If
        End Sub
        Protected Sub SubscribeSelectedItemSynchronizationMessage()
            Messenger.Default.Register(Of SelectedItemSynchronizationMessage(Of TEntity))(Me, Sub(x) OnSelectedItemSynchronizationMessage(x))
        End Sub
        Protected Overridable Sub OnSelectedItemSynchronizationMessage(ByVal m As SelectedItemSynchronizationMessage(Of TEntity))
            If m.Entity Is Nothing Then
                Entity = Nothing
            Else
                OnParameterChanged(Repository.GetPrimaryKey(m.Entity))
            End If
        End Sub
        Protected Overridable ReadOnly Property EnableEntityChangedSynchronization() As Boolean
            Get
                Return False
            End Get
        End Property
        Protected Overrides Sub OnEntityMessage(ByVal msg As EntityMessage(Of TEntity, TPrimaryKey))
            If EnableEntityChangedSynchronization AndAlso msg.MessageType = EntityMessageType.Changed Then
                If Object.Equals(msg.PrimaryKey, PrimaryKey) Then
                    Reload()
                End If
            End If
            MyBase.OnEntityMessage(msg)
        End Sub
    End Class
End Namespace
