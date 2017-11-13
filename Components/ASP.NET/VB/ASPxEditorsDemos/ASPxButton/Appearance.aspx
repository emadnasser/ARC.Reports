<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Appearance.aspx.vb"
	Inherits="ASPxButton_Appearance" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<link rel="stylesheet" type="text/css" href="Css/Appearance.css" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<div class="buttonsPanel">
		<div>
			<dx:ASPxButton ID="btnImageAndText" runat="server"
				Width="90px" Text="Cancel" AutoPostBack="false">
				<Image IconID="actions_cancel_16x16"></Image> 
			</dx:ASPxButton>
		</div>
		<label>
			RenderMode = "Button"<br />
			Text = "Cancel"<br />
			Image.IconID = "actions_cancel_16x16"
		</label>
	</div>
	<div class="buttonsPanel">
		<div>
			<dx:ASPxButton ID="btnLinkImageAndText" runat="server" RenderMode="Link"
				Width="90px" Height="25px" Text="Refresh" AutoPostBack="false" ImagePosition="Right">
				<Image IconID="actions_refresh_16x16gray"></Image> 
			</dx:ASPxButton>
		</div>
		<label>
			RenderMode = "Link"<br />
			Text = "Refresh"<br />
			Image.IconID = "actions_refresh_16x16gray"<br />
			ImagePosition = "Right"<br />
		</label>
	</div>
	<div class="buttonsPanel">
		<div>
			<dx:ASPxButton ID="btnNative" runat="server" Native="True"
				Width="90px" Height="25px" Text="OK" AutoPostBack="false">
			</dx:ASPxButton>
		</div>
		<label>
			Native = "True"<br />
			Text = "OK"
		</label>
	</div>
	<div class="buttonsPanel">
		<div>
			<dx:ASPxButton ID="btnIcq" runat="server" EnableTheming="False" Text="Send&nbsp;a&nbsp;message"
				AllowFocus="False" AutoPostBack="False" ImagePosition="Right" CssClass="icq">
				<HoverStyle CssClass="icqHovered" />
				<PressedStyle CssClass="icqPressed" />
				<Image Url="Images/Icq.png" Width="16px" Height="16px" />
			</dx:ASPxButton>
		</div>
		<label>
			EnableTheming = "False"<br />
			Text = "Send&nbsp;a&nbsp;message"<br />
			Image.Url = "Images/Icq.png"<br />
			ImagePosition = "Right"<br />
			CssClass = "icq"<br />
			HoverStyle.CssClass = "icqHovered"<br />
			PressedStyle.CssClass = "icqPressed"<br />
		</label>
	</div>
	<div class="buttonsPanel">
		<div>
			<dx:ASPxButton ID="btnWine" runat="server" Text="Submit"
				AutoPostBack="False" AllowFocus="False" CssClass="wine" EnableTheming="false">
				<HoverStyle CssClass="wineHottracked" />
				<PressedStyle CssClass="winePressed" />
			</dx:ASPxButton>
		</div>
		<label>
			EnableTheming = "False"<br />
			Text="Submit"<br />
			CssClass = "wine"<br />
			HoverStyle.CssClass = "wineHottracked"<br />
			PressedStyle.CssClass = "winePressed"<br />
		</label>
	</div>
	<div class="buttonsPanel">
		<div>
			<dx:ASPxButton ID="btnBlueBall" runat="server" AutoPostBack="False" AllowFocus="False" RenderMode="Link" EnableTheming="False">
				<Image>
					<SpriteProperties CssClass="blueBall" HottrackedCssClass="blueBallHottracked" PressedCssClass="blueBallPressed" />
				</Image> 
			</dx:ASPxButton>
		</div>
		<label>
			EnableTheming = "False"<br />
			RenderMode = "Link"<br />
			Image.SpriteProperties.CssClass = "blueBall"<br />
			Image.SpriteProperties.HottrackedCssClass = "blueBallHottracked"<br />
			Image.SpriteProperties.PressedCssClass = "blueBallPressed"
		</label>
	</div>
</asp:Content>