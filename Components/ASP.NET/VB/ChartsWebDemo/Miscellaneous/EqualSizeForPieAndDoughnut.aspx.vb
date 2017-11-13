Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Web
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class PointSeries
	Inherits ChartBasePage

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbMinAllowedSize.Items.Add(New ListEditItem("0%", 0))
			cbMinAllowedSize.Items.Add(New ListEditItem("10%", 10))
			cbMinAllowedSize.Items.Add(New ListEditItem("20%", 20))
			cbMinAllowedSize.Items.Add(New ListEditItem("30%", 30))
			cbMinAllowedSize.Items.Add(New ListEditItem("40%", 40))
			cbMinAllowedSize.Items.Add(New ListEditItem("50%", 50))
			cbMinAllowedSize.Items.Add(New ListEditItem("60%", 60))
			cbMinAllowedSize.Items.Add(New ListEditItem("70%", 70))
			cbMinAllowedSize.Items.Add(New ListEditItem("80%", 80))
			cbMinAllowedSize.Items.Add(New ListEditItem("90%", 90))
			cbMinAllowedSize.Items.Add(New ListEditItem("100%", 100))
			cbMinAllowedSize.SelectedIndex = 0
			cbView.Items.Add("Pie")
			cbView.Items.Add("Doughnut")
			cbView.SelectedIndex = 0
		End If
	End Sub
	Private Sub PerformSetEqualPieSizeAction()
		CType(WebChartControl1.Diagram, SimpleDiagram).EqualPieSize = chbEqualSize.Checked
	End Sub
	Private Sub PerformSetMinAllowedSizePercentageAction()
		CType(WebChartControl1.Series("Condiments").View, PieSeriesView).MinAllowedSizePercentage = Integer.Parse(CStr(cbMinAllowedSize.SelectedItem.Value))
	End Sub
	Private Sub PerformChangeViewAction()
		If CStr(cbView.SelectedItem.Text) = "Pie" Then
			For Each series As Series In WebChartControl1.Series
				series.ChangeView(ViewType.Pie)
			Next series
		Else
			For Each series As Series In WebChartControl1.Series
				series.ChangeView(ViewType.Doughnut)
			Next series
		End If
	End Sub
	Private Sub PerformRestoreDefaultLayoutAction()
		PerformChangeViewAction()
		PerformSetEqualPieSizeAction()
		PerformSetMinAllowedSizePercentageAction()
	End Sub

	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "EqualSize" Then
			PerformSetEqualPieSizeAction()
		ElseIf e.Parameter = "MinAllowedSize" Then
			PerformSetMinAllowedSizePercentageAction()
		ElseIf e.Parameter = "View" Then
			PerformChangeViewAction()
		ElseIf e.Parameter = "Reset" Then
			PerformRestoreDefaultLayoutAction()
		End If
	End Sub

End Class
