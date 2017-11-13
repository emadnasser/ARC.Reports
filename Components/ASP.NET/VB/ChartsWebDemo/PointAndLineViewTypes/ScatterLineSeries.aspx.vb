Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts
Imports DevExpress.Utils

Partial Public Class ScatterLineSeries
	Inherits ChartBasePage
	Private Const a As Integer = 10
	Private Const archimedeanSpiralIndex As Integer = 0
	Private Const cardioidIndex As Integer = 1
	Private Const cartesianFoliumIndex As Integer = 2

	Private ReadOnly Property Series() As SeriesCollection
		Get
			Return WebChartControl1.Series
		End Get
	End Property
	Private ReadOnly Property ArchimedeanSpiralSeries() As Series
		Get
			Return Series(archimedeanSpiralIndex)
		End Get
	End Property
	Private ReadOnly Property CardioidSeries() As Series
		Get
			Return Series(cardioidIndex)
		End Get
	End Property
	Private ReadOnly Property CartesianFoliumSeries() As Series
		Get
			Return Series(cartesianFoliumIndex)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = ArchimedeanSpiralSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Dim view As ScatterLineSeriesView = TryCast(WebChartControl1.Series(0).View, ScatterLineSeriesView)
			cbShowMarkers.Checked = view.MarkerVisibility <> DefaultBoolean.False
			ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, view.PointMarkerOptions.Kind, view.PointMarkerOptions.StarPointCount)
			ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, view.PointMarkerOptions.Size)
			ComboBoxHelper.PrepareFunctionTypeScatterLineComboBox(cbFunctionType)
			PerformFunctionTypeAction()
		End If
		lblMarkerKind.ClientEnabled = cbShowMarkers.Checked
		lblMarkerSize.ClientEnabled = cbShowMarkers.Checked
		cbMarkerKind.ClientEnabled = cbShowMarkers.Checked
		cbMarkerSize.ClientEnabled = cbShowMarkers.Checked
	End Sub
	Private Sub CreateArchimedeanSpiralPoints()
		For i As Integer = 0 To 719 Step 10
			Dim t As Double = CDbl(i) / 180 * Math.PI
			Dim x As Double = t * Math.Cos(t)
			Dim y As Double = t * Math.Sin(t)
			ArchimedeanSpiralSeries.Points.Add(New SeriesPoint(x, y))
		Next i
	End Sub
	Private Sub CreateCardioidPoints()
		For i As Integer = 0 To 359 Step 10
			Dim t As Double = CDbl(i) / 180 * Math.PI
			Dim x As Double = a * (2 * Math.Cos(t) - Math.Cos(2 * t))
			Dim y As Double = a * (2 * Math.Sin(t) - Math.Sin(2 * t))
			CardioidSeries.Points.Add(New SeriesPoint(x, y))
		Next i
	End Sub
	Private Sub CreateCartesianFoliumPoints()
		For i As Integer = -30 To 124 Step 5
			Dim t As Double = Math.Tan(CDbl(i) / 180 * Math.PI)
			Dim x As Double = 3 * CDbl(a) * t / (t * t * t + 1)
			Dim y As Double = x * t
			CartesianFoliumSeries.Points.Add(New SeriesPoint(x, y))
		Next i
	End Sub
	Private Sub ShowSeries(ByVal visibleSeries As Series)
		For Each series As Series In Me.Series
			If series Is visibleSeries Then
				visibleSeries.Visible = True
			Else
				series.Visible = False
			End If
		Next series
	End Sub
	Private Sub PerformShowLabelsAction()
		For Each series As Series In Me.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
		Next series
		WebChartControl1.ToolTipEnabled = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
	End Sub
	Private Sub PerformMarkerKindAction()
		Dim item As MarkerKindItem = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind)
		Dim pointCount As Integer = 0
		Dim starItem As StarMarkerKindItem = TryCast(item, StarMarkerKindItem)
		If starItem IsNot Nothing Then
			pointCount = starItem.PointCount
		End If
		For Each series As Series In WebChartControl1.Series
			Dim view As ScatterLineSeriesView = CType(series.View, ScatterLineSeriesView)
			view.PointMarkerOptions.Kind = item.MarkerKind
			If pointCount <> 0 Then
				view.PointMarkerOptions.StarPointCount = pointCount
			End If
		Next series
	End Sub
	Private Sub PerformMarkerSizeAction()
		For Each series As Series In Me.Series
			CType(series.View, ScatterLineSeriesView).LineMarkerOptions.Size = Convert.ToInt32(cbMarkerSize.SelectedItem.Text)
		Next series
	End Sub
	Private Sub PerformFunctionTypeAction()
		If cbFunctionType.SelectedIndex = archimedeanSpiralIndex Then
			If ArchimedeanSpiralSeries.Points.Count = 0 Then
				CreateArchimedeanSpiralPoints()
			End If
			ShowSeries(ArchimedeanSpiralSeries)
		ElseIf cbFunctionType.SelectedIndex = cardioidIndex Then
			If CardioidSeries.Points.Count = 0 Then
				CreateCardioidPoints()
			End If
			ShowSeries(CardioidSeries)
		ElseIf cbFunctionType.SelectedIndex = cartesianFoliumIndex Then
			If CartesianFoliumSeries.Points.Count = 0 Then
				CreateCartesianFoliumPoints()
			End If
			ShowSeries(CartesianFoliumSeries)
		End If
	End Sub
	Private Sub PerformShowMarkersAction()
		For Each series As Series In Me.Series
			CType(series.View, ScatterLineSeriesView).MarkerVisibility = If(cbShowMarkers.Checked, DefaultBoolean.True, DefaultBoolean.False)
		Next series
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "MarkerKind" Then
			PerformMarkerKindAction()
		ElseIf e.Parameter = "MarkerSize" Then
			PerformMarkerSizeAction()
		ElseIf e.Parameter = "FunctionType" Then
			PerformFunctionTypeAction()
		ElseIf e.Parameter = "ShowMarkers" Then
			PerformShowMarkersAction()
		End If
	End Sub
End Class
