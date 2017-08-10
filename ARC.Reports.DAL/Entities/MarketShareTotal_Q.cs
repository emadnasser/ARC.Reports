namespace ARC.Reports.DAL.Entities
{
    public class MarketShareTotal_Q
    {
        public string Channel { get; set; }
        public double? MarketShare_1 { get; set; }
        public double? MarketTrades_1 { get; set; }
        public double? MarketShare_2 { get; set; }
        public double? MarketTrades_2 { get; set; }
        public double? MarketShare_3 { get; set; }
        public double? MarketTrades_3 { get; set; }
        public double? MarketShare_4 { get; set; }
        public double? MarketTrades_4 { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
