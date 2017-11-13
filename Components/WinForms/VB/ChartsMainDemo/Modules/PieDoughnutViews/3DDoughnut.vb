Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.PieDoughnutViews
	Partial Public Class Doughnut3dDemo
		Inherits ChartDemoBase3D
		Private chart As ChartControl
		Private WithEvents checkEditValueAsPercent As CheckEdit

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			InitExplodeModeComboBox()
			cbLabelPosition.EditValue = "Radial"
			ShowLabels = True
		End Sub

		Private Sub InitExplodeModeComboBox()
			If ChartControl.Series.Count > 0 Then
				cbExplodeMode.Properties.Items.AddRange(PieExplodingHelper.CreateModeList(ChartControl.Series(0).Points, False))
			End If
			cbExplodeMode.SelectedIndex = 0
		End Sub
		Private Sub checkEditValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditValueAsPercent.CheckedChanged
			If ChartControl.Series.Count > 0 Then
				ChartControl.Series(0).Label.TextPattern = If(Me.checkEditValueAsPercent.Checked, "{VP:P0}", "{V:F1}")
			End If
		End Sub
		Private Sub SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLabelPosition.SelectedIndexChanged
			If ChartControl.Series.Count > 0 Then
				Dim label As Doughnut3DSeriesLabel = TryCast(ChartControl.Series(0).Label, Doughnut3DSeriesLabel)
				If label IsNot Nothing Then
					label.Position = CType(cbLabelPosition.SelectedIndex, PieSeriesLabelPosition)
				End If
			End If
		End Sub
		Private Sub txtHoleRadius_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtHoleRadius.EditValueChanged
			If ChartControl.Series.Count > 0 AndAlso TypeOf ChartControl.Series(0).View Is Doughnut3DSeriesView Then
				CType(ChartControl.Series(0).View, Doughnut3DSeriesView).HoleRadiusPercent = Convert.ToInt32(txtHoleRadius.EditValue)
			End If
		End Sub
		Private Sub cbExplodeMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbExplodeMode.SelectedIndexChanged
			If ChartControl.Series.Count > 0 Then
				Dim view As Doughnut3DSeriesView = TryCast(ChartControl.Series(0).View, Doughnut3DSeriesView)
				If view IsNot Nothing Then
					Dim mode As String = CStr(cbExplodeMode.SelectedItem)
					PieExplodingHelper.ApplyMode(view, mode)
				End If
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
			If ChartControl.Series.Count > 0 Then
				Dim label As Doughnut3DSeriesLabel = TryCast(ChartControl.Series(0).Label, Doughnut3DSeriesLabel)
				If label IsNot Nothing Then
					cbLabelPosition.SelectedIndex = CInt(Fix(label.Position))
				End If
				checkEditValueAsPercent.Checked = ChartControl.Series(0).Label.TextPattern.Contains("VP")
				cbLabelPosition.Enabled = ShowLabels
				labelPosition.Enabled = ShowLabels
				checkEditValueAsPercent.Enabled = ShowLabels
				If TypeOf ChartControl.Series(0).View Is Doughnut3DSeriesView Then
					txtHoleRadius.EditValue = (CType(ChartControl.Series(0).View, Doughnut3DSeriesView)).HoleRadiusPercent
				End If
			End If
		End Sub
	End Class
End Namespace
