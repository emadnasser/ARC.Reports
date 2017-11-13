Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class StepLineDemo
		Inherits ChartDemoLineBase
		Private WithEvents chart As ChartControl

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
			Me.seriesSelected = ChartControl.Series(0)
			Me.seriesSelected.DataSource = SourceOfEnergy.GetFuelPrices()
		End Sub
		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chart.BoundDataChanged
			ChartControl.Animate()
		End Sub
	End Class
End Namespace

