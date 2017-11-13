Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class StackedLineDemo
		Inherits LineDemo
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.BoundDataChanged
			If chart.Series.Count > 0 Then
				chart.SetObjectSelection(Me.chart.Series(0))
			End If
			chart.Animate()
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ChartControl.DataSource = DevAV.GetSalesByLast10Years()
		End Sub
	End Class
End Namespace
