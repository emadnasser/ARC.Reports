using System;
using System.Web.UI;
using DevExpress.Web;
using System.Xml;

public partial class TreeView_DataBinding : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            treeView.DataBind();
            treeView.ExpandToDepth(0);
        }
    }

    protected void treeView_NodeDataBound(object sender, TreeViewNodeEventArgs e) {
        XmlNode dataNode = ((e.Node.DataItem as IHierarchyData).Item as XmlNode);
        if(dataNode.Name == "class")
            e.Node.TextStyle.Font.Bold = true;
    }
}
