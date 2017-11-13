Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class RegressionLineDemo
		Inherits ChartDemoBase2D
		Private Const XMin As Integer = 0
		Private Const XMax As Integer = 100
		Private Const PointCount As Integer = 40

		Private Shared ReadOnly random As New Random()

		Private Shared Function CalcRandomY(ByVal arrayX() As Integer) As Double()
			Dim k As Double = CDbl(random.Next(-100, 100)) / 10
			If k < 0.1 AndAlso k >= 0 Then
				k = 0.1
			End If
			If k > -0.1 AndAlso k < 0 Then
				k = -0.1
			End If
			Dim b As Double = CDbl(random.Next(-100, 100)) / 10
			Dim deviation As Double = Math.Abs(k * (XMax - XMin) * 0.4)
			Dim arrayY(arrayX.Length - 1) As Double
			For i As Integer = 0 To arrayY.Length - 1
				Dim isNegativeDelta As Boolean = random.Next(0, 1) = 0
				Dim delta As Double = deviation * random.NextDouble()
				If isNegativeDelta Then
					delta = -delta
				End If
				arrayY(i) = k * arrayX(i) + b + delta
			Next i
			Return arrayY
		End Function
		Private Shared Function CalcRandomX() As Integer()
			Dim arrayX(PointCount - 1) As Integer
			For i As Integer = 0 To arrayX.Length - 1
				arrayX(i) = random.Next(XMin, XMax)
			Next i
			Return arrayX
		End Function
		Private Shared Function CalcRandomPointsAroundLine() As SeriesPoint()
			Dim arrayX() As Integer = CalcRandomX()
			Dim arrayY() As Double = CalcRandomY(arrayX)
			Dim seriesPoints(arrayX.Length - 1) As SeriesPoint
			For i As Integer = 0 To arrayX.Length - 1
				seriesPoints(i) = New SeriesPoint(arrayX(i), arrayY(i))
			Next i
			Return seriesPoints
		End Function

		Private ReadOnly Property Series() As Series
			Get
				Return If(chart.Series.Count > 0, chart.Series(0), Nothing)
			End Get
		End Property
		Private ReadOnly Property RegressionLine() As RegressionLine
			Get
				If Series IsNot Nothing Then
					Dim view As XYDiagramSeriesViewBase = TryCast(Series.View, XYDiagramSeriesViewBase)
					If view IsNot Nothing Then
						For Each indicator As Indicator In view.Indicators
							Dim regrLine As RegressionLine = TryCast(indicator, RegressionLine)
							If regrLine IsNot Nothing Then
								Return regrLine
							End If
						Next indicator
					End If
				End If
				Return Nothing
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries
		End Sub

		Private Sub InitSeries()
			If Series IsNot Nothing AndAlso Series.View.GetType().Equals(GetType(PointSeriesView)) Then
				Series.Points.Clear()
				Series.Points.AddRange(CalcRandomPointsAroundLine())
			End If
		End Sub
		Private Sub btnCreateRandomPoints_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreateRandomPoints.Click
			InitSeries()
			RegressionLine.Visible = False
			ChartControl.Animate()
		End Sub
		Private Sub speThickness_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles speThickness.EditValueChanged
			If RegressionLine IsNot Nothing Then
				RegressionLine.LineStyle.Thickness = Convert.ToInt32(speThickness.EditValue)
			End If
		End Sub
		Private Sub clreColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles clreColor.EditValueChanged
			If RegressionLine IsNot Nothing Then
				RegressionLine.Color = CType(clreColor.EditValue, Color)
			End If
		End Sub
		Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDashStyle.SelectedIndexChanged
			If RegressionLine IsNot Nothing Then
				RegressionLine.LineStyle.DashStyle = CType(cbDashStyle.SelectedIndex + 1, DashStyle)
			End If
		End Sub
		Private Sub chart_AnimationEnded(ByVal sender As Object, ByVal e As EventArgs) Handles chart.AnimationEnded
			RegressionLine.Visible = True
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			RegressionLine.Visible = False
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			If RegressionLine IsNot Nothing Then
				clreColor.Color = RegressionLine.Color
				speThickness.Value = RegressionLine.LineStyle.Thickness
				cbDashStyle.SelectedIndex = CInt(Fix(RegressionLine.LineStyle.DashStyle)) - 1
			End If
			InitSeries()
			ShowLabels = False
			For Each series As Series In chart.Series
				series.CrosshairLabelPattern = "{A}: {V:F2}"
			Next series
		End Sub


	End Class
End Namespace
