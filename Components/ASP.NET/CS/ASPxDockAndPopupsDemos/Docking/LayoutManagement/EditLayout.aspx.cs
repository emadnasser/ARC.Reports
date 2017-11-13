using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Docking_LayoutManagement_EditLayout : Page {
    const string LayoutSessionKey = "1e38ba85-292e-494e-8f3e-5c8654a9dfef";
    bool saveLayout = false;

    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnRestore_Click(object sender, EventArgs e) {
        this.dockManager.ResetLayoutToInitial();
    }

    protected void dockManager_ClientLayout(object sender, DevExpress.Web.ASPxClientLayoutArgs e) {
        if(e.LayoutMode == ClientLayoutMode.Saving && this.saveLayout) 
            Session[LayoutSessionKey] = e.LayoutData;
        if(e.LayoutMode == ClientLayoutMode.Loading)
            e.LayoutData = Session[LayoutSessionKey] as string;
    }

    protected void btnCancel_Click(object sender, EventArgs e) {
        Response.Redirect("~/Docking/LayoutManagement.aspx", true);
    }

    protected void btnSave_Click(object sender, EventArgs e) {
        this.saveLayout = true;
        Response.Redirect("~/Docking/LayoutManagement.aspx", false);
    }
}
