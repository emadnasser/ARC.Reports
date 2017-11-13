using DevExpress.DashboardCommon;
using System.Linq;

namespace DashboardMainDemo.Modules {
    public partial class ChampionsLeagueStatistics : DashboardTutorialControl {
        public ChampionsLeagueStatistics() {
            InitializeComponent();
        }

        protected override void SubscribeDashboardEvents() {
            DashboardViewer.MasterFilterDefaultValues += OnDashboardViewerMasterFilterDefaultValues;
        }

        void OnDashboardViewerMasterFilterDefaultValues(object sender, MasterFilterDefaultValuesEventArgs e) {
            if(e.ItemComponentName == "scatterChartLeagueStatistics") {
                DashboardDataRow selRow = e.AvailableFilterValues.FirstOrDefault(row => object.Equals(row[0], "Spain"));
                if (selRow != null)
                    e.FilterValues = new[] { selRow };
            }
        }
    }
}
