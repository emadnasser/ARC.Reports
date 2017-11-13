Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class StackedStepAreaSeries
	Inherits ChartBasePage
	Private Sub PerformInvertedAction()
		For Each series As Series In WebChartControl1.Series
			Dim view = CType(series.View, StackedStepAreaSeriesView)
			view.InvertedStep = cbInverted.Checked
		Next series
	End Sub
	Private Sub PerformShowLabelsAction()
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
			WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
		Next series
	End Sub

	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		Select Case e.Parameter
			Case "Inverted"
				PerformInvertedAction()
			Case "ShowLabels"
				PerformShowLabelsAction()
		End Select
	End Sub
End Class
