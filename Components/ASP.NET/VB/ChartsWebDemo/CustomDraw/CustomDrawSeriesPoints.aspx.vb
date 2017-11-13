Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraCharts

Partial Public Class CustomDrawSeriesPoints
	Inherits ChartBasePage
	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			InitSeries()
			cbShowLabels.Checked = Series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			cbCustomDraw.Checked = True
			SetPointsColor(cbCustomDraw.Checked)
		End If
	End Sub
	Protected Sub WebChartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
		If cbCustomDraw.Checked Then
			Dim color As String = GetColorName(e.SeriesPoint(0))
			If (Not String.IsNullOrEmpty(color)) Then
				e.LabelText = color & ": " & e.LabelText
			End If
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "CreateBars" Then
			InitSeries()
		ElseIf e.Parameter = "CustomDraw" Then
			SetPointsColor(cbCustomDraw.Checked)
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		Series.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
	End Sub
	Private Sub InitSeries()
		Dim random As New Random()
		Series.Points.Clear()
		For i As Integer = 0 To 24
			Series.Points.Add(New SeriesPoint(i.ToString(), New Double() { random.NextDouble() * 3 }))
		Next i
		SetPointsColor(cbCustomDraw.Checked)
	End Sub
	Private Function GetColorName(ByVal val As Double) As String
		If val < 1 Then
			Return "Green"
		ElseIf val < 2 Then
			Return "Yellow"
		Else
			Return "Red"
		End If
	End Function
	Private Sub SetPointsColor(ByVal colorize As Boolean)
		If Series IsNot Nothing AndAlso SupportType() Then
			For i As Integer = 0 To Series.Points.Count - 1
				SetColor(Series.Points(i), colorize)
			Next i
		End If
	End Sub
	Private Function SupportType() As Boolean
		Return TypeOf WebChartControl1.Series(0).View Is SideBySideBarSeriesView OrElse TypeOf WebChartControl1.Series(0).View Is LineSeriesView OrElse TypeOf WebChartControl1.Series(0).View Is AreaSeriesView OrElse TypeOf WebChartControl1.Series(0).View Is PointSeriesView
	End Function
	Private Sub SetColor(ByVal point As SeriesPoint, ByVal colorize As Boolean)
		Dim val As Double = point.Values(0)
		Dim color As Color
		If colorize Then
			If val < 1 Then
				color = Color.FromArgb(81, 137, 3)
			ElseIf val < 2 Then
				color = Color.FromArgb(249, 170, 15)
			Else
				color = Color.FromArgb(199, 57, 12)
			End If
		Else
			color = Color.Empty
		End If
		point.Color = color
	End Sub
	Protected Sub cbCustomDraw_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		SetPointsColor(cbCustomDraw.Checked)
	End Sub
End Class
