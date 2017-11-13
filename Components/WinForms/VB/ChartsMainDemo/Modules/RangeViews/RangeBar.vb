Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.RangeViews
	Partial Public Class RangeBarDemo
		Inherits ChartDemoBase2D
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ChartControl.Series(0).DataSource = SourceOfEnergy.GetEuropeBrentPrices()
			ChartControl.Series(1).DataSource = SourceOfEnergy.GetOkWtiPrices()
		End Sub
	End Class
End Namespace

