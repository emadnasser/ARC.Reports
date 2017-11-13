Imports DevExpress.SalesDemo.Model
Imports DevExpress.XtraCharts

Namespace DevExpress.SalesDemo.Win.Modules
	Partial Public Class ucSalesDashboard
		Inherits BaseModule

		Private ReadOnly Property SalesbySecorSeries() As Series
			Get
				Return chartSalesbySecor.Series(0)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Initialize()
		End Sub

		Private Sub Initialize()
			Dim dataProvider As IDataProvider = DataSource.GetDataProvider()
			SalesbySecorSeries.DataSource = dataProvider.GetSalesBySector(New Date(), Date.Now, GroupingPeriod.All)

			dailySalesPerformance.SetSalesPerformanceProvider(New DailySalesPerformance(dataProvider))
			monthlySalesPerformance.SetSalesPerformanceProvider(New MonthlySalesPerformance(dataProvider))

			Dim palette As Palette = ChartUtils.GeneratePalette()
			chartSalesbySecor.PaletteRepository.Add(palette.Name, palette)
			chartSalesbySecor.PaletteName = palette.Name
			AddHandler chartSalesbySecor.CustomDrawSeriesPoint, AddressOf ChartUtils.CustomDrawPieSeriesPoint


			Dim year As Integer = Date.Today.Year
			Dim thisYearSales As SalesGroup = dataProvider.GetTotalSalesByRange(New Date(year, 1, 1), Date.Today)
			Dim fiscalToDataValue As Decimal = thisYearSales.TotalCost
			fiscalToData.Text = fiscalToDataValue.ToString("$0,0")
			needleFiscalToData.Value = CSng(thisYearSales.TotalCost)
			Dim salesForecast As Decimal = SalesForecastMaker.GetYtdForecast(fiscalToDataValue)
			linearScaleRangeBarForecast.Value = CSng(salesForecast / 1000000)

			Dim preYear As Integer = year - 1
			Dim prevYearSales As SalesGroup = dataProvider.GetTotalSalesByRange(New Date(preYear, 1, 1), New Date(preYear, 12, Date.DaysInMonth(preYear, 12)))
			labelFiscalYear.Text = "FISCAL YEAR " & preYear.ToString()
			fiscalYear.Text = prevYearSales.TotalCost.ToString("$0,0")
			needleFiscalYear.Value = CSng(prevYearSales.TotalCost)
		End Sub
	End Class
End Namespace
