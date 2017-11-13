Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class StackedSplineAreaDemo
		Inherits ChartDemoBase2D
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
			ChartControl.DataSource = DevAV.GetSalesByLast10Years()
		End Sub
	End Class
End Namespace
