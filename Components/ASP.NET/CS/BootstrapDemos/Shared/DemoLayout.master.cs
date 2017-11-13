using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Xml.Linq;
using DevExpress.Web.Bootstrap;
using DevExpress.Web;

public partial class DemoLayout : System.Web.UI.MasterPage {
    protected void Page_Load(object sender, EventArgs e) {
        Page.Header.DataBind();
        Brand.DataBind();

        FillThemes();
        FillResolutions();

        if(DemoUtils.CurrentResolution != Resolution.Default)
            BSDemoTree.NavigateUrlFormatString = "{0}?resolution=" + DemoUtils.CurrentResolution.ToString();
    }

    protected void BSDemoTree_DataBound(object sender, EventArgs e) {
        if(!IsPostBack)
            BSDemoTree.ExpandAll();
        BSDemoTree.SelectedNode = BSDemoTree.Nodes.FindAllRecursive(n => ResolveUrl(n.NavigateUrl).Equals(Request.Url.LocalPath, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
    }
    protected void BSDemoTree_NodeDataBound(object source, TreeViewNodeEventArgs e) {
        if(string.IsNullOrEmpty(e.Node.NavigateUrl))
            return;
        e.Node.NavigateUrl = ResolveUrl(e.Node.NavigateUrl);
    }

    protected void FillThemes() {
        XDocument xdoc = XDocument.Load(MapPath("~/App_Data/Themes.xml"));
        var themes = from theme in xdoc.Descendants("theme")
                     select new {
                         Name = theme.Attribute("Name").Value,
                         Text = theme.Attribute("Text").Value
                     };
        var currentTheme = DemoUtils.CurrentTheme;
        var item = TopMenu.Items.FindByName("Themes");
        foreach(var theme in themes) {
            var themeItem = item.Items.Add(theme.Text, theme.Name);
            themeItem.GroupName = "theme";
            if(theme.Name == currentTheme)
                themeItem.Checked = true;
        }
    }
    protected void FillResolutions() {
        var currentResolution = DemoUtils.CurrentResolution;
        var item = TopMenu.Items.FindByName("Resolution");
        item.ClientVisible = !DemoUtils.IsMobileDevice;
        foreach(Resolution resolution in Enum.GetValues(typeof(Resolution))) {
            var resolutionItem = new BootstrapMenuItem(DemoUtils.GetResolutionDescription(resolution), resolution.ToString());
            resolutionItem.GroupName = "resolution";
            item.Items.Insert(item.Items.Count - 1, resolutionItem);
            if(resolution == currentResolution)
                resolutionItem.Checked = true;
        }
    }
}
