using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Reports.DAL.Entities
{
    public class Rep_0011
    {
        public int Id { get; set; }
        public string Buy_Total_Ammount { get; set; }
        public string Sell_Total_Ammount { get; set; }
        public string ETS_Share_Value { get; set; }
        public string Market_Share_Value { get; set; }
        public string Percentage { get; set; }
        public string Market { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    }
}
