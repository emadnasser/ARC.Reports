using System;
using System.Web.UI;
using DevExpress.Web;
using System.Web;

public partial class SiteMap_DataBinding : Page {
    string CurrentSiteMapProvider {
        get { return ddlSiteMapProvider.SelectedItem.Value.ToString(); }
    }

    string CurrentStartingNodeUrl {
        get { return ddlStartingNodeUrl.SelectedItem.Value.ToString(); }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack || ASPxSiteMapDataSource1.SiteMapProvider != CurrentSiteMapProvider) {
            ASPxSiteMapDataSource1.SiteMapProvider = CurrentSiteMapProvider;
            ddlStartingNodeUrl.Items.Clear();
            ddlStartingNodeUrl.Items.Add(new ListEditItem(" ", ""));
            ddlStartingNodeUrl.SelectedIndex = 0;
            foreach(SiteMapNode node in ASPxSiteMapDataSource1.Provider.RootNode.ChildNodes)
                ddlStartingNodeUrl.Items.Add(new ListEditItem(node.Title, node.Url));
        }
        ASPxSiteMapDataSource1.StartingNodeUrl = CurrentStartingNodeUrl;
        ASPxSiteMapDataSource1.ShowStartingNode = cbShowStartingNode.Checked;
    }
}
