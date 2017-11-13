Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.ResolveLabelsOverlapping
	Partial Public Class ResolveOverlappingFor3dPieDemo
		Inherits ChartDemoBase3D
		Private ReadOnly Property Label() As SeriesLabelBase
			Get
				If chart.Series.Count <> 0 Then
					Return chart.Series(0).Label
				Else
					Return Nothing
				End If
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			CheckEditShowLabelsVisible = False
		End Sub

		Private Sub checkEditResolveOverlapping_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditResolveOverlapping.CheckedChanged
			If Label IsNot Nothing Then
				If checkEditResolveOverlapping.Checked Then
					Label.ResolveOverlappingMode = ResolveOverlappingMode.Default
				Else
					Label.ResolveOverlappingMode = ResolveOverlappingMode.None
				End If
			End If
			UpdateControls()
		End Sub
		Private Sub spinIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinIndent.EditValueChanged
			If Label IsNot Nothing Then
				Label.ResolveOverlappingMinIndent = Convert.ToInt32(spinIndent.EditValue)
			End If
		End Sub

		Protected Overrides Sub UpdateRotationAngles(ByVal diagram As Diagram3D)
			diagram.RotationAngleX = -50
			diagram.RotationAngleY = 170
			diagram.RotationAngleZ = -25
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If Label IsNot Nothing Then
				checkEditResolveOverlapping.Checked = Label.ResolveOverlappingMode = ResolveOverlappingMode.Default
				labelIndent.Enabled = Label.ResolveOverlappingMode <> ResolveOverlappingMode.None
				spinIndent.Enabled = labelIndent.Enabled
				spinIndent.EditValue = Label.ResolveOverlappingMinIndent
			End If
		End Sub
	End Class
End Namespace
