Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts

Partial Public Class Trendlines
	Inherits ChartBasePage
	Private ReadOnly Property View() As XYDiagramSeriesViewBase
		Get
			Return CType(WebChartControl1.Series(0).View, XYDiagramSeriesViewBase)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			FillDefaultTrendlines()
		End If
	End Sub
	Private Sub FillDefaultTrendlines()
		Dim trendline1 As New TrendLine("Trendline 2")
		trendline1.Point1.Argument = New DateTime(2016, 4, 15)
		trendline1.Point1.ValueLevel = ValueLevel.High
		trendline1.Point2.Argument = New DateTime(2016, 6, 12)
		trendline1.Point2.ValueLevel = ValueLevel.High
		trendline1.ExtrapolateToInfinity = False
		View.Indicators.Add(trendline1)

		Dim trendline2 As New TrendLine("Trendline 1")
		trendline2.Point1.Argument = New DateTime(2016, 6, 23)
		trendline2.Point1.ValueLevel = ValueLevel.High
		trendline2.Point2.Argument = New DateTime(2016, 10, 11)
		trendline2.Point2.ValueLevel = ValueLevel.High
		View.Indicators.Add(trendline2)

		Dim trendline3 As New TrendLine("Trendline 3")
		trendline3.Point1.Argument = New DateTime(2016, 3, 20)
		trendline3.Point1.ValueLevel = ValueLevel.Low
		trendline3.Point2.Argument = New DateTime(2016, 5, 13)
		trendline3.Point2.ValueLevel = ValueLevel.Low
		trendline3.ExtrapolateToInfinity = False
		View.Indicators.Add(trendline3)

		Dim trendline4 As New TrendLine("Trendline 4")
		trendline4.Point1.Argument = New DateTime(2016, 6, 27)
		trendline4.Point1.ValueLevel = ValueLevel.Low
		trendline4.Point2.Argument = New DateTime(2016, 10, 31)
		trendline4.Point2.ValueLevel = ValueLevel.Low
		View.Indicators.Add(trendline4)
	End Sub
End Class
