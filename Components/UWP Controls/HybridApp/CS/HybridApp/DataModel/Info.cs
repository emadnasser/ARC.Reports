using System;
using System.Collections.Generic;

namespace HybridApp.DataModel {
    public class SummaryItem {
        public string StageName { get; set; }
        public decimal Summary { get; set; }
        public decimal SummaryForView { get { return Summary / 1000; } }
    }
    public class SalesSummaryItem {
        public string Category { get; set; }
        public decimal Sales { get; set; }
        public decimal SalesForView { get { return Sales / 1000; } }
    }
    public class CostAverageItem {
        public string Category { get; set; }
        public decimal Cost { get; set; }
        public decimal CostForView { get { return Cost / 1000; } }
    }
    public class SalesInfo {
        public string Caption { get; set; }
        public string CaptionForView { get { return Caption.Replace("Sales (", "").Replace(")", ""); } }
        public List<SalesProductInfo> ListProductInfo { get; set; }
        public DateTime time { get; set; }
        public SalesInfo() {
            ListProductInfo = new List<SalesProductInfo>();
        }
    }
    public class SalesProductInfo {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal ValueForView { get { return Value / 1000; } }
    }
}
