using System;
using System.Web.UI;
using System.Web;

public partial class TitleIndex_Grouping : Page {
    protected void Page_Load(object sender, EventArgs e) {
        string groupingField = HttpContext.Current.Request.QueryString["gfield"];
        int activeTabIndex = 1;
        if(!string.IsNullOrEmpty(groupingField))
            activeTabIndex = ASPxTabControl1.Tabs.IndexOfName(groupingField);
        if(activeTabIndex >= 1)
            ASPxTitleIndex1.GroupHeaderFormatString = "{0} ({1})";
        ASPxTabControl1.ActiveTabIndex = activeTabIndex > 0 ? activeTabIndex : 0;
        ASPxTitleIndex1.GroupingField = ASPxTabControl1.ActiveTab.Name;
    }
}
