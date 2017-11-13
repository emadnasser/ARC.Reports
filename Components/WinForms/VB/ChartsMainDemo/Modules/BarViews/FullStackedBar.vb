Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class FullStackedBarDemo
		Inherits ChartDemoBase2D
		Private chart As ChartControl
		Private WithEvents checkEditValueAsPercent As CheckEdit

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub checkEditValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditValueAsPercent.CheckedChanged
			ChartControl.SeriesTemplate.Label.TextPattern = If(Me.checkEditValueAsPercent.Checked, "{VP:P0}", "{V:F1}K")
		End Sub
		Private Sub cbTextOrientation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTextOrientation.SelectedIndexChanged
			ChartControl.SeriesTemplate.Label.TextOrientation = CType(cbTextOrientation.SelectedIndex, TextOrientation)
		End Sub
		Private Sub cbLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLabelPosition.SelectedIndexChanged
			Dim label As StackedBarSeriesLabel = TryCast(ChartControl.SeriesTemplate.Label, StackedBarSeriesLabel)
			If label IsNot Nothing Then
				Select Case CStr(cbLabelPosition.SelectedItem)
					Case "Top Inside"
						label.Position = BarSeriesLabelPosition.TopInside
					Case "Center"
						label.Position = BarSeriesLabelPosition.Center
					Case "Bottom Inside"
						label.Position = BarSeriesLabelPosition.BottomInside
					Case Else
						label.Position = BarSeriesLabelPosition.Center
				End Select
				UpdateControls()
			End If
		End Sub
		Private Sub spnLabelIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spnLabelIndent.EditValueChanged
			Dim label As StackedBarSeriesLabel = TryCast(ChartControl.SeriesTemplate.Label, StackedBarSeriesLabel)
			If label IsNot Nothing Then
				label.Indent = Convert.ToInt32(spnLabelIndent.EditValue)
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
			ChartControl.DataSource = DevAV.GetSalesMixByRegion()
			Me.checkEditValueAsPercent.Checked = True
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			labelPosition.Enabled = ShowLabels
			cbLabelPosition.Enabled = ShowLabels
			Dim indentEnabled As Boolean = ShowLabels AndAlso (CStr(cbLabelPosition.SelectedItem) = "Top Inside" OrElse CStr(cbLabelPosition.SelectedItem) = "Bottom Inside")
			labelIndent.Enabled = indentEnabled
			spnLabelIndent.Enabled = indentEnabled
			labelTextOrientation.Enabled = ShowLabels
			cbTextOrientation.Enabled = ShowLabels
			Me.checkEditValueAsPercent.Enabled = ShowLabels
		End Sub
	End Class
End Namespace
