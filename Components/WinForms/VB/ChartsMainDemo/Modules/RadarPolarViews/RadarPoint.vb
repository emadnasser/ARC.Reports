Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class RadarPointDemo
		Inherits RadarDemoBase
		Private WithEvents chart As ChartControl

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub chart_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.VisibleChanged
			If Me.chart.Series.Count > 0 Then
				chart.SetObjectSelection(Me.chart.Series(0))
			End If
		End Sub
	End Class
End Namespace
