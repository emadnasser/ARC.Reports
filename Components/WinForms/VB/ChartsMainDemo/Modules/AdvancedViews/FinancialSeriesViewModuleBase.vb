Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.AdvancedViews
	Partial Public Class FinancialSeriesViewDemoBase
		Inherits ChartDemoBase2D
		#Region "Nested clas: StockLevelItem"
		Public Class StockLevelItem
			Private level_Renamed As StockLevel

			Public ReadOnly Property Level() As StockLevel
				Get
					Return Me.level_Renamed
				End Get
			End Property

			Public Sub New(ByVal level As StockLevel)
				Me.level_Renamed = level
			End Sub
			Public Overrides Function ToString() As String
				Return Me.level_Renamed.ToString()
			End Function
		End Class
		#End Region

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxEditLabelLevel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditLabelLevel.SelectedIndexChanged
			If seriesSelected Is Nothing Then
				Return
			End If
			Select Case (CType(comboBoxEditLabelLevel.SelectedItem, StockLevelItem)).Level
				Case StockLevel.Low
					seriesSelected.Label.TextPattern = "{LV:G4}"
				Case StockLevel.High
					seriesSelected.Label.TextPattern = "{HV:G4}"
				Case StockLevel.Open
					seriesSelected.Label.TextPattern = "{OV:G4}"
				Case StockLevel.Close
					seriesSelected.Label.TextPattern = "{CV:G4}"
				Case Else
					seriesSelected.Label.TextPattern = "{CV:G4}"
			End Select
		End Sub
		Private Sub comboBoxEditReductionLevel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditReductionLevel.SelectedIndexChanged
			If seriesSelected Is Nothing Then
				Return
			End If
			Dim view As FinancialSeriesViewBase = TryCast(seriesSelected.View, FinancialSeriesViewBase)
			If view IsNot Nothing Then
				view.ReductionOptions.Level = (CType(comboBoxEditReductionLevel.SelectedItem, StockLevelItem)).Level
			End If
		End Sub
		Private Sub checkEditWorkdaysOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditWorkdaysOnly.CheckedChanged
			Dim diagram As IXYDiagram2D = TryCast(ChartControl.Diagram, IXYDiagram2D)
			If diagram IsNot Nothing Then
				diagram.AxisX.DateTimeScaleOptions.WorkdaysOnly = checkEditWorkdaysOnly.Checked
			End If
		End Sub
		Private Sub LoadSeriesData()
			If seriesSelected Is Nothing Then
				Return
			End If
			seriesSelected.ValueDataMembers.AddRange("Low", "High", "Open", "Close")
			seriesSelected.ArgumentDataMember = "Date"
			seriesSelected.DataSource = MarketPrices.GetGoogleStockPrices()
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = False
			Dim items() As StockLevelItem = { New StockLevelItem(StockLevel.Low), New StockLevelItem(StockLevel.High), New StockLevelItem(StockLevel.Open), New StockLevelItem(StockLevel.Close) }
			comboBoxEditLabelLevel.Properties.Items.AddRange(items)
			comboBoxEditLabelLevel.SelectedIndex = 3
			comboBoxEditReductionLevel.Properties.Items.AddRange(items)
			comboBoxEditReductionLevel.SelectedIndex = 3
			LoadSeriesData()
		End Sub
		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			comboBoxEditLabelLevel.Enabled = ShowLabels
			labelLabelLevel.Enabled = ShowLabels
			Dim diagram As IXYDiagram2D = TryCast(ChartControl.Diagram, IXYDiagram2D)
			If diagram Is Nothing Then
				checkEditWorkdaysOnly.Enabled = False
			Else
				checkEditWorkdaysOnly.Enabled = True
				checkEditWorkdaysOnly.Checked = diagram.AxisX.DateTimeScaleOptions.WorkdaysOnly
			End If
		End Sub
	End Class
End Namespace
