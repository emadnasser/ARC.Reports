using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.Demos;

public partial class Accessibility_RightToLeft : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            grid.StartEdit(2);
    }
}
