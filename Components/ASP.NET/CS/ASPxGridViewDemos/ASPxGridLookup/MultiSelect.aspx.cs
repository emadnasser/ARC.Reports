using System;
using System.Web.UI;

public partial class ASPxGridLookup_MultiSelect : Page {
    protected void Page_Load(object sender, EventArgs e) {
        GridLookup.GridView.Width = GridLookup.Width;
    }
}
