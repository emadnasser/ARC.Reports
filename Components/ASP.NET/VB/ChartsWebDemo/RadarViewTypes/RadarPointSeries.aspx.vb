Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class RadarPointSeries
	Inherits ChartBasePage
	Private ReadOnly Property Diagram() As RadarDiagram
		Get
			Return CType(WebChartControl1.Diagram, RadarDiagram)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim series As Series = WebChartControl1.Series(0)
			Dim view As RadarPointSeriesView = CType(series.View, RadarPointSeriesView)
			cbShowLabels.Checked = series.LabelsVisibility = DefaultBoolean.True
			ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, view.PointMarkerOptions.Kind, view.PointMarkerOptions.StarPointCount)
			ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, view.PointMarkerOptions.Size)
			ComboBoxHelper.PrepareComboBox(cbDiagramType, Diagram.DrawingStyle)
			ComboBoxHelper.PrepareComboBox(cbTextDirection, Diagram.AxisX.Label.TextDirection)
		End If
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
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		Next series
		WebChartControl1.ToolTipEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformMarkerKindAction()
		Dim item As MarkerKindItem = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind)
		Dim pointCount As Integer = 0
		Dim starItem As StarMarkerKindItem = TryCast(item, StarMarkerKindItem)
		If starItem IsNot Nothing Then
			pointCount = starItem.PointCount
		End If
		For Each series As Series In WebChartControl1.Series
			Dim view As RadarPointSeriesView = CType(series.View, RadarPointSeriesView)
			view.PointMarkerOptions.Kind = item.MarkerKind
			If pointCount <> 0 Then
				view.PointMarkerOptions.StarPointCount = pointCount
			End If
		Next series
	End Sub
	Private Sub PerformDiagramTypeAction()
		Diagram.DrawingStyle = CType(ComboBoxHelper.GetSelectedItem(cbDiagramType, GetType(RadarDiagramDrawingStyle)), RadarDiagramDrawingStyle)
	End Sub
	Private Sub PerformMarkerSizeAction()
		Dim size As Integer = Convert.ToInt32(cbMarkerSize.SelectedItem.Text)
		For Each series As Series In WebChartControl1.Series
			CType(series.View, RadarPointSeriesView).PointMarkerOptions.Size = size
		Next series
	End Sub
	Private Sub PerformTextDirectionAction()
		Dim label As RadarAxisXLabel = Diagram.AxisX.Label
		label.TextDirection = CType(ComboBoxHelper.GetSelectedItem(cbTextDirection, GetType(RadarAxisXLabelTextDirection)), RadarAxisXLabelTextDirection)
	End Sub
End Class
