Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ViewCombinations
	Partial Public Class BarAndLine2dDemo
		Inherits ChartDemoBase2D
		Private chart As DevExpress.XtraCharts.ChartControl

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
