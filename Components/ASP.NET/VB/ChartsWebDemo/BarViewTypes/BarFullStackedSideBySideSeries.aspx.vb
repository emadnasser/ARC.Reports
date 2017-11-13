Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class BarFullStackedSideBySideSeries
	Inherits ChartBasePage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim series As SeriesBase = WebChartControl1.SeriesTemplate
			If series IsNot Nothing AndAlso series.Label IsNot Nothing AndAlso (Not String.IsNullOrEmpty(series.Label.TextPattern)) Then
				cbValueAsPercent.Checked = series.Label.TextPattern.Contains("VP")
			End If
			cbShowLabels.Checked = series.LabelsVisibility = DefaultBoolean.True
			rbSex.Checked = True
		End If
		cbValueAsPercent.ClientEnabled = cbShowLabels.Checked
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		Dim labeltextPattern As String = If(cbValueAsPercent.Checked, "{VP:P0}", "{V:0,,.00}")
		WebChartControl1.SeriesTemplate.Label.TextPattern = labeltextPattern
		WebChartControl1.SeriesTemplate.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Protected Sub WebChartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
		For Each series As Series In WebChartControl1.Series
			Dim view As ISupportStackedGroup = TryCast(series.View, ISupportStackedGroup)
			Dim genderAge As GenderAgeInfo = CType(series.Tag, GenderAgeInfo)
			If view IsNot Nothing Then
				view.StackedGroup = If(rbSex.Checked, genderAge.Gender, genderAge.Age)
			End If
		Next series
	End Sub
End Class
