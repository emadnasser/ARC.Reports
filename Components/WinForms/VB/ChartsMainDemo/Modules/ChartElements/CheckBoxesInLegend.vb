Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing

Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class CheckBoxesInLegendDemo
		Inherits ChartDemoBase
		Private Const StripColorAlpha As Integer = 55

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Me.chart.DataSource = ChartData.GetData()
		End Sub

		Private Sub CreateRegressionLines()
			For i As Integer = 0 To chart.Series.Count - 1
				Dim series As Series = chart.Series(i)
				Dim view As XYDiagram2DSeriesViewBase = CType(series.View, XYDiagram2DSeriesViewBase)
				Dim regressionLine As New RegressionLine(series.Name & " Trend")
				regressionLine.ShowInLegend = True
				regressionLine.Color = chart.PaletteRepository(chart.PaletteName)(i).Color
				regressionLine.CheckedInLegend = False
				view.Indicators.Add(regressionLine)
			Next i
		End Sub
		Private Sub CreateStrips()
			Dim diagram As XYDiagram2D = CType(chart.Diagram, XYDiagram2D)
			Dim axisY As Axis2D = diagram.GetAllAxesY()(0)
			Dim paletteEntries() As PaletteEntry = chart.GetPaletteEntries(Me.chart.Series.Count)
			Dim counter As Integer = 0
			For Each series As Series In chart.Series
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
				stripColor = Color.FromArgb(StripColorAlpha, stripColor)
				strip.Color = stripColor
				strip.ShowInLegend = True
				strip.CheckedInLegend = False
				axisY.Strips.Add(strip)
				counter += 1
			Next series
		End Sub
		Private Sub checkEditUseCheckBoxes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditUseCheckBoxes.CheckedChanged
			chart.Legend.UseCheckBoxes = Not chart.Legend.UseCheckBoxes
			checkEdit2.Enabled = chart.Legend.UseCheckBoxes
		End Sub
		Private Sub checkEdit2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit2.CheckedChanged
			For Each series As Series In chart.Series
				Dim indicator As Indicator = (CType(series.View, XYDiagram2DSeriesViewBase)).Indicators(0)
				indicator.CheckableInLegend = Not indicator.CheckableInLegend
			Next series
		End Sub
		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.BoundDataChanged
			CreateRegressionLines()
			CreateStrips()
		End Sub
	End Class

	Friend Class ChartData
		Public Class ChartDataItem
			Private privateSeries As String
			Public Property Series() As String
				Get
					Return privateSeries
				End Get
				Private Set(ByVal value As String)
					privateSeries = value
				End Set
			End Property
			Private privateYear As DateTime
			Public Property Year() As DateTime
				Get
					Return privateYear
				End Get
				Private Set(ByVal value As DateTime)
					privateYear = value
				End Set
			End Property
			Private privateValue As Double
			Public Property Value() As Double
				Get
					Return privateValue
				End Get
				Private Set(ByVal value As Double)
					privateValue = value
				End Set
			End Property
			Public Sub New(ByVal series As String, ByVal year As DateTime, ByVal value As Double)
				Me.Series = series
				Me.Year = year
				Me.Value = value
			End Sub
		End Class

		Public Shared Function GetData() As List(Of ChartDataItem)
			Dim itemsCount As Integer = 6
			Dim values() As Double = { 46900R, 43658R, 42658R, 41235R, 42568R, 41888R, 68953R, 67456R, 67986R, 65326R, 63255R, 60223R, 10569R, 15786R, 19300R, 18756R, 18749R, 20112R, 65897R, 62102R, 61325R, 55400R, 62359R, 65212R, 45356R, 46893R, 50326R, 43268R, 43265R, 63262R }
			Dim series() As String = { "Beverages", "Dairy Products", "Ice Cream", "Refrigerated Meat", "Sausage" }
			Dim currentDate As DateTime = DateTime.Now
			Dim data As New List(Of ChartDataItem)()
			For s As Integer = 0 To series.Length - 1
				For d As Integer = 0 To itemsCount - 1
					data.Add(New ChartDataItem(series(s), currentDate.AddYears(-d), values((s * itemsCount + d) Mod values.Length)))
				Next d
			Next s
			Return data
		End Function
	End Class
End Namespace
