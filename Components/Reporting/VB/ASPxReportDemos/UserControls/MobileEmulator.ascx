<%@ Control Language="vb" AutoEventWireup="true" CodeFile="MobileEmulator.ascx.vb" Inherits="UserControls_MobileEmulator" %>
<link rel="stylesheet" type="text/css" href="<%=Page.ResolveClientUrl("~/Content/MobileEmulator.css")%>" />
<div class="<%=If(IsLandscape, "main landscape", "main")%>">
	<div class="<%=If(IsLandscape, "ios-image landscape", "ios-image")%>"></div>
	<iframe name="ios" id="ios" class="<%=If(IsLandscape, "landscape", "")%>" src="<%=Page.ResolveUrl(Url)%>"></iframe>
	<a href="<%=Page.ResolveUrl(Url)%>">
		<div class="<%=If(IsLandscape, "QRCode landscape", "QRCode")%>">
			<img src='<%=QRCodeUrl%>' alt="QRCode" />
			<div>View on your device</div>
		</div>
	</a>
</div>