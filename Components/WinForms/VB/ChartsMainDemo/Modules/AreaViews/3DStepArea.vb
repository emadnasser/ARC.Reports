Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts.Demos.PointLineViews

Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class StepArea3dDemo
		Inherits StepLine3dDemo
		Private chart As ChartControl

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
			ShowLabels = True
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			Dim view As StepArea3DSeriesView = TryCast(Series.View, StepArea3DSeriesView)
			If view IsNot Nothing Then
				Me.checkEditInverted.Checked = view.InvertedStep
			End If
		End Sub
	End Class
End Namespace
