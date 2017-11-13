Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class BarStackedSideBySideSeries
	Inherits ChartBasePage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			checkBoxShowLabel.Checked = WebChartControl1.SeriesTemplate.LabelsVisibility = DefaultBoolean.True
			rbSex.Checked = True
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		WebChartControl1.SeriesTemplate.LabelsVisibility = If(checkBoxShowLabel.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(checkBoxShowLabel.Checked, DefaultBoolean.False, DefaultBoolean.True)
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
