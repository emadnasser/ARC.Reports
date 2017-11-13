Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.ResolveLabelsOverlapping
	Partial Public Class ResolveOverlappingOfAxisLabelsDemo
		Inherits ChartDemoBase2D
		Private ReadOnly Property AxisLabel() As AxisLabel
			Get
				Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
				If diagram IsNot Nothing AndAlso diagram.AxisX IsNot Nothing Then
					Return diagram.AxisX.Label
				Else
					Return Nothing
				End If
			End Get
		End Property
		Private ReadOnly Property ResolveOverlappingEnabled() As Boolean
			Get
				Dim label As AxisLabel = AxisLabel
				If label IsNot Nothing Then
					Return label.ResolveOverlappingOptions.AllowStagger AndAlso label.ResolveOverlappingOptions.AllowRotate AndAlso label.ResolveOverlappingOptions.AllowHide
				End If
				Return False
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries
		End Sub

		Private Sub spinIndent_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinIndent.EditValueChanged
			If AxisLabel IsNot Nothing Then
				AxisLabel.ResolveOverlappingOptions.MinIndent = Convert.ToInt32(spinIndent.EditValue)
			End If
		End Sub
		Private Sub checkEditResolveOverlapping_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditResolveOverlapping.CheckedChanged
			If AxisLabel IsNot Nothing Then
				Dim resolveOverlappingEnabled As Boolean = checkEditResolveOverlapping.Checked
				AxisLabel.ResolveOverlappingOptions.AllowStagger = resolveOverlappingEnabled
				AxisLabel.ResolveOverlappingOptions.AllowRotate = resolveOverlappingEnabled
				AxisLabel.ResolveOverlappingOptions.AllowHide = resolveOverlappingEnabled
			End If
			UpdateControls()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If AxisLabel IsNot Nothing Then
				checkEditResolveOverlapping.Checked = ResolveOverlappingEnabled
				labelIndent.Enabled = ResolveOverlappingEnabled
				spinIndent.Enabled = labelIndent.Enabled
				spinIndent.EditValue = AxisLabel.ResolveOverlappingOptions.MinIndent
			End If
		End Sub
	End Class
End Namespace
