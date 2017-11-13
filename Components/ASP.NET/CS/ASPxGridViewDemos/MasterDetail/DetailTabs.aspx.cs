using System;
using System.Web.UI;
using DevExpress.Web;

public partial class MasterDetail_DetailTabs : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsCallback && !IsPostBack) {
            grid.DataBind();
            grid.DetailRows.ExpandRow(2);
        }
    }
    protected void productsGrid_DataSelect(object sender, EventArgs e) {
        Session["SupplierID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
    }
    protected void categoriesGrid_DataSelect(object sender, EventArgs e) {
        Session["SupplierID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
    }
    protected void ordersGrid_DataSelect(object sender, EventArgs e) {
        Session["ProductID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
    }
    protected void ordersGrid_CustomUnboundColumnData(object sender,
                DevExpress.Web.ASPxGridViewColumnDataEventArgs e) {
        if(e.Column.FieldName == "Total") {
            int quantity = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"));
            decimal price = (decimal)e.GetListSourceFieldValue("UnitPrice");
            decimal discount = Convert.ToDecimal(e.GetListSourceFieldValue("Discount"));
            e.Value = price * quantity * (1 - discount);
        }
    }
}
