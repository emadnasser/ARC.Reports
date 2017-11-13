Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.PieDoughnutViews
	Partial Public Class Pie3dDemo
		Inherits ChartDemoBase3D
		Private chart As ChartControl
		Private WithEvents checkEditValueAsPercent As CheckEdit

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			InitExplodeModeComboBox()
			cbLabelPosition.EditValue = "Radial"
			ShowLabels = True
		End Sub

		Private Sub InitExplodeModeComboBox()
			cbExplodeMode.Properties.Items.AddRange(PieExplodingHelper.CreateModeList(ChartControl.Series(0).Points, False))
			cbExplodeMode.SelectedIndex = 0
		End Sub
		Private Sub checkEditValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditValueAsPercent.CheckedChanged
			If chart.Series.Count = 0 Then
				Return
			End If
			chart.Series(0).Label.TextPattern = If(Me.checkEditValueAsPercent.Checked, "{VP:P0}", "{V:F1}")
		End Sub
		Private Sub SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLabelPosition.SelectedIndexChanged
			If chart.Series.Count = 0 Then
				Return
			End If
			Dim label As Pie3DSeriesLabel = TryCast(chart.Series(0).Label, Pie3DSeriesLabel)
			If label IsNot Nothing Then
				label.Position = CType(cbLabelPosition.SelectedIndex, PieSeriesLabelPosition)
			End If
		End Sub
		Private Sub cbExplodeMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbExplodeMode.SelectedIndexChanged
			If chart.Series.Count = 0 Then
				Return
			End If
			Dim view As Pie3DSeriesView = TryCast(chart.Series(0).View, Pie3DSeriesView)
			If view IsNot Nothing Then
				Dim mode As String = CStr(cbExplodeMode.SelectedItem)
				PieExplodingHelper.ApplyMode(view, mode)
				txtDistance.Enabled = mode <> PieExplodingHelper.None
			End If
		End Sub
		Private Sub txtDistance_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDistance.EditValueChanged
			If chart.Series.Count = 0 Then
				Return
			End If
			Dim view As Pie3DSeriesView = TryCast(chart.Series(0).View, Pie3DSeriesView)
			If view IsNot Nothing Then
				view.ExplodedDistancePercentage = Convert.ToDouble(Me.txtDistance.EditValue)
			End If
		End Sub

		Protected Overrides Sub UpdateRotationAngles(ByVal diagram As Diagram3D)
			diagram.RotationOrder = RotationOrder.ZXY
			diagram.RotationAngleX = -35
			diagram.RotationAngleY = 0
			diagram.RotationAngleZ = 15
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If chart.Series.Count = 0 Then
				Return
			End If
			Dim label As Pie3DSeriesLabel = TryCast(chart.Series(0).Label, Pie3DSeriesLabel)
			If label IsNot Nothing Then
				cbLabelPosition.SelectedIndex = CInt(Fix(label.Position))
				checkEditValueAsPercent.Checked = ChartControl.Series(0).Label.TextPattern.Contains("VP")
			End If
			cbLabelPosition.Enabled = ShowLabels
			labelPosition.Enabled = ShowLabels
			checkEditValueAsPercent.Enabled = ShowLabels
			Dim view As Pie3DSeriesView = TryCast(chart.Series(0).View, Pie3DSeriesView)
			If view IsNot Nothing Then
				txtDistance.EditValue = view.ExplodedDistancePercentage
			End If
		End Sub
	End Class
End Namespace
