using System;
using System.Web.UI;

public partial class LayoutFeatures_CrossBandControls : Page {
    protected void Page_Init(object sender, EventArgs e) {
        Response.Redirect("~/ReportControls/CrossBand.aspx");
    }
}
