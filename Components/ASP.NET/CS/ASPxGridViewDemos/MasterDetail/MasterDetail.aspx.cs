using System;
using System.Web.UI;
using DevExpress.Web;

public partial class MasterDetail_MasterDetail : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            grid.DataBind();
            grid.DetailRows.ExpandRow(0);
        }
    }
    protected void detailGrid_DataSelect(object sender, EventArgs e) {
        Session["CustomerID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
    }
    protected void detailGrid_CustomUnboundColumnData(object sender, ASPxGridViewColumnDataEventArgs e) {
        if(e.Column.FieldName == "Total") {
            decimal price = (decimal)e.GetListSourceFieldValue("UnitPrice");
            int quantity = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"));
            e.Value = price * quantity;
        }
    }
    protected void chkSingleExpanded_CheckedChanged(object sender, EventArgs e) {
        grid.SettingsDetail.AllowOnlyOneMasterRowExpanded = chkSingleExpanded.Checked;
        if(grid.SettingsDetail.AllowOnlyOneMasterRowExpanded) {
            grid.DetailRows.CollapseAllRows();
        }
    }
}
