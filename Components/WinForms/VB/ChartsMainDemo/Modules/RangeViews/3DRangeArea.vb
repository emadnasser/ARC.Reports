Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts.Demos.PointLineViews

Namespace DevExpress.XtraCharts.Demos.RangeViews
	Partial Public Class RangeArea3dDemo
		Inherits Line3dDemo
		Private chart As ChartControl

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxLabelKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxLabelKind.SelectedIndexChanged
			If chart.Series.Count = 0 Then
				Return
			End If
			Dim label As RangeArea3DSeriesLabel = TryCast(chart.Series(0).Label, RangeArea3DSeriesLabel)
			If label Is Nothing Then
				Return
			End If
			Select Case CStr(comboBoxLabelKind.SelectedItem)
				Case "One Label"
					label.Kind = RangeAreaLabelKind.OneLabel
				Case "Two Labels"
					label.Kind = RangeAreaLabelKind.TwoLabels
				Case "Min Value Label"
					label.Kind = RangeAreaLabelKind.MinValueLabel
				Case "Max Value Label"
					label.Kind = RangeAreaLabelKind.MaxValueLabel
				Case Else
					label.Kind = RangeAreaLabelKind.TwoLabels
			End Select
			If label.Kind = RangeAreaLabelKind.OneLabel Then
				label.TextPattern ="{VD}"
			Else
				label.TextPattern = "{V:G4}"
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
			UpdateControls()
		End Sub
		Protected Overrides Sub InitDataSource()
			ChartControl.Series(0).DataSource = SourceOfEnergy.GetOkWtiPrices()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			comboBoxLabelKind.Enabled = ShowLabels
			labelLabelKind.Enabled = ShowLabels
		End Sub
	End Class
End Namespace
