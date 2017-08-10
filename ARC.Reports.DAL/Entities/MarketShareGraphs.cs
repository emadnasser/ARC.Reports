using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Reports.DAL.Entities
{
    public class MarketShareGraphs
    {
        public double ETS_Share_Value { get; set; }
        public double Market_Share_Value { get; set; }
        public double Percentage { get; set; }
        public DateTime? date { get; set; }
        public DateTime? date2 { get; set; }
    }
}
