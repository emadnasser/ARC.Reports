using System;
using System.Web.UI;

public partial class Ribbon_OneLineMode : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack) {
            ASPxRibbon.OneLineMode = cbOneLineMode.Checked;
        }
        else {
            cbOneLineMode.Checked = ASPxRibbon.OneLineMode;
        }
    }
}
