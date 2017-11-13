using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using DevExpress.Web;

public class DashboardBasePage : Page {
    static DashboardBasePage() {
        DevExpress.Utils.UrlAccessSecurityLevelSetting.SecurityLevel = DevExpress.Utils.UrlAccessSecurityLevel.FilesFromBaseDirectory;
    }
    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);

    }
    protected override void OnInit(EventArgs e) {
        base.OnInit(e);
        string dashboardName = GetType().BaseType.Name;
        if(!string.IsNullOrEmpty(dashboardName)) {
            Control phContent = Form.FindControl("ContentHolder");
            if(phContent != null) {
                HtmlGenericControl div = new HtmlGenericControl("div");
                ASPxHyperLink link = new ASPxHyperLink {
                    ForeColor = System.Drawing.Color.White,
                    Target = "_blank",
                    NavigateUrl = string.Format("~/FullScreenSamples/{0}.aspx", dashboardName)
                };
                link.Style.Add("text-decoration", "none");
                link.EnableTheming = false;
                HtmlGenericControl innerDiv = new HtmlGenericControl("b");
                innerDiv.Attributes.Add("class", "fullScreenLink");
                innerDiv.InnerText = "Full Screen View";
                link.Controls.Add(innerDiv);
                div.Controls.Add(link);
                phContent.Controls.AddAt(0, div);
            }
        }
    }
}
