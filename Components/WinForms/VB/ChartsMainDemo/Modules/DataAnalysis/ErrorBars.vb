Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Namespace DevExpress.XtraCharts.Demos.DataAnalysis

	Partial Public Class ErrorBarsDemo
		Inherits ChartDemoBase
		Private ReadOnly indicatorColor As Color = Color.Black
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chartControl_Renamed
			End Get
		End Property
		Public Overrides ReadOnly Property AnimateChartControlOnDemoAppear() As Boolean
			Get
				Return False
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			FillDataSet()
			ChartControl.RefreshData()
			cbeSeriesView.SelectedIndex = 0
			cbeErrorBarsKind.SelectedIndex = 0
			cbeEndStyle.SelectedIndex = 0
			cbeDirection.SelectedIndex = 0
		End Sub

		Private Sub FillDataSet()
			Dim table = dataSet.Tables(0)
			table.Rows.Add("A", 20, 5, 8)
			table.Rows.Add("B", 50, 3, 5)
			table.Rows.Add("C", 40, 20, 10)
			table.Rows.Add("D", 22, 15, 5)
			table.Rows.Add("E", 30, 5, 8)
			table.Rows.Add("F", 45, 5, 4)
			table.Rows.Add("G", 35, 5, 3)
			table.Rows.Add("H", 28, 4, 2)
			table.Rows.Add("I", 46, 6, 4)
			table.Rows.Add("J", 27, 8, 20)
			table.Rows.Add("K", 20, 5, 8)
			table.Rows.Add("L", 50, 3, 5)
			table.Rows.Add("M", 40, 20, 10)
			table.Rows.Add("N", 22, 15, 5)
			table.Rows.Add("O", 30, 5, 8)
			table.Rows.Add("P", 45, 5, 2)
			table.Rows.Add("Q", 35, 5, 5)
			table.Rows.Add("R", 28, 4, 4)
			table.Rows.Add("S", 46, 6, 5)
			table.Rows.Add("T", 27, 8, 8)
		End Sub
		Private Sub cbeSeriesView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeSeriesView.SelectedIndexChanged
			Dim selectedViewString As String = CStr(cbeSeriesView.SelectedItem)
			Select Case selectedViewString
				Case ""
					Return
				Case "Bar"
					ChartControl.Series(0).ChangeView(ViewType.Bar)
				Case "Point"
					ChartControl.Series(0).ChangeView(ViewType.Point)
				Case Else
					Throw New Exception(String.Format("The {0} series view is unknown.", selectedViewString))
			End Select
		End Sub
		Private Sub cbeErrorBarsKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeErrorBarsKind.SelectedIndexChanged
			Dim selectedErrorBarKind As String = CStr(cbeErrorBarsKind.SelectedItem)
			Dim view As XYDiagram2DSeriesViewBase = CType(ChartControl.Series(0).View, XYDiagram2DSeriesViewBase)
			view.Indicators.Clear()
			Select Case selectedErrorBarKind
				Case ""
					Return
				Case "Fixed Values"
					view.Indicators.Add(New FixedValueErrorBars() With {.NegativeError = 1, .PositiveError = 3, .Color = Me.indicatorColor})
				Case "Percentage"
					view.Indicators.Add(New PercentageErrorBars() With {.Percent = 10, .Color = Me.indicatorColor})
				Case "Standard Deviation(s)"
					view.Indicators.Add(New StandardDeviationErrorBars() With {.Multiplier = 1, .Color = Me.indicatorColor})
				Case "Standard Error"
					view.Indicators.Add(New StandardErrorBars() With {.Color = Me.indicatorColor})
				Case "Data Source"
					view.Indicators.Add(New DataSourceBasedErrorBars() With {.NegativeErrorDataMember = "Table1.NegativeError", .PositiveErrorDataMember = "Table1.PositiveError", .Color = Me.indicatorColor})
					ChartControl.RefreshData()
				Case Else
					Throw New Exception(String.Format("The {0} error bar kind is unknown.", selectedErrorBarKind))
			End Select
			SetDirection()
			SetEndStyle()
		End Sub
		Private Sub cbeEndStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeEndStyle.SelectedIndexChanged
			SetEndStyle()
		End Sub
		Private Sub cbeDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeDirection.SelectedIndexChanged
			SetDirection()
		End Sub
		Private Sub SetDirection()
			Dim selectedDirection As String = CStr(cbeDirection.SelectedItem)
			Dim view As XYDiagram2DSeriesViewBase = CType(ChartControl.Series(0).View, XYDiagram2DSeriesViewBase)
			Dim indicator As ErrorBars = CType(view.Indicators(0), ErrorBars)
			Select Case selectedDirection
				Case ""
					Return
				Case "Both"
					indicator.Direction = ErrorBarDirection.Both
				Case "Minus"
					indicator.Direction = ErrorBarDirection.Minus
				Case "Plus"
					indicator.Direction = ErrorBarDirection.Plus
				Case Else
					Throw New Exception(String.Format("The {0} error bar direction is unknown.", selectedDirection))
			End Select
		End Sub
		Private Sub SetEndStyle()
			Dim selectedStyle As String = CStr(cbeEndStyle.SelectedItem)
			Dim view As XYDiagram2DSeriesViewBase = CType(ChartControl.Series(0).View, XYDiagram2DSeriesViewBase)
			Dim indicator As ErrorBars = CType(view.Indicators(0), ErrorBars)
			Select Case selectedStyle
				Case ""
					Return
				Case "Cap"
					indicator.EndStyle = ErrorBarEndStyle.Cap
				Case "No Cap"
					indicator.EndStyle = ErrorBarEndStyle.NoCap
				Case Else
					Throw New Exception(String.Format("The {0} error bar end style is unknown.", selectedStyle))
			End Select
		End Sub
	End Class

End Namespace
