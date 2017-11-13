Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.DemoData.Models

Namespace GridDemo
    Public Class ProductSaleDataGenerator
        Private ReadOnly random As New Random()
        Private ReadOnly products As List(Of String) = Nothing

        Public Sub New()
            products = NWindContext.Create().Invoices.Select(Function(invoice) invoice.ProductName).Distinct().ToList()
        End Sub

        Public Function GenerateSales(ByVal count As Integer) As List(Of ProductSaleData)
            Dim sales As New List(Of ProductSaleData)()
            Dim countries = NWindContext.Create().CountriesArray
            Return Enumerable.Range(0, count).Select(Function(index) CreateSale(countries(index Mod countries.Length), products(index Mod products.Count), Date.Today.Year - index Mod 9)).ToList()
        End Function
        Public Function CreateSale(ByVal country As String, ByVal product As String, ByVal year As Integer) As ProductSaleData
            Dim sale = New ProductSaleData()
            sale.Country = country
            sale.ProductName = product
            sale.Year = year
            sale.Sales = random.Next(50000000, 500000000)
            sale.SalesVsTarget = (random.NextDouble() - 0.5) / 5
            sale.Profit = random.Next(-30000000, 50000000)
            sale.CustomersSatisfaction = Math.Round((random.NextDouble() + 1) * 2.5, 1)
            sale.MarketShare = random.NextDouble() / 3 + 0.15
            Return sale
        End Function
    End Class
End Namespace
