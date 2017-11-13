Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class StackedStepAreaDemo
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
		End Sub

		Private Sub checkEditInverted_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditInverted.CheckedChanged
			If FirstSeries IsNot Nothing Then
				Dim view As StackedStepAreaSeriesView = TryCast(FirstSeries.View, StackedStepAreaSeriesView)
				If view IsNot Nothing Then
					view.InvertedStep = checkEditInverted.Checked
				End If
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If FirstSeries IsNot Nothing AndAlso TypeOf FirstSeries.View Is StackedStepAreaSeriesView Then
				checkEditInverted.Enabled = True
				checkEditInverted.Checked = (CType(FirstSeries.View, StackedStepAreaSeriesView)).InvertedStep
			Else
				checkEditInverted.Checked = False
				checkEditInverted.Enabled = False
			End If
		End Sub
	End Class
End Namespace
