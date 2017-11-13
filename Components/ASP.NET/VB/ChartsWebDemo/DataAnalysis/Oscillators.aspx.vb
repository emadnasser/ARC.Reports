Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class Oscillators
	Inherits ChartBasePage
	Private ReadOnly Property SeriesView() As StockSeriesView
		Get
			Return CType(WebChartControl1.Series(0).View, StockSeriesView)
		End Get
	End Property
	Private ReadOnly Property Diagram() As XYDiagram
		Get
			Return CType(WebChartControl1.Diagram, XYDiagram)
		End Get
	End Property

	Private Function CreateIndicator() As SeparatePaneIndicator
		Select Case cmbOscillator.SelectedIndex
			Case 1
				Return New CommodityChannelIndex("(CCI) Commodity Channel Index")
			Case 2
				Return New DetrendedPriceOscillator("(DPO) Detrended Price Oscillator")
			Case 3
				Return New MovingAverageConvergenceDivergence("(MACD) Moving Average Convergence Divergence")
			Case 4
				Return New RateOfChange("(RoC) Rate of Change")
			Case 5
				Return New RelativeStrengthIndex("(RSI) Relative Strength Index")
			Case 6
				Return New ChaikinsVolatility("(CHV) Chaikins Volatility")
			Case 7
				Return New WilliamsR("(%R) Williams %R")
			Case Else
				Return New AverageTrueRange("(ATR) Average True Range")
		End Select
	End Function
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		SeriesView.Indicators.Clear()
		Dim indicator As SeparatePaneIndicator = CreateIndicator()
		indicator.Pane = Diagram.Panes(0)
		indicator.AxisY = Diagram.SecondaryAxesY(0)
		SeriesView.Indicators.Add(indicator)
		CType(WebChartControl1.Annotations(0), TextAnnotation).Text = indicator.Name
	End Sub
	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl1
	End Function
End Class
