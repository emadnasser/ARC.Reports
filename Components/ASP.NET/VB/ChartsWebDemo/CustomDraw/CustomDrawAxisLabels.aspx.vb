Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class CustomDrawAxisLabels
	Inherits ChartBasePage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = WebChartControl1.Series(0).LabelsVisibility = DefaultBoolean.True
			cbCustomDraw.Checked = True
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			For Each series As Series In WebChartControl1.Series
				series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
				WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
			Next series
		End If
	End Sub
	Protected Sub WebChartControl1_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As CustomDrawAxisLabelEventArgs)
		If cbCustomDraw.Checked Then
			Dim axis As AxisBase = e.Item.Axis
			If TypeOf axis Is AxisY Then
				Dim axisValue As Double = CDbl(e.Item.AxisValue)
				If axisValue < 0 Then
					e.Item.TextColor = Color.Red
				ElseIf axisValue > 0 Then
					e.Item.Text = "+" & e.Item.Text
					e.Item.TextColor = Color.Green
				End If
				e.Item.Font = New Font(e.Item.Font.FontFamily, e.Item.Font.Size + CSng(Math.Abs(axisValue)) / 4.0f)
				e.Item.EnableAntialiasing = DefaultBoolean.True
			End If
		End If
	End Sub
End Class
