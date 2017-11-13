Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class PriceIndicators
	Inherits ChartBasePage
	Private ReadOnly Property SeriesView() As StockSeriesView
		Get
			Return (CType(WebChartControl1.Series(0).View, StockSeriesView))
		End Get
	End Property
	Private ReadOnly Property PriceIndicator() As Indicator
		Get
			Return SeriesView.Indicators(0)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ComboBoxHelper.PrepareRegressionLineColorComboBox(cbColor)
			ComboBoxHelper.PrepareDashStyleCombobox(cbDashStyle, PriceIndicator.LineStyle.DashStyle)
			spnThickness.Value = PriceIndicator.LineStyle.Thickness
		End If
	End Sub
	Private Sub PerformColorAction()
		PriceIndicator.Color = ComboBoxHelper.GetSelectedRegressionLineColor(cbColor)
	End Sub
	Private Sub PerformDashStyleAction()
		PriceIndicator.LineStyle.DashStyle = CType(ComboBoxHelper.GetSelectedItem(cbDashStyle, GetType(DashStyle)), DashStyle)
	End Sub
	Private Sub PerformThicknessAction()
		PriceIndicator.LineStyle.Thickness = Convert.ToInt32(spnThickness.Value)
	End Sub
	Private Sub PeformUpdateIndicatorAction()
		Dim oldIndicator As Indicator = PriceIndicator
		SeriesView.Indicators.Clear()
		Dim indicator As Indicator = Nothing
		If cmbPriceIndicator.SelectedIndex = 0 Then
			indicator = New MedianPrice("Median Price")
		ElseIf cmbPriceIndicator.SelectedIndex = 1 Then
			indicator = New TypicalPrice("Typical Price")
		Else
			indicator = New WeightedClose("Weighted Close")
		End If
		indicator.Assign(oldIndicator)
		SeriesView.Indicators.Add(indicator)
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "Color" Then
			PerformColorAction()
		ElseIf e.Parameter = "DashStyle" Then
			PerformDashStyleAction()
		ElseIf e.Parameter = "Thickness" Then
			PerformThicknessAction()
		ElseIf e.Parameter = "Indicator" Then
			PeformUpdateIndicatorAction()
		End If
	End Sub
	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl1
	End Function
End Class
