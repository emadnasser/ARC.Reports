Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class BarSeries
	Inherits ChartBasePage
	Private Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim label As SideBySideBarSeriesLabel = CType(WebChartControl1.SeriesTemplate.Label, SideBySideBarSeriesLabel)
		If (Not IsPostBack) Then
			ComboBoxHelper.PrepareComboBox(cbTextOrientation, TextOrientation.Horizontal)
			ComboBoxHelper.PrepareComboBox(cbLabelPosition, New String() { "Top", "Top Inside", "Center", "Bottom Inside" })
			chbShowLabels.Checked = WebChartControl1.SeriesTemplate.LabelsVisibility = DefaultBoolean.True
			spnLabelIndent.Value = label.Indent
			cbTextOrientation.SelectedIndex = CInt(Fix(label.TextOrientation))
			Select Case label.Position
				Case BarSeriesLabelPosition.Top
					cbLabelPosition.Value = "Top"
				Case BarSeriesLabelPosition.TopInside
					cbLabelPosition.Value = "Top Inside"
				Case BarSeriesLabelPosition.Center
					cbLabelPosition.Value = "Center"
				Case BarSeriesLabelPosition.BottomInside
					cbLabelPosition.Value = "Bottom Inside"
				Case Else
					cbLabelPosition.Value = "Center"
			End Select
		End If
		lblLabelPosition.ClientEnabled = chbShowLabels.Checked
		cbLabelPosition.ClientEnabled = chbShowLabels.Checked
		lbTextOrientation.ClientEnabled = chbShowLabels.Checked
		cbTextOrientation.ClientEnabled = chbShowLabels.Checked
		Dim indentEnabled As Boolean = chbShowLabels.Checked AndAlso (label.Position = BarSeriesLabelPosition.TopInside OrElse label.Position = BarSeriesLabelPosition.BottomInside)
		lblLabelIndent.ClientEnabled = indentEnabled
		spnLabelIndent.ClientEnabled = indentEnabled
		WebChartControl1.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries
	End Sub
	Private Sub PerformLabelPositionAction()
		Dim position As BarSeriesLabelPosition
		Select Case CStr(cbLabelPosition.Value)
			Case "Top"
				position = BarSeriesLabelPosition.Top
			Case "Top Inside"
				position = BarSeriesLabelPosition.TopInside
			Case "Center"
				position = BarSeriesLabelPosition.Center
			Case "Bottom Inside"
				position = BarSeriesLabelPosition.BottomInside
			Case Else
				position = BarSeriesLabelPosition.Top
		End Select
		CType(WebChartControl1.SeriesTemplate.Label, SideBySideBarSeriesLabel).Position = position
	End Sub
	Private Sub PerformShowLabelsAction()
		WebChartControl1.SeriesTemplate.LabelsVisibility = If(chbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(chbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformTextOrientationAction()
		WebChartControl1.SeriesTemplate.Label.TextOrientation = CType(cbTextOrientation.SelectedIndex, TextOrientation)
	End Sub
	Private Sub PerformLabelIndentAction()
		CType(WebChartControl1.SeriesTemplate.Label, BarSeriesLabel).Indent = Convert.ToInt32(spnLabelIndent.Value)
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "LabelPosition" Then
			PerformLabelPositionAction()
		ElseIf e.Parameter = "TextOrientation" Then
			PerformTextOrientationAction()
		ElseIf e.Parameter = "LabelIndent" Then
			PerformLabelIndentAction()
		End If
	End Sub
End Class
