using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Features_ClearButton : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!Page.IsPostBack) {
            ComboBox.DataBind();
            ComboBox.SelectedItem = ComboBox.Items.FindByText("C#");
        }
    }
}
