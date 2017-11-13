using System;
using System.Collections.Generic;

namespace DevExpress.DemoData.Models {
    
    public partial class AboutRegion
    {
        public long Id { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double PopulationPortion{ get; set; }
    }
}
