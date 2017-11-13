using System;
using DevExpress.Web;
using System.Web;
using System.Web.UI;
using DevExpress.Web.Demos;

public partial class Menu_DataBinding : Page {
    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Menu/CSS/WorldCupImages.css");
    }

    protected void ASPxMenu1_ItemDataBound(object sender, MenuItemEventArgs e) {
        SiteMapNode node = e.Item.DataItem as SiteMapNode;
        if(node != null) {
            if(!string.IsNullOrEmpty(node["SpriteImage"]))
                e.Item.Image.SpriteProperties.CssClass = node["SpriteImage"];
            if(!string.IsNullOrEmpty(node["result"]))
                e.Item.Text = "<b>" + node["result"] + "</b> " + e.Item.Text;
        }
    }
}
