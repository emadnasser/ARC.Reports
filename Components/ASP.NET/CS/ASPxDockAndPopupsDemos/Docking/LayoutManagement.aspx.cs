using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Docking_LayoutManagement : Page {
    const string LayoutSessionKey = "1e38ba85-292e-494e-8f3e-5c8654a9dfef";

    protected void Page_Load(object sender, EventArgs e) {
    }

    protected void btnEditLayout_Click(object sender, EventArgs e) {
        Response.Redirect("~/Docking/LayoutManagement/EditLayout.aspx", true);
    }

    protected void dockManager_ClientLayout(object sender, ASPxClientLayoutArgs e) {
        if(e.LayoutMode == ClientLayoutMode.Loading)
            e.LayoutData = Session[LayoutSessionKey] as string;
    }
}
