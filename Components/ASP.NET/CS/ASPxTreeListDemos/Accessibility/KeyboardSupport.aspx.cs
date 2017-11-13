using System;
using System.Web.UI;

public partial class Accessibility_KeyboardSupport : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            treeList.DataBind();
            treeList.ExpandToLevel(2);
        }
    }
}
