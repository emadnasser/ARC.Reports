<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="ToolbarMode.aspx.vb" Inherits="Features_ToolbarMode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxComboBox ID="cbToolbarMode" runat="server" AutoPostBack="True" Width="130px" ValueType="System.Int32" SelectedIndex="0" Caption="Toolbar Mode">
		<CaptionSettings Position="Top" />
		<RootStyle CssClass="OptionsBottomMargin"></RootStyle>
		<Items>
			<dx:ListEditItem Text="Menu" Value="0" />
			<dx:ListEditItem Text="Ribbon" Value="1" />
			<dx:ListEditItem Text="None" Value="2" />
		</Items>
	</dx:ASPxComboBox>
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Width="850px" Height="440px">
	</dx:ASPxHtmlEditor>
</asp:Content>