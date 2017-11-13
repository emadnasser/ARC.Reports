using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;

namespace DashboardMainDemo.Dashboards {
    public partial class CustomerSupport : Dashboard {
        public CustomerSupport() {
            InitializeComponent();
        }
        void CustomerSupport_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            CustomerSupportData data = new CustomerSupportData(DataLoader.LoadCustomerSupport(), DataLoader.LoadEmployees());
            e.Data = data.CustomerSupport;
        }
    }
}
