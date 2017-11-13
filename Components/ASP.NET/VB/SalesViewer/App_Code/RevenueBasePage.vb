Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DataAccess

Public MustInherit Class RevenueBasePage
    Inherits BasePage

    Protected Class DateRange
        Private privateStartDate As Date
        Public Property StartDate() As Date
            Get
                Return privateStartDate
            End Get
            Private Set(ByVal value As Date)
                privateStartDate = value
            End Set
        End Property
        Private privateEndDate As Date
        Public Property EndDate() As Date
            Get
                Return privateEndDate
            End Get
            Private Set(ByVal value As Date)
                privateEndDate = value
            End Set
        End Property

        Public Sub New(ByVal startDate As Date, ByVal endDate As Date)
            Me.StartDate = startDate
            Me.EndDate = endDate
        End Sub
    End Class

    Protected MustOverride ReadOnly Property DailySalesPerformanceVerticalChart() As VerticalChartControlBase
    Protected MustOverride ReadOnly Property UnitSalesVerticalChart() As VerticalChartControlBase

    Protected MustOverride Function GetChartSalesRevenueCollection(ByVal startDate As Date, ByVal endDate As Date) As IEnumerable(Of ChartData)
    Protected MustOverride Function GetChartSalesCountCollection(ByVal startDate As Date, ByVal endDate As Date) As IEnumerable(Of ChartData)

    Protected Overrides Sub OnInit(ByVal e As EventArgs)
        MyBase.OnInit(e)
        AddHandler DailySalesPerformanceVerticalChart.RangeSelectionChanged, Sub(s, arg) PopulateDailySalesPerformanceChart()
        AddHandler UnitSalesVerticalChart.RangeSelectionChanged, Sub(s, arg) PopulateUnitSalesChart()
    End Sub
    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        If Not IsCallback Then
            PopulateDailySalesPerformanceChart()
            PopulateUnitSalesChart()
        End If
    End Sub

    Protected Sub PopulateDailySalesPerformanceChart()
        PopulateChart(DailySalesPerformanceVerticalChart, GetTodayRange(), GetYesterdayRange(), GetLastWeekRange(), GetChartCurrentRange(), GetChartPreviousRange(), getChartDataFunc:= Function(startDate, endDate) GetChartSalesRevenueCollection(startDate, endDate), getValueFunc:= Function(startDate, endDate) SalesProvider.GetSalesRevenue(startDate, endDate), dateToStringFunc:= Function([date]) DateTimeHelper.GetDateString([date], "d"))
    End Sub
    Protected Sub PopulateUnitSalesChart()
        PopulateChart(UnitSalesVerticalChart, GetCurrentMonthRange(), GetLastMonthRange(), GetYTDRange(), GetChartCurrentRange(True), GetChartPreviousRange(True), getChartDataFunc:= Function(startDate, endDate) GetChartSalesCountCollection(startDate, endDate), getValueFunc:= Function(startDate, endDate) SalesProvider.GetSaleCount(startDate, endDate), dateToStringFunc:= Function([date]) [date].ToString("MMMM"))
    End Sub
    Private Sub PopulateChart(ByVal chart As VerticalChartControlBase, ByVal current As DateRange, ByVal previous As DateRange, ByVal custom As DateRange, ByVal currentChart As DateRange, ByVal previousChart As DateRange, ByVal getChartDataFunc As Func(Of Date, DateTime, IEnumerable(Of ChartData)), ByVal getValueFunc As Func(Of Date, DateTime, Double), ByVal dateToStringFunc As Func(Of Date, String))

        chart.CurrentValue = getValueFunc(current.StartDate, current.EndDate)
        chart.PreviousValue = getValueFunc(previous.StartDate, previous.EndDate)
        chart.CustomPeriodValue = getValueFunc(custom.StartDate, current.EndDate)

        chart.CurrentSeriesName = dateToStringFunc(currentChart.StartDate)
        chart.PreviousSeriesName = dateToStringFunc(previousChart.StartDate)
        chart.SetChartData(getChartDataFunc(currentChart.StartDate, currentChart.EndDate).ToList(), getChartDataFunc(previousChart.StartDate, previousChart.EndDate).ToList())
    End Sub

    #Region "Get DateTime Ranges"
    Protected Function GetTodayRange() As DateRange
        Return GetRange(Date.Now, SelectionInterval.Day)
    End Function
    Protected Function GetYesterdayRange() As DateRange
        Return GetRange(Date.Now.AddDays(-1), SelectionInterval.Day)
    End Function
    Protected Function GetLastWeekRange() As DateRange
        Return GetRange(Date.Now.AddDays(-7), Date.Now, SelectionInterval.Day)
    End Function
    Protected Function GetChartCurrentRange(Optional ByVal monthRange As Boolean = False) As DateRange
        Dim selectedDate As Date = If(monthRange, UnitSalesVerticalChart.GetSelectedDate(), DailySalesPerformanceVerticalChart.GetSelectedDate())
        Return GetRange(selectedDate,If(monthRange, SelectionInterval.Month, SelectionInterval.Day))
    End Function
    Protected Function GetChartPreviousRange(Optional ByVal monthRange As Boolean = False) As DateRange
        Dim dayBeforeSelected As Date = If(monthRange, UnitSalesVerticalChart.GetSelectedDate().AddMonths(-1), DailySalesPerformanceVerticalChart.GetSelectedDate().AddDays(-1))
        Return GetRange(dayBeforeSelected,If(monthRange, SelectionInterval.Month, SelectionInterval.Day))
    End Function
    Protected Function GetCurrentMonthRange() As DateRange
        Return GetRange(Date.Now, SelectionInterval.Month)
    End Function
    Protected Function GetLastMonthRange() As DateRange
        Return GetRange(Date.Now.AddMonths(-1), SelectionInterval.Month)
    End Function
    Protected Function GetYTDRange() As DateRange
        Return New DateRange(New Date(Date.Now.Year, 1, 1), DateTimeHelper.GetIntervalEndDate(Date.Now, SelectionInterval.Month))
    End Function
    Private Function GetRange(ByVal [date] As Date, ByVal interval As SelectionInterval) As DateRange
        Return GetRange([date], [date], interval)
    End Function
    Private Function GetRange(ByVal startDate As Date, ByVal endDate As Date, ByVal interval As SelectionInterval) As DateRange
        Return New DateRange(DateTimeHelper.GetIntervalStartDate(startDate, interval), DateTimeHelper.GetIntervalEndDate(endDate, interval))
    End Function
    #End Region
End Class
