using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;

namespace DashboardMainDemo.Dashboards {
    public partial class SalesPerformance : Dashboard {
        public SalesPerformance() {
            InitializeComponent();
        }
        void SalesPerformance_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            SalesPerformanceDataGenerator dataGenerator = new SalesPerformanceDataGenerator(DataLoader.LoadSales());
            dataGenerator.Generate();
            if(e.DataSource == dsMonthlySales)
                e.Data = dataGenerator.MonthlySales;
            else if(e.DataSource == dsTotalSales)
                e.Data = dataGenerator.TotalSales;
            else if(e.DataSource == dsKeyMetrics)
                e.Data = dataGenerator.KeyMetrics;
        }
    }
}
