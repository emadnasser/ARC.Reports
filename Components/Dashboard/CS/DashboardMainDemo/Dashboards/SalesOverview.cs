using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;

namespace DashboardMainDemo.Dashboards {
    public partial class SalesOverview : Dashboard {
        public SalesOverview() {
            InitializeComponent();
        }
        void SalesOverview_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            SalesOverviewDataGenerator dataGenerator = new SalesOverviewDataGenerator(DataLoader.LoadSales());
            dataGenerator.Generate();
            e.Data = dataGenerator.Data;
        }
    }
}
