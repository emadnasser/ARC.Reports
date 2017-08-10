using System;

namespace ARC.Reports.DAL.Entities
{
    public class MarketShareTotal_D_Totals
    {
        public int Id { get; set; }
        public string Buy_Total_Ammount { get; set; }
        public string Sell_Total_Ammount { get; set; }
        public string ETS_Share_Value { get; set; }
        public string Market_Share_Value { get; set; }
        public string Market_Share_Index { get; set; }
        public string DiffDayNom { get; set; }
        public string DiffDayPer { get; set; }
        public string Percentage { get; set; }
        public string Market { get; set; }
        public DateTime? date { get; set; }
    }
}
