<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Templates.aspx.vb"
	Inherits="SiteMap_Templates" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel EnableViewState="False" ShowHeader="False" ID="ASPxRoundPanel1"
		runat="server" Width="100%">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent2" runat="server">
				<dx:ASPxSiteMapControl SkinID="None" EnableViewState="False"
					Height="100%" Width="100%" Border-BorderWidth="0px" BackColor="Transparent" ID="ASPxSiteMapControl1"
					runat="server" DataSourceID="ASPxSiteMapDataSource1" Font-Names="Tahoma" Font-Size="11px"
					Font-Underline="False">
					<Columns>
						<dx:SiteMapColumn />
						<dx:SiteMapColumn />
					</Columns>
					<ColumnSeparatorStyle Width="20px">
						<Paddings Padding="0px" />
					</ColumnSeparatorStyle>
					<Paddings Padding="0px" />
					<DefaultLevelProperties Font-Underline="False" VerticalAlign="Top" ForeColor="#0066CC"
						Font-Names="Tahoma" Font-Size="1em">
					</DefaultLevelProperties>
					<LinkStyle HoverColor="#51A0EF">
						<Font Underline="False" />
						<HoverFont Underline="False" />
					</LinkStyle>
					<LevelProperties>
						<dx:LevelProperties Font-Bold="False" Font-Names="Tahoma" Font-Size="16px" Font-Underline="False"
							ForeColor="#666666" VerticalAlign="Top">
							<ChildNodesPaddings Padding="0px" PaddingBottom="8px" PaddingLeft="0px" PaddingRight="0px"
								PaddingTop="5px" />
							<NodePaddings Padding="0px" />
							<BorderBottom BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" />
						</dx:LevelProperties>
						<dx:LevelProperties BulletStyle="None" Font-Names="Tahoma" Font-Size="1em" ForeColor="#1473D2"
							NodeSpacing="3px" VerticalAlign="Top" Wrap="True">
							<NodeTemplate>
								<table>
									<tr>
										<td style="white-space: nowrap; padding: 1px;">
											<dx:ASPxHyperLink ID="Label1" runat="server" Text='<%#Eval("Title")%>' NavigateUrl='<%#Eval("Url")%>'
												ForeColor="#1473D2" />
										</td>
										<td style="width: 100%; padding: 1px; vertical-align: top;" id="Td1" runat="server" visible='<%#If(String.IsNullOrEmpty(Container.SiteMapNode("type")), False, True)%>'>
											<dx:ASPxImage ID="Image1" runat="server" Visible='<%#If(String.IsNullOrEmpty(Container.SiteMapNode("type")), False, True)%>'
												ImageUrl='<%#"~/SiteMap/Images/" & Container.SiteMapNode("type") & ".gif"%>' />
										</td>
									</tr>
								</table>
							</NodeTemplate>
							<ChildNodesPaddings PaddingLeft="11px" PaddingTop="3px" />
							<NodePaddings Padding="0px" PaddingBottom="0px" PaddingTop="0px" />
						</dx:LevelProperties>
					</LevelProperties>
					<Border BorderWidth="0px" />
				</dx:ASPxSiteMapControl>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server" SiteMapFileName="~/App_Data/SiteMap/Products.sitemap" />
</asp:Content>