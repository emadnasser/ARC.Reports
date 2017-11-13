using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using System.Drawing;

public partial class Docking_ForbiddenZones : Page {
    protected void Page_Load(object sender, EventArgs e) {
        foreach(ASPxDockPanel panel in ASPxDockManager.Panels) {
            panel.ShowCloseButton = false;
            panel.Height = 230;
            panel.Width = 240;
            panel.Styles.Content.HorizontalAlign = HorizontalAlign.Center;
            panel.Styles.Content.Paddings.PaddingLeft = 31;
            panel.Styles.Content.Paddings.PaddingRight = 31;
            panel.Styles.Content.Paddings.PaddingTop = 24;
        }

        foreach(ASPxDockZone zone in ASPxDockManager.Zones) {
            zone.BackColor = ColorTranslator.FromHtml("#F4F4F4");
            zone.Border.BorderColor = ColorTranslator.FromHtml("#D9D9D9");
            zone.Border.BorderStyle = BorderStyle.Solid;
            zone.Border.BorderWidth = 1;
            zone.Paddings.Padding = 3;
        }
    }
}
