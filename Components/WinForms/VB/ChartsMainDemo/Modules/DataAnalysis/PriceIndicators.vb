Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class PriceIndicatorsDemo
		Inherits ChartDemoBase2D
		#Region "PriceIndicatorItem class"
		Private Class PriceIndicatorItem
			Private ReadOnly indicator_Renamed As Indicator

			Public ReadOnly Property Indicator() As Indicator
				Get
					Return indicator_Renamed
				End Get
			End Property

			Public Sub New(ByVal indicator As Indicator)
				Me.indicator_Renamed = indicator
			End Sub
			Public Overrides Function ToString() As String
				Return indicator_Renamed.Name
			End Function
		End Class
		#End Region

		Private ReadOnly Property SelectedIndicator() As Indicator
			Get
				Dim priceIndicatorItem As PriceIndicatorItem = TryCast(cbePriceIndicator.SelectedItem, PriceIndicatorItem)
				If priceIndicatorItem IsNot Nothing Then
					Return priceIndicatorItem.Indicator
				End If
				Return Nothing
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property
		Public Overrides ReadOnly Property AnimateChartControlOnDemoAppear() As Boolean
			Get
				Return False
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			InitializePriceIndicators()
			UpdateControls()
		End Sub

		Private Sub InitializePriceIndicators()
			Dim view = CType(chart.Series(0).View, FinancialSeriesViewBase)
			For Each indicator As Indicator In view.Indicators
				Dim indicatorItem As New PriceIndicatorItem(indicator)
				cbePriceIndicator.Properties.Items.Add(indicatorItem)
			Next indicator
			cbePriceIndicator.SelectedIndex = 0
		End Sub
		Private Sub cbePriceIndicator_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbePriceIndicator.SelectedIndexChanged
			UpdateControls()
		End Sub
		Private Sub speThickness_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles speThickness.EditValueChanged
			If SelectedIndicator IsNot Nothing Then
				SelectedIndicator.LineStyle.Thickness = Convert.ToInt32(speThickness.EditValue)
			End If
		End Sub
		Private Sub clreColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles clreColor.EditValueChanged
			If SelectedIndicator IsNot Nothing Then
				SelectedIndicator.Color = CType(clreColor.EditValue, Color)
			End If
		End Sub
		Private Sub cbDashStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDashStyle.SelectedIndexChanged
			If SelectedIndicator IsNot Nothing Then
				SelectedIndicator.LineStyle.DashStyle = CType(cbDashStyle.SelectedIndex + 1, DashStyle)
			End If
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ChartControl.Series(0).DataSource = MarketPrices.GetAppleStockPrices()
		End Sub
		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			For Each item As PriceIndicatorItem In cbePriceIndicator.Properties.Items
				item.Indicator.Visible = cbePriceIndicator.SelectedItem Is item
			Next item
			If SelectedIndicator IsNot Nothing Then
				speThickness.EditValue = SelectedIndicator.LineStyle.Thickness
				clreColor.EditValue = SelectedIndicator.Color
				cbDashStyle.SelectedIndex = CInt(Fix(SelectedIndicator.LineStyle.DashStyle)) - 1
			End If
		End Sub
	End Class
End Namespace
