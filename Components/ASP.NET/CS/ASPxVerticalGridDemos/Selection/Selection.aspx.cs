using System;

public partial class Records_Selection : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) { 
            VerticalGrid.DataBind();
            VerticalGrid.Selection.SelectRecord(1);
            VerticalGrid.Selection.SelectRecord(5);
        }
    }
}
