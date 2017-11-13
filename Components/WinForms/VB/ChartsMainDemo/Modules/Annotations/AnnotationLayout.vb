Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.Annotations
	Partial Public Class AnnotationLayoutDemo
		Inherits ChartDemoBase2D
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub cheMoving_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheMoving.CheckedChanged
			For Each annotation As Annotation In chart.AnnotationRepository
				annotation.RuntimeMoving = cheMoving.Checked
			Next annotation
		End Sub
		Private Sub cheResizing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheResizing.CheckedChanged
			For Each annotation As Annotation In chart.AnnotationRepository
				annotation.RuntimeResizing = cheResizing.Checked
			Next annotation
		End Sub
		Private Sub cheRotation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheRotation.CheckedChanged
			For Each annotation As Annotation In chart.AnnotationRepository
				annotation.RuntimeRotation = cheRotation.Checked
			Next annotation
		End Sub
		Private Sub cheAnchoring_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheAnchoring.CheckedChanged
			For Each annotation As Annotation In chart.AnnotationRepository
				annotation.RuntimeAnchoring = cheAnchoring.Checked
			Next annotation
		End Sub
	End Class
End Namespace
