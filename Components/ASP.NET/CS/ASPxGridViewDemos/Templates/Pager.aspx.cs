using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Templates_Pager : Page {
    const string PageSizeSessionKey = "ed5e843d-cff7-47a7-815e-832923f7fb09";

    protected int GridPageSize {
        get {
            if(Session[PageSizeSessionKey] == null)
                return Grid.SettingsPager.PageSize;
            return (int)Session[PageSizeSessionKey];
        }
        set { Session[PageSizeSessionKey] = value; }
    }

    protected void Page_Init(object sender, EventArgs e) {
        Grid.SettingsPager.PageSize = GridPageSize;
    }

    protected void Grid_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
        GridPageSize = int.Parse(e.Parameters);
        Grid.SettingsPager.PageSize = GridPageSize;
        Grid.DataBind();
    }

    protected void PagerCombo_Load(object sender, EventArgs e) {
        (sender as ASPxComboBox).Value = Grid.SettingsPager.PageSize;
    }
}
