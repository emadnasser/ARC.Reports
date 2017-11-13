<%@ Control Language="vb" ClassName="FullScreenHyperLink" %>
<script runat="server">
	Public Property NavigateUrl() As String
	Public Property FullScreenModeOnly() As Boolean
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		hlFullscreen.NavigateUrl = NavigateUrl

		hlQrcode.Attributes("href") = NavigateUrl
		hlQrcodeFS.Attributes("href") = NavigateUrl
		imgQrcode.Attributes("src") = FullScreenModeUtils.GetQRCodeImageUrl(Page, NavigateUrl)
		imgQrcodeFS.Attributes("src") = FullScreenModeUtils.GetQRCodeImageUrl(Page, NavigateUrl)
		rptResolutions.DataSource = FullScreenModeUtils.Resolutions
		rptResolutions.DataBind()
	End Sub
	Public Function GetResolutionUrl(ByVal dataItem As Object) As String
		Dim resolution As FullScreenModeResolution = CType(dataItem, FullScreenModeResolution)
		Return FullScreenModeUtils.GetUrl(Page, NavigateUrl, resolution.Width, resolution.Height)
	End Function
	Public Function GetResolutionImageUrl(ByVal dataItem As Object) As String
		Dim resolution As FullScreenModeResolution = CType(dataItem, FullScreenModeResolution)
		Return String.Format("~/Content/ResolutionIcons/{0}.png", resolution.Name)
	End Function
</script>
<div class="fullscreenlinksContainer">
<%
	   If (Not FullScreenModeOnly) Then
%>
		<dx:ASPxLabel runat="server" Text="Please click one of the following links to open the demonstration page in the corresponding resolution:"></dx:ASPxLabel>
		<div class="links">
			<div class="link">
				<a id="hlQrcode" runat="server" href="#" target="_blank" class="qrcode" ><img id="imgQrcode" runat="server" src="" alt="QRCode" /></a>
			</div>
			<asp:Repeater ID="rptResolutions" runat="server">
				<ItemTemplate>
					<div class="link">
						<dx:ASPxHyperLink runat="server" Target="_blank" NavigateUrl='<%#GetResolutionUrl(Container.DataItem)%>' ImageUrl='<%#GetResolutionImageUrl(Container.DataItem)%>'></dx:ASPxHyperLink>
						<br />
						<dx:ASPxHyperLink runat="server" Target="_blank" NavigateUrl='<%#GetResolutionUrl(Container.DataItem)%>' Text='<%#Eval("Name")%>'></dx:ASPxHyperLink>
					</div>
				</ItemTemplate>
			</asp:Repeater>
		</div>
<%
	   Else
%>
		<a id="hlQrcodeFS" runat="server" href="#" target="_blank" class="qrcode" ><img id="imgQrcodeFS" runat="server" src="" alt="QRCode" /></a>
		<br />
		<dx:ASPxHyperLink ID="hlFullscreen" runat="server" Target="_blank" Text="Please click here to open the demonstration page in the fullscreen mode"></dx:ASPxHyperLink>
<%
	   End If
%>
</div>