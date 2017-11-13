Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class PolarPointDemo
		Inherits PolarDemoBase
		Private chart As ChartControl

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			For Each series As Series In chart.Series
				series.ToolTipPointPattern = "{A}: {V:F2}"
			Next series
		End Sub
	End Class
End Namespace
