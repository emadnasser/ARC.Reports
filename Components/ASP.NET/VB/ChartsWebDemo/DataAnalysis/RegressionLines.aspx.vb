Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class RegressionLines
	Inherits ChartBasePage
	Private Const xMin As Integer = 0
	Private Const xMax As Integer = 100
	Private Const pointCount As Integer = 40
	Private ReadOnly random As New Random()

	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property RegressionLine() As RegressionLine
		Get
			Return CType((CType(Series.View, XYDiagramSeriesViewBase)).Indicators(0), RegressionLine)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			InitSeries()
			Dim series As Series = WebChartControl1.Series(0)
			Dim view As PointSeriesView = CType(series.View, PointSeriesView)

			cbShowLabels.Checked = series.LabelsVisibility = DefaultBoolean.True
			ComboBoxHelper.PrepareRegressionLineColorComboBox(cbColor)
			ComboBoxHelper.PrepareDashStyleCombobox(cbDashStyle, RegressionLine.LineStyle.DashStyle)
			spnThickness.Value = RegressionLine.LineStyle.Thickness
		End If
	End Sub
	Private Sub InitSeries()
		If Series IsNot Nothing AndAlso Series.View.GetType().Equals(GetType(PointSeriesView)) Then
			Series.Points.Clear()
			Series.Points.AddRange(CalcRandomPointsAroundLine())
		End If
	End Sub
	Private Sub PeformCreatePointsAction()
		InitSeries()
	End Sub
	Private Sub PerformShowLabelsAction()
		Series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformColorAction()
		RegressionLine.Color = ComboBoxHelper.GetSelectedRegressionLineColor(cbColor)
	End Sub
	Private Sub PerformDashStyleAction()
		RegressionLine.LineStyle.DashStyle = CType(ComboBoxHelper.GetSelectedItem(cbDashStyle, GetType(DashStyle)), DashStyle)
	End Sub
	Private Sub PerformThicknessAction()
		RegressionLine.LineStyle.Thickness = Convert.ToInt32(spnThickness.Value)
	End Sub
	Private Function CalcRandomY(ByVal arrayX() As Integer) As Double()
		Dim k As Double = CDbl(random.Next(-100, 100)) / 10
		If k < 0.1 AndAlso k >= 0 Then
			k = 0.1
		End If
		If k > -0.1 AndAlso k < 0 Then
			k = -0.1
		End If
		Dim b As Double = CDbl(random.Next(-100, 100)) / 10
		Dim deviation As Double = Math.Abs(k * (xMax - xMin) * 0.4)
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
	Private Function CalcRandomX() As Integer()
		Dim arrayX(pointCount - 1) As Integer
		For i As Integer = 0 To arrayX.Length - 1
			arrayX(i) = random.Next(xMin, xMax)
		Next i
		Return arrayX
	End Function
	Private Function CalcRandomPointsAroundLine() As SeriesPoint()
		Dim arrayX() As Integer = CalcRandomX()
		Dim arrayY() As Double = CalcRandomY(arrayX)
		Dim seriesPoints(arrayX.Length - 1) As SeriesPoint
		For i As Integer = 0 To arrayX.Length - 1
			seriesPoints(i) = New SeriesPoint(arrayX(i), arrayY(i))
		Next i
		Return seriesPoints
	End Function
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "Color" Then
			PerformColorAction()
		ElseIf e.Parameter = "DashStyle" Then
			PerformDashStyleAction()
		ElseIf e.Parameter = "Thickness" Then
			PerformThicknessAction()
		ElseIf e.Parameter = "CreatePoints" Then
			PeformCreatePointsAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		End If
	End Sub
End Class
