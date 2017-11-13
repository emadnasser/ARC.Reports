Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class RadarRangeAreaSeries
	Inherits ChartBasePage
	Private ReadOnly Property Diagram() As RadarDiagram
		Get
			Return CType(WebChartControl1.Diagram, RadarDiagram)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim series As Series = WebChartControl1.Series(0)
			Dim view = CType(series.View, RadarRangeAreaSeriesView)
			cbShowLabels.Checked = series.LabelsVisibility = DefaultBoolean.True
			cbShowMarkers.Checked = view.Marker1Visibility = DefaultBoolean.True
			ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, view.Marker1.Kind, view.Marker1.StarPointCount)
			ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, view.Marker1.Size)
			ComboBoxHelper.PrepareComboBox(cbDiagramType, Diagram.DrawingStyle)
			ComboBoxHelper.PrepareComboBox(cbTextDirection, Diagram.AxisX.Label.TextDirection)
		End If
		lblMarkerKind.ClientEnabled = cbShowMarkers.Checked
		lblMarkerSize.ClientEnabled = cbShowMarkers.Checked
		cbMarkerKind.ClientEnabled = cbShowMarkers.Checked
		cbMarkerSize.ClientEnabled = cbShowMarkers.Checked
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "MarkerKind" Then
			PerformMarkerKindAction()
		ElseIf e.Parameter = "DiagramType" Then
			PerformDiagramTypeAction()
		ElseIf e.Parameter = "MarkerSize" Then
			PerformMarkerSizeAction()
		ElseIf e.Parameter = "TextDirection" Then
			PerformTextDirectionAction()
		ElseIf e.Parameter = "ShowMarkers" Then
			PerformShowMarkersAction()
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		WebChartControl1.Series(0).LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.ToolTipEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformMarkerKindAction()
		Dim item As MarkerKindItem = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind)
		Dim pointCount As Integer = 0
		Dim starItem As StarMarkerKindItem = TryCast(item, StarMarkerKindItem)
		If starItem IsNot Nothing Then
			pointCount = starItem.PointCount
		End If
		Dim view = CType(WebChartControl1.Series(0).View, RadarRangeAreaSeriesView)
		view.Marker1.Kind = item.MarkerKind
		view.Marker2.Kind = item.MarkerKind
		If pointCount <> 0 Then
			view.Marker1.StarPointCount = pointCount
			view.Marker2.StarPointCount = pointCount
		End If

	End Sub
	Private Sub PerformDiagramTypeAction()
		Diagram.DrawingStyle = CType(ComboBoxHelper.GetSelectedItem(cbDiagramType, GetType(RadarDiagramDrawingStyle)), RadarDiagramDrawingStyle)
	End Sub
	Private Sub PerformMarkerSizeAction()
		Dim size As Integer = Convert.ToInt32(cbMarkerSize.SelectedItem.Text)
		Dim view = CType(WebChartControl1.Series(0).View, RadarRangeAreaSeriesView)
		view.Marker1.Size = size
		view.Marker2.Size = size
	End Sub
	Private Sub PerformTextDirectionAction()
		Dim label As RadarAxisXLabel = Diagram.AxisX.Label
		label.TextDirection = CType(ComboBoxHelper.GetSelectedItem(cbTextDirection, GetType(RadarAxisXLabelTextDirection)), RadarAxisXLabelTextDirection)
	End Sub
	Private Sub PerformShowMarkersAction()
		Dim view = CType(WebChartControl1.Series(0).View, RadarRangeAreaSeriesView)
		view.Marker1Visibility = If(cbShowMarkers.Checked, DefaultBoolean.True, DefaultBoolean.False)
		view.Marker2Visibility = If(cbShowMarkers.Checked, DefaultBoolean.True, DefaultBoolean.False)
	End Sub
End Class
