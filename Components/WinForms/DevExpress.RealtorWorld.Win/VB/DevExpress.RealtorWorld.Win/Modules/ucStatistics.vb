Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts

Namespace DevExpress.RealtorWorld.Win
	Partial Public Class ucStatistics
		Inherits BaseModule
		Private Shared Regions() As String = { "Middle West", "Mountain", "Pacific", "South", "North East" }
		Public Overrides ReadOnly Property AllowWaitDialog() As Boolean
			Get
				Return False
			End Get
		End Property
		Private ReadOnly Property PopularitySeries() As Series
			Get
				Return ccPopularity.Series(0)
			End Get
		End Property
		Private ReadOnly Property PriceSeries() As Series
			Get
				Return ccPrice.Series(0)
			End Get
		End Property
		Private ReadOnly Property SimilarHousesSoldSeries() As Series
			Get
				Return ccSimilarHouses.Series("Sold")
			End Get
		End Property
		Private ReadOnly Property SimilarHousesProposalsSeries() As Series
			Get
				Return ccSimilarHouses.Series("Proposals")
			End Get
		End Property
		Private ReadOnly Property PriceDiagram() As XYDiagram
			Get
				Return CType(ccPrice.Diagram, XYDiagram)
			End Get
		End Property
		Private ReadOnly Property SimilarHousesDiagram() As XYDiagram
			Get
				Return CType(ccSimilarHouses.Diagram, XYDiagram)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub FillPricesChart(ByVal home As Home, ByVal random As Random)
			PriceSeries.Points.Clear()
			Dim [date] As DateTime = DateTime.Now
			Dim startDate As DateTime = [date].Subtract(New TimeSpan(500, 0, 0, 0, 0))
			ccPrice.BeginInit()
			Try
				PriceSeries.Points.Add(New SeriesPoint([date], home.Price / 1000))
				Do While [date] > startDate
					[date] = [date].Subtract(New TimeSpan(1, 0, 0, 0, 0))
					PriceSeries.Points.Insert(0, New SeriesPoint([date], PriceSeries.Points(0).Values(0) * (1 + (random.NextDouble() - 0.5) / 1000)))
				Loop
			Finally
				ccPrice.EndInit()
			End Try
			PriceDiagram.AxisX.VisualRange.SetMinMaxValues(CDate(PriceDiagram.AxisX.WholeRange.MaxValue) - New TimeSpan(100, 0, 0, 0), PriceDiagram.AxisX.WholeRange.MaxValue)
		End Sub
		Private Sub FillPopularityRatingChart(ByVal random As Random)
			ccPopularity.BeginInit()
			Try
				PopularitySeries.Points.Clear()
				For i As Integer = 0 To Regions.Length - 1
					PopularitySeries.Points.Add(New SeriesPoint(Regions(i), random.Next(80)))
				Next i
			Finally
				ccPopularity.EndInit()
			End Try
		End Sub
		Private Sub FillSimilarHousesChart(ByVal random As Random)
			Dim year As Integer = DateTime.Now.Year
			ccSimilarHouses.BeginInit()
			Try
				SimilarHousesProposalsSeries.Points.Clear()
				SimilarHousesSoldSeries.Points.Clear()
				For i As Integer = 0 To 9
					Dim proposalCount As Integer = random.Next(50, 250)
					SimilarHousesProposalsSeries.Points.Insert(0, New SeriesPoint(year - i, proposalCount))
					SimilarHousesSoldSeries.Points.Insert(0, New SeriesPoint(year - i, Math.Round(proposalCount * (random.Next(10, 80) / 100.0))))
				Next i
			Finally
				ccSimilarHouses.EndInit()
			End Try
			SimilarHousesDiagram.AxisX.VisualRange.MinValue = year - 5
		End Sub
		Public Sub InitData(ByVal home As Home)
			Dim random As New Random(home.ID)
			FillPopularityRatingChart(random)
			FillPricesChart(home, random)
			FillSimilarHousesChart(random)
		End Sub
	End Class
End Namespace
