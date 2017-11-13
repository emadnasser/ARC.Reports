Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Drawing
Imports System.Globalization

Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class OscillatorsDemo
		Inherits ChartDemoBase2D
		#Region "OscillatorItem class"
		Private Class OscillatorItem
			Private ReadOnly oscillator_Renamed As SeparatePaneIndicator

			Public ReadOnly Property Oscillator() As SeparatePaneIndicator
				Get
					Return oscillator_Renamed
				End Get
			End Property

			Public Sub New(ByVal oscillator As SeparatePaneIndicator)
				Me.oscillator_Renamed = oscillator
			End Sub
			Public Overrides Function ToString() As String
				Return oscillator_Renamed.Name
			End Function
		End Class
		#End Region

		Private ReadOnly Property Diagram() As XYDiagram
			Get
				Return CType(chart.Diagram, XYDiagram)
			End Get
		End Property
		Private ReadOnly Property SelectedOscillator() As OscillatorItem
			Get
				Return CType(cbeOscillator.SelectedItem, OscillatorItem)
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
			Try
				chart.DataSource = CsvReader.ReadFinancialData("AUDUSDDaily.csv")
			Catch e As Exception
				XtraMessageBox.Show(LookAndFeel.ActiveLookAndFeel, e.Message, "Data Loading Error")
			End Try
			Diagram.AxisX.WholeRange.SetMinMaxValues(New DateTime(2015, 1, 2), New DateTime(2015, 06, 30))
			Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day
			Diagram.AxisX.WholeRange.SideMarginsValue = 0.7
			Diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Week
			Diagram.AxisX.DateTimeScaleOptions.GridOffset = CalculateOffsetToMonday()
			Diagram.AxisX.Interlaced = False
			InitializeOscillators()
		End Sub

		Private Function CalculateOffsetToMonday() As Double
			Dim currentDayOfWeekIndex = CInt(Fix(CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek))
			Return (CInt(Fix(DayOfWeek.Monday))) - currentDayOfWeekIndex
		End Function
		Private Sub InitializeOscillators()
			AddOscillator(New AverageTrueRange("(ATR) Average True Range"))
			AddOscillator(New CommodityChannelIndex("(CCI) Commodity Channel Index"))
			AddOscillator(New DetrendedPriceOscillator("(DPO) Detrended Price Oscillator"))
			Dim macd As New MovingAverageConvergenceDivergence("(MACD) Moving Average Convergence/Divergence") With {.SignalLineColor = Color.LightGray}
			macd.SignalLineStyle.Thickness = 2
			AddOscillator(macd)
			AddOscillator(New RateOfChange("(RoC) Rate of Change"))
			AddOscillator(New RelativeStrengthIndex("(RSI) Relative Strength Index"))
			AddOscillator(New ChaikinsVolatility("(CHV) Chaikins Volatility"))
			AddOscillator(New TripleExponentialMovingAverageTrix("(TRIX) Triple Exponential Moving Average"))
			AddOscillator(New WilliamsR("(%R) Williams %R"))
			cbeOscillator.SelectedIndex = 0
		End Sub
		Private Sub AddOscillator(ByVal oscillator As SeparatePaneIndicator)
			Dim view As StockSeriesView = CType(chart.Series(0).View, StockSeriesView)
			Dim diagram As XYDiagram = CType(chart.Diagram, XYDiagram)
			view.Indicators.Add(oscillator)
			oscillator.AxisY = diagram.SecondaryAxesY(0)
			oscillator.Pane = diagram.Panes(0)
			oscillator.Visible = False
			oscillator.LineStyle.Thickness = 2
			oscillator.ShowInLegend = True
			Dim item As New OscillatorItem(oscillator)
			cbeOscillator.Properties.Items.Add(item)
		End Sub
		Private Sub cbeOscillator_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeOscillator.SelectedIndexChanged
			UpdateControls()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			For Each item As OscillatorItem In cbeOscillator.Properties.Items
				If item Is SelectedOscillator Then
					item.Oscillator.Visible = True
					If chart.AnnotationRepository.Count > 0 Then
						Dim indicatorAnnotation As TextAnnotation = TryCast(chart.AnnotationRepository(0), TextAnnotation)
						If indicatorAnnotation IsNot Nothing Then
							indicatorAnnotation.Text = item.Oscillator.Name
						End If
					End If
				Else
					item.Oscillator.Visible = False
				End If
			Next item
		End Sub
	End Class
End Namespace
