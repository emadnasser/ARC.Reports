using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Docking_ClientSideEvents : Page {
    protected void Page_Load(object sender, EventArgs e) {
       foreach(ASPxDockPanel panel in DockManager.Panels) {
           panel.Height = 200;
           panel.Styles.Content.Paddings.PaddingTop = 13;
           panel.Styles.Content.Paddings.PaddingBottom = 0;
           panel.Styles.Content.Paddings.PaddingLeft = 13;
           panel.Styles.Content.Paddings.PaddingRight = 13;
       }
    }
}
