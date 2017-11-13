Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports DevExpress.Xpf.Utils
Imports System.ComponentModel
Imports System.Collections
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace GridDemo
    <POCOViewModel>
    Public Class CountItem
        Public Overridable Property DisplayName() As String
        Public Overridable Property Count() As Integer
    End Class
    Public Class CountItemCollection
        Inherits List(Of CountItem)

    End Class
    Public Class OrderDataListSource
        Implements IListSource

        Private orderDataGenerator As OrderDataGenerator


        Public Sub New(ByVal orderDataGenerator_Renamed As OrderDataGenerator)
            Me.orderDataGenerator = orderDataGenerator_Renamed
        End Sub
        Public ReadOnly Property ContainsListCollection() As Boolean Implements IListSource.ContainsListCollection
            Get
                Return False
            End Get
        End Property
        Public Function GetList() As IList Implements IListSource.GetList
            Return orderDataGenerator.GetOrders()
        End Function
    End Class

End Namespace
