using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DashboardCommon;

namespace DashboardMainDemo.Dashboards {
    public partial class RevenueByIndustry : Dashboard {
        public RevenueByIndustry() {
            InitializeComponent();
        }

        private void RevenueByIndustry_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            e.Data = RevenueByIndustryDataHelper.Generate(DataLoader.LoadRevenueByIndustry());

        }
    }
}
