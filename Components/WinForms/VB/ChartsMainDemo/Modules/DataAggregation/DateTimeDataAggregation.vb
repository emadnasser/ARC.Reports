Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.DataAggregation
	Partial Public Class DateTimeDataAggregationDemo
		Inherits ChartDemoBase
		Private Const PointCount As Integer = 50000

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
				Dim argument As DateTime = DateTime.Now.AddDays(-PointCount)
				Dim random As New Random()
				Series.Points.BeginUpdate()
				Series.Points.Clear()
				For i As Double = 0 To PointCount - 1
					Series.Points.Add(New SeriesPoint(argument.AddDays(i), Math.Abs(value)))
					value += (random.NextDouble() * 10.0 - 5.0)
				Next i
				Series.Points.EndUpdate()
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Using dlg As New WaitDialogForm("Please Wait", "Loading Data...", New Size(200, 50), ParentForm)
				LoadPoints()
			End Using
		End Sub
	End Class
End Namespace
