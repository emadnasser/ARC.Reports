Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.CustomDraw
	Partial Public Class SeriesPointsDemo
		Inherits ChartDemoBase2D
		Private Const PointsCount As Integer = 25

		Private ReadOnly Property Series() As Series
			Get
				Return chart.Series(0)
			End Get
		End Property

		Protected Overrides ReadOnly Property CrosshairEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.False
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButtonRandom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonRandom.Click
			InitSeries()
			SetPointsColor(Me.checkEditCustomDraw.Checked)
			ChartControl.Animate()
		End Sub
		Private Function SupportType() As Boolean
			Return TypeOf chart.Series(0).View Is SideBySideBarSeriesView OrElse TypeOf chart.Series(0).View Is LineSeriesView OrElse TypeOf chart.Series(0).View Is AreaSeriesView OrElse TypeOf chart.Series(0).View Is PointSeriesView
		End Function
		Private Sub InitSeries()
			Dim random As New Random()
			If Series IsNot Nothing AndAlso SupportType() Then
				Series.Points.Clear()
				For i As Integer = 0 To PointsCount - 1
					Series.Points.Add(New SeriesPoint(i.ToString(), New Double() { random.NextDouble() * 3 }))
				Next i
			End If
		End Sub
		Private Sub chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles chart.CustomDrawSeriesPoint
			If Me.checkEditCustomDraw.Checked AndAlso e.SeriesPoint.Values.Length > 0 Then
				Dim color As String = GetColorName(e.SeriesPoint(0))
				If (Not String.IsNullOrEmpty(color)) Then
					e.LabelText = color & ": " & e.LabelText
				End If
			End If
		End Sub
		Private Sub checkEditCustomDraw_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditCustomDraw.CheckedChanged
			SetPointsColor(Me.checkEditCustomDraw.Checked)
			Me.chart.Invalidate()
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

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Me.checkEditCustomDraw.Checked = True
			InitSeries()
			SetPointsColor(Me.checkEditCustomDraw.Checked)
			ShowLabels = True
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
		End Sub
	End Class
End Namespace
