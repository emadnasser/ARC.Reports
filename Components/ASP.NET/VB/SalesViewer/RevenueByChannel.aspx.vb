Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DataAccess
Imports DevExpress.Utils
Imports DevExpress.XtraCharts

Partial Public Class RevenueByChannel
    Inherits BasePage

    Public Overrides ReadOnly Property RangeControl() As IRangeControl
        Get
            Return FooterRangeControl
        End Get
    End Property
    Public Property ChannelsRevenue() As List(Of ChartData)
    Private Property EarliestDateTime() As Date

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        PaletteHelper.LoadCommonPalette(ChartControl)
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        DateSelectorControl.CallbackPanelId = DailyRevenueCallbackPanel.ClientID
        ProductSalesRevenue.SetData(SalesProvider.GetSalesGroupedByChannel(SalesStartDate, SalesEndDate))
        If Not IsCallback Then
            PopulateDailySalesData()
        End If
    End Sub
    Private Sub PopulateDailySalesData()
        Dim data As List(Of RangeChartData) = SalesProvider.GetDailySalesGroupedByChannel(DateSelectorControl.CurrentDate).ToList()
        ChannelsRevenue = data.GroupBy(Function(d) d.SeriesName).Select(Function(item) New ChartData() With {.Value = item.Sum(Function(x) x.Value), .PointName = item.Key}).ToList()
        EarliestDateTime = data.Min(Function(x) x.Argument)
        ChartControl.DataSource = data
        ChartControl.DataBind()
    End Sub

    Protected Sub DailyRevenueCallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
        Dim delta As Integer = 0
        If Int32.TryParse(e.Parameter, delta) AndAlso delta <> 0 Then
            DateSelectorControl.ChangeDate(delta)
            PopulateDailySalesData()
        End If
    End Sub
    Protected Sub ChartControl_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As CustomDrawAxisLabelEventArgs)
        If TypeOf e.Item.Axis Is AxisX AndAlso CDate(e.Item.AxisValue) = EarliestDateTime Then
            e.Item.Text = ""
        End If
    End Sub
End Class
