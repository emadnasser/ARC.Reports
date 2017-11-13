Imports System
Imports System.Collections.Generic
Imports DataAccess

Partial Public Class RevenueBySector
    Inherits RevenueBasePage

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
        Return SalesProvider.GetSaleCountGroupedBySector(startDate, endDate)
    End Function
    Protected Overrides Function GetChartSalesRevenueCollection(ByVal startDate As Date, ByVal endDate As Date) As IEnumerable(Of ChartData)
        Return SalesProvider.GetSalesGroupedBySector(startDate, endDate)
    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        ProductSalesRevenue.SetData(SalesProvider.GetSalesGroupedBySector(SalesStartDate, SalesEndDate))
    End Sub

    Public Overrides ReadOnly Property RangeControl() As IRangeControl
        Get
            Return FooterRangeControl
        End Get
    End Property
End Class
