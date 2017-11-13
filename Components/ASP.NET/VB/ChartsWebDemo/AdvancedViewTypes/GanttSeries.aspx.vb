Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class GanttSeries
	Inherits ChartBasePage
	Private Shared ReadOnly rightAxisLimit As DateTime = New System.DateTime(2006, 11, 13)

	Private ReadOnly Property PlannedSeries() As Series
		Get
			Return WebChartControl1.GetSeriesByName("Planned")
		End Get
	End Property
	Private ReadOnly Property CompletedSeries() As Series
		Get
			Return WebChartControl1.GetSeriesByName("Completed")
		End Get
	End Property
	Private ReadOnly Property ProgressLine() As ConstantLine
		Get
			Return (CType(WebChartControl1.Diagram, XYDiagram)).AxisY.ConstantLines(0)
		End Get
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "Palette" OrElse e.Parameter = "Appearance" Then
			Return
		End If
		Dim [date] As DateTime = Convert.ToDateTime(e.Parameter, CultureInfo.InvariantCulture)
		SetProgressState([date])
	End Sub
	Private Sub SetProgressState(ByVal dateTime As DateTime)
		If dateTime > rightAxisLimit Then
			dateTime = rightAxisLimit
		End If
		CompletedSeries.Points.BeginUpdate()
		CompletedSeries.Points.Clear()
		For Each point As SeriesPoint In PlannedSeries.Points
			Dim plannedStartDate As DateTime = point.DateTimeValues(0)
			If System.DateTime.Compare(plannedStartDate, dateTime) >= 0 Then
				Continue For
			End If
			Dim plannedFinishDate As DateTime = point.DateTimeValues(1)
			Dim completedFinishDate As DateTime
			If System.DateTime.Compare(dateTime, plannedFinishDate) > 0 Then
				completedFinishDate = plannedFinishDate
			Else
				completedFinishDate = dateTime
			End If
			CompletedSeries.Points.Add(New SeriesPoint(point.Argument, New DateTime() { plannedStartDate, completedFinishDate }))
		Next point
		CompletedSeries.Points.EndUpdate()
		ProgressLine.AxisValue = dateTime
	End Sub
End Class
