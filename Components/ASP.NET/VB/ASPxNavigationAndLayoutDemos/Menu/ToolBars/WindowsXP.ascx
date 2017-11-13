<%@ Control Language="vb" AutoEventWireup="true" CodeFile="WindowsXP.ascx.vb" Inherits="Menu_Toolbars_WindowsXP" %>
<dx:ASPxMenu SkinID="None" ID="ASPxMenu1" runat="server" DataSourceID="XmlDataSource1" CssClass="tbWindowsXP"
	ItemImagePosition="Top" SeparatorCssClass="tbSeparator">
	<ItemImage Height="28px" Width="28px" />
	<ItemStyle ImageSpacing="0px" CssClass="tbItem">
		<HoverStyle CssClass="tbItemHover">
		</HoverStyle>
	</ItemStyle>
	<ClientSideEvents ItemClick="function(s, e) {
	// cursor:hand;
}" />
</dx:ASPxMenu>
<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Menu/ToolbarWindowsXP.xml"
	XPath="/MenuItems/*" />