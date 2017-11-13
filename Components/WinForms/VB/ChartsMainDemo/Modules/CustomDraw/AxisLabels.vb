Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.CustomDraw
	Partial Public Class AxisLabelsDemo
		Inherits ChartDemoBase2D
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub checkEditCustomDraw_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditCustomDraw.CheckedChanged
			ChartControl.RefreshData()
		End Sub
		Private Sub chart_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As CustomDrawAxisLabelEventArgs) Handles chart.CustomDrawAxisLabel
			If checkEditCustomDraw.Checked Then
				Dim axis As AxisBase = e.Item.Axis
				If TypeOf axis Is AxisY OrElse TypeOf axis Is AxisY3D OrElse TypeOf axis Is RadarAxisY Then
					Dim axisValue As Double = CDbl(e.Item.AxisValue)
					If axisValue < 0 Then
						e.Item.TextColor = Color.Red
					ElseIf axisValue > 0 Then
						e.Item.Text = "+" & e.Item.Text
						e.Item.TextColor = Color.Green
					End If
					e.Item.Font = New Font(e.Item.Font.FontFamily, e.Item.Font.Size + CSng(Math.Abs(axisValue)), FontStyle.Bold)
					e.Item.EnableAntialiasing = DefaultBoolean.True
				End If
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			checkEditCustomDraw.Checked = True
			ShowLabels = True
		End Sub
	End Class
End Namespace

