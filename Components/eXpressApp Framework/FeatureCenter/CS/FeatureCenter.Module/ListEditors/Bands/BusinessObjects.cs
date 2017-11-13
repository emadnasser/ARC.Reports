using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DevExpress.Persistent.Base;

namespace FeatureCenter.Module.ListEditors {
    [DefaultClassOptions]
    [ImageName("ListEditors.Demo_ListEditors_Grid_LargeData")]
    public class OrderBands {
        [Browsable(false)]
        public int ID { get; protected set; }

        public DateTime? Date { get; set; }
        public int Qty { get; set; }
        public string Name { get; set; }

        public ContactBands Contact { get; set; }
        public ProductBands Product { get; set; }
    }

    public class ContactBands {

        public ContactBands() {
            Orders = new List<OrderBands>();
        }

        [Browsable(false)]
        public int ID { get; protected set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public IList<OrderBands> Orders { get; set; }
    }

    public class ProductBands {

        public ProductBands() {
            Orders = new List<OrderBands>();
        }

        [Browsable(false)]
        public int ID { get; protected set; }

        public string Company { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public double UnitPrice { get; set; }

        public IList<OrderBands> Orders { get; set; }
    }
}
