using System;
using System.Web.UI;
using DevExpress.Web;

public partial class TabControl_Features : Page {
    TabAlign CurrentTabAlign {
        get {
            return (TabAlign)Enum.Parse(typeof(TabAlign),
                ddlTabAlign.SelectedItem.Value.ToString());
        }
    }

    TabPosition CurrentTabPosition {
        get { 
            return (TabPosition)Enum.Parse(typeof(TabPosition),
                ddlTabPosition.SelectedItem.Value.ToString());
        }
    }

    ActivateTabPageAction CurrentActivateTabPageAction {
        get {
            return (ActivateTabPageAction)Enum.Parse(typeof(ActivateTabPageAction),
                ddlActivateTabPageAction.SelectedItem.Value.ToString());
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            return;
        carTabPage.AutoPostBack = cbAutoPostBack.Checked;
        carTabPage.EnableHotTrack = cbEnableHotTrack.Checked;
        carTabPage.TabAlign = CurrentTabAlign;
        carTabPage.TabPosition = CurrentTabPosition;
        carTabPage.ActivateTabPageAction = CurrentActivateTabPageAction;
    }
}
