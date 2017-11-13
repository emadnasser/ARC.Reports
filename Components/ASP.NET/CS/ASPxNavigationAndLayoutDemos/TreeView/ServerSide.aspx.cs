using System;
using System.Web.UI;
using DevExpress.Web;

public partial class TreeView_ServerSide : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            FillNodesComboBox(treeView.Nodes);
            cbNodes.SelectedIndex = 0;
            InitializePropertiesEditors();
        }
    }

    protected void FillNodesComboBox(TreeViewNodeCollection nodes) {
        foreach (TreeViewNode node in nodes) {
            string itemText = node.Nodes.Count > 0 ? node.Text : '-' + node.Text;
            cbNodes.Items.Add(new ListEditItem(itemText, node.Name));
            if (node.Nodes.Count > 0)
                FillNodesComboBox(node.Nodes);
        }
    }

    protected TreeViewNode GetCurrentNode() {
        return treeView.Nodes.FindByName(cbNodes.SelectedItem.Value.ToString());
    }

    protected void cbNodes_SelectedIndexChanged(object sender, EventArgs e) {
        InitializePropertiesEditors();
    }

    private void InitializePropertiesEditors() {
        TreeViewNode node = GetCurrentNode();
        chbEnabled.Checked = node.Enabled;
        chbVisible.Checked = node.Visible;
        chbSelected.Checked = treeView.SelectedNode == node;
        chbChecked.Checked = node.Checked;
        chbChecked.Enabled = node.AllowCheck;
        chbExpanded.Checked = node.Expanded;
        chbExpanded.Enabled = node.Nodes.Count > 0;
    }

    protected void chbEnabled_CheckedChanged(object sender, EventArgs e) {
        GetCurrentNode().Enabled = chbEnabled.Checked;
    }

    protected void chbVisible_CheckedChanged(object sender, EventArgs e) {
        GetCurrentNode().Visible = chbVisible.Checked;
    }

    protected void chbSelected_CheckedChanged(object sender, EventArgs e) {
        TreeViewNode node = chbSelected.Checked ? GetCurrentNode() : null;
        treeView.SelectedNode = node;
    }

    protected void chbChecked_CheckedChanged(object sender, EventArgs e) {
        GetCurrentNode().Checked = chbChecked.Checked;
    }

    protected void chbExpanded_CheckedChanged(object sender, EventArgs e) {
        GetCurrentNode().Expanded = chbExpanded.Checked;
    }

    protected void treeView_NodeClick(object sender, TreeViewNodeEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "NodeClick");
        cbNodes.Value = e.Node.Name;
        InitializePropertiesEditors();
    }

    protected void treeView_ExpandedChanged(object sender, TreeViewNodeEventArgs e) {
        if (e.Node == GetCurrentNode())
            chbExpanded.Checked = e.Node.Expanded;
        EventMonitor.TraceEvent(sender, e, "ExpandedChanged");
    }

    protected void treeView_ExpandedChanging(object sender, TreeViewNodeCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "ExpandedChanging");
    }

    protected void treeView_CheckedChanged(object sender, TreeViewNodeEventArgs e) {
        if (e.Node == GetCurrentNode())
            chbChecked.Checked = e.Node.Checked;
        EventMonitor.TraceEvent(sender, e, "CheckedChanged");
    }
}
