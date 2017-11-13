Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class BarDemo
		Inherits ChartDemoBase2D
		Private chart As ChartControl

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub cbTextOrientation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTextOrientation.SelectedIndexChanged
			For Each series As Series In chart.Series
				If series.Label IsNot Nothing Then
					series.Label.TextOrientation = CType(cbTextOrientation.SelectedIndex, TextOrientation)
				End If
			Next series
		End Sub
		Private Sub cbLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLabelPosition.SelectedIndexChanged
			For Each series As Series In chart.Series
				Dim label As SideBySideBarSeriesLabel = TryCast(series.Label, SideBySideBarSeriesLabel)
				If label IsNot Nothing Then
					Select Case CStr(cbLabelPosition.SelectedItem)
						Case "Auto"
							label.Position = BarSeriesLabelPosition.Auto
						Case "Top"
							label.Position = BarSeriesLabelPosition.Top
						Case "Top Inside"
							label.Position = BarSeriesLabelPosition.TopInside
						Case "Center"
							label.Position = BarSeriesLabelPosition.Center
						Case "Bottom Inside"
							label.Position = BarSeriesLabelPosition.BottomInside
						Case Else
							label.Position = BarSeriesLabelPosition.Auto
					End Select
					UpdateControls()
				End If
			Next series
		End Sub
		Private Sub spnLabelIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spnLabelIndent.EditValueChanged
			For Each series As Series In chart.Series
				Dim label As SideBySideBarSeriesLabel = TryCast(series.Label, SideBySideBarSeriesLabel)
				If label IsNot Nothing Then
					label.Indent = Convert.ToInt32(spnLabelIndent.EditValue)
				End If
			Next series
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
			ChartControl.DataSource = DevAV.GetSales()
			ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries
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
		End Sub
	End Class
End Namespace
