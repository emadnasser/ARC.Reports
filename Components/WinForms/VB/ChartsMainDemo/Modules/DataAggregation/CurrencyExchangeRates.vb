Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.IO
Imports System.Xml
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.DataAggregation
	Partial Public Class CurrencyExchangeRatesDemo
		Inherits ChartDemoBase
		Private ReadOnly Property Diagram() As XYDiagram
			Get
				Return TryCast(chart.Diagram, XYDiagram)
			End Get
		End Property
		Private ReadOnly Property AxisX() As AxisBase
			Get
				Return If(Diagram IsNot Nothing, Diagram.AxisX, Nothing)
			End Get
		End Property
		Private ReadOnly Property SeriesGBP() As Series
			Get
				Return chart.Series(0)
			End Get
		End Property
		Private ReadOnly Property SeriesEUR() As Series
			Get
				Return chart.Series(1)
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
		End Sub

		Private Sub LoadSeries(ByVal series As Series, ByVal xmlFile As String)
			LoadPoints(series, AssemblyHelper.GetEmbeddedResourceStream(GetType(CurrencyExchangeRatesDemo).Assembly, xmlFile, False))
		End Sub
		Private Sub LoadPoints(ByVal series As Series, ByVal xmlStream As Stream)
			If series IsNot Nothing AndAlso xmlStream IsNot Nothing Then
				Dim document As New XmlDocument()
				document.Load(xmlStream)
				series.Points.BeginUpdate()
				series.Points.Clear()
				If document IsNot Nothing Then
					Dim elements As XmlNodeList = document.DocumentElement.GetElementsByTagName("CurrencyRate")
					For Each element As XmlNode In elements
						Dim [date] As DateTime = DateTime.Parse(element.ChildNodes(0).InnerText, CultureInfo.InvariantCulture)
						Dim rate As Double = Double.Parse(element.ChildNodes(1).InnerText, CultureInfo.InvariantCulture)
						series.Points.Add(New SeriesPoint([date], rate))
					Next element
				End If
				series.Points.EndUpdate()
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			LoadSeries(SeriesGBP, "GbpUsdRate.xml")
			LoadSeries(SeriesEUR, "EurUsdRate.xml")
			Dim offset As New TimeSpan(366 * 2, 0, 0, 0)
			AxisX.VisualRange.SetMinMaxValues(CDate(AxisX.VisualRange.MaxValue) - offset, CDate(AxisX.VisualRange.MaxValue))
		End Sub

		Private Sub CustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs) Handles chart.CustomDrawCrosshair
			Dim elementIndex As Integer = 0
			For Each crosshairGroup As CrosshairElementGroup In e.CrosshairElementGroups
				For Each crosshairElement As CrosshairElement In crosshairGroup.CrosshairElements
					Dim labelElement As CrosshairLabelElement = crosshairElement.LabelElement
					labelElement.MarkerSize = New System.Drawing.Size(0, 0)
					labelElement.MarkerVisible = False
					labelElement.TextColor = chart.PaletteRepository(chart.PaletteName)(elementIndex).Color
					elementIndex += 1
				Next crosshairElement
			Next crosshairGroup
		End Sub
	End Class
End Namespace
