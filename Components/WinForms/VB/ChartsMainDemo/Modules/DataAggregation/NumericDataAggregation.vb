Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.DataAggregation
	Partial Public Class NumericDataAggregationDemo
		Inherits ChartDemoBase
		Private Const PointCount As Integer = 500000

		Private ReadOnly Property Series() As Series
			Get
				Return If(chart.Series.Count > 0, chart.Series(0), Nothing)
			End Get
		End Property
		Private ReadOnly Property Diagram() As XYDiagram
			Get
				Return TryCast(chart.Diagram, XYDiagram)
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property
		Public Overrides ReadOnly Property AnimateChartControlOnDemoAppear() As Boolean
			Get
				Return False
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub LoadPoints()
			If Series IsNot Nothing Then
				Dim value As Double = 0
				Dim argument As Double = 0
				Dim random As New Random()
				Series.Points.BeginUpdate()
				Series.Points.Clear()
				For i As Double = 0 To PointCount - 1
					Series.Points.Add(New SeriesPoint(argument, value))
					value += (random.NextDouble() * 10.0 - 5.0)
					argument += random.NextDouble()
				Next i
				Series.Points.EndUpdate()
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Using dlg As New WaitDialogForm("Please Wait", "Loading Data...", New Size(200, 50), ParentForm)
				LoadPoints()
			End Using
			Diagram.AxisX.NumericScaleOptions.ScaleMode = ScaleMode.Automatic
			Dim crosshairPosition As New CrosshairFreePosition()
			crosshairPosition.DockTarget = (CType(ChartControl.Diagram, XYDiagram2D)).DefaultPane
			crosshairPosition.DockCorner = DockCorner.LeftTop
			ChartControl.CrosshairOptions.CommonLabelPosition = crosshairPosition
			For Each series As Series In chart.Series
				series.CrosshairLabelPattern = "{A} : {V:F2}"
			Next series
		End Sub
	End Class
End Namespace
