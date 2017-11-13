using System;
using System.Web.UI;

public partial class ASPxButton_Features : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack)
            ASPxButton5.ClientEnabled = !ASPxButton4.Checked;
    }
}
