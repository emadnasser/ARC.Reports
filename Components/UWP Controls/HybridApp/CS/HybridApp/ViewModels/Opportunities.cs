using System;
using System.Collections.Generic;
using System.Linq;
using HybridApp.DataModel;
using HybridApp.HybridAppService;

namespace HybridApp.ViewModels {
    public static class Opportunities {
        public enum Stage {
            High,
            Medium,
            Low,
            Unlikely,
            Summary
        }
        public class MapItem {
            public Address Address { get; set; }
            public Stage Stage { get; set; }
            public DateTime Date { get; set; }
            public string City { get { return Address.City; } }
            public double Latitude { get { return Address.Latitude; } }
            public double Longitude { get { return Address.Longitude; } }
            public string Name { get { return Enum.GetName(typeof(Stage), Stage); } }
            public int Index { get { return (int)Stage; } }
            public decimal Value { get; set; }
        }
        public static SummaryItem GetSummaryItem(IEnumerable<Quote> quotes, Stage stage) {
            var query = GetQuotes(quotes, stage);
            return new SummaryItem {
                StageName = stage.ToString(),
                Summary = !query.Any() ? 0 : query.Sum(q => q.Total)
            };
        }
        public static IEnumerable<MapItem> GetOpportunities(IEnumerable<Quote> quotes) {
            yield return GetOpportunity(quotes, Stage.High);
            yield return GetOpportunity(quotes, Stage.Medium);
            yield return GetOpportunity(quotes, Stage.Low);
            yield return GetOpportunity(quotes, Stage.Unlikely);
        }
        public static IEnumerable<SummaryItem> GetSummaryOpportunities(IEnumerable<Quote> quotes) {
            yield return GetSummaryItem(quotes, Stage.High);
            yield return GetSummaryItem(quotes, Stage.Medium);
            yield return GetSummaryItem(quotes, Stage.Low);
            yield return GetSummaryItem(quotes, Stage.Unlikely);
        }
        static MapItem GetOpportunity(IEnumerable<Quote> quotes, Stage stage) {
            return new MapItem
            {
                Stage = stage,
                Value = GetQuotes(quotes, stage).Sum(q => q.Total)
            };
        }
        static string GetName(Stage stage) {
            return Enum.GetName(typeof(Stage), stage);
        }
        static IEnumerable<Quote> GetQuotes(IEnumerable<Quote> quotes, Stage stage) {
            double min, max;
            GetRange(stage, out min, out max);
            return quotes.Where(q => q.Opportunity > min && q.Opportunity < max);
        }
        static IEnumerable<MapItem> GetOpportunities(IEnumerable<Quote> quotes, IEnumerable<Customer> customers, Stage stage) {
            string name = GetName(stage);
            return from q in GetQuotes(quotes, stage)
                   join c in customers on q.CustomerId equals c.Id
                   select new MapItem { Stage = stage, Address = q.CustomerStore.Address, Value = q.Total, Date = q.Date };
        }
        static void GetRange(Stage stage, out double min, out double max) {
            switch(stage) {
                case Stage.High:
                    max = 1.0;
                    min = 0.6;
                    break;
                case Stage.Medium:
                    min = 0.3;
                    max = 0.6;
                    break;
                case Stage.Low:
                    min = 0.12;
                    max = 0.3;
                    break;
                case Stage.Summary:
                    min = 0.0;
                    max = 1.0;
                    break;
                default:
                    min = 0.0;
                    max = 0.12;
                    break;
            }
        }
        public static IEnumerable<MapItem> GetOpportunities(System.Collections.ObjectModel.ObservableCollection<HybridAppService.Quote> quotes, System.Collections.ObjectModel.ObservableCollection<HybridAppService.Customer> customers, Stage stage) {
            string name = GetName(stage);
            return from q in GetQuotes(quotes, stage)
                   join c in customers on q.CustomerId equals c.Id
                   select new MapItem { Stage = stage, Address = q.CustomerStore.Address, Value = q.Total, Date = q.Date };
        }
    }
}
