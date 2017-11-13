Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.SwiftPlotView
	Partial Public Class RealtimeChartDemo
		Inherits ChartDemoBase
		Private Const Interval As Integer = 20

		Private Shared Function GetRegressionLine(ByVal series As Series) As RegressionLine
			If series IsNot Nothing Then
				Dim swiftPlotView As SwiftPlotSeriesView = TryCast(series.View, SwiftPlotSeriesView)
				If swiftPlotView IsNot Nothing Then
					For Each indicator As Indicator In swiftPlotView.Indicators
						Dim regressionLine As RegressionLine = TryCast(indicator, RegressionLine)
						If regressionLine IsNot Nothing Then
							Return regressionLine
						End If
					Next indicator
				End If
			End If
			Return Nothing
		End Function

		Private random As New Random()
		Private value1 As Double = 10.0
		Private value2 As Double = -10.0
		Private inProcess? As Boolean = Nothing

		Private ReadOnly Property TimeInterval() As Integer
			Get
				Return Convert.ToInt32(spnTimeInterval.EditValue)
			End Get
		End Property
		Private ReadOnly Property Series1() As Series
			Get
				Return If(chart.Series.Count > 0, chart.Series(0), Nothing)
			End Get
		End Property
		Private ReadOnly Property Series2() As Series
			Get
				Return If(chart.Series.Count > 1, chart.Series(1), Nothing)
			End Get
		End Property
		Private ReadOnly Property Regression1() As RegressionLine
			Get
				Return GetRegressionLine(Series1)
			End Get
		End Property
		Private ReadOnly Property Regression2() As RegressionLine
			Get
				Return GetRegressionLine(Series2)
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

		Private Sub SetPauseResumeButtonText()
			btnPauseResume.Text = If(timer.Enabled, "Pause", "Resume")
		End Sub
		Private Sub UpdateValues()
			value1 = CalculateNextValue(value1)
			value2 = CalculateNextValue(value2)
		End Sub
		Private Sub DisableProcess()
			inProcess = timer.Enabled
			timer.Enabled = False
		End Sub
		Private Sub RestoreProcess()
			If inProcess.HasValue Then
				timer.Enabled = CBool(inProcess)
				inProcess = Nothing
			End If
		End Sub
		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick
			If Series1 Is Nothing OrElse Series2 Is Nothing Then
				Return
			End If
			Dim argument As DateTime = DateTime.Now
			Dim pointsToUpdate1(Interval - 1) As SeriesPoint
			Dim pointsToUpdate2(Interval - 1) As SeriesPoint
			For i As Integer = 0 To Interval - 1
				pointsToUpdate1(i) = New SeriesPoint(argument, value1)
				pointsToUpdate2(i) = New SeriesPoint(argument, value2)
				argument = argument.AddMilliseconds(1)
				UpdateValues()
			Next i
			Dim minDate As DateTime = argument.AddSeconds(-TimeInterval)
			Dim pointsToRemoveCount As Integer = 0
			For Each point As SeriesPoint In Series1.Points
				If point.DateTimeArgument < minDate Then
					pointsToRemoveCount += 1
				End If
			Next point
			If pointsToRemoveCount < Series1.Points.Count Then
				pointsToRemoveCount -= 1
			End If
			AddPoints(Series1, pointsToUpdate1)
			AddPoints(Series2, pointsToUpdate2)
			If pointsToRemoveCount > 0 Then
				Series1.Points.RemoveRange(0, pointsToRemoveCount)
				Series2.Points.RemoveRange(0, pointsToRemoveCount)
			End If
			Dim diagram As SwiftPlotDiagram = TryCast(chart.Diagram, SwiftPlotDiagram)
			If diagram IsNot Nothing AndAlso (diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Millisecond OrElse diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous) Then
				diagram.AxisX.WholeRange.SetMinMaxValues(minDate, argument)
			End If
		End Sub
		Private Sub AddPoints(ByVal series As Series, ByVal pointsToUpdate() As SeriesPoint)
			If TypeOf series.View Is SwiftPlotSeriesViewBase Then
				series.Points.AddRange(pointsToUpdate)
			End If
		End Sub
		Private Sub btnPauseResume_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPauseResume.Click
			timer.Enabled = Not timer.Enabled
			SetPauseResumeButtonText()
		End Sub
		Private Sub chRegression_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chRegression.CheckedChanged
			If Regression1 IsNot Nothing Then
				Regression1.Visible = chRegression.Checked
			End If
			If Regression2 IsNot Nothing Then
				Regression2.Visible = chRegression.Checked
			End If
		End Sub
		Private Function CalculateNextValue(ByVal value As Double) As Double
			Return value + (random.NextDouble() * 10.0 - 5.0)
		End Function

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			timer.Interval = Interval
			SetPauseResumeButtonText()
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			RestoreProcess()
		End Sub
		Protected Overrides Sub DoHide()
			MyBase.DoHide()
			DisableProcess()
		End Sub
	End Class
End Namespace
