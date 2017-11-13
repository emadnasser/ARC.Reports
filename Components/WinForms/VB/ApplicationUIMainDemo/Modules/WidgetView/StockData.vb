Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class StockData
        Public Property ClosePrice() As Decimal
        Public Property [Date]() As Date
        Public Property HighPrice() As Decimal
        Public Property LowPrice() As Decimal
        Public Property OpenPrice() As Decimal
        Public Property Volumne() As Integer
    End Class
    Public NotInheritable Class StockDataCreator
        Private Const BeginDate As Integer = 40000
        Private Shared r As New Random()
        Private Sub New()
        End Sub
        Public Shared Function GetData(ByVal index As Integer) As StockData
            Dim delta As Integer = r.Next(-5, 5)
            Dim data As New StockData()
            data.Date = Date.FromOADate(BeginDate + index)
            data.HighPrice = r.Next(20 + delta, 30 + delta) + CDec(Math.Round(r.NextDouble(), 2))
            data.LowPrice = r.Next(10 + delta, 18 + delta) + CDec(Math.Round(r.NextDouble(), 2))
            data.OpenPrice = r.Next(20 + delta, 25 + delta) + CDec(Math.Round(r.NextDouble(), 2))
            data.ClosePrice = r.Next(15 + delta, 20 + delta) + CDec(Math.Round(r.NextDouble(), 2))
            data.Volumne = r.Next(10000, 18000)
            Return data
        End Function
    End Class
End Namespace
