using System;
using System.Collections.Generic;
using DevExpress.Web;

public partial class ASPxTokenBox_TokenBoxColumn : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            grid.StartEdit(2);
    }
}
