<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Office2007Children.ascx.vb"
	Inherits="Menu_Toolbars_Office2007Children" %>
<dx:ASPxRoundPanel SkinID="None" ID="rpRibbon" runat="server" ShowHeader="False"
	BackColor="Transparent">
	<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">
			<table class="tbOffice2007Container">
				<tr>
					<td valign="top">
						<dx:ASPxMenu SkinID="None" ID="mRibbonChilds" runat="server" DataSourceID="XmlDataSource1" CssClass="tbOffice2007"
							ItemImagePosition="Top" ItemSpacing="0px">
							<LinkStyle Color="#0560A6">
								<HoverFont Underline="True" />
							</LinkStyle>
							<ItemStyle ImageSpacing="0px" CssClass="tbItem">
								<HoverStyle CssClass="tbItemHover">
								</HoverStyle>
								<CheckedStyle CssClass="tbItemChecked">
								</CheckedStyle>
							</ItemStyle>
							<ItemImage Height="32px" Width="32px" />
						</dx:ASPxMenu>
					</td>
				</tr>
				<tr>
					<td align="center">
						<dx:ASPxLabel ID="lblWatch" runat="server" ForeColor="#3E6AAA" />
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	<Content>
		<BackgroundImage ImageUrl="~/Menu/Images/Toolbars/Office2007/ContentBackground.gif"
			Repeat="RepeatX" VerticalPosition="bottom" />
	</Content>
	<BackgroundImage ImageUrl="~/Menu/Images/Toolbars/Office2007/Background.gif" Repeat="RepeatX"
		VerticalPosition="top" />
	<ContentPaddings  Padding="2"/>
	<Border BorderColor="#A5BDD4" BorderStyle="Solid" BorderWidth="1px"/>
	<BorderTop  BorderColor="#C5D2DF" BorderStyle="Solid" BorderWidth="1px"/>
</dx:ASPxRoundPanel>
<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Menu/ToolbarOffice2007.xml" />