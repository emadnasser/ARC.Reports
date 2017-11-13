using System;
using DevExpress.Web;
using System.Web.UI;

public partial class Summary_Group : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            grid.ExpandRow(1);
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
