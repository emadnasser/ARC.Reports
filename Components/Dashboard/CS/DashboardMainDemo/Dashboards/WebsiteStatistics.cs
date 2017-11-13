using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;

namespace DashboardMainDemo.Dashboards {
    public partial class WebsiteStatistics : Dashboard {
        public WebsiteStatistics() {
            InitializeComponent();
        }
        void WebsiteStatistics_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            WebsiteStatisticsDataGenerator data = new WebsiteStatisticsDataGenerator();
            e.Data = data.WebsiteStatistics;
        }
    }
}
