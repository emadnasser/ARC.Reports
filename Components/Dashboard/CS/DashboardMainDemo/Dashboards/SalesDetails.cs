using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;

namespace DashboardMainDemo.Dashboards {
    public partial class SalesDetails : Dashboard {
        public SalesDetails() {
            InitializeComponent();
        }
        void SalesDetails_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            SalesDetailsDataGenerator dataGenerator = new SalesDetailsDataGenerator(DataLoader.LoadSales());
            dataGenerator.Generate();
            e.Data = dataGenerator.Data;
        }
    }
}
