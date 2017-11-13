Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AdvancedViews
	Partial Public Class CandleStickDemo
		Inherits FinancialSeriesViewDemoBase
		Private chart As ChartControl

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			If Me.chart.Series.Count > 0 Then
				Me.seriesSelected = Me.chart.Series(0)
			End If
			ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries
		End Sub
	End Class
End Namespace

