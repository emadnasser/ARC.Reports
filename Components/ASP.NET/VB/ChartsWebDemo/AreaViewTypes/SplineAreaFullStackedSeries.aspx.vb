Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts

Partial Public Class SplineAreaFullStackedSeries
	Inherits ChartBasePage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim series As SeriesBase = WebChartControl1.SeriesTemplate
			cbShowLabels.Checked = series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			If series IsNot Nothing AndAlso series.Label IsNot Nothing AndAlso (Not String.IsNullOrEmpty(series.Label.TextPattern)) Then
				cbValueAsPercent.Checked = series.Label.TextPattern.Contains("VP")
			End If
		End If
		cbValueAsPercent.ClientEnabled = cbShowLabels.Checked
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		Dim labeltextPattern As String = If(cbValueAsPercent.Checked, "{VP:P0}", "${V}M")
		WebChartControl1.SeriesTemplate.Label.TextPattern = labeltextPattern
		WebChartControl1.SeriesTemplate.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
End Class
