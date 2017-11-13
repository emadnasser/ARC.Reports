using System;
using System.Web.UI;
using DevExpress.Web;

public partial class TreeView_Features : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            treeView.ExpandToDepth(0);
        else {
            treeView.AllowSelectNode = cbAllowSelectNode.Checked;
            treeView.AutoPostBack = cbAutoPostBack.Checked;
            treeView.EnableAnimation = cbEnableAnimation.Checked;
            treeView.EnableHotTrack = cbEnableHotTrack.Checked;
            treeView.ShowTreeLines = cbShowTreeLines.Checked;
            treeView.ShowExpandButtons = cbShowExpandButtons.Checked;
            treeView.AllowCheckNodes = cbAllowCheckNodes.Checked;
            treeView.CheckNodesRecursive = cbCheckNodesRecursive.Checked;
        }
    }
    protected void CheckNodesRecursiveChanged(object sender, EventArgs e) {
        RefreshTreeView(treeView.RootNode);
    }
    protected void RefreshTreeView(TreeViewNode node) {
        node.Checked = false;
        node.Nodes.ForEach(RefreshTreeView);
    }
}
