<%@ Control Language="C#" %>
<script runat="server">
              
    protected void Page_Load(object sender, EventArgs e) {
        dvProducts.DataSource = Utils.GenerateProductDemos(false);
        dvProducts.DataBind();
        rpLargeProducts.DataSource = Utils.GenerateProductDemos(true);
        rpLargeProducts.DataBind();
    }
</script>
<div class="ProductsView Large">
    <asp:Repeater runat="server" ID="rpLargeProducts">
        <ItemTemplate>
            <div class="Product">
                <h3>
                    <a href="<%# ResolveClientUrl((string)Eval("NavigateUrl")) %>"><%# Eval("Title") %></a>
                </h3>
                <div class="SmallScreenshotShadow">
                    <a href="<%# ResolveClientUrl((string)Eval("NavigateUrl")) %>">
                        <img src="<%# ResolveClientUrl((string)Eval("ImageUrl")) %>" alt="<%# Eval("Title") %>" /></a>
                </div>
                <div class="Description">
                    <%# Eval("Description") %>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
<dx:ASPxDataView runat="server" ID="dvProducts" CssClass="ProductsView Small" ItemSpacing="24px"
    EnableTheming="false" AllowPaging="False" SettingsTableLayout-ColumnCount="4" Width="910px">
    <itemtemplate>
            <div class="ProductWrapper">
                    <h3>
                        <a href="<%# ResolveClientUrl((string)Eval("NavigateUrl")) %>"><%# Eval("Title") %></a>
                    </h3>
                <div class="SmallScreenshotShadow">
                    <a href="<%# ResolveClientUrl((string)Eval("NavigateUrl")) %>">
                        <img src="<%# ResolveClientUrl((string)Eval("ImageUrl")) %>" alt="<%# Eval("Title") %>" /></a>
                </div>
                <a href="<%# ResolveClientUrl((string)Eval("NavigateUrl")) %>"><%# Eval("Description") %></a>
            </div>
        </itemtemplate>
    <itemstyle cssclass="Product" HorizontalAlign="Center" VerticalAlign="Bottom" width="255px" />
</dx:ASPxDataView>
