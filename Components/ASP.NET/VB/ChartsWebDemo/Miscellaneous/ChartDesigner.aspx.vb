Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.IO
Imports System.Web.SessionState
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class ChartDesigner
	Inherits ChartBasePage

	Private Shared Sub SaveChartToSession(ByVal chart As WebChartControl, ByVal session As HttpSessionState)
		session("ChartLayout") = chart.SaveToXml()
		session("ChartWidth") = chart.Width
		session("ChartHeight") = chart.Height
	End Sub

	Private Sub CreateChart()
		Dim areaSeries As New Series("Area", ViewType.Bar)
		FillAreaSeries(areaSeries)
		Dim populationSeries As New Series("Population", ViewType.Bar)
		FillPopulationSeries(populationSeries)
		chart.Series.Add(areaSeries)
		chart.Series.Add(populationSeries)
		Dim diagram = (CType(chart.Diagram, XYDiagram))
		Dim secondaryYAxis As New SecondaryAxisY("Population Axis")
		secondaryYAxis.Title.Text = "Population estimates"
		secondaryYAxis.Title.Visibility = DefaultBoolean.True
		secondaryYAxis.Label.TextPattern = "{V:0,,}M"
		diagram.SecondaryAxesY.Add(secondaryYAxis)
		CType(populationSeries.View, BarSeriesView).AxisY = secondaryYAxis
		diagram.AxisY.Title.Text = "Area, km²"
		diagram.AxisY.Title.Visibility = DefaultBoolean.True
		diagram.AxisY.Label.TextPattern = "{V:0,,}M"
		Dim title = New ChartTitle() With {.Text = "Largest Countries <br> by Area and Population"}
		chart.Titles.Add(title)
		chart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center
		chart.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside
		chart.Legend.Direction = LegendDirection.LeftToRight
		chart.Legend.Border.Visibility = DefaultBoolean.False
	End Sub
	Private Sub FillAreaSeries(ByVal series As Series)
		series.Points.Add(New SeriesPoint("Russia", 17098242))
		series.Points.Add(New SeriesPoint("Canada", 9984670))
		series.Points.Add(New SeriesPoint("USA", 9519431))
		series.Points.Add(New SeriesPoint("China", 9596960))
		series.Points.Add(New SeriesPoint("Brazil", 8514877))
		series.Points.Add(New SeriesPoint("Australia", 7692024))
		series.Points.Add(New SeriesPoint("India", 3287263))
		series.Points.Add(New SeriesPoint("Argentina", 2766890))
		series.Points.Add(New SeriesPoint("Kazakhstan", 2724902))
		series.Points.Add(New SeriesPoint("Algeria", 2381740))
	End Sub
	Private Sub FillPopulationSeries(ByVal series As Series)
		series.Points.Add(New SeriesPoint("Russia", 146267288))
		series.Points.Add(New SeriesPoint("Canada", 35675834))
		series.Points.Add(New SeriesPoint("USA", 321348000))
		series.Points.Add(New SeriesPoint("China", 1366499000))
		series.Points.Add(New SeriesPoint("Brazil", 201009622))
		series.Points.Add(New SeriesPoint("Australia", 23130931))
		series.Points.Add(New SeriesPoint("India", 1220800359))
		series.Points.Add(New SeriesPoint("Argentina", 42610981))
		series.Points.Add(New SeriesPoint("Kazakhstan", 17439271))
		series.Points.Add(New SeriesPoint("Algeria", 38087812))
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			If Session("ChartLayout") Is Nothing Then
				CreateChart()
			Else
				Dim xmlLayout = CStr(Session("ChartLayout"))
				chart.LoadFromXml(xmlLayout)
			End If
		End If
	End Sub
	Protected Sub ShowDesignerButton_Click(ByVal sender As Object, ByVal e As EventArgs)
		SaveChartToSession(chart, Session)
		Response.Redirect("~/ChartDesignerPage.aspx")
	End Sub

	Public Overrides Function FindWebChartControl() As WebChartControl
		Return chart
	End Function
End Class
