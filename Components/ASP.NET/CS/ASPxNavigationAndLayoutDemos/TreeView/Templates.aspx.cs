using System;
using System.Web.UI;

public partial class TreeView_Templates : Page {
    protected void Page_Load(object sender, EventArgs e) {
        treeView.ExpandAll();
    }
}
