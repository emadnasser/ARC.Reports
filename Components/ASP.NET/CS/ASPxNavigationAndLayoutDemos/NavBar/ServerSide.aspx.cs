using System;
using DevExpress.Web;
using System.Web.UI;

public partial class NavBar_ServerSide : Page {
    const string EnabledImageUrl = "~/NavBar/Images/online.png";
    const string DisabledImageUrl = "~/NavBar/Images/offline.png";

    string SelectedItemName {
        get { return ddlItems.SelectedItem.Value.ToString(); }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if (IsPostBack)
            return;
        Random rand = new Random();
        foreach (NavBarGroup group in ASPxNavBar1.Groups) {
            ddlItems.Items.Add(new ListEditItem(group.Text, group.Name));
            FillItemsDropDownList(ddlItems, group.Items);
            ddlItems.SelectedIndex = 0;
            int index = rand.Next(group.Items.Count);
            ApplyFilter(group.Items[index].Name);
        }
    }

    protected void cbEnable_CheckedChanged(object sender, EventArgs e) {
        ApplyFilter(ddlItems.SelectedItem.Value.ToString());
    }

    protected void cbVisible_CheckedChanged(object sender, EventArgs e) {
        NavBarItem item = ASPxNavBar1.Items.FindByName(SelectedItemName);
        if (item != null) {
            item.Visible = cbVisible.Checked;
            return;
        }
        NavBarGroup group = ASPxNavBar1.Groups.FindByName(SelectedItemName);
        if (group != null)
            group.Visible = cbVisible.Checked;
    }

    protected void cbSelect_CheckedChanged(object sender, EventArgs e) {
        NavBarItem item = ASPxNavBar1.Items.FindByName(SelectedItemName);
        if (item != null) {
            item.Selected = cbSelect.Checked;
            return;
        }
        NavBarGroup group = ASPxNavBar1.Groups.FindByName(SelectedItemName);
        if (group != null)
            group.Expanded = cbSelect.Checked;
    }

    protected void ASPxNavBar1_HeaderClick(object sender, NavBarGroupCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "HeaderClick");
        ddlItems.Value = e.Group.Name;

        ChangeCheckBoxLabel();
        cbEnable.Checked = e.Group.Enabled;
        cbVisible.Checked = e.Group.Visible;
        cbSelect.Checked = !e.Group.Expanded;
    }

    protected void ASPxNavBar1_ExpandedChanging(object sender, NavBarGroupCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "ExpandedChanging");
    }

    protected void ASPxNavBar1_ExpandedChanged(object sender, NavBarGroupEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "ExpandedChanged");
    }

    protected void ASPxNavBar1_ItemClick(object sender, NavBarItemEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "ItemClick");
        ddlItems.Value = ASPxNavBar1.SelectedItem.Name;
        ddlItems_SelectedIndexChanged(sender, e);
    }

    protected void ddlItems_Load(object sender, EventArgs e) {
        ChangeCheckBoxLabel();
    }

    protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e) {
        ChangeCheckBoxLabel();
        NavBarItem item = ASPxNavBar1.Items.FindByName(SelectedItemName);
        if (item != null) {
            cbEnable.Checked = item.Enabled;
            cbVisible.Checked = item.Visible;
            cbSelect.Checked = item.Selected;
            return;
        }
        NavBarGroup group = ASPxNavBar1.Groups.FindByName(SelectedItemName);
        if (group != null) {
            cbEnable.Checked = group.Enabled;
            cbVisible.Checked = group.Visible;
            cbSelect.Checked = group.Expanded;
        }
    }

    void ApplyFilter(string value) {
        NavBarItem item = ASPxNavBar1.Items.FindByName(value);
        if (item != null) {
            item.Enabled = !item.Enabled;
            item.Image.Url = item.Enabled ? EnabledImageUrl : DisabledImageUrl;
            return;
        }
        NavBarGroup group = ASPxNavBar1.Groups.FindByName(value);
        if (group != null)
            group.Enabled = !group.Enabled;
        foreach (NavBarItem groupItem in group.Items) {
            groupItem.Image.Url = group.Enabled && groupItem.Enabled ?
                EnabledImageUrl : DisabledImageUrl;
        }
    }

    void ChangeCheckBoxLabel() {
        cbSelect.Text = ddlItems.SelectedItem.Text.Contains("-") ? "Selected" : "Expanded";
    }

    void FillItemsDropDownList(ASPxComboBox dropDownList, NavBarItemCollection items) {
        for (int i = 0; i < items.Count; i++) 
            dropDownList.Items.Add(new ListEditItem(" - " + items[i].Text, items[i].Name));
    }
}
