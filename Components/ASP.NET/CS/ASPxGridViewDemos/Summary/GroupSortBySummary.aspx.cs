using System;
using System.Web.UI;
using DevExpress.Data;
using DevExpress.Web;

public partial class Summary_SoryBySummary : Page {

    protected void Page_Load(object sender, EventArgs e) {
        grid.GroupSummarySortInfo.Clear();
        if(ddlGroupSummary.SelectedIndex > 0) {
            ColumnSortOrder sortOrder = ddlGroupSummary.SelectedIndex == 1 ? ColumnSortOrder.Ascending : ColumnSortOrder.Descending;
            grid.GroupSummarySortInfo.AddRange(new ASPxGroupSummarySortInfo("Country", grid.GroupSummary["Total"], sortOrder));
        }
    }
    protected void grid_CustomUnboundColumnData(object sender, ASPxGridViewColumnDataEventArgs e) {
        if(e.Column.FieldName == "Total") {
            decimal price = (decimal)e.GetListSourceFieldValue("UnitPrice");
            int quantity = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"));
            e.Value = price * quantity;
        }
    }
}
