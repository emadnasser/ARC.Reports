using System;
using System.Web.UI;
using DevExpress.Web;

public partial class TabControl_ClientSideAPI : Page {
    protected void Page_Load(object sender, EventArgs e) {
        cbTabs.Items.Clear();
        foreach(TabPage tabPage in PageControl.TabPages)
            cbTabs.Items.Add(new ListEditItem(tabPage.Text, tabPage.Name));
    }
}
