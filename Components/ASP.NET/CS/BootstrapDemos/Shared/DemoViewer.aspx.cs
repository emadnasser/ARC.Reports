using System;

public partial class DemoViewer : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(Request.QueryString["url"] == null)
            Response.Redirect("../");
        DataBind();
    }
}
