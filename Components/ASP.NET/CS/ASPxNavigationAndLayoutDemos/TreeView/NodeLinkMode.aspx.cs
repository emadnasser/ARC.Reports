using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TreeView_NodeLinkMode : Page {
    protected void Page_Load(object sender, EventArgs e) {
        treeView1.ExpandAll();
        treeView2.ExpandAll();
        treeView1.SelectedNode = treeView1.Nodes[1];
    }
}
