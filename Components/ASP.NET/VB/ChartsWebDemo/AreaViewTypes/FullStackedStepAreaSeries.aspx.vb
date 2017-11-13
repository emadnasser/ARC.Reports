Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class FullStackedStepAreaSeries
	Inherits ChartBasePage
	Private Sub PerformInvertedAction()
		For Each series As Series In WebChartControl1.Series
			Dim view = CType(series.View, FullStackedStepAreaSeriesView)
			view.InvertedStep = cbInverted.Checked
		Next series
	End Sub
	Private Sub PerformShowLabelsAction()
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
			WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
		Next series
	End Sub
	Private Sub PerformValueAsPercentAction()
		Dim labeltextPattern As String = If(cbValueAsPercent.Checked, "{VP:P0}", "{V:F1}")
		For Each series As Series In WebChartControl1.Series
			series.Label.TextPattern = labeltextPattern
		Next series
	End Sub

	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		Select Case e.Parameter
			Case "Inverted"
				PerformInvertedAction()
			Case "ShowLabels"
				PerformShowLabelsAction()
			Case "ValueAsPercent"
				PerformValueAsPercentAction()
		End Select
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim series As Series = WebChartControl1.Series(0)
			cbShowLabels.Checked = series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			If series IsNot Nothing AndAlso series.Label IsNot Nothing AndAlso (Not String.IsNullOrEmpty(series.Label.TextPattern)) Then
				cbValueAsPercent.Checked = series.Label.TextPattern.Contains("VP")
			End If
			PerformValueAsPercentAction()
		End If
		cbValueAsPercent.ClientEnabled = cbShowLabels.Checked
	End Sub
End Class
