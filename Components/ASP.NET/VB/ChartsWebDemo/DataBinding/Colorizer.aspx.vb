Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Web
Imports System.Xml
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class ColorizerControl
	Inherits ChartBasePage
	Private Function GetHPIs() As List(Of HPIStatistics)
		Dim document As New XmlDocument()
		Using xmlStream As Stream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/HPI.xml"))
			document.Load(xmlStream)
		End Using
		Dim result As New List(Of HPIStatistics)()
		If document IsNot Nothing Then
			Dim elements As XmlNodeList = document.DocumentElement.GetElementsByTagName("CountryStatistics")
			For Each element As XmlNode In elements
				Dim country As String = element.ChildNodes(0).InnerText
				Dim population As Double = Integer.Parse(element.ChildNodes(1).InnerText) / 1000000.0
				Dim hpi As Double = Convert.ToDouble(element.ChildNodes(2).InnerText, CultureInfo.InvariantCulture)
				Dim product As Decimal = Convert.ToDecimal(element.ChildNodes(3).InnerText, CultureInfo.InvariantCulture)
				result.Add(New HPIStatistics(country, population, hpi, product))
			Next element
		End If
		Return result
	End Function

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim paletteEntries = New PaletteEntry() { New PaletteEntry(Color.FromArgb(255, 90, 25), Color.FromArgb(255, 90, 25)), New PaletteEntry(Color.FromArgb(254, 173, 45), Color.FromArgb(254, 173, 45)), New PaletteEntry(Color.FromArgb(229, 227, 53), Color.FromArgb(229, 227, 53)), New PaletteEntry(Color.FromArgb(172, 228, 92), Color.FromArgb(172, 228, 92)), New PaletteEntry(Color.FromArgb(110, 201, 92), Color.FromArgb(110, 201, 92))}
		Dim palette = New Palette("ColorizerPalette", PaletteScaleMode.Repeat, paletteEntries)
		chart.PaletteRepository.Add("ColorizerPalette", palette)
		Dim series As Series = chart.Series(0)
		Dim rangeColorizer As New RangeColorizer()
		rangeColorizer.RangeStops.Add(22)
		rangeColorizer.RangeStops.Add(30)
		rangeColorizer.RangeStops.Add(38)
		rangeColorizer.RangeStops.Add(46)
		rangeColorizer.RangeStops.Add(54)
		rangeColorizer.RangeStops.Add(64)
		rangeColorizer.LegendItemPattern = "{V1} - {V2} HPI"
		rangeColorizer.PaletteName = "ColorizerPalette"
		series.Colorizer = rangeColorizer
		series.ArgumentScaleType = ScaleType.Qualitative
		series.ArgumentDataMember = "Country"
		series.ValueDataMembers.AddRange(New String() { "Product", "Population" })
		series.ColorDataMember = "HPI"
		series.ToolTipHintDataMember = "HPIHint"
		series.DataSource = GetHPIs()
		chart.DataBind()
	End Sub

	Public Overrides Function FindWebChartControl() As WebChartControl
		Return chart
	End Function
	Public Overrides Function ShowPaletteComboBox() As Boolean
		Return False
	End Function

End Class

Public Class HPIStatistics 'HPI - Happy Planet Index
	Public Property Country() As String
	Public Property Population() As Double
	Public Property HPI() As Double
	Public Property HPIHint() As String
	Public Property Product() As Decimal

	Public Sub New(ByVal country As String, ByVal population As Double, ByVal hpi As Double, ByVal product As Decimal)
		Me.Country = country
		Me.Population = population
		Me.HPI = hpi
		Me.Product = product
		Me.HPIHint = String.Format("{0:n2}", hpi)
	End Sub
End Class
