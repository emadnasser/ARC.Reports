Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class RangeAreaSeries
	Inherits ChartBasePage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim series As Series = WebChartControl1.Series(0)
			Dim view As RangeAreaSeriesView = CType(series.View, RangeAreaSeriesView)

			cbShowLabels.Checked = series.LabelsVisibility = DefaultBoolean.True
			cbShowMarker1.Checked = view.Marker1Visibility = DefaultBoolean.True
			cbShowMarker2.Checked = view.Marker2Visibility = DefaultBoolean.True
			ComboBoxHelper.PrepareComboBox(cbLabelKind, New String() { "One Label", "Two Labels", "Min Value Label", "Max Value Label", "Value 1 Label", "Value 2 Label" }, "Two Labels")
			ComboBoxHelper.PrepareMarkerKindComboBox(cbMarker1Kind, view.Marker1.Kind, view.Marker1.StarPointCount)
			ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarker1Size, view.Marker1.Size)
			ComboBoxHelper.PrepareMarkerKindComboBox(cbMarker2Kind, view.Marker2.Kind, view.Marker2.StarPointCount)
			ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarker2Size, view.Marker2.Size)
		End If
		lblMarker1Kind.ClientEnabled = cbShowMarker1.Checked
		cbMarker1Kind.ClientEnabled = cbShowMarker1.Checked
		lblMarker1Size.ClientEnabled = cbShowMarker1.Checked
		cbMarker1Size.ClientEnabled = cbShowMarker1.Checked
		lblMarker2Kind.ClientEnabled = cbShowMarker2.Checked
		cbMarker2Kind.ClientEnabled = cbShowMarker2.Checked
		lblMarker2Size.ClientEnabled = cbShowMarker2.Checked
		cbMarker2Size.ClientEnabled = cbShowMarker2.Checked
		lblLabelKind.ClientEnabled = cbShowLabels.Checked
		cbLabelKind.ClientEnabled = cbShowLabels.Checked
	End Sub
	Private Sub PerformShowMarker1Action()
		For Each series As Series In WebChartControl1.Series
			CType(series.View, RangeAreaSeriesView).Marker1Visibility = If(cbShowMarker1.Checked, DefaultBoolean.True, DefaultBoolean.False)
		Next series
	End Sub
	Private Sub PerformShowMarker2Action()
		For Each series As Series In WebChartControl1.Series
			CType(series.View, RangeAreaSeriesView).Marker2Visibility = If(cbShowMarker2.Checked, DefaultBoolean.True, DefaultBoolean.False)
		Next series
	End Sub
	Private Sub PerformMarkerKindAction(ByVal marker As Marker, ByVal item As MarkerKindItem)
		Dim pointCount As Integer = 0
		Dim starItem As StarMarkerKindItem = TryCast(item, StarMarkerKindItem)
		If starItem IsNot Nothing Then
			pointCount = starItem.PointCount
		End If
		marker.Kind = item.MarkerKind
		If pointCount <> 0 Then
			marker.StarPointCount = pointCount
		End If
	End Sub
	Private Sub PerformMarker1KindAction()
		Dim item As MarkerKindItem = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarker1Kind)
		Dim marker1 As Marker = (CType(WebChartControl1.Series(0).View, RangeAreaSeriesView)).Marker1
		PerformMarkerKindAction(marker1, item)
	End Sub
	Private Sub PerformMarker2KindAction()
		Dim item As MarkerKindItem = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarker2Kind)
		Dim marker2 As Marker = (CType(WebChartControl1.Series(0).View, RangeAreaSeriesView)).Marker2
		PerformMarkerKindAction(marker2, item)
	End Sub
	Private Sub PerformMarker1SizeAction()
		Dim size As Integer = Convert.ToInt32(cbMarker1Size.SelectedItem.Text)
		For Each series As Series In WebChartControl1.Series
			CType(series.View, RangeAreaSeriesView).Marker1.Size = size
		Next series
	End Sub
	Private Sub PerformMarker2SizeAction()
		Dim size As Integer = Convert.ToInt32(cbMarker2Size.SelectedItem.Text)
		For Each series As Series In WebChartControl1.Series
			CType(series.View, RangeAreaSeriesView).Marker2.Size = size
		Next series
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
			Case "Value 1 Label"
				kind = RangeAreaLabelKind.Value1Label
			Case "Value 2 Label"
				kind = RangeAreaLabelKind.Value2Label
			Case Else
				kind = RangeAreaLabelKind.OneLabel
		End Select
		For Each series As Series In WebChartControl1.Series
			Dim label As RangeAreaSeriesLabel = CType(series.Label, RangeAreaSeriesLabel)
			label.Kind = kind
			If label.Kind = RangeAreaLabelKind.OneLabel Then
				series.Label.TextPattern = "{VD:F2}"
			Else
				series.Label.TextPattern = "{V:F2}"
			End If
		Next series
	End Sub
	Private Sub PerformShowLabelsAction()
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		Next series
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ShowMarker1" Then
			PerformShowMarker1Action()
		ElseIf e.Parameter = "Marker1Kind" Then
			PerformMarker1KindAction()
		ElseIf e.Parameter = "Marker1Size" Then
			PerformMarker1SizeAction()
		End If
		If e.Parameter = "ShowMarker2" Then
			PerformShowMarker2Action()
		ElseIf e.Parameter = "Marker2Kind" Then
			PerformMarker2KindAction()
		ElseIf e.Parameter = "Marker2Size" Then
			PerformMarker2SizeAction()
		ElseIf e.Parameter = "LabelKind" Then
			PerformLabelKindAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		End If
	End Sub
End Class
