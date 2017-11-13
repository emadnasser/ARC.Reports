using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using System.IO;

public partial class TreeView_VirtualMode : Page {
    internal static System.Text.RegularExpressions.Regex DotsPathRegex = new System.Text.RegularExpressions.Regex(@"^[\.]+$");

    const string FileImageUrl = "~/TreeView/Images/FileSystem/file.png";
    const string DirImageUrl = "~/TreeView/Images/FileSystem/directory.png";

    protected void treeView_VirtualModeCreateChildren(object sender,
        TreeViewVirtualModeCreateChildrenEventArgs e) {
        string parentNodePath = string.IsNullOrEmpty(e.NodeName) ?
            Page.MapPath("~/") : e.NodeName;

        if(DotsPathRegex.IsMatch(parentNodePath)) //page relative path is not allowed
            return;

        List<TreeViewVirtualNode> children = new List<TreeViewVirtualNode>();
        if(Directory.Exists(parentNodePath)) {
            PopulateChildNodes(Directory.GetDirectories(parentNodePath), false, 
                DirImageUrl, children);
            PopulateChildNodes(Directory.GetFiles(parentNodePath), true,
                FileImageUrl, children);
        }
        e.Children = children;
    }

    void PopulateChildNodes(string[] paths, bool isLeaf, string imageUrl, 
        List<TreeViewVirtualNode> children) {
        foreach(string childPath in paths) {
            string childFileName = Path.GetFileName(childPath);
            if(IsSystemName(childFileName))
                continue;
            TreeViewVirtualNode childNode = new TreeViewVirtualNode(childPath, childFileName);
            childNode.IsLeaf = isLeaf;
            childNode.Image.Url = imageUrl;
            children.Add(childNode);
        }
    }

    bool IsSystemName(string name) {
        name = name.ToLower();
        return name.StartsWith("app_") || name == "bin"
            || name.EndsWith(".aspx.cs") || name.EndsWith(".aspx.vb");
    }
}
