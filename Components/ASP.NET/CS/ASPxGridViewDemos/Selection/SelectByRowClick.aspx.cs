using System;
using System.Web.UI;

public partial class Selection_SelectByRowClick : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            grid.DataBind();
            for(int i = 0; i < 6; i++)
                grid.Selection.SelectRow(i);
        }
    }

}
