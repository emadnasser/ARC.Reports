Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraCharts

Partial Public Class PointSeries
	Inherits ChartBasePage
	Private Shared Function CalcRandomPoints(ByVal random As Random, ByVal count As Integer, ByVal xMin As Integer, ByVal xMax As Integer, ByVal yMin As Integer, ByVal yMax As Integer) As Point()
		If count > Math.Abs(xMax - xMin) * Math.Abs(yMax - yMin) Then
			Throw New ArgumentException("Parameter ""count"" very large. Can't calculate unique random points.")
		End If
		Dim points(count - 1) As Point
		For i As Integer = 0 To points.Length - 1
			Dim repeat As Boolean
			Do
				repeat = False
				points(i).X = random.Next(xMin, xMax)
				points(i).Y = random.Next(yMin, yMax)
				For k As Integer = 0 To i - 1
					If points(k) = points(i) Then
						repeat = True
						Exit For
					End If
				Next k
			Loop While repeat
		Next i
		Return points
	End Function
	Private Shared Function CalcRandomSeriesPoints(ByVal random As Random, ByVal count As Integer, ByVal xMin As Integer, ByVal xMax As Integer, ByVal yMin As Integer, ByVal yMax As Integer) As SeriesPoint()
		Dim points() As Point = CalcRandomPoints(random, count, xMin, xMax, yMin, yMax)
		Dim seriesPoints(points.Length - 1) As SeriesPoint
		For i As Integer = 0 To points.Length - 1
			seriesPoints(i) = New SeriesPoint(points(i).X.ToString(), New Double() { points(i).Y })
		Next i
		Return seriesPoints
	End Function

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			InitSeries()
			Dim series As Series = WebChartControl1.Series(0)
			Dim label As PointSeriesLabel = CType(series.Label, PointSeriesLabel)
			Dim view As PointSeriesView = CType(series.View, PointSeriesView)

			cbShowLabels.Checked = series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			ComboBoxHelper.PrepareLabelAngleComboBox(cbLabelAngle, label.Angle)
			ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, view.PointMarkerOptions.Kind, view.PointMarkerOptions.StarPointCount)
			ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, view.PointMarkerOptions.Size)
		End If
		lblLabelAngle.ClientEnabled = cbShowLabels.Checked
		cbLabelAngle.ClientEnabled = cbShowLabels.Checked
		lblLabelPosition.ClientEnabled = cbShowLabels.Checked
		cbLabelPosition.ClientEnabled = cbShowLabels.Checked
	End Sub
	Private Sub InitSeries()
		Dim random As New Random()
		WebChartControl1.Series(0).Points.Clear()
		WebChartControl1.Series(0).Points.AddRange(CalcRandomSeriesPoints(random, 20, 1, 8, 5, 12))
		WebChartControl1.Series(1).Points.Clear()
		WebChartControl1.Series(1).Points.AddRange(CalcRandomSeriesPoints(random, 20, 9, 16, 1, 8))
		WebChartControl1.Series(2).Points.Clear()
		WebChartControl1.Series(2).Points.AddRange(CalcRandomSeriesPoints(random, 20, 6, 13, 14, 21))
	End Sub
	Private Sub PerformLabelAngleAction()
		Dim labelAngle As Integer = Convert.ToInt32(cbLabelAngle.SelectedItem.Text)
		For Each series As Series In WebChartControl1.Series
			CType(series.Label, PointSeriesLabel).Angle = labelAngle
		Next series
	End Sub
	Private Sub PerformLabelPositionAction()
		Dim labelPosition As PointLabelPosition = CType(cbLabelPosition.SelectedIndex, PointLabelPosition)
		For Each series As Series In WebChartControl1.Series
			CType(series.Label, PointSeriesLabel).Position = labelPosition
		Next series
	End Sub
	Private Sub PerformMarkerKindAction()
		Dim item As MarkerKindItem = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind)
		Dim pointCount As Integer = 0
		Dim starItem As StarMarkerKindItem = TryCast(item, StarMarkerKindItem)
		If starItem IsNot Nothing Then
			pointCount = starItem.PointCount
		End If
		For Each series As Series In WebChartControl1.Series
			Dim view As PointSeriesView = CType(series.View, PointSeriesView)
			view.PointMarkerOptions.Kind = item.MarkerKind
			If pointCount <> 0 Then
				view.PointMarkerOptions.StarPointCount = pointCount
			End If
		Next series
	End Sub
	Private Sub PerformMarkerSizeAction()
		Dim size As Integer = Convert.ToInt32(cbMarkerSize.SelectedItem.Text)
		For Each series As Series In WebChartControl1.Series
			CType(series.View, PointSeriesView).PointMarkerOptions.Size = size
		Next series
	End Sub
	Private Sub PeformCreatePointsAction()
		InitSeries()
	End Sub
	Private Sub PerformShowLabelsAction()
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
		Next series
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "LabelAngle" Then
			PerformLabelAngleAction()
		End If
		If e.Parameter = "LabelPosition" Then
			PerformLabelPositionAction()
		ElseIf e.Parameter = "MarkerKind" Then
			PerformMarkerKindAction()
		ElseIf e.Parameter = "MarkerSize" Then
			PerformMarkerSizeAction()
		ElseIf e.Parameter = "CreatePoints" Then
			PeformCreatePointsAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		End If
	End Sub
End Class
