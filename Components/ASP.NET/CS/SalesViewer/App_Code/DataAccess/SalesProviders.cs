using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess {
    public class SalesProvider : BaseProvider<DataContext.Sale> {

        public IEnumerable<ChartData> GetSalesGroupedByRegion(int productId, DateTime minDate, DateTime maxDate) {
            return TryGetResult<IEnumerable<ChartData>>(() => {
                return (from s in DataTable
                        where s.SaleDate >= minDate &&
                        s.SaleDate <= maxDate &&
                        s.ProductId == productId
                        group s by new { PointName = s.Region.Name } into saleGroup
                        select new ChartData {
                            PointName = saleGroup.Key.PointName,
                            Value = saleGroup.Sum(x => x.TotalCost)
                        }).ToList();
            });
        }

        public IEnumerable<ChartData> GetSalesGroupedByChannel(int productId, DateTime minDate, DateTime maxDate) {
            return TryGetResult<IEnumerable<ChartData>>(() => {
                IQueryable<DataContext.Sale> query = (from s in DataTable
                                          where s.SaleDate >= minDate && s.SaleDate <= maxDate
                                          select s);
                if(productId > -1)
                    query = query.Where(s => s.ProductId == productId);
                return (from s in query
                        group s by new { PointName = s.Channel.Name } into saleGroup
                        select new ChartData {
                            PointName = saleGroup.Key.PointName,
                            Value = saleGroup.Sum(x => x.TotalCost)
                        });
            });
        }
        public IEnumerable<ChartData> GetSalesGroupedByChannel(DateTime minDate, DateTime maxDate) {
            return GetSalesGroupedByChannel(-1, minDate, maxDate);
        }

        public IEnumerable<ChartData> GetSalesGroupedBySector(int productId, DateTime minDate, DateTime maxDate) {
            return TryGetResult<IEnumerable<ChartData>>(() => {
                IQueryable<DataContext.Sale> query = (from s in DataTable
                                          where s.SaleDate >= minDate && s.SaleDate <= maxDate
                                          select s);
                if(productId > -1)
                    query = query.Where(s => s.ProductId == productId);
                return (from s in query
                        group s by new { PointName = s.Sector.Name } into saleGroup
                        select new ChartData {
                            PointName = saleGroup.Key.PointName,
                            Value = saleGroup.Sum(x => x.TotalCost)
                        });
            });
        }
        public IEnumerable<ChartData> GetSalesGroupedBySector(DateTime minDate, DateTime maxDate) {
            return GetSalesGroupedBySector(-1, minDate, maxDate);
        }

        public IEnumerable<ChartData> GetSalesGroupedByProduct(DateTime minDate, DateTime maxDate) {
            return TryGetResult<IEnumerable<ChartData>>(() => {
                return (from s in DataTable
                        where s.SaleDate >= minDate &&
                        s.SaleDate <= maxDate
                        group s by new { PointName = s.Product.Name } into saleGroup
                        select new ChartData {
                            PointName = saleGroup.Key.PointName,
                            Value = saleGroup.Sum(x => x.TotalCost)
                        }).ToList();
            });
        }

        public IEnumerable<ChartData> GetCustomerPurchasesGroupedByProduct(int customerId, DateTime minDate, DateTime maxDate) {
            return TryGetResult<IEnumerable<ChartData>>(() => {
                return (from s in DataTable
                        where s.SaleDate >= minDate &&
                        s.SaleDate <= maxDate &&
                        s.CustomerId == customerId
                        group s by new { PointName = s.Product.Name } into saleGroup
                        select new ChartData {
                            PointName = saleGroup.Key.PointName,
                            Value = saleGroup.Sum(x => x.TotalCost)
                        }).ToList();
            });
        }

        #region Revenue
        public IEnumerable<ChartData> GetSaleCountGroupedByProduct(DateTime minDate, DateTime maxDate) {
            return TryGetResult<IEnumerable<ChartData>>(() => {
                return (from s in DataTable
                        where s.SaleDate >= minDate &&
                        s.SaleDate <= maxDate
                        group s by new { PointName = s.Product.Name } into saleGroup
                        select new ChartData {
                            PointName = saleGroup.Key.PointName,
                            Value = saleGroup.Count()
                        }).ToList();
            });
        }

        public IEnumerable<ChartData> GetSaleCountGroupedBySector(DateTime minDate, DateTime maxDate) {
            return TryGetResult<IEnumerable<ChartData>>(() => {
                return (from s in DataTable
                        where s.SaleDate >= minDate &&
                        s.SaleDate <= maxDate
                        group s by new { PointName = s.Sector.Name } into saleGroup
                        select new ChartData {
                            PointName = saleGroup.Key.PointName,
                            Value = saleGroup.Count()
                        }).ToList();
            });
        }
        public int GetSaleCount(DateTime minDate, DateTime maxDate) {
            return TryGetResult<int>(() => {
                return DataTable.Count(s => s.SaleDate >= minDate && s.SaleDate <= maxDate);
            }, useCache: true, keySuffix: string.Format("{0}.{1}", minDate, maxDate));
        }
        public double GetSalesRevenue(DateTime minDate, DateTime maxDate) {
            return TryGetResult<double>(() => {
                return DataTable.Where(s => s.SaleDate >= minDate && s.SaleDate <= maxDate).Sum(s => s.TotalCost);
            }, useCache: true, keySuffix: string.Format("{0}.{1}", minDate, maxDate));
        }
        public IEnumerable<RangeChartData> GetDailySalesGroupedByChannel(DateTime day) {
            return TryGetResult<IEnumerable<RangeChartData>>(() => {
                DateTime startDate = DateTimeHelper.GetIntervalStartDate(day, SelectionInterval.Day);
                DateTime endDate = DateTimeHelper.GetIntervalEndDate(day, SelectionInterval.Day);

                return (from s in DataTable
                        where s.SaleDate >= startDate && s.SaleDate <= endDate
                        group s by new {
                            SeriesName = s.Channel.Name,
                            Year = s.SaleDate.Year,
                            Month = s.SaleDate.Month,
                            Day = s.SaleDate.Day,
                            Hour = s.SaleDate.Hour
                        } into saleGroup
                        select new {
                            TotalCost = saleGroup.Sum(x => x.TotalCost),
                            SeriesName = saleGroup.Key.SeriesName,
                            Year = saleGroup.Key.Year,
                            Month = saleGroup.Key.Month,
                            Day = saleGroup.Key.Day,
                            Hour = saleGroup.Key.Hour
                        }).ToList().Select(s => new RangeChartData() {
                            Argument = new DateTime(s.Year, s.Month, s.Day, s.Hour, 0, 0, 0),
                            SeriesName = s.SeriesName,
                            Value = s.TotalCost
                        });
            });
        }
        #endregion

        // Footer Range Control
        public IEnumerable<RangeChartData> GetRangeChartData(DateTime startDate, DateTime endDate) {
            return TryGetResult<IEnumerable<RangeChartData>>(() => {
                return (from s in DataTable
                        where s.SaleDate >= startDate && s.SaleDate <= endDate
                        group s by new { Year = s.SaleDate.Year, Month = s.SaleDate.Month, Day = s.SaleDate.Date.Day } into groupS
                        select new {
                            Year = groupS.Key.Year,
                            Month = groupS.Key.Month,
                            Day = groupS.Key.Day,
                            TotalCost = groupS.Sum(x => x.TotalCost)
                        }).ToList().Select(x => new RangeChartData() {
                            Argument = new DateTime(x.Year, x.Month, x.Day),
                            Value = x.TotalCost
                        }).OrderBy(s => s.Argument);
            }, useCache: true, keySuffix: string.Format("{0}.{1}", startDate, endDate));
        }
        public DateTime GetMinDate() {
            return TryGetResult<DateTime>(() => {
                return DataTable.Min(s => s.SaleDate);
            }, useCache: true);
        }
        public DateTime GetMaxDate() {
            return TryGetResult<DateTime>(() => {
                return DataTable.Where(s => s.SaleDate <= DateTimeHelper.GetIntervalEndDate(DateTime.Now, SelectionInterval.Day)).Max(s => s.SaleDate);
            }, useCache: true);
        }
    }

    #region Data Transfer Objects
    public class Sale {
        public string ProductName { get; set; }
        public DateTime SaleDate { get; set; }
        public double TotalCost { get; set; }
    }

    public class ChartDataBase {
        public double Value { get; set; }
        public string SeriesName { get; set; }

        public ChartDataBase() {
            SeriesName = "Series1";
        }
    }
    public class ChartData : ChartDataBase {
        public string PointName { get; set; }
    }
    public class RangeChartData : ChartDataBase {
        public DateTime Argument { get; set; }
    }
    #endregion
}
