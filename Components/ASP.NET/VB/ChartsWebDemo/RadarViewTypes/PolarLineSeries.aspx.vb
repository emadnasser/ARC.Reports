Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class PolarLineSeries
	Inherits ChartBasePage
	Private Const defaultPointsCount As Integer = 72

	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property View() As RadarLineSeriesView
		Get
			Return CType(Series.View, RadarLineSeriesView)
		End Get
	End Property
	Private ReadOnly Property Diagram() As RadarDiagram
		Get
			Return CType(WebChartControl1.Diagram, RadarDiagram)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = Series.LabelsVisibility = DefaultBoolean.True
			cbShowMarkers.Checked = View.MarkerVisibility <> DefaultBoolean.False
			ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, View.PointMarkerOptions.Kind, View.PointMarkerOptions.StarPointCount)
			ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, View.PointMarkerOptions.Size)
			ComboBoxHelper.PrepareComboBox(cbDiagramType, Diagram.DrawingStyle)
			ComboBoxHelper.PrepareFunctionTypeComboBox(cbFunctionType)
			Series.Points.AddRange(PolarFunctionCalculator.GenerateFunctionPoints(2, defaultPointsCount))
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
		ElseIf e.Parameter = "FunctionType" Then
			PerformFunctionTypeAction()
		ElseIf e.Parameter = "ShowMarkers" Then
			PerformShowMarkersAction()
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		Series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
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
		View.LineMarkerOptions.Size = Convert.ToInt32(cbMarkerSize.SelectedItem.Text)
	End Sub
	Private Sub PerformFunctionTypeAction()
		Series.Points.Clear()
		Series.Points.AddRange(PolarFunctionCalculator.GenerateFunctionPoints(cbFunctionType.SelectedIndex, defaultPointsCount))
	End Sub
	Private Sub PerformShowMarkersAction()
		View.MarkerVisibility = If(cbShowMarkers.Checked, DefaultBoolean.True, DefaultBoolean.False)
	End Sub
End Class
