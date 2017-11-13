using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;

namespace DashboardMainDemo.Dashboards {
    public partial class RevenueAnalysis : Dashboard {
        public RevenueAnalysis() {
            InitializeComponent();
        }
        void RevenueAnalysis_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            RevenueAnalysisDataGenerator dataGenerator = new RevenueAnalysisDataGenerator(DataLoader.LoadSales());
            dataGenerator.Generate();
            e.Data = dataGenerator.Data;
        }
    }
}
