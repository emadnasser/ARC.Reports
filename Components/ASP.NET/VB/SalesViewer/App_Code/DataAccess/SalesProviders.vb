Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace DataAccess
    Public Class SalesProvider
        Inherits BaseProvider(Of DataContext.Sale)

        Public Function GetSalesGroupedByRegion(ByVal productId As Integer, ByVal minDate As Date, ByVal maxDate As Date) As IEnumerable(Of ChartData)
            Return TryGetResult(Of IEnumerable(Of ChartData))(Function() (
                From s In DataTable
                Where s.SaleDate >= minDate AndAlso s.SaleDate <= maxDate AndAlso s.ProductId = productId
                Group s By GroupKey = New With {Key .PointName = s.Region.Name} Into saleGroup = Group
                Select New ChartData With {.PointName = GroupKey.PointName, .Value = saleGroup.Sum(Function(x) x.TotalCost)}).ToList())
        End Function

        Public Function GetSalesGroupedByChannel(ByVal productId As Integer, ByVal minDate As Date, ByVal maxDate As Date) As IEnumerable(Of ChartData)
            Return TryGetResult(Of IEnumerable(Of ChartData))(Function()
                Dim query As IQueryable(Of DataContext.Sale) = (
                    From s In DataTable
                    Where s.SaleDate >= minDate AndAlso s.SaleDate <= maxDate
                    Select s)
                If productId > -1 Then
                    query = query.Where(Function(s) s.ProductId = productId)
                End If
                Return (
                    From s In query
                    Group s By GroupKey = New With {Key .PointName = s.Channel.Name} Into saleGroup = Group
                    Select New ChartData With {.PointName = GroupKey.PointName, .Value = saleGroup.Sum(Function(x) x.TotalCost)})
            End Function)
        End Function
        Public Function GetSalesGroupedByChannel(ByVal minDate As Date, ByVal maxDate As Date) As IEnumerable(Of ChartData)
            Return GetSalesGroupedByChannel(-1, minDate, maxDate)
        End Function

        Public Function GetSalesGroupedBySector(ByVal productId As Integer, ByVal minDate As Date, ByVal maxDate As Date) As IEnumerable(Of ChartData)
            Return TryGetResult(Of IEnumerable(Of ChartData))(Function()
                Dim query As IQueryable(Of DataContext.Sale) = (
                    From s In DataTable
                    Where s.SaleDate >= minDate AndAlso s.SaleDate <= maxDate
                    Select s)
                If productId > -1 Then
                    query = query.Where(Function(s) s.ProductId = productId)
                End If
                Return (
                    From s In query
                    Group s By GroupKey = New With {Key .PointName = s.Sector.Name} Into saleGroup = Group
                    Select New ChartData With {.PointName = GroupKey.PointName, .Value = saleGroup.Sum(Function(x) x.TotalCost)})
            End Function)
        End Function
        Public Function GetSalesGroupedBySector(ByVal minDate As Date, ByVal maxDate As Date) As IEnumerable(Of ChartData)
            Return GetSalesGroupedBySector(-1, minDate, maxDate)
        End Function

        Public Function GetSalesGroupedByProduct(ByVal minDate As Date, ByVal maxDate As Date) As IEnumerable(Of ChartData)
            Return TryGetResult(Of IEnumerable(Of ChartData))(Function() (
                From s In DataTable
                Where s.SaleDate >= minDate AndAlso s.SaleDate <= maxDate
                Group s By GroupKey = New With {Key .PointName = s.Product.Name} Into saleGroup = Group
                Select New ChartData With {.PointName = GroupKey.PointName, .Value = saleGroup.Sum(Function(x) x.TotalCost)}).ToList())
        End Function

        Public Function GetCustomerPurchasesGroupedByProduct(ByVal customerId As Integer, ByVal minDate As Date, ByVal maxDate As Date) As IEnumerable(Of ChartData)
            Return TryGetResult(Of IEnumerable(Of ChartData))(Function() (
                From s In DataTable
                Where s.SaleDate >= minDate AndAlso s.SaleDate <= maxDate AndAlso s.CustomerId = customerId
                Group s By GroupKey = New With {Key .PointName = s.Product.Name} Into saleGroup = Group
                Select New ChartData With {.PointName = GroupKey.PointName, .Value = saleGroup.Sum(Function(x) x.TotalCost)}).ToList())
        End Function

        #Region "Revenue"
        Public Function GetSaleCountGroupedByProduct(ByVal minDate As Date, ByVal maxDate As Date) As IEnumerable(Of ChartData)
            Return TryGetResult(Of IEnumerable(Of ChartData))(Function() (
                From s In DataTable
                Where s.SaleDate >= minDate AndAlso s.SaleDate <= maxDate
                Group s By GroupKey = New With {Key .PointName = s.Product.Name} Into saleGroup = Group
                Select New ChartData With {.PointName = GroupKey.PointName, .Value = saleGroup.Count()}).ToList())
        End Function

        Public Function GetSaleCountGroupedBySector(ByVal minDate As Date, ByVal maxDate As Date) As IEnumerable(Of ChartData)
            Return TryGetResult(Of IEnumerable(Of ChartData))(Function() (
                From s In DataTable
                Where s.SaleDate >= minDate AndAlso s.SaleDate <= maxDate
                Group s By GroupKey = New With {Key .PointName = s.Sector.Name} Into saleGroup = Group
                Select New ChartData With {.PointName = GroupKey.PointName, .Value = saleGroup.Count()}).ToList())
        End Function
        Public Function GetSaleCount(ByVal minDate As Date, ByVal maxDate As Date) As Integer
            Return TryGetResult(Of Integer)(Function() DataTable.Count(Function(s) s.SaleDate >= minDate AndAlso s.SaleDate <= maxDate), useCache:= True, keySuffix:= String.Format("{0}.{1}", minDate, maxDate))
        End Function
        Public Function GetSalesRevenue(ByVal minDate As Date, ByVal maxDate As Date) As Double
            Return TryGetResult(Of Double)(Function() DataTable.Where(Function(s) s.SaleDate >= minDate AndAlso s.SaleDate <= maxDate).Sum(Function(s) s.TotalCost), useCache:= True, keySuffix:= String.Format("{0}.{1}", minDate, maxDate))
        End Function
        Public Function GetDailySalesGroupedByChannel(ByVal day As Date) As IEnumerable(Of RangeChartData)
            Return TryGetResult(Of IEnumerable(Of RangeChartData))(Function()
                Dim startDate As Date = DateTimeHelper.GetIntervalStartDate(day, SelectionInterval.Day)
                Dim endDate As Date = DateTimeHelper.GetIntervalEndDate(day, SelectionInterval.Day)
                Return (
                    From s In DataTable
                    Where s.SaleDate >= startDate AndAlso s.SaleDate <= endDate
                    Group s By GroupKey = New With {Key .SeriesName = s.Channel.Name, Key .Year = s.SaleDate.Year, Key .Month = s.SaleDate.Month, Key .Day = s.SaleDate.Day, Key .Hour = s.SaleDate.Hour} Into saleGroup = Group
                    Select New With {Key .TotalCost = saleGroup.Sum(Function(x) x.TotalCost), Key .SeriesName = GroupKey.SeriesName, Key .Year = GroupKey.Year, Key .Month = GroupKey.Month, Key .Day = GroupKey.Day, Key .Hour = GroupKey.Hour}).ToList().Select(Function(s) New RangeChartData() With {.Argument = New Date(s.Year, s.Month, s.Day, s.Hour, 0, 0, 0), .SeriesName = s.SeriesName, .Value = s.TotalCost})
            End Function)
        End Function
        #End Region

        ' Footer Range Control
        Public Function GetRangeChartData(ByVal startDate As Date, ByVal endDate As Date) As IEnumerable(Of RangeChartData)
            Return TryGetResult(Of IEnumerable(Of RangeChartData))(Function() (
                From s In DataTable
                Where s.SaleDate >= startDate AndAlso s.SaleDate <= endDate
                Group s By GroupKey = New With {Key .Year = s.SaleDate.Year, Key .Month = s.SaleDate.Month, Key .Day = s.SaleDate.Date.Day} Into groupS = Group
                Select New With {Key .Year = GroupKey.Year, Key .Month = GroupKey.Month, Key .Day = GroupKey.Day, Key .TotalCost = groupS.Sum(Function(x) x.TotalCost)}).ToList().Select(Function(x) New RangeChartData() With {.Argument = New Date(x.Year, x.Month, x.Day), .Value = x.TotalCost}).OrderBy(Function(s) s.Argument), useCache:= True, keySuffix:= String.Format("{0}.{1}", startDate, endDate))
        End Function
        Public Function GetMinDate() As Date
            Return TryGetResult(Of Date)(Function() DataTable.Min(Function(s) s.SaleDate), useCache:= True)
        End Function
        Public Function GetMaxDate() As Date
            Return TryGetResult(Of Date)(Function() DataTable.Where(Function(s) s.SaleDate <= DateTimeHelper.GetIntervalEndDate(Date.Now, SelectionInterval.Day)).Max(Function(s) s.SaleDate), useCache:= True)
        End Function
    End Class

    #Region "Data Transfer Objects"
    Public Class Sale
        Public Property ProductName() As String
        Public Property SaleDate() As Date
        Public Property TotalCost() As Double
    End Class

    Public Class ChartDataBase
        Public Property Value() As Double
        Public Property SeriesName() As String

        Public Sub New()
            SeriesName = "Series1"
        End Sub
    End Class
    Public Class ChartData
        Inherits ChartDataBase

        Public Property PointName() As String
    End Class
    Public Class RangeChartData
        Inherits ChartDataBase

        Public Property Argument() As Date
    End Class
    #End Region
End Namespace
