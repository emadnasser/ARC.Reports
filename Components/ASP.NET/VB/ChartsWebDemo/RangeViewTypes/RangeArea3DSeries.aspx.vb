Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts

Partial Public Class RangeArea3DSeries
	Inherits ChartBasePage
	Private ReadOnly Property Diagram() As Diagram3D
		Get
			Return CType(WebChartControl1.Diagram, Diagram3D)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = WebChartControl1.Series(0).LabelsVisibility <> DevExpress.Utils.DefaultBoolean.False
			ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle)
			ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent)
			ComboBoxHelper.PrepareComboBox(cbLabelKind, New String() { "One Label", "Two Labels", "Min Value Label", "Max Value Label" }, "Two Labels")
		End If
		lblLabelKind.ClientEnabled = cbShowLabels.Checked
		cbLabelKind.ClientEnabled = cbShowLabels.Checked
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "PerspectiveAngle" Then
			PerformPerspectiveAngleAction()
		ElseIf e.Parameter = "ZoomPercent" Then
			PerformZoomPercentAction()
		ElseIf e.Parameter = "LabelKind" Then
			PerformLabelKindAction()
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
		Next series
	End Sub
	Private Sub PerformPerspectiveAngleAction()
		Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle)
	End Sub
	Private Sub PerformZoomPercentAction()
		Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text)
	End Sub
	Private Sub PerformLabelKindAction()
		Dim kind As RangeAreaLabelKind
		Select Case CStr(cbLabelKind.Value)
			Case "One Label"
				kind = RangeAreaLabelKind.OneLabel
			Case "Two Labels"
				kind = RangeAreaLabelKind.TwoLabels
			Case "Min Value Label"
				kind = RangeAreaLabelKind.MinValueLabel
			Case "Max Value Label"
				kind = RangeAreaLabelKind.MaxValueLabel
			Case Else
				kind = RangeAreaLabelKind.OneLabel
		End Select
		For Each series As Series In WebChartControl1.Series
			Dim label As RangeArea3DSeriesLabel = CType(series.Label, RangeArea3DSeriesLabel)
			label.Kind = kind
			If label.Kind = RangeAreaLabelKind.OneLabel Then
				series.Label.TextPattern = "{VD:F2}"
			Else
				series.Label.TextPattern = "{V:F2}"
			End If
		Next series
	End Sub
End Class
