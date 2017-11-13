<%@ Control Language="C#" ClassName="FullScreenHyperLink" %>
<script runat="server">
    public string NavigateUrl  { get; set; }
    public bool FullScreenModeOnly { get; set; }
    protected void Page_Load(object sender, EventArgs e) {
        hlFullscreen.NavigateUrl = NavigateUrl;
        
        hlQrcode.Attributes["href"] = NavigateUrl;
        hlQrcodeFS.Attributes["href"] = NavigateUrl;
        imgQrcode.Attributes["src"] =  FullScreenModeUtils.GetQRCodeImageUrl(Page, NavigateUrl);
        imgQrcodeFS.Attributes["src"] = FullScreenModeUtils.GetQRCodeImageUrl(Page, NavigateUrl);
        rptResolutions.DataSource = FullScreenModeUtils.Resolutions;
        rptResolutions.DataBind();
    }
    public string GetResolutionUrl(object dataItem) {
        FullScreenModeResolution resolution = (FullScreenModeResolution)dataItem;
        return FullScreenModeUtils.GetUrl(Page, NavigateUrl, resolution.Width, resolution.Height);
    }
    public string GetResolutionImageUrl(object dataItem) {
        FullScreenModeResolution resolution = (FullScreenModeResolution)dataItem;
        return string.Format("~/Content/ResolutionIcons/{0}.png", resolution.Name);
    }
</script>
<div class="fullscreenlinksContainer">
    <% if(!FullScreenModeOnly) { %>
        <dx:ASPxLabel runat="server" Text="Please click one of the following links to open the demonstration page in the corresponding resolution:"></dx:ASPxLabel>
        <div class="links">
            <div class="link">
                <a id="hlQrcode" runat="server" href="#" target="_blank" class="qrcode" ><img id="imgQrcode" runat="server" src="" alt="QRCode" /></a>
            </div>
            <asp:Repeater ID="rptResolutions" runat="server">
                <ItemTemplate>
                    <div class="link">
                        <dx:ASPxHyperLink runat="server" Target="_blank" NavigateUrl='<%# GetResolutionUrl(Container.DataItem) %>' ImageUrl='<%# GetResolutionImageUrl(Container.DataItem) %>'></dx:ASPxHyperLink>
                        <br />
                        <dx:ASPxHyperLink runat="server" Target="_blank" NavigateUrl='<%# GetResolutionUrl(Container.DataItem) %>' Text='<%# Eval("Name") %>'></dx:ASPxHyperLink>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    <% } else { %>
        <a id="hlQrcodeFS" runat="server" href="#" target="_blank" class="qrcode" ><img id="imgQrcodeFS" runat="server" src="" alt="QRCode" /></a>
        <br />
        <dx:ASPxHyperLink ID="hlFullscreen" runat="server" Target="_blank" Text="Please click here to open the demonstration page in the fullscreen mode"></dx:ASPxHyperLink>
    <% } %>
</div>
