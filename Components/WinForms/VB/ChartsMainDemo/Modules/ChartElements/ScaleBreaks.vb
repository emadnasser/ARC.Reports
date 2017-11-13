Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class ScaleBreaksDemo
		Inherits ChartDemoBase2D
		Private ReadOnly Property Axis() As Axis
			Get
				Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
				Return If(diagram IsNot Nothing, diagram.AxisY, Nothing)
			End Get
		End Property
		Private ReadOnly Property AutoScaleBreaks() As AutoScaleBreaks
			Get
				Return If(Axis IsNot Nothing, Axis.AutoScaleBreaks, Nothing)
			End Get
		End Property
		Private ReadOnly Property Options() As ScaleBreakOptions
			Get
				Return If(Axis IsNot Nothing, Axis.ScaleBreakOptions, Nothing)
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

		Private Sub UpdateControlsState()
			If Options Is Nothing OrElse AutoScaleBreaks Is Nothing Then
				Return
			End If
			lblMaxCount.Enabled = AutoScaleBreaks.Enabled
			spnMaxCount.Enabled = AutoScaleBreaks.Enabled
			cbStyle.Enabled = AutoScaleBreaks.Enabled
			spnSize.Enabled = AutoScaleBreaks.Enabled
			ceColor.Enabled = AutoScaleBreaks.Enabled
			lblStyle.Enabled = AutoScaleBreaks.Enabled
			lblSize.Enabled = AutoScaleBreaks.Enabled
			lblColor.Enabled = AutoScaleBreaks.Enabled
			btnResetColor.Enabled = AutoScaleBreaks.Enabled AndAlso Options.Color <> Color.Empty
		End Sub
		Private Sub chEnableScaleBreaks_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chEnableScaleBreaks.CheckedChanged
			If AutoScaleBreaks IsNot Nothing Then
				AutoScaleBreaks.Enabled = chEnableScaleBreaks.Checked
			End If
			UpdateControlsState()
		End Sub
		Private Sub cbStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStyle.SelectedIndexChanged
			If Options IsNot Nothing Then
				Options.Style = CType(cbStyle.SelectedIndex, ScaleBreakStyle)
			End If
		End Sub
		Private Sub spnSize_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spnSize.EditValueChanged
			If Options IsNot Nothing Then
				Options.SizeInPixels = Convert.ToInt32(spnSize.EditValue)
			End If
		End Sub
		Private Sub ceColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceColor.EditValueChanged
			If Options IsNot Nothing Then
				Options.Color = CType(ceColor.EditValue, Color)
			End If
			UpdateControlsState()
		End Sub
		Private Sub btnResetColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetColor.Click
			If Options IsNot Nothing Then
				Options.Color = Color.Empty
				ceColor.EditValue = Options.Color
			End If
		End Sub
		Private Sub spnMaxCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spnMaxCount.EditValueChanged
			If AutoScaleBreaks IsNot Nothing Then
				AutoScaleBreaks.MaxCount = Convert.ToInt32(spnMaxCount.EditValue)
			End If
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If AutoScaleBreaks IsNot Nothing Then
				chEnableScaleBreaks.Checked = AutoScaleBreaks.Enabled
				spnMaxCount.EditValue = AutoScaleBreaks.MaxCount
			End If
			If Options IsNot Nothing Then
				cbStyle.SelectedIndex = CInt(Fix(Options.Style))
				spnSize.EditValue = Options.SizeInPixels
				ceColor.EditValue = Options.Color
			End If
			UpdateControlsState()
		End Sub
	End Class
End Namespace

