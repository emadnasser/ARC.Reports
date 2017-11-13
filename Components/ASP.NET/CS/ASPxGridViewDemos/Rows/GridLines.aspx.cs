using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Rows_GridLines : Page {

    protected void ddlGridLines_SelectedIndexChanged(object sender, EventArgs e) {
        grid.Settings.GridLines = (GridLines)Enum.Parse(typeof(GridLines), ddlGridLines.Text, true);
    }
}
