using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Reports.DAL.Entities
{
    public class BrokerageMetricsMonthly
    {
        public string Months { get; set; }
        public string Active_CICs { get; set; }
        public string Turnover { get; set; }
        public string Port_Value { get; set; }
    }
}
