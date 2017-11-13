Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class GanttSideBySideSeries
	Inherits ChartBasePage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = WebChartControl1.Series(0).LabelsVisibility = DefaultBoolean.True
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		Next series
	End Sub
	Private Sub PerformCustomCallback(ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "Palette" OrElse e.Parameter = "Appearance" Then
			Return
		End If
		Dim parameters() As String = e.Parameter.Split(";"c)
		Dim seriesName As String = parameters(0)
		Dim argument As String = parameters(1)
		Dim valueIndex As Integer = Convert.ToInt32(parameters(2))
		Dim [date] As DateTime = Convert.ToDateTime(parameters(3), CultureInfo.InvariantCulture)
		Dim series As Series = WebChartControl1.GetSeriesByName(seriesName)
		If series Is Nothing Then
			Return
		End If
		Dim i As Integer = 0
		Do While i < series.Points.Count
			Dim point As SeriesPoint = series.Points(i)
			If point.Argument = argument Then
				Dim values() As DateTime = CType(point.DateTimeValues.Clone(), DateTime())
				values(valueIndex) = [date]
				Dim modifiedPoint As New SeriesPoint(point.Argument, values)
				series.Points.RemoveAt(i)
				series.Points.Insert(i, modifiedPoint)
				Return
			End If
			i += 1
		Loop
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		Else
			PerformCustomCallback(e)
		End If
	End Sub
End Class
