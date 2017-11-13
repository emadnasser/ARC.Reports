using DevExpress.Web;
using DevExpress.Web.Bootstrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridView_MasterDetail : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            GridView1.DataBind();
            GridView1.DetailRows.ExpandRow(0);
        }
    }
    protected void detailGrid_DataSelect(object sender, EventArgs e) {
        Session["CustomerID"] = (sender as BootstrapGridView).GetMasterRowKeyValue();
    }
    protected void detailGrid_CustomUnboundColumnData(object sender, ASPxGridViewColumnDataEventArgs e) {
        if(e.Column.FieldName == "Total") {
            decimal price = (decimal)e.GetListSourceFieldValue("UnitPrice");
            int quantity = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"));
            e.Value = price * quantity;
        }
    }
}
