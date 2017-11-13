using System.Linq;
using System.Web.UI;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;

public partial class ChampionsLeagueStatistics : Page {
    protected void OnMasterFilterDefaultValues(object sender, MasterFilterDefaultValuesWebEventArgs e) {
        if(e.ItemComponentName == "scatterChartLeagueStatistics") {
            DashboardDataRow selRow = e.AvailableFilterValues.FirstOrDefault(row => object.Equals(row[0], "Spain"));
            if(selRow != null)
                e.FilterValues = new[] { selRow };
        }
    }
}
