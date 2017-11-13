Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class FullStackedLineDemo
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
		Private Sub checkValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkValueAsPercent.CheckedChanged
			If seriesSelected IsNot Nothing Then
				seriesSelected.Label.TextPattern = If(Me.checkValueAsPercent.Checked, "{VP:P0}", "${V}M")
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			checkValueAsPercent.Checked = True
			ChartControl.DataSource = DevAV.GetBranchesSales()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			checkValueAsPercent.Enabled = False
			If seriesSelected IsNot Nothing Then
				checkValueAsPercent.Enabled = ShowLabels
				checkValueAsPercent.Checked = seriesSelected.Label.TextPattern IsNot Nothing AndAlso seriesSelected.Label.TextPattern.Contains("VP")
			End If
		End Sub
	End Class
End Namespace
