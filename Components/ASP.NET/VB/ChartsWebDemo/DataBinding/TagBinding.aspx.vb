Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class TagBinding
	Inherits ChartBasePage
	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = Series.LabelsVisibility = DefaultBoolean.True
		End If
	End Sub
	Protected Sub WebChartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
		e.LegendText = CStr((CType(e.SeriesPoint.Tag, DataRowView))("OfficialName"))
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		Series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
End Class
