Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.AdvancedViews
	Partial Public Class StockDemo
		Inherits FinancialSeriesViewDemoBase
		#Region "inner classes"
		Public Class StockTypeItem
			Private stockType_Renamed As StockType
			Public ReadOnly Property StockType() As StockType
				Get
					Return Me.stockType_Renamed
				End Get
			End Property

			Public Sub New(ByVal stockType As StockType)
				Me.stockType_Renamed = stockType
			End Sub
			Public Overrides Function ToString() As String
				Return Me.stockType_Renamed.ToString()
			End Function
		End Class
		#End Region

		Private chart As DevExpress.XtraCharts.ChartControl
		Private WithEvents comboBoxEditStockType As DevExpress.XtraEditors.ComboBoxEdit

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Me.seriesSelected = Me.chart.Series(0)
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries
			Dim items() As StockTypeItem = { New StockTypeItem(StockType.Both), New StockTypeItem(StockType.Close), New StockTypeItem(StockType.Open) }
			Me.comboBoxEditStockType.Properties.Items.AddRange(items)
			Me.comboBoxEditStockType.SelectedIndex = 0
		End Sub
		Private Sub comboBoxEditStockType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditStockType.SelectedIndexChanged
			If Me.seriesSelected Is Nothing Then
				Return
			End If
			Dim view As StockSeriesView = TryCast(seriesSelected.View, StockSeriesView)
			If view IsNot Nothing Then
				view.ShowOpenClose = (CType(Me.comboBoxEditStockType.SelectedItem, StockTypeItem)).StockType
			End If
		End Sub
	End Class
End Namespace

