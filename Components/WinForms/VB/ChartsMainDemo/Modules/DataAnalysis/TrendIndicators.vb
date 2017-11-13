Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Globalization

Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class TrendIndicatorsDemo
		Inherits ChartDemoBase2D
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
				Me.chart.DataSource = CsvReader.ReadFinancialData("USDJPYDaily.csv")
			Catch e As Exception
				XtraMessageBox.Show(LookAndFeel.ActiveLookAndFeel, e.Message, "Data Loading Error")
			End Try
			Dim diagram = CType(Me.chart.Diagram, XYDiagram)
			Dim minValue = New DateTime(2014, 7, 1)
			Dim maxValue = New DateTime(2014, 12, 31)
			diagram.AxisX.WholeRange.SetMinMaxValues(minValue, maxValue)
			diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day
			diagram.AxisX.WholeRange.SideMarginsValue = 0.7
		End Sub

		Private Function CalculateOffsetToMonday() As Double
			Dim currentDayOfWeekIndex = CInt(Fix(CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek))
			Return (CInt(Fix(DayOfWeek.Monday))) - currentDayOfWeekIndex
		End Function
	End Class
End Namespace
