Imports System

Namespace DevExpress.DevAV.Common.ViewModel
    Public Class SelectedItemSynchronizationMessage(Of TEntity As Class)
        Public Sub New(ByVal entity As TEntity)
            Me.Entity = entity
        End Sub
        Private privateEntity As TEntity
        Public Property Entity() As TEntity
            Get
                Return privateEntity
            End Get
            Private Set(ByVal value As TEntity)
                privateEntity = value
            End Set
        End Property
    End Class
End Namespace
