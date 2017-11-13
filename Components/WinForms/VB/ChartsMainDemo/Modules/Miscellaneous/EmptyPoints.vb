Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class EmptyPointsDemo
		Inherits ChartDemoBase
		Private chart As ChartControl

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Function IsFullStackedView(ByVal view As SeriesViewBase) As Boolean
			Return TypeOf view Is FullStackedAreaSeriesView OrElse TypeOf view Is FullStackedArea3DSeriesView OrElse TypeOf view Is FullStackedSplineAreaSeriesView OrElse TypeOf view Is FullStackedSplineArea3DSeriesView OrElse TypeOf view Is FullStackedLineSeriesView OrElse TypeOf view Is FullStackedLine3DSeriesView
		End Function
		Private Sub UpdateAxesLabelsPattern(ByVal axisXLabel As AxisLabel, ByVal axisYLabel As AxisLabel, ByVal view As SeriesViewBase)
			axisXLabel.TextPattern = "{A:m}"
			If IsFullStackedView(view) Then
				axisYLabel.TextPattern = "{V:P0}"
			Else
				axisYLabel.TextPattern = "{V:G}"
			End If
		End Sub
		Private Sub UpdateSeries(ByVal series As Series)
			If IsFullStackedView(series.View) Then
				series.Label.TextPattern = "{VP:P0}"
			Else
				series.Label.TextPattern = "{V:G2}"
			End If
			Dim supportTransparency As ISupportTransparency = TryCast(series.View, ISupportTransparency)
			If supportTransparency IsNot Nothing Then
				If (TypeOf series.View Is AreaSeriesView) OrElse (TypeOf series.View Is Area3DSeriesView) Then
					supportTransparency.Transparency = 135
				Else
					supportTransparency.Transparency = 0
				End If
			End If
		End Sub
		Private Sub comboBoxEditViewType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditViewType.SelectedIndexChanged
			Dim viewType As ViewType = ViewType.Line
			Select Case comboBoxEditViewType.SelectedItem.ToString()
				Case "Lines"
					viewType = ViewType.Line
				Case "Stacked Lines"
					viewType = ViewType.StackedLine
				Case "Full-Stacked Lines"
					viewType = ViewType.FullStackedLine
				Case "Step Lines"
					viewType = ViewType.StepLine
				Case "Areas"
					viewType = ViewType.Area
				Case "Stacked Areas"
					viewType = ViewType.StackedArea
				Case "Full-Stacked Areas"
					viewType = ViewType.FullStackedArea
				Case "Step Areas"
					viewType = ViewType.StepArea
				Case "3D Lines"
					viewType = ViewType.Line3D
				Case "3D Stacked Lines"
					viewType = ViewType.StackedLine3D
				Case "3D Full-Stacked Lines"
					viewType = ViewType.FullStackedLine3D
				Case "3D Step Lines"
					viewType = ViewType.StepLine3D
				Case "3D Areas"
					viewType = ViewType.Area3D
				Case "3D Stacked Areas"
					viewType = ViewType.StackedArea3D
				Case "3D Full-Stacked Areas"
					viewType = ViewType.FullStackedArea3D
				Case "3D Step Areas"
					viewType = ViewType.StepArea3D
				Case "Spline"
					viewType = ViewType.Spline
				Case "Spline Area"
					viewType = ViewType.SplineArea
				Case "Stacked Spline"
					viewType = ViewType.StackedSplineArea
				Case "Full-Stacked Spline"
					viewType = ViewType.FullStackedSplineArea
				Case "Spline 3D"
					viewType = ViewType.Spline3D
				Case "Spline Area 3D"
					viewType = ViewType.SplineArea3D
				Case "Stacked Spline 3D"
					viewType = ViewType.StackedSplineArea3D
				Case "Full-Stacked Spline 3D"
					viewType = ViewType.FullStackedSplineArea3D
			End Select
			For Each series As Series In chart.Series
				series.ChangeView(viewType)
				UpdateSeries(series)
			Next series
			Dim diagram As Diagram3D = TryCast(chart.Diagram, Diagram3D)
			If diagram IsNot Nothing Then
				diagram.ZoomPercent = 120
				diagram.RuntimeRotation = True
				diagram.RuntimeScrolling = True
				diagram.RuntimeZooming = True
				Dim xyDiagram3D As XYDiagram3D = TryCast(diagram, XYDiagram3D)
				If xyDiagram3D IsNot Nothing Then
					UpdateAxesLabelsPattern(xyDiagram3D.AxisX.Label, xyDiagram3D.AxisY.Label, chart.Series(0).View)
				End If
			Else
				Dim xyDiagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
				If xyDiagram IsNot Nothing Then
					UpdateAxesLabelsPattern(xyDiagram.AxisX.Label, xyDiagram.AxisY.Label, chart.Series(0).View)
				End If
			End If
			ChartControl.Animate()
		End Sub
	End Class
End Namespace
