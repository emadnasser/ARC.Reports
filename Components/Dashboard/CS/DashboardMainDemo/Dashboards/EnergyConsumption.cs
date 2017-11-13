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
    public partial class EnergyConsumption : Dashboard {
        public EnergyConsumption() {
            InitializeComponent();
        }

        private void EnergyConsumption_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            if(e.DataSource == dsConsumptionTotal)
                e.Data = EnergyConsumptionDataHelper.GenerateTotal(DataLoader.LoadEnergyConsumptionTotal());
            else if(e.DataSource == dsConsumptionBySector)
                e.Data = EnergyConsumptionDataHelper.GenerateBySector(DataLoader.LoadEnergyConsumptionBySector());
        }
    }
}
