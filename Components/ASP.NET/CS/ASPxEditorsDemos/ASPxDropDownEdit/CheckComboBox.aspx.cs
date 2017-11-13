using System;
using System.Web.UI;

public partial class ASPxDropDownEdit_CheckComboBox : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            ASPxDropDownEdit1.Text = "Chrome;Safari";
    }
}
