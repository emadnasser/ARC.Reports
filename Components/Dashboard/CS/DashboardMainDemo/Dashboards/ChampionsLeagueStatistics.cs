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
    public partial class ChampionsLeagueStatistics : Dashboard {
        public ChampionsLeagueStatistics() {
            InitializeComponent();
        }
        void ChampionsLeagueStatistics_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            e.Data = ChampionsLeagueStatisticsDataHelper.Generate(DataLoader.LoadChampionsLeagueStatistics());
        }
    }
}
