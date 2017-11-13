using System;
using System.Web.UI;

public partial class Root : System.Web.UI.MasterPage {
    protected void Page_Init(object sender, EventArgs e) {
        var pageNameScript = string.Format("<script type='text/javascript'>DevAVPageName = '{0}';</script>", PageName);
        Page.Header.Controls.AddAt(0, new LiteralControl(pageNameScript));
    }

    protected string PageName { 
        get {
            var page = Page as BasePage;
            return page != null ? page.PageName : string.Empty;
        }
    }
}
