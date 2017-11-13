using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.Demos;

public partial class Splitter_PaneAutoSizing : Page {
    const string htmlLocation = "~/App_Data/Html";
    public string GetHtml() {
        string htmlFileName = string.IsNullOrEmpty(ASPxTreeView1.SelectedNode.Name) ? "Articles.html" : ASPxTreeView1.SelectedNode.Name + ".html";
        string resolvedPath = MapPath(Path.Combine(htmlLocation, htmlFileName));
        return File.ReadAllText(resolvedPath);
    }

    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Splitter/CSS/PaneAutoSizing.css");
        if(!IsCallback) {
            ASPxTreeView1.SelectedNode = ASPxTreeView1.Nodes[0].Nodes[0];
        }
    }
}
