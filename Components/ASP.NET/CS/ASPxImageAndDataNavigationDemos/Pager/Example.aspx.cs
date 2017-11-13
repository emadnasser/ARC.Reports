using System;
using DevExpress.Web;
using System.Web.UI;

public partial class Pager_Example : Page {
    protected void Page_Load(object sender, EventArgs e) {
        RegisterRequiresControlState(ASPxPager1);
    }
    protected void ASPxPager1_PageIndexChanged(object sender, EventArgs e) {
        MultiView1.ActiveViewIndex = (sender as ASPxPager).PageIndex;
    }
}
