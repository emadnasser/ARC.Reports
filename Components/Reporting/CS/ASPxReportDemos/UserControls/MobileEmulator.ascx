<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MobileEmulator.ascx.cs" Inherits="UserControls_MobileEmulator" %>
<link rel="stylesheet" type="text/css" href="<%= Page.ResolveClientUrl("~/Content/MobileEmulator.css") %>" />
<div class="<%= IsLandscape ? "main landscape" : "main" %>">
    <div class="<%= IsLandscape ? "ios-image landscape" : "ios-image" %>"></div>
    <iframe name="ios" id="ios" class="<%= IsLandscape ? "landscape" : "" %>" src="<%= Page.ResolveUrl(Url) %>"></iframe>
    <a href="<%= Page.ResolveUrl(Url) %>">
        <div class="<%= IsLandscape ? "QRCode landscape" : "QRCode" %>">
            <img src='<%= QRCodeUrl %>' alt="QRCode" />
            <div>View on your device</div>
        </div>
    </a>
</div>
