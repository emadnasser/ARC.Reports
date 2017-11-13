using System;
using DevExpress.Web;
using System.Web.UI;
using DevExpress.Web.Demos;

public partial class NavBar_ClientSideAPI : Page {
    protected void Page_Load(object sender, EventArgs e) {
        FillGroupsDropDownList(cbGroups, NavBar.Groups);
        cbGroups.SelectedIndex = 0;
        cbItems.SelectedIndex = 0;
    }

    void FillGroupsDropDownList(ASPxComboBox comboBox, NavBarGroupCollection groups) {
        comboBox.Items.Clear();
        for(int i = 0; i < groups.Count; i++)
            comboBox.Items.Add(new ListEditItem(groups[i].Text, groups[i].Name));
    }
}
