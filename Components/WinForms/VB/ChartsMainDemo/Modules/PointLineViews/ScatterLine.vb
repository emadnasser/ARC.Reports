Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class ScatterLineDemo
		Inherits ChartDemoLineBase
		Private Const A As Integer = 10
		Private Const ArchimedeanSpiralIndex As Integer = 0
		Private Const CardioidIndex As Integer = 1
		Private Const CartesianFoliumIndex As Integer = 2

		Private ReadOnly Property Series() As SeriesCollection
			Get
				Return chart.Series
			End Get
		End Property
		Private ReadOnly Property ArchimedeanSpiralSeries() As Series
			Get
				Return Series(ArchimedeanSpiralIndex)
			End Get
		End Property
		Private ReadOnly Property CardioidSeries() As Series
			Get
				Return Series(CardioidIndex)
			End Get
		End Property
		Private ReadOnly Property CartesianFoliumSeries() As Series
			Get
				Return Series(CartesianFoliumIndex)
			End Get
		End Property
		Protected Overrides ReadOnly Property ProcessedSeries() As Series()
			Get
				Return New Series() { ArchimedeanSpiralSeries, CardioidSeries, CartesianFoliumSeries }
			End Get
		End Property
		Protected Overrides ReadOnly Property CrosshairEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.False
			End Get
		End Property
		Protected Overrides ReadOnly Property ToolTipEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.True
			End Get
		End Property
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()

		End Sub
		Private Sub CreateArchimedeanSpiralPoints()
			For i As Integer = 0 To 719 Step 10
				Dim t As Double = CDbl(i) / 180 * Math.PI
				Dim x As Double = t * Math.Cos(t)
				Dim y As Double = t * Math.Sin(t)
				ArchimedeanSpiralSeries.Points.Add(New SeriesPoint(x, y))
			Next i
		End Sub
		Private Sub CreateCardioidPoints()
			For i As Integer = 0 To 359 Step 10
				Dim t As Double = CDbl(i) / 180 * Math.PI
				Dim x As Double = A * (2 * Math.Cos(t) - Math.Cos(2 * t))
				Dim y As Double = A * (2 * Math.Sin(t) - Math.Sin(2 * t))
				CardioidSeries.Points.Add(New SeriesPoint(x, y))
			Next i
		End Sub
		Private Sub CreateCartesianFoliumPoints()
			For i As Integer = -30 To 124 Step 5
				Dim t As Double = Math.Tan(CDbl(i) / 180 * Math.PI)
				Dim x As Double = 3 * CDbl(A) * t / (t * t * t + 1)
				Dim y As Double = x * t
				CartesianFoliumSeries.Points.Add(New SeriesPoint(x, y))
			Next i
		End Sub
		Private Sub ShowSeries(ByVal visibleSeries As Series)
			For Each series As Series In Me.Series
				If series Is visibleSeries Then
					visibleSeries.Visible = True
					seriesSelected = series
				Else
					series.Visible = False
				End If
			Next series
		End Sub
		Private Sub comboBoxEditFunctionType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditFunctionType.SelectedIndexChanged
			If comboBoxEditFunctionType.SelectedIndex = ArchimedeanSpiralIndex Then
				If ArchimedeanSpiralSeries.Points.Count = 0 Then
					CreateArchimedeanSpiralPoints()
				End If
				ShowSeries(ArchimedeanSpiralSeries)
			ElseIf comboBoxEditFunctionType.SelectedIndex = CardioidIndex Then
				If CardioidSeries.Points.Count = 0 Then
					CreateCardioidPoints()
				End If
				ShowSeries(CardioidSeries)
			ElseIf comboBoxEditFunctionType.SelectedIndex = CartesianFoliumIndex Then
				If CartesianFoliumSeries.Points.Count = 0 Then
					CreateCartesianFoliumPoints()
				End If
				ShowSeries(CartesianFoliumSeries)
			End If
			ChartControl.Animate()
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = False
			comboBoxEditFunctionType.SelectedIndex = ArchimedeanSpiralIndex
			For Each series As Series In chart.Series
				series.ToolTipPointPattern = "{A:F2} : {V:F2}"
			Next series
		End Sub
	End Class
End Namespace

