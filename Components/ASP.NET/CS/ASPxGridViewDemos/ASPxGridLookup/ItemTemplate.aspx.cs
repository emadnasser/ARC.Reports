using System;
using System.Web.UI;
using DevExpress.Web;

public partial class ASPxGridLookup_ItemTemplate : Page {
    protected void Page_Init(object sender, EventArgs e) {
        GridLookup.GridView.Width = 300;
        GridLookup.GridView.DataBound += GridView_DataBound;
        GridLookup.GridView.BeforeGetCallbackResult += GridView_BeforeGetCallbackResult;
    }
    protected void GridView_DataBound(object sender, EventArgs e) {
        GridLookup.GridView.Settings.VerticalScrollBarMode = GridLookup.GridView.VisibleRowCount <= 2 ? ScrollBarMode.Hidden : ScrollBarMode.Visible;
    }

    void GridView_BeforeGetCallbackResult(object sender, EventArgs e) {
        GridLookup.GridView.DataBind();
    }
}
