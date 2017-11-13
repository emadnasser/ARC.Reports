using System;

public partial class Accessibility_RightToLeft : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            NewsGroupDataProvider.Restore();
            this.treeList.DataBind();
            this.treeList.ExpandAll();
            this.treeList.StartEdit("2");
        }
    }
}
