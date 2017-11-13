<%@ Control Language="C#" %>
<script runat="server">
    public string MainMessage { get; set; }
    public string Details { get; set; }
    protected void Page_Load(object sender, EventArgs e)     {
        if (DemosModel.Instance.DemoProducts.Count <= 1) {
            dvProductsLinks.Visible = false;
            return;
        }
        dvProductsLinks.DataSource = DemosModel.Instance.DemoProducts.Where(product => !product.IsRootDemo).OrderBy(product => product.NavItemTitle)
            .Select(product => new { Title = product.NavItemTitle, NavigateUrl = Utils.GenerateDemoUrl(product.Intro) });
        dvProductsLinks.DataBind();        
    }
</script>
<div class="ErrorContainer">
    <div class="MainMessage">
        <%= MainMessage %></div>
    <div class="Details">
        <%= Details %></div>
    <div>
        <dx:ASPxDataView runat="server" ID="dvProductsLinks" CssClass="ProductsView" EnableTheming="False"
            AllowPaging="False" SettingsTableLayout-ColumnCount="3" ItemSpacing="0px">
            <PagerSettings Visible="False">
            </PagerSettings>
            <ItemTemplate>
                <a href="<%# ResolveClientUrl((string)Eval("NavigateUrl")) %>">
                    <%# Eval("Title")%></a>
            </ItemTemplate>
            <ItemStyle CssClass="Product" />
            <EmptyItemStyle CssClass="EmptyProduct" />
        </dx:ASPxDataView>
    </div>
</div>
