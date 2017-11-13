using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class TreeView_ClientSide : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e) {        
        treeView.DataBind();
        treeView.ExpandAll();
        ASPxTreeView tvNodes = ddNodes.FindControl("tvNodes") as ASPxTreeView;
        tvNodes.DataBind();
        tvNodes.ExpandAll();
        tvNodes.SelectedNode = tvNodes.Nodes[0];
        ddNodes.Text = tvNodes.SelectedNode.Text;
        ddNodes.KeyValue = tvNodes.SelectedNode.Name;
    }

}
