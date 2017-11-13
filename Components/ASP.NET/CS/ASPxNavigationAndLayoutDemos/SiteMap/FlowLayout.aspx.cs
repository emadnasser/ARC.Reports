using System;
using System.Web.UI;

public partial class SiteMap_FlowLayout : Page {
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e) {
        ASPxSiteMapControl1.FlowLayoutMaximumDisplayItems =
            int.Parse(ddlFlowLayoutMaximumDisplayItems.SelectedItem.Value.ToString());
    }
}
