using DevExpress.Xpf.DemoBase.Helpers;
using DevExpress.Mvvm;
using DevExpress.DemoData.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DevExpress.Mvvm.DataAnnotations;
using System.Xml.Serialization;
using System.Reflection;
using System.Collections.ObjectModel;
using System;
using System.Windows.Threading;
using DevExpress.Xpf.Core;

namespace GridDemo {
    [POCOViewModel]
    public class FixedRowsViewModel {
        const int HistoryLength = 20;
        const int UpdateInterval = 1000;
        Random random = new Random();
        public ObservableCollectionCore<StockItem> Data { get; set; }
        string[] fixedTopRows = { "MSFT", "AAPL", "ORCL" };
        public List<StockItem> FixedTopRows { get; set; }
        string[] fixedBottomRows = { "IBM", "CSCO", "MSI", "DELL", "XRX" };
        public List<StockItem> FixedBottomRows { get; set; }
        public StockItem CurrentItem { get; set; }

        public FixedRowsViewModel() {
            ObservableCollectionCore<StockItem> data = StockItems.GetData();
            foreach(StockItem stockItem in data) {
                for(int i = 0; i < HistoryLength; i++)
                    UpdatePrice(stockItem);
            }
            FixedTopRows = data.Where(x => fixedTopRows.Contains(x.CompanyName)).ToList();
            FixedBottomRows = data.Where(x => fixedBottomRows.Contains(x.CompanyName)).ToList();
            CurrentItem = data.FirstOrDefault(x => x.CompanyName == "EBAY");
            Data = data;
        }

        DispatcherTimer timer;
        public void StartUpdate() {
            timer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(UpdateInterval) };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        public void StopUpdate() {
            timer.Stop();
            timer.Tick -= timer_Tick;
            timer = null;
        }
        void timer_Tick(object sender, EventArgs e) {
            Data.BeginUpdate();
            foreach(StockItem stockItem in Data)
                UpdatePrice(stockItem);
            Data.EndUpdate();
        }

        void UpdatePrice(StockItem stockItem) {
            double newDelta = random.NextDouble() * 0.5 - 0.25;
            if(Math.Sign(stockItem.DeltaPrice) == Math.Sign(newDelta))
                stockItem.DeltaChange = 0;
            else
                stockItem.DeltaChange = Math.Sign(newDelta);
            stockItem.DeltaPrice = newDelta;
            stockItem.Price += stockItem.DeltaPrice;
            if(stockItem.Price < stockItem.LowPrice)
                stockItem.LowPrice = stockItem.Price;
            if(stockItem.Price > stockItem.HighPrice)
                stockItem.HighPrice = stockItem.Price;
            stockItem.DeltaPricePercent = stockItem.DeltaPrice / stockItem.Price;
            stockItem.Volume += Convert.ToInt32(random.NextDouble() * stockItem.Volume * 0.005 - 0.0025);
            UpdatePriceHistory(stockItem);
        }
        void UpdatePriceHistory(StockItem stockItem) {
            List<double> newPriceHistory = new List<double>(new double[HistoryLength]);
            for(int i = 1; i < HistoryLength; i++)
                newPriceHistory[i - 1] = i < stockItem.PriceHistory.Count ? stockItem.PriceHistory[i] : 0;
            newPriceHistory[HistoryLength - 1] = stockItem.Price;
            stockItem.PriceHistory = newPriceHistory;
        }
    }

    [XmlRoot("StockItems")]
    public class StockItems : ObservableCollectionCore<StockItem> {
        public static ObservableCollectionCore<StockItem> GetData() {
            XmlSerializer s = new XmlSerializer(typeof(StockItems));
            Assembly assembly = typeof(MultiView).Assembly;
            return (ObservableCollectionCore<StockItem>)s.Deserialize(assembly.GetManifestResourceStream(DemoHelper.GetPath("GridDemo.Data.", assembly) + "StockSource.xml"));
        }
    }

    public class StockItem {
        public string CompanyName { get; set; }
        public double Price { get; set; }
        public int Volume { get; set; }
        public double LowPrice { get; set; }
        public double HighPrice { get; set; }
        public double DeltaPrice { get; set; }
        public double DeltaPricePercent { get; set; }
        public int DeltaChange { get; set; }

        public StockItem() {
            PriceHistory = new List<double>();
        }
        public List<double> PriceHistory { get; set; }
    }
}
