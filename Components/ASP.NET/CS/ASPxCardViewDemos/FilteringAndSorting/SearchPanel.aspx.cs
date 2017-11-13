using System;

public partial class Filtering_SearchPanel : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            CardView.SearchPanelFilter = "an";
    }
}
