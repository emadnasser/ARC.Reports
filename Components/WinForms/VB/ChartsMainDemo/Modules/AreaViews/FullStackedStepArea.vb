Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class FullStackedStepAreaDemo
		Inherits ChartDemoBase2D
		Private ReadOnly Property FirstSeries() As Series
			Get
				Return If(chart.Series.Count > 0, chart.Series(0), Nothing)
			End Get
		End Property
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			SetSeriesLabelTextPattern(Me.checkEditInverted.Checked)
		End Sub
		Private Sub checkValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkValueAsPercent.CheckedChanged
			SetSeriesLabelTextPattern(Me.checkValueAsPercent.Checked)
		End Sub
		Private Sub checkEditInverted_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditInverted.CheckedChanged
			If FirstSeries IsNot Nothing Then
				Dim view As FullStackedStepAreaSeriesView = TryCast(FirstSeries.View, FullStackedStepAreaSeriesView)
				If view IsNot Nothing Then
					view.InvertedStep = Me.checkEditInverted.Checked
				End If
			End If
		End Sub
		Private Sub SetSeriesLabelTextPattern(ByVal isInPercent As Boolean)
			For Each series As Series In Me.chart.Series
				Dim view As FullStackedStepAreaSeriesView = TryCast(series.View, FullStackedStepAreaSeriesView)
				If view IsNot Nothing Then
					series.Label.TextPattern = If(isInPercent, "{VP:P0}", "{V:F1}")
				End If
			Next series
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If FirstSeries IsNot Nothing AndAlso TypeOf FirstSeries.View Is FullStackedStepAreaSeriesView Then
				checkEditInverted.Enabled = True
				checkEditInverted.Checked = (CType(FirstSeries.View, FullStackedStepAreaSeriesView)).InvertedStep
			Else
				checkEditInverted.Checked = False
				checkEditInverted.Enabled = False
			End If
			checkValueAsPercent.Enabled = ShowLabels
		End Sub
	End Class
End Namespace
