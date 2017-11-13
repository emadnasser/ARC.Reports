Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Web.UI.WebControls
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class NestedDoughnutSeries
	Inherits ChartBasePage
	Private ReadOnly Property SeriesTemplate() As SeriesBase
		Get
			Return WebChartControl1.SeriesTemplate
		End Get
	End Property
	Private ReadOnly Property SeriesTemplateView() As NestedDoughnutSeriesView
		Get
			Return (CType(SeriesTemplate.View, NestedDoughnutSeriesView))
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ComboBoxHelper.PrepareNestedDoughnutHolePercentComboBox(cbHoleRadius)
			ComboBoxHelper.PrepareInnerIndentComboBox(cbInnerIndent)
			ComboBoxHelper.PrepareNestedDoughnutSeriesArgumentComboBox(cbSeriesArgument)
		End If
	End Sub
	Private Sub PerformSeriesArgumentAction()
		Dim showAgeSeriesArgument As Boolean = cbSeriesArgument.SelectedIndex = 1
		WebChartControl1.SeriesDataMember = If(showAgeSeriesArgument, "CountryGenderKey", "CountryAgeKey")
		Dim argumentDataMember As String = If(showAgeSeriesArgument, "Age", "Gender")
		WebChartControl1.Titles(0).Text = "Population: " & argumentDataMember & " Structure"
		SeriesTemplate.ToolTipHintDataMember = If(showAgeSeriesArgument, "Gender", "Age")
		SeriesTemplate.ArgumentDataMember = argumentDataMember
	End Sub
	Private Sub PerformHoleRadiusAction()
		SeriesTemplateView.HoleRadiusPercent = ComboBoxHelper.GetSelectedNestedDoughnutHolePercent(cbHoleRadius)
	End Sub
	Private Sub PerformInnerIndentAction()
		SeriesTemplateView.InnerIndent = ComboBoxHelper.GetSelectedInnerIndent(cbInnerIndent)
	End Sub
	Protected Sub WebChartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim chart As WebChartControl = CType(sender, WebChartControl)
		If chart.Series.Count > 0 Then
			chart.Series(0).ShowInLegend = True
			For Each series As Series In chart.Series
				Dim nestedView As NestedDoughnutSeriesView = TryCast(series.View, NestedDoughnutSeriesView)
				Dim population As AgePopulation = TryCast(series.Points(0).Tag, AgePopulation)
				If population IsNot Nothing AndAlso nestedView IsNot Nothing Then
					Dim name As String = population.Name
					nestedView.Group = name
					nestedView.Titles.Clear()
					nestedView.Titles.Add(New SeriesTitle() With {.Text = name})
				End If
			Next series
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "SeriesArgument" Then
			PerformSeriesArgumentAction()
		ElseIf e.Parameter = "HoleRadius" Then
			PerformHoleRadiusAction()
		ElseIf e.Parameter = "InnerIndent" Then
			PerformInnerIndentAction()
		End If
	End Sub
End Class
