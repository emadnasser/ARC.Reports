Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts
Imports DevExpress.Utils

Partial Public Class SplineAreaSeries
	Inherits ChartBasePage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim series As SeriesBase = WebChartControl1.SeriesTemplate
			Dim label As PointSeriesLabel = CType(series.Label, PointSeriesLabel)
			Dim view As SplineAreaSeriesView = CType(series.View, SplineAreaSeriesView)
			cbShowLabels.Checked = series.LabelsVisibility = DefaultBoolean.True
			ComboBoxHelper.PrepareLabelAngleComboBox(cbLabelAngle, label.Angle)
			ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, view.PointMarkerOptions.Kind, view.PointMarkerOptions.StarPointCount)
			ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, view.PointMarkerOptions.Size)
			ComboBoxHelper.PrepareTransparencyComboBox(cbTransparency, view.Transparency)
		End If
		lblLabelAngle.ClientEnabled = cbShowLabels.Checked
		cbLabelAngle.ClientEnabled = cbShowLabels.Checked
	End Sub
	Private Sub PerformLabelAngleAction()
		Dim labelAngle As Integer = Convert.ToInt32(cbLabelAngle.SelectedItem.Text)
		CType(WebChartControl1.SeriesTemplate.Label, PointSeriesLabel).Angle = labelAngle
	End Sub
	Private Sub PerformMarkerKindAction()
		Dim item As MarkerKindItem = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind)
		Dim pointCount As Integer = 0
		Dim starItem As StarMarkerKindItem = TryCast(item, StarMarkerKindItem)
		If starItem IsNot Nothing Then
			pointCount = starItem.PointCount
		End If
		Dim view As PointSeriesView = CType(WebChartControl1.SeriesTemplate.View, PointSeriesView)
		view.PointMarkerOptions.Kind = item.MarkerKind
		If pointCount <> 0 Then
			view.PointMarkerOptions.StarPointCount = pointCount
		End If
	End Sub
	Private Sub PerformMarkerSizeAction()
		Dim size As Integer = Convert.ToInt32(cbMarkerSize.SelectedItem.Text)
		CType(WebChartControl1.SeriesTemplate.View, PointSeriesView).PointMarkerOptions.Size = size
	End Sub
	Private Sub PerformTransparencyAction()
		Dim transparency As Byte = Convert.ToByte(cbTransparency.SelectedItem.Text)
		CType(WebChartControl1.SeriesTemplate.View, SplineAreaSeriesView).Transparency = transparency
	End Sub
	Private Sub PerformShowLabelsAction()
		WebChartControl1.SeriesTemplate.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "LabelAngle" Then
			PerformLabelAngleAction()
		ElseIf e.Parameter = "MarkerKind" Then
			PerformMarkerKindAction()
		ElseIf e.Parameter = "MarkerSize" Then
			PerformMarkerSizeAction()
		ElseIf e.Parameter = "Transparency" Then
			PerformTransparencyAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		End If
	End Sub
End Class
