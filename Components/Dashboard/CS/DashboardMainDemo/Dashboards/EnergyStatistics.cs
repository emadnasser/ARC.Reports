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
    public partial class EnergyStatistics : Dashboard {
        public EnergyStatistics() {
            InitializeComponent();
        }
        void EuroEnergyStatistics_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            e.Data = EnergyStaticticsDataHelper.Generate(DataLoader.LoadEuroEnergyStatistics());
        }
    }
}
