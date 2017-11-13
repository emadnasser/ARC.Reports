using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Filtering_HeaderFilter : Page {
    protected void Page_Load(object sender, EventArgs e) {
        GridHeaderFilterMode headerFilterMode = hFModeCheckBox.Checked ? GridHeaderFilterMode.CheckedList : GridHeaderFilterMode.List;
        foreach(CardViewColumn column in CardView.Columns)
            column.SettingsHeaderFilter.Mode = headerFilterMode;
    }
    protected void CardView_HeaderFilterFillItems(object sender, ASPxCardViewHeaderFilterEventArgs e) {
        if(e.Column.FieldName == "Total")
            PrepareTotalFilterItems(e);
        if(e.Column.FieldName == "Quantity")
            PrepareQuantityFilterItems(e);
    }
    protected virtual void PrepareTotalFilterItems(ASPxCardViewHeaderFilterEventArgs e) {
        e.Values.Clear();
        if(e.Column.SettingsHeaderFilter.Mode == GridHeaderFilterMode.List)
            e.AddShowAll();
        int step = 100;
        for(int i = 0; i < 10; i++) {
            double start = step * i;
            double end = start + step - 0.01;
            e.AddValue(string.Format("from {0:c} to {1:c}", start, end), "", string.Format("[Total] >= {0} and [Total] <= {1}", start, end));
        }
        e.AddValue(string.Format("> {0:c}", 1000), "", "[Total] > 1000");
    }
    protected virtual void PrepareQuantityFilterItems(ASPxCardViewHeaderFilterEventArgs e) {
        int max = 0;
        for(int i = 0; i < e.Values.Count; i++) {
            int value;
            if(!int.TryParse(e.Values[i].Value, out value)) continue;
            if(value > max) max = value;
        }
        e.Values.Clear();
        if(e.Column.SettingsHeaderFilter.Mode == GridHeaderFilterMode.List)
        e.AddShowAll();
        int step = 10;
        for(int i = 0; i < max / step + 1; i++) {
            int start = step * i;
            int end = start + step - 1;
            e.AddValue(string.Format("from {0} to {1}", start, end), "", string.Format("[Quantity] >= {0} and [Quantity] <= {1}", start, end));
        }   
    }
}
