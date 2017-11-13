using System;
using System.Web.UI;
using System.Linq;
using DevExpress.Web;

public partial class Filtering_HeaderFilter : Page {
    protected void Page_Load(object sender, EventArgs e) {
        GridHeaderFilterMode headerFilterMode = hFModeCheckBox.Checked ? GridHeaderFilterMode.CheckedList : GridHeaderFilterMode.List;
        foreach(VerticalGridDataRow row in VerticalGrid.DataRows)
            row.SettingsHeaderFilter.Mode = headerFilterMode;
    }
    protected void VerticalGrid_HeaderFilterFillItems(object sender, ASPxVerticalGridHeaderFilterEventArgs e) {
        if(e.Row.FieldName == "Price")
            PreparePriceFilterItems(e);
        if(e.Row.FieldName == "HouseSize")
            PrepareHouseSizeFilterItems(e);
    }
    protected void PreparePriceFilterItems(ASPxVerticalGridHeaderFilterEventArgs e) {
        e.Values.Clear();
        if(e.Row.SettingsHeaderFilter.Mode == GridHeaderFilterMode.List)
            e.AddShowAll();
        int step = 500000;
        for(int i = 0; i < 4; i++) {
            double start = step * i;
            double end = start + step - 1;
            e.AddValue(string.Format("from {0:c0} to {1:c0}", start, end), "", string.Format("[Price] >= {0} and [Price] <= {1}", start, end));
        }
        e.AddValue(string.Format("> {0:c}", 2000000), "", "[Price] > 2000000");
    }
    protected void PrepareHouseSizeFilterItems(ASPxVerticalGridHeaderFilterEventArgs e) {
        e.Values.Clear();
        if(e.Row.SettingsHeaderFilter.Mode == GridHeaderFilterMode.List)
            e.AddShowAll();
        int step = 5000;
        for(int i = 0; i < 2; i++) {
            double start = step * i;
            double end = start + step - 1;
            e.AddValue(string.Format("from {0} to {1}", start, end), "", string.Format("[HouseSize] >= {0} and [HouseSize] <= {1}", start, end));
        }
        e.AddValue("> 10000", "", "[HouseSize] > 10000");
    }
}
