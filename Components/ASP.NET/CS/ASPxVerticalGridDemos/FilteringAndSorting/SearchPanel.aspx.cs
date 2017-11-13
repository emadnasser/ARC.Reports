using System;
using DevExpress.Web.Demos;

public partial class Filtering_SearchPanel : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        VerticalGrid.Settings.HeaderAreaWidth = Utils.IsLargeTheme ? 210 : 150;
        if(!IsPostBack)
            VerticalGrid.SearchPanelFilter = "an";
    }
}
