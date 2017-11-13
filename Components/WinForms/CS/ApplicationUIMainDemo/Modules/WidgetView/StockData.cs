using System;

namespace DevExpress.ApplicationUI.Demos {
    public partial class StockData {
        public decimal ClosePrice { get; set; }
        public DateTime Date { get; set; }
        public decimal HighPrice { get; set; }
        public decimal LowPrice { get; set; }
        public decimal OpenPrice { get; set; }
        public int Volumne { get; set; }
    }
    public static class StockDataCreator {
        const int BeginDate = 40000;
        static Random r = new Random();
        public static StockData GetData(int index) {
            int delta = r.Next(-5, 5);
            StockData data = new StockData();
            data.Date = DateTime.FromOADate(BeginDate + index);
            data.HighPrice = r.Next(20 + delta, 30 + delta) + (decimal)Math.Round(r.NextDouble(), 2);
            data.LowPrice = r.Next(10 + delta, 18 + delta) + (decimal)Math.Round(r.NextDouble(), 2);
            data.OpenPrice = r.Next(20 + delta, 25 + delta) + (decimal)Math.Round(r.NextDouble(), 2);
            data.ClosePrice = r.Next(15 + delta, 20 + delta) + (decimal)Math.Round(r.NextDouble(), 2);
            data.Volumne = r.Next(10000, 18000);
            return data;
        }
    }
}
