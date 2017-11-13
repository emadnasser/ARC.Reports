using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Menu_ClientSideAPI : Page {
    protected void Page_Load(object sender, EventArgs e) {
        cbItems.Items.Clear();
        FillComboBox(cbItems, menu.Items);
        cbItems.SelectedIndex = 0;
    }
    void FillComboBox(ASPxComboBox comboBox, MenuItemCollection items) {
        for(int i = 0; i < items.Count; i++) {
            comboBox.Items.Add(items[i].Text, items[i].Name);
        }
    }
}
