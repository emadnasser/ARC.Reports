<%@ Control Language="C#" %>
<script runat="server">
    
    protected void Page_Init(object sender, EventArgs e) {
        Page.Load += OwnerPage_Load;
    }
    protected void OwnerPage_Load(object sender, EventArgs e) {
        Page page = (sender as Control).Page;        
        Utils.RegisterCssLink(page, "~/Content/Site.css?v=" + Utils.GetVersionSuffix());
        Utils.RegisterCssLink(page, "~/Content/CodeFormatter.css");
    }
</script>
<script type="text/javascript" src="<%= Page.ResolveClientUrl("~/Scripts/Demo.js?v=") + Utils.GetVersionSuffix() %>"></script>
<style>
    @font-face
    {
        font-family: "arima madurai";
        src:url("<%= Page.ResolveClientUrl("~/Content/Fonts/CustomFont0.woff") %>?v=<%= Utils.GetVersionSuffix() %>") format('woff');
    }
    @font-face
    {
        font-family: "comfortaa";
        src:url("<%= Page.ResolveClientUrl("~/Content/Fonts/CustomFont1.woff") %>?v=<%= Utils.GetVersionSuffix() %>") format('woff');
    }
    @font-face
    {
        font-family: "asap";
        src:url("<%= Page.ResolveClientUrl("~/Content/Fonts/CustomFont2.woff") %>?v=<%= Utils.GetVersionSuffix() %>") format('woff');
    }
</style>
