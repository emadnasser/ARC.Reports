using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Summary_GroupFooter : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            string[] names = Enum.GetNames(typeof(GridViewGroupFooterMode));
            foreach(string name in names) {
                ddlGroupFooter.Items.Add(name);
            }
            ddlGroupFooter.Text = grid.Settings.ShowGroupFooter.ToString();
            grid.ExpandRow(1);
        }
    }
    protected void ddlGroupFooter_SelectedIndexChanged(object sender, EventArgs e) {
        GridViewGroupFooterMode mode = (GridViewGroupFooterMode)Enum.Parse(typeof(GridViewGroupFooterMode), ddlGroupFooter.Text);
        grid.Settings.ShowGroupFooter = mode;
    }

    protected void grid_CustomUnboundColumnData(object sender, ASPxGridViewColumnDataEventArgs e) {
        if(e.Column.FieldName == "Total") {
            decimal price = (decimal)e.GetListSourceFieldValue("UnitPrice");
            int quantity = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"));
            e.Value = price * quantity;
        }
    }
}
