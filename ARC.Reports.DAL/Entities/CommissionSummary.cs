namespace ARC.Reports.DAL.Entities
{
    public class CommissionSummary
    {
        public decimal CIC { get; set; }
        public string Equator { get; set; }
        public string Agent { get; set; }
        public string Symbol { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal Total_Commission { get; set; }
        public decimal SAMA_Commission { get; set; }
        public decimal ARC_Commission { get; set; }
        public decimal Number_Of_Trades { get; set; }
        public decimal Total_Amount { get; set; }
    }
}
