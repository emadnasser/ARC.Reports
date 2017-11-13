using System;
using System.Web.UI;

public partial class Menu_Scrolling : Page {    
    protected void Page_Load(object sender, EventArgs e) {
        // Store in Session for use in ScrollingPage.aspx
        Session["DXEnableScrolling"] = enableScrolling.Checked;
    }
}
