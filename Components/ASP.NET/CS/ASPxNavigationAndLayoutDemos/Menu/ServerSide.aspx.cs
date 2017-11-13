using System;
using System.Web.UI;
using DevExpress.Utils;
using DevExpress.Web;

public partial class Menu_ServerSide : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            ASPxMenu1.ShowPopOutImages = DefaultBoolean.False;
            FillItemsList(ddlItems, ASPxMenu1.Items, false);
            ddlItems.SelectedIndex = 0;
        }
    }

    void FillItemsList(ASPxComboBox dropDownList, MenuItemCollection items, bool isChild) {
        foreach(MenuItem item in items) {
            string itemText = (isChild ? " - " : "") + item.Text;
            dropDownList.Items.Add(new ListEditItem(itemText, item.Name));
            FillItemsList(dropDownList, item.Items, true);
        }
    }

    protected void ASPxMenu1_ItemClick(object sender, MenuItemEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "ItemClick");
        ddlItems.Value = ASPxMenu1.SelectedItem.Name;
        ddlItems_SelectedIndexChanged(sender, e);
    }

    protected void cbEnable_CheckedChanged(object sender, EventArgs e) {
        MenuItem item = ASPxMenu1.Items.FindByName(ddlItems.SelectedItem.Value.ToString());
        if(item != null) 
            item.Enabled = cbEnable.Checked;
    }

    protected void cbVisible_CheckedChanged(object sender, EventArgs e) {
        MenuItem item = ASPxMenu1.Items.FindByName(ddlItems.SelectedItem.Value.ToString());
        if(item != null) 
            item.Visible = cbVisible.Checked;
    }

    protected void cbSelect_CheckedChanged(object sender, EventArgs e) {
        MenuItem item = ASPxMenu1.Items.FindByName(ddlItems.SelectedItem.Value.ToString());
        if(item != null) 
            item.Selected = cbSelect.Checked;
    }

    protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e) {
        MenuItem item = ASPxMenu1.Items.FindByName(ddlItems.SelectedItem.Value.ToString());
        if(item != null) {
            cbEnable.Checked = item.Enabled;
            cbVisible.Checked = item.Visible;
            cbSelect.Checked = item.Selected;
        }
    }

}
