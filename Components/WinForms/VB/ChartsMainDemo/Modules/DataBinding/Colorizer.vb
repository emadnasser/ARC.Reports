Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataBinding
	Partial Public Class ColorizerDemo
		Inherits ChartDemoBase2D

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Dim series As Series = ChartControl.Series(0)
			Dim rangeColorizer As New RangeColorizer()
			rangeColorizer.RangeStops.AddRange(New Double() { 22, 30, 38, 46, 54, 64 })
			rangeColorizer.LegendItemPattern = "{V1} - {V2} HPI"
			rangeColorizer.PaletteName = "ColorizerPalette"
			series.Colorizer = rangeColorizer
			series.ArgumentScaleType = ScaleType.Qualitative
			series.ArgumentDataMember = "Country"
			series.ValueDataMembers.AddRange(New String() { "Product", "Population" })
			series.ColorDataMember = "HPI"
			series.ToolTipHintDataMember = "HPI"
			series.DataSource = HPI.GetData()
		End Sub
	End Class
End Namespace
