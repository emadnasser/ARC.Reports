using System;
using System.Web.UI;
using DevExpress.Web;
using System.Xml;

public partial class Menu_ScrollingPage : Page {
    const string sessionKey = "DXEnableScrolling";

    bool EnableSubMenuScrolling {
        get {
            if(Session[sessionKey] == null)
                Session[sessionKey] = true;
            return (bool)Session[sessionKey];
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        menu.EnableSubMenuScrolling = EnableSubMenuScrolling;
    }

    protected void menu_ItemDataBound(object sender, MenuItemEventArgs e) {
        IHierarchyData itemHierarchyData = (IHierarchyData)e.Item.DataItem;
        XmlElement element = (XmlElement)itemHierarchyData.Item;
        if(element.Attributes["Index"] == null)
            return;
        int imgIndex = int.Parse(element.Attributes["Index"].Value);
        e.Item.Image.SpriteProperties.CssClass = string.Format("componentImage_{0}", imgIndex);
    }
}
