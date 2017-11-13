using System;
using System.Web.UI;

public partial class Ribbon_Features : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack) {
            ASPxRibbon.AllowMinimize = cbAllowMinimize.Checked;
            ASPxRibbon.ShowFileTab = cbShowFileTab.Checked;
            ASPxRibbon.ShowTabs = cbShowTabs.Checked;
            ASPxRibbon.ShowGroupLabels = cbShowGroupNames.Checked;
        }
        else {
            cbShowFileTab.Checked = ASPxRibbon.ShowFileTab;
            cbShowTabs.Checked = ASPxRibbon.ShowTabs;
            cbAllowMinimize.Checked = ASPxRibbon.AllowMinimize;
            cbShowGroupNames.Checked = ASPxRibbon.ShowGroupLabels;
        }
    }
}
