Imports System.ComponentModel.DataAnnotations
Imports System.Linq

Namespace GridDemo
    Public Class ConditionalFormattingViewModel
        Public Sub New()
            Items = SaleOverviewDataGenerator.GenerateSales()
        End Sub
        Private privateItems As SaleOverviewData()
        Public Property Items() As SaleOverviewData()
            Get
                Return privateItems
            End Get
            Private Set(ByVal value As SaleOverviewData())
                privateItems = value
            End Set
        End Property
    End Class
End Namespace
