using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Splitter_ControlsResizing : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(ASPxWebControl.GlobalTheme.Contains("Metropolis"))
            ASPxSplitter1.Styles.Pane.CssClass = "metropolisPane";
        else if(ASPxWebControl.GlobalTheme.Contains("Youthful"))
            ASPxSplitter1.Styles.Pane.CssClass = "youthfulPane";
        else
            ASPxSplitter1.Styles.Pane.CssClass = string.Empty;
    }
}
