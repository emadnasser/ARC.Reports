using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System.Linq;

public partial class ChampionsLeagueStatistics : DashboardBasePage {
    protected void OnMasterFilterDefaultValues(object sender, MasterFilterDefaultValuesWebEventArgs e) {
        if(e.ItemComponentName == "scatterChartLeagueStatistics") {
            DashboardDataRow selRow = e.AvailableFilterValues.FirstOrDefault(row => object.Equals(row[0], "Spain"));
            if(selRow != null)
                e.FilterValues = new[] { selRow };
        }
    }
}
