using System;
using System.Web.UI;

public partial class Splitter_ContentUrl : Page {
    protected void Page_Load(object sender, EventArgs e) {
        ASPxSplitter1.GetPaneByName("ContentUrlPane").ContentUrl = 
            ASPxNavBar1.SelectedItem.NavigateUrl;
    }
}
