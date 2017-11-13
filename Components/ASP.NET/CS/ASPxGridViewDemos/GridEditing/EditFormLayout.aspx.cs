using System;
using System.Collections.Specialized;
using DevExpress.Web;
using DevExpress.Web.Data;

public partial class GridEditing_EditFormLayout : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack)
            grid.StartEdit(2);
    }
}
