using System;
using System.Web.UI;

public partial class GridEditing_TwoWayBinding : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            grid.StartEdit(2);
        }
    }
}
