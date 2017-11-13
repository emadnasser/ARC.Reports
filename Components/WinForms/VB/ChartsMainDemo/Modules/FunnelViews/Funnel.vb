Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.FunnelViews
	Partial Public Class FunnelDemo
		Inherits ChartDemoBase2D
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property
		Protected Overrides ReadOnly Property ToolTipEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.True
			End Get
		End Property
		Private ReadOnly Property Label() As FunnelSeriesLabel
			Get
				If chart.Series.Count = 0 Then
					Return Nothing
				End If
				Return TryCast(chart.Series(0).Label, FunnelSeriesLabel)
			End Get
		End Property
		Private ReadOnly Property View() As FunnelSeriesView
			Get
				If chart.Series.Count = 0 Then
					Return Nothing
				End If
				Return TryCast(chart.Series(0).View, FunnelSeriesView)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
			cbHeightToWidthRatio.Properties.Items.AddRange(New Double() { 0.1, 0.25, 0.5, 0.75, 1, 2, 4, 6, 8, 10 })
			For Each series As Series In chart.Series
				series.ToolTipPointPattern = "{A}: {V} ({VP:0.0%})"
			Next series
		End Sub
		Private Sub cbLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLabelPosition.SelectedIndexChanged
			If Label IsNot Nothing Then
				Label.Position = CType(cbLabelPosition.SelectedIndex, FunnelSeriesLabelPosition)
			End If
		End Sub
		Private Sub checkEditValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditValueAsPercent.CheckedChanged
			chart.Series(0).Label.TextPattern = "{A} : " & (If(Me.checkEditValueAsPercent.Checked, "{VP:P0}", "{V:F0}"))
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
				checkEditAlignToCenter.Checked = View.AlignToCenter
				checkEditHeightToWidthRatioAuto.Checked = View.HeightToWidthRatioAuto
				spinPointDistance.EditValue = View.PointDistance
			End If
		End Sub
		Private Sub checkEditHeightToWidthRatioAuto_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditHeightToWidthRatioAuto.CheckedChanged
			If View IsNot Nothing Then
				View.HeightToWidthRatioAuto = checkEditHeightToWidthRatioAuto.Checked
				cbHeightToWidthRatio.Enabled = Not checkEditHeightToWidthRatioAuto.Checked
			End If
		End Sub
		Private Sub checkEditAlignToCenter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditAlignToCenter.CheckedChanged
			If View IsNot Nothing Then
				View.AlignToCenter = checkEditAlignToCenter.Checked
			End If
		End Sub
		Private Sub cbHeightToWidthRatio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbHeightToWidthRatio.SelectedIndexChanged
			If View IsNot Nothing Then
				View.HeightToWidthRatio = Convert.ToDouble(cbHeightToWidthRatio.SelectedItem)
			End If
		End Sub
		Private Sub spinPointDistance_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinPointDistance.EditValueChanged
			If View IsNot Nothing Then
				View.PointDistance = Convert.ToInt32(spinPointDistance.Value)
			End If
		End Sub
	End Class
End Namespace

