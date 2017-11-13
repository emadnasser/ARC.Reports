using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI;
using DevExpress.Web.ASPxTreeList;

public partial class Data_VirtualMode : Page {

    protected void treeList_VirtualModeCreateChildren(object sender, TreeListVirtualModeCreateChildrenEventArgs e) {
        string path = e.NodeObject == null ? Page.MapPath("~/") : e.NodeObject.ToString();

        List<string> children = new List<string>();
        if(Directory.Exists(path)) {
            foreach(string name in Directory.GetDirectories(path)) {
                if(!IsSystemName(name))
                    children.Add(name);
            }
            foreach(string name in Directory.GetFiles(path))
                if(!IsSystemName(name))
                    children.Add(name);
        }
        e.Children = children;
    }

    protected void treeList_VirtualModeNodeCreating(object sender, TreeListVirtualModeNodeCreatingEventArgs e) {
        string nodePath = e.NodeObject.ToString();
        e.NodeKeyValue = GetNodeGuid(nodePath);
        e.IsLeaf = !Directory.Exists(nodePath);
        e.SetNodeValue("name", Path.GetFileName(nodePath));
        e.SetNodeValue("date", Directory.GetCreationTime(nodePath));
    }

    Guid GetNodeGuid(string path) {
        if(!Map.ContainsKey(path))
            Map[path] = Guid.NewGuid();
        return Map[path];
    }
    Dictionary<string, Guid> Map {
        get {
            const string key = "DX_PATH_GUID_MAP";
            if(Session[key] == null)
                Session[key] = new Dictionary<string, Guid>();
            return Session[key] as Dictionary<string, Guid>;
        }
    }
    bool IsSystemName(string name) {
        name = Path.GetFileName(name).ToLower();
        return name.StartsWith("app_") || name == "bin"
            || name.EndsWith(".aspx.cs") || name.EndsWith(".aspx.vb");
    }

}
