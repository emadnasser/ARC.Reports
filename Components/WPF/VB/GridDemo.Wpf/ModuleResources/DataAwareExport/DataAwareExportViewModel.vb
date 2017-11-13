Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace GridDemo
    <POCOViewModel>
    Public Class DataAwareExportViewModel
        Private dataGenerator As ProductSaleDataGenerator

        Public Overridable Property ItemCount() As Integer?
        Protected Sub OnItemCountChanged()
            If (Not ViewModelBase.IsInDesignMode) AndAlso ItemCount.HasValue Then
                Items = dataGenerator.GenerateSales(ItemCount.Value)
            End If
        End Sub

        Public Overridable Property Items() As List(Of ProductSaleData)

        Public Sub New()
            If Not ViewModelBase.IsInDesignMode Then
                dataGenerator = New ProductSaleDataGenerator()
            End If
        End Sub
    End Class
End Namespace
