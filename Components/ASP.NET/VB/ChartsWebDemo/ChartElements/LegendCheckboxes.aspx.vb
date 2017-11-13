Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class LegendCheckboxesDemo
	Inherits ChartBasePage
	Private Const seriesCount As Integer = 5
	Private Const indicatorPaletteName As String = "SameAsChartPaletteIndicatorpalette"
	Private Const stripColorAlpha As Integer = 55

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			CreteRegressionLines()
			CreateStrips()
		End If
	End Sub

	Private Sub CreteRegressionLines()
		For Each series As Series In WebChartControl1.Series
			Dim view As XYDiagram2DSeriesViewBase = CType(series.View, XYDiagram2DSeriesViewBase)
			Dim regressionLine As New RegressionLine(series.Name & " Trend")
			regressionLine.ShowInLegend = True
			regressionLine.Color = series.View.Color
			regressionLine.CheckedInLegend = False
			view.Indicators.Add(regressionLine)
		Next series
	End Sub
	Private Sub CreateStrips()
		Dim diagram As XYDiagram2D = CType(WebChartControl1.Diagram, XYDiagram2D)
		Dim axisY As Axis2D = diagram.GetAllAxesY()(0)
		Dim paletteEntries() As PaletteEntry = WebChartControl1.GetPaletteEntries(seriesCount)
		Dim counter As Integer = 0
		For Each series As Series In WebChartControl1.Series
			Dim firstValue As Double = series.Points(0).Values(0)
			Dim minValue As Double = firstValue
			Dim maxValue As Double = firstValue
			For Each seriesPoint As SeriesPoint In series.Points
				If seriesPoint.Values(0) > maxValue Then
					maxValue = seriesPoint.Values(0)
				End If
				If seriesPoint.Values(0) < minValue Then
					minValue = seriesPoint.Values(0)
				End If
			Next seriesPoint
			Dim strip As New Strip(series.Name & " Range", minValue, maxValue)
			Dim stripColor As Color = paletteEntries(counter).Color
			stripColor = Color.FromArgb(stripColorAlpha, stripColor)
			strip.Color = stripColor
			strip.ShowInLegend = True
			strip.CheckedInLegend = False
			axisY.Strips.Add(strip)
			counter += 1
		Next series
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ChangeUseCheckboxes" Then
			WebChartControl1.Legend.UseCheckBoxes = Not WebChartControl1.Legend.UseCheckBoxes
		ElseIf e.Parameter = "ChangeIndicatorsCheckability" Then
			For Each series As Series In WebChartControl1.Series
				Dim indicator As Indicator = (CType(series.View, XYDiagram2DSeriesViewBase)).Indicators(0)
				indicator.CheckableInLegend = Not indicator.CheckableInLegend
			Next series
		End If
	End Sub
End Class
