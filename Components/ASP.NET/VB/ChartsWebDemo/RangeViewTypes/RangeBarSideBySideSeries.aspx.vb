Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class RangeBarSideBySideSeries
	Inherits ChartBasePage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = WebChartControl1.Series(0).LabelsVisibility = DefaultBoolean.True
		End If
		WebChartControl1.Series(0).DataSource = SourceOfEnergy.GetEuropeBrentPrices()
		WebChartControl1.Series(1).DataSource = SourceOfEnergy.GetOkWtiPrices()
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		Next series
		WebChartControl1.ToolTipEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
End Class