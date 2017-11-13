using System;
using System.Web.UI;
using DevExpress.Web;
using System.Web.UI.WebControls;

public partial class Docking_ClientSideAPI : Page {
    protected void Page_Load(object sender, EventArgs e) {
        foreach(ASPxDockPanel panel in dockManager.Panels) {
            panel.Height = 100;
            panel.Width = 250;
            panel.Styles.Content.HorizontalAlign = HorizontalAlign.Center;
            panel.ShowFooter = true;
        }

        foreach(ASPxDockZone zone in dockManager.Zones) {
            zone.PanelSpacing = 11;
            zone.Width = 250;
            zone.Height = 385;
        }
    }
}
