<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.vb"
	Inherits="Menu_Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable">
		<tr>
			<td>
				<dx:ASPxLabel ID="Label1" runat="server" Text="RepeatDirection:" AssociatedControlID="ddlRepeatDirection" />
			</td>
			<td>
				<dx:ASPxComboBox SelectedIndex="0" ID="ddlRepeatDirection" runat="server" Width="87px"
					AutoPostBack="True" OnSelectedIndexChanged="ddlRepeatDirection_SelectedIndexChanged">
					<Items>
						<dx:ListEditItem Text="Vertical" Value="Vertical" />
						<dx:ListEditItem Text="Horizontal" Value="Horizontal" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td class="LeftPadding">
				<dx:ASPxLabel ID="lblColumnCount" runat="server" Text="ColumnCount:" AssociatedControlID="tbColumnCount" />
			</td>
			<td>
				<dx:ASPxTextBox ID="tbColumnCount" runat="server" Width="50px" Text="2" />
			</td>
		</tr>
		<tr>
			<td colspan="2">
			</td>
			<td class="LeftPadding">
				<dx:ASPxLabel ID="lblMaximumDisplayLevels" runat="server" Text="MaximumDisplayLevels:"
					AssociatedControlID="tbMaximumDisplayLevels" />
			</td>
			<td>
				<dx:ASPxTextBox ID="tbMaximumDisplayLevels" runat="server" Width="50px" Text="2" />
			</td>
		</tr>
		<tr>
			<td colspan="3">
			</td>
			<td>
				<dx:ASPxButton ID="btnApply" CssClass="DemoButton" runat="server" Text="Apply" OnClick="btnApply_Click"
					Width="70px" />
			</td>
		</tr>
		<tr>
			<td colspan="3">
			</td>
			<td>
				<dx:ASPxLabel ID="lblColumnCountError" runat="server" Text="ColumnCount value isn't valid"
					ForeColor="Red" Visible="False" />
			</td>
		</tr>
		<tr>
			<td colspan="3">
			</td>
			<td>
				<dx:ASPxLabel ID="lblMaximumDisplayLevelsError" runat="server" Text="MaximumDisplayLevels value isn't valid"
					ForeColor="Red" Visible="False" />
			</td>
		</tr>
	</table>
	<dx:ASPxSiteMapControl ID="smpMain" runat="server" DataSourceID="ASPxSiteMapDataSource1"
		Width="100%" MaximumDisplayLevels="2">
		<Columns>
			<dx:SiteMapColumn />
			<dx:SiteMapColumn />
		</Columns>
	</dx:ASPxSiteMapControl>
	<dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server" SiteMapFileName="~/App_Data/SiteMap/Feature.sitemap" />
</asp:Content>