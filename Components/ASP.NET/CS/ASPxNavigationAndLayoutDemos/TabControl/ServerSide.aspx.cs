using System;
using System.Web.UI;
using DevExpress.Web.Demos;
using DevExpress.Web;
using DevExpress.CodeParser;
using DevExpress.Web.DemoUtils;
using System.Web.UI.WebControls;

public partial class TabControl_ServerSide : Page {
    protected const string CssCode =
        "div.SampleCSS span {\n" +
        "    font-size: 8pt;\n" +
        "    font-family: Verdana;\n" +
        "    font-weight: bold;\n" +
        "}";

    protected const string HtmlCode =
        "<div class=\"SampleCSS\">\n" +
        "    <span>Sample content</span>\n" +
        "</div>";

    TabPage CurrentTab {
        get {
            return ASPxPageControl1.TabPages.FindByName(ddlTabs.SelectedItem.Value.ToString());
        }
    }

    protected void Page_Init(object sender, EventArgs e) {
        CssCodeHolder.InnerHtml = CodeFormatter.GetFormattedCode(TokenLanguage.Css, CssCode);
        HtmlCodeHolder.InnerHtml =
            CodeFormatter.GetFormattedCode(TokenLanguage.Html, HtmlCode);
    }

    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/TabControl/CSS/ServerSide.css");
        if(!IsPostBack) {
            foreach(TabPage tabPage in ASPxPageControl1.TabPages)
                ddlTabs.Items.Add(new ListEditItem(tabPage.Text, tabPage.Name));
            ddlTabs.SelectedIndex = 0;
        }
        if(Utils.IsLargeTheme)
            ddlTabs.Width = Unit.Pixel(95);
        else
            ddlTabs.Width = Unit.Pixel(70);
    }

    protected void cbEnable_CheckedChanged(object sender, EventArgs e) {
        CurrentTab.Enabled = cbEnable.Checked;
        ddlTabs_SelectedIndexChanged(sender, e);
    }

    protected void cbVisible_CheckedChanged(object sender, EventArgs e) {
        CurrentTab.Visible = cbVisible.Checked;
        ddlTabs_SelectedIndexChanged(sender, e);
    }

    protected void cbActive_CheckedChanged(object sender, EventArgs e) {
        cbActive.Checked =  cbEnable.Checked && cbVisible.Checked;
        if(cbActive.Checked)
            ASPxPageControl1.ActiveTabPage = CurrentTab;
    }

    protected void ASPxPageControl1_ActiveTabChanged(object sender, TabControlEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "ActiveTabChanged");
        ddlTabs.Value = ASPxPageControl1.ActiveTabPage.Name;
        ddlTabs_SelectedIndexChanged(sender, e);
    }

    protected void ASPxPageControl1_ActiveTabChanging(object sender, 
        TabControlCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "ActiveTabChanging");
    }

    protected void ddlTabs_SelectedIndexChanged(object sender, EventArgs e) {
        cbEnable.Checked = CurrentTab.Enabled;
        cbVisible.Checked = CurrentTab.Visible;
        cbActive.Checked = CurrentTab.IsActive;
    }
}
