Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.FunnelViews
	Partial Public Class Funnel3dDemo
		Inherits ChartDemoBase3D
		Private ReadOnly Property Label() As FunnelSeriesLabel
			Get
				If chart.Series.Count = 0 Then
					Return Nothing
				End If
				Return TryCast(chart.Series(0).Label, FunnelSeriesLabel)
			End Get
		End Property
		Private ReadOnly Property View() As Funnel3DSeriesView
			Get
				If chart.Series.Count = 0 Then
					Return Nothing
				End If
				Return TryCast(chart.Series(0).View, Funnel3DSeriesView)
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

		Private Sub spinPointDistance_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinPointDistance.EditValueChanged
			If View IsNot Nothing Then
				View.PointDistance = Convert.ToInt32(spinPointDistance.Value)
			End If
		End Sub
		Private Sub cbHeightToWidthRatio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbHeightToWidthRatio.SelectedIndexChanged
			If View IsNot Nothing Then
				View.HeightToWidthRatio = Convert.ToDouble(cbHeightToWidthRatio.SelectedItem)
			End If
		End Sub
		Private Sub spinHoleRadius_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinHoleRadius.EditValueChanged
			If View IsNot Nothing Then
				View.HoleRadiusPercent = Convert.ToInt32(spinHoleRadius.EditValue)
			End If
		End Sub
		Private Sub cbLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLabelPosition.SelectedIndexChanged
			If Label IsNot Nothing Then
				Label.Position = CType(cbLabelPosition.SelectedIndex, FunnelSeriesLabelPosition)
			End If
		End Sub
		Private Sub checkEditValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditValueAsPercent.CheckedChanged
			chart.Series(0).Label.TextPattern = If(Me.checkEditValueAsPercent.Checked, "{VP:P0}", "{V:F0}")
		End Sub

		Protected Overrides Sub UpdateRotationAngles(ByVal diagram As Diagram3D)
			diagram.RotationOrder = RotationOrder.ZXY
			diagram.RotationAngleX = 15
			diagram.RotationAngleY = 0
			diagram.RotationAngleZ = 0
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			cbHeightToWidthRatio.Properties.Items.AddRange(New Double() { 0.1, 0.25, 0.5, 0.75, 1, 2, 4, 6, 8, 10 })
			ShowLabels = True
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If Label IsNot Nothing Then
				cbLabelPosition.SelectedIndex = CInt(Fix(Label.Position))
				checkEditValueAsPercent.Checked = chart.Series(0).Label.TextPattern.Contains("VP")
				cbLabelPosition.Enabled = ShowLabels
				labelPosition.Enabled = ShowLabels
				checkEditValueAsPercent.Enabled = ShowLabels
			End If
			If View IsNot Nothing Then
				cbHeightToWidthRatio.EditValue = View.HeightToWidthRatio
				spinPointDistance.EditValue = View.PointDistance
				spinHoleRadius.EditValue = View.HoleRadiusPercent
			End If
		End Sub
	End Class
End Namespace
