using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Reports.DAL.Entities
{
    public class Rep_001
    {
        public int Id { get; set; }
        public string Channel { get; set; }
        public string Operation { get; set; }
        public string Amount { get; set; }
        public Nullable<int> Transactions { get; set; }
        public Nullable<double> Percentage { get; set; }
        public string MarketType { get; set; }
        public Nullable<System.DateTime> InsertedDate { get; set; }
    }
}
