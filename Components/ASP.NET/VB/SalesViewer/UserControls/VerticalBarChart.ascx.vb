Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Web.UI.WebControls
Imports DataAccess
Imports DevExpress.Web
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class VerticalBarChart
    Inherits VerticalChartControlBase

    Public Property IsCurrency() As Boolean

    Public Property ChartOffsetX() As Integer

    Public Property CurrentTitle() As String
    Public Property PreviousTitle() As String
    Public Property CustomPeriodTitle() As String

    Public Property TitleFormatString() As String
    Public Property RangeSelectorFormatString() As String
    Public Property CrosshairFormatString() As String
        Get
            Return WebChartControl.SeriesTemplate.CrosshairLabelPattern
        End Get
        Set(ByVal value As String)
            WebChartControl.SeriesTemplate.CrosshairLabelPattern = value
        End Set
    End Property
    Public Property SelectionInterval() As SelectionInterval
        Get
            Return DateSelectorControl.SelectionInterval
        End Get
        Set(ByVal value As SelectionInterval)
            DateSelectorControl.SelectionInterval = value
        End Set
    End Property
    Public Property Width() As Unit
        Get
            Return VerticalBarCallbackPanel.Width
        End Get
        Set(ByVal value As Unit)
            VerticalBarCallbackPanel.Width = value
        End Set
    End Property
    Public Property Height() As Unit
        Get
            Return VerticalBarCallbackPanel.Height
        End Get
        Set(ByVal value As Unit)
            VerticalBarCallbackPanel.Height = value
        End Set
    End Property
    Protected Overrides ReadOnly Property WebChartControl() As WebChartControl
        Get
            Return VerticalChartControl
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        DateSelectorControl.CallbackPanelId = VerticalBarCallbackPanel.ClientID
        If ChartOffsetX < 0 Then
            VerticalBarCallbackPanel.Paddings.PaddingLeft = Unit.Pixel(-ChartOffsetX)
        End If
    End Sub

    Public Overrides Function GetSelectedDate() As Date
        Return DateSelectorControl.CurrentDate
    End Function

    Public Overrides Sub SetChartData(ByVal current As List(Of ChartData), ByVal previous As List(Of ChartData))
        For Each item In current
            item.SeriesName = CurrentSeriesName
        Next item
        For Each item In previous
            item.SeriesName = PreviousSeriesName
        Next item
        WebChartControl.DataSource = previous.Union(current).ToList()
        WebChartControl.DataBind()
    End Sub

    Protected Sub VerticalBarCallbackPanel_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
        Dim delta As Integer = 0
        If Int32.TryParse(e.Parameter, delta) AndAlso delta <> 0 Then
            DateSelectorControl.ChangeDate(delta)
            RaiseRangeSelectionChanged()
        End If
    End Sub
    Protected Sub VerticalChartControl_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As CustomDrawAxisLabelEventArgs)
        If TypeOf e.Item.Axis Is AxisY Then
            If IsCurrency Then
                e.Item.Text = ScaleHelper.GetCurrencyAbbreviationMask(e.Item.Text, AbbreviationType.Thousands)
            Else
                e.Item.Text = ScaleHelper.GetAbbreviationMask(e.Item.Text, AbbreviationType.Thousands)
            End If
        End If
    End Sub
    Protected Sub VerticalChartControl_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim currentSeries As Series = WebChartControl.GetSeriesByName(CurrentSeriesName)
        If currentSeries IsNot Nothing Then
            CType(currentSeries.View, SideBySideBarSeriesView).ColorEach = True
        End If
    End Sub
End Class

