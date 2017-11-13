using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class GridView_Selection : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        selectAllMode.DataSource = Enum.GetValues(typeof(GridViewSelectAllCheckBoxMode));
        selectAllMode.DataBind();
        if(!IsPostBack)
            selectAllMode.Value = ((GridViewCommandColumn)GridView2.Columns[0]).SelectAllCheckboxMode;
    }
    protected void SelectAllMode_SelectedIndexChanged(object sender, EventArgs e) {
        GridViewSelectAllCheckBoxMode selectAllCheckboxMode = (GridViewSelectAllCheckBoxMode)Enum.Parse(typeof(GridViewSelectAllCheckBoxMode), selectAllMode.Text);
        ((GridViewCommandColumn)GridView2.Columns[0]).SelectAllCheckboxMode = selectAllCheckboxMode;
    }

    protected void GridView4_CustomJSProperties(object sender, ASPxGridViewClientJSPropertiesEventArgs e) {
        e.Properties["cpVisibleRowCount"] = GridView4.VisibleRowCount;
    }
}
