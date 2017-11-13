using System;
using System.Web.UI;
using System.Threading;

public partial class TreeView_EnableCallbacks : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            treeView.DataBind();
            treeView.Nodes[0].Expanded = true;
            treeView.Nodes[1].Expanded = true;
        }
        if(IsCallback) {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(1000); 
        }
    }
}
