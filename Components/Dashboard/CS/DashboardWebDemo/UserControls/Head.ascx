<%@ Control Language="C#" %>
<script runat="server">
    
    protected void Page_Init(object sender, EventArgs e) {
        Page.Load += OwnerPage_Load;
    }
    protected void OwnerPage_Load(object sender, EventArgs e) {
        Page page = (sender as Control).Page;        
        Utils.RegisterCssLink(page, "~/Content/Site.css");
        Utils.RegisterCssLink(page, "~/Content/DashboardSite.css");
        Utils.RegisterCssLink(page, "~/Content/CodeFormatter.css");
        if(Utils.IsIE6())
            Utils.RegisterCssLink(page, "~/Content/ie6.css");
    }
        
</script>
<script type="text/javascript" src="<%= Page.ResolveClientUrl("~/Scripts/Demo.js") %>"></script>
