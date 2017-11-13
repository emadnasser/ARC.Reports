<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Office2007.ascx.vb" Inherits="Menu_Toolbars_Office2007" %>
<dx:ASPxRoundPanel SkinID="None" ID="ASPxRoundPanel2" runat="server" ShowHeader="False"
	BackColor="Transparent">
	<PanelCollection>
		<dx:PanelContent runat="server">
			<dx:ASPxMenu SkinID="None" ID="ASPxMenu1" runat="server" DataSourceID="XmlDataSource1" CssClass="tbOffice2007Group"
				SeparatorWidth="2px" OnItemDataBound="ASPxMenu1_ItemDataBound">
				<ItemStyle CssClass="tbItem" />
			</dx:ASPxMenu>
		</dx:PanelContent>
	</PanelCollection>
	<Content>
		<BackgroundImage ImageUrl="~/Menu/Images/Toolbars/Office2007/Main/Background.gif"
			Repeat="RepeatX" />
	</Content>
	<ContentPaddings Padding="2" />
	<Border BorderColor="#8DB2E3" BorderStyle="Solid" BorderWidth="1px" />
</dx:ASPxRoundPanel>
<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Menu/ToolbarOffice2007.xml"
	XPath="/MenuItems/*" />