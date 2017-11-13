Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.ViewCombinations
	Partial Public Class BarAndArea3dDemo
		Inherits ChartDemoBase3D
		Private ReadOnly Property Diagram() As Diagram3D
			Get
				Return TryCast(ChartControl.Diagram, Diagram3D)
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			ShowLabels = True
			UpdateScrollAndZoomControls()
		End Sub

		Private Sub UpdateScrollAndZoomControls()
			tbcHorizontalScrollPercent.Value = CInt(Fix(Math.Round(Diagram.HorizontalScrollPercent)))
			tbcVerticalScrollPercent.Value = CInt(Fix(Math.Round(Diagram.VerticalScrollPercent)))
			zoomTrackBarControl.Value = Diagram.ZoomPercent
		End Sub
		Private Sub tbcVerticalScrollPercent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbcVerticalScrollPercent.EditValueChanged
			If Diagram IsNot Nothing Then
				Diagram.VerticalScrollPercent = tbcVerticalScrollPercent.Value
			End If
		End Sub
		Private Sub tbcHorizontalScrollPercent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbcHorizontalScrollPercent.EditValueChanged
			If Diagram IsNot Nothing Then
				Diagram.HorizontalScrollPercent = tbcHorizontalScrollPercent.Value
			End If
		End Sub
		Private Sub zoomTrackBarControl_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles zoomTrackBarControl.EditValueChanged
			If Diagram IsNot Nothing Then
				Diagram.ZoomPercent = zoomTrackBarControl.Value
			End If
		End Sub
		Private Sub chart_Zoom3D(ByVal sender As Object, ByVal e As ChartZoom3DEventArgs) Handles chart.Zoom3D
			zoomTrackBarControl.Value = e.NewZoomPercent
		End Sub
		Private Sub chart_Scroll3D(ByVal sender As Object, ByVal e As ChartScroll3DEventArgs) Handles chart.Scroll3D
			If e.ScrollDirection = ChartScrollDirection.Horizontal OrElse e.ScrollDirection = ChartScrollDirection.Both Then
				tbcHorizontalScrollPercent.Value = CInt(Fix(Math.Round(e.NewHorizontalScrollPercent)))
			End If
			If e.ScrollDirection = ChartScrollDirection.Vertical OrElse e.ScrollDirection = ChartScrollDirection.Both Then
				tbcVerticalScrollPercent.Value = CInt(Fix(Math.Round(e.NewVerticalScrollPercent)))
			End If
		End Sub

		Protected Overrides Sub UpdateRotationAngles(ByVal diagram As Diagram3D)
			diagram.RotationAngleY = 30
			diagram.VerticalScrollPercent = 5
			diagram.HorizontalScrollPercent = 0
			diagram.ZoomPercent = 140
			UpdateScrollAndZoomControls()
		End Sub
	End Class
End Namespace
