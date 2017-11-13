using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Threading;

public partial class MSAjax_UpdatePanel : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack)
            Thread.Sleep(1500);
    }

    protected void grid_CustomUnboundColumnData(object sender, DevExpress.Web.ASPxGridViewColumnDataEventArgs e) {
        if(e.Column.FieldName == "Total") {
            decimal price = (decimal)e.GetListSourceFieldValue("UnitPrice");
            int quantity = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"));
            e.Value = price * quantity;
        }
    }
    protected void cbCountry_SelectedIndexChanged(object sender, EventArgs e) {
        Session["Country"] = (string)cbCountry.SelectedValue;
        grid.Selection.UnselectAll();
        grid.PageIndex = 0;
        grid.DataBind();
    }
    protected void cbYear_SelectedIndexChanged(object sender, EventArgs e) {
        int year = 1995;
        Session["AllYears"] = !int.TryParse((string)cbYear.SelectedValue, out year);
        Session["Year"] = year;
        grid.Selection.UnselectAll();
        grid.PageIndex = 0;
        grid.DataBind();
    }
    public string GetSelectedAmount() {
        double result = 0;
        List<object> totals = grid.GetSelectedFieldValues("Total");
        for(int i = 0; i < totals.Count; i++) {
            if(totals[i] == null || totals[i] == DBNull.Value) continue;
            result += (double)totals[i];
        }
        return string.Format("{0:c}", result);
    }
}
