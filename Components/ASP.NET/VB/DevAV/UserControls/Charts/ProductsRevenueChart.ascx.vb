Imports System
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class UserControls_Charts_ProductsRevenueChart
    Inherits ChartUserControl

    Public Overrides ReadOnly Property Chart() As WebChartControl
        Get
            Return RevenueChart
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Chart.Series(0).DataSource = DataProvider.GetRevenueChartData()
    End Sub

    Protected Sub RevenueChart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
        OnCustomDrawSeriesPoint(e)
    End Sub
    Protected Sub RevenueChart_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
        ChangeChartWidth(Convert.ToInt32(e.Parameter))
    End Sub
End Class
