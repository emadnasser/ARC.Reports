Imports System
Imports System.Collections.Generic
Imports DataAccess

Partial Public Class RevenueByProduct
    Inherits RevenueBasePage

    Public Overrides ReadOnly Property RangeControl() As IRangeControl
        Get
            Return FooterRangeControl
        End Get
    End Property

    Protected Overrides ReadOnly Property DailySalesPerformanceVerticalChart() As VerticalChartControlBase
        Get
            Return DailySalesPerformanceChart
        End Get
    End Property
    Protected Overrides ReadOnly Property UnitSalesVerticalChart() As VerticalChartControlBase
        Get
            Return UnitSalesChart
        End Get
    End Property

    Protected Overrides Function GetChartSalesCountCollection(ByVal startDate As Date, ByVal endDate As Date) As IEnumerable(Of ChartData)
        Return SalesProvider.GetSaleCountGroupedByProduct(startDate, endDate)
    End Function
    Protected Overrides Function GetChartSalesRevenueCollection(ByVal startDate As Date, ByVal endDate As Date) As IEnumerable(Of ChartData)
        Return SalesProvider.GetSalesGroupedByProduct(startDate, endDate)
    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        ProductSalesRevenue.SetData(SalesProvider.GetSalesGroupedByProduct(SalesStartDate, SalesEndDate))
    End Sub
End Class
