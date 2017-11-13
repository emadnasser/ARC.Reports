using System;

public partial class GroupingSorting_FixedGroups: System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            Grid.ExpandAll();
    }
}
