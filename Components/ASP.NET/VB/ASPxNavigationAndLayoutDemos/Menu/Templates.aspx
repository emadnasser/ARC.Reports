<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Templates.aspx.vb"
	Inherits="Menu_Templates" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="height: 480px;">
		<dx:ASPxMenu BorderBetweenItemAndSubMenu="HideRootOnly" EnableViewState="False" EnableClientSideAPI="true"
			ID="ASPxMenu1" AutoSeparators="None" runat="server" ShowSubMenuShadow="true"
			ItemImagePosition="Right" ShowPopOutImages="True">
			<SubMenuStyle GutterWidth="0px" />
			<Items>
				<dx:MenuItem Text="SubMenu Template" Name="submenu">
					<Items>
						<dx:MenuItem />
					</Items>
					<SubMenuTemplate>
						<dx:ASPxSiteMapControl EnableViewState="False" ID="ASPxSiteMapControl1" runat="server"
							DataSourceID="ASPxSiteMapDataSource1">
							<Columns>
								<dx:SiteMapColumn />
								<dx:SiteMapColumn />
								<dx:SiteMapColumn />
							</Columns>
						</dx:ASPxSiteMapControl>
						<dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server" SiteMapProvider="MenuSiteMapProvider" />
					</SubMenuTemplate>
				</dx:MenuItem>
				<dx:MenuItem Text="Item Template" Name="item">
					<SubMenuStyle Paddings-Padding="8px" Font-Size="10px" Font-Names="Verdana" Wrap="False"
						ForeColor="#000000" />
					<Items>
						<dx:MenuItem Text="ASP.NET" Name="aspdotnet">
							<Template>
								<dx:ASPxLabel EnableViewState="False" runat="server" Text="News" Font-Size="10px"
									ForeColor="#003399" Font-Bold="true" />
								<table style="padding-top: 4px;">
									<tr>
										<td>
											<dx:ASPxCheckBox EnableViewState="False" Checked="true" ID="CheckBox1" runat="server" />
										</td>
										<td>
											<dx:ASPxLabel ForeColor="#000000" EnableViewState="false" AssociatedControlID="CheckBox1"
												ID="Label3" Text='<%#Container.Item.Text%>' runat="server" />
										</td>
									</tr>
								</table>
							</Template>
						</dx:MenuItem>
						<dx:MenuItem Text="Announcements" Name="announcements">
							<Template>
								<table>
									<tr>
										<td>
											<dx:ASPxCheckBox EnableViewState="false" ID="CheckBox2" runat="server" />
										</td>
										<td>
											<dx:ASPxLabel ForeColor="#000000" EnableViewState="false" AssociatedControlID="CheckBox2"
												ID="Label3" Text='<%#Container.Item.Text%>' runat="server" />
										</td>
									</tr>
								</table>
							</Template>
						</dx:MenuItem>
						<dx:MenuItem Text="Building Controls" Name="building">
							<Template>
								<table>
									<tr>
										<td>
											<dx:ASPxCheckBox EnableViewState="false" ID="CheckBox3" runat="server" />
										</td>
										<td>
											<dx:ASPxLabel ForeColor="#000000" EnableViewState="false" AssociatedControlID="CheckBox3"
												Text='<%#Container.Item.Text%>' ID="Label3" runat="server" />
										</td>
									</tr>
								</table>
							</Template>
						</dx:MenuItem>
						<dx:MenuItem Text="Graphic Designer" Name="graphic">
							<Template>
								<table>
									<tr>
										<td>
											<dx:ASPxCheckBox EnableViewState="false" ID="CheckBox4" runat="server" />
										</td>
										<td>
											<dx:ASPxLabel ForeColor="#000000" EnableViewState="false" AssociatedControlID="CheckBox4"
												ID="Label3" Text="<%#Container.Item.Text%>" runat="server" />
										</td>
									</tr>
								</table>
							</Template>
						</dx:MenuItem>
						<dx:MenuItem Text="Web Controls" Name="webcontrols">
							<Template>
								<table>
									<tr>
										<td>
											<dx:ASPxCheckBox EnableViewState="false" Checked="true" ID="CheckBox5" runat="server" />
										</td>
										<td>
											<dx:ASPxLabel ForeColor="#000000" EnableViewState="false" AssociatedControlID="CheckBox5"
												ID="Label3" Text="<%#Container.Item.Text%>" runat="server" />
										</td>
									</tr>
								</table>
							</Template>
						</dx:MenuItem>
						<dx:MenuItem Text="Web Services" Name="webservices">
							<Template>
								<table>
									<tr>
										<td>
											<dx:ASPxCheckBox EnableViewState="false" ID="CheckBox6" runat="server" />
										</td>
										<td>
											<dx:ASPxLabel ForeColor="#000000" EnableViewState="false" AssociatedControlID="CheckBox6"
												ID="Label3" Text="<%#Container.Item.Text%>" runat="server" />
										</td>
									</tr>
								</table>
							</Template>
						</dx:MenuItem>
						<dx:MenuItem Text="Email" Name="email" BeginGroup="true">
							<Template>
								<dx:ASPxLabel ID="Label2" EnableViewState="false" AssociatedControlID="TextBox1"
									runat="server" Text="<%#Container.Item.Text%>" Font-Size="10px" ForeColor="#003399"
									Font-Bold="true" />
								<table style="margin-top: 4px; width:260px">
									<tr>
										<td style="width: 100%;">
											<dx:ASPxTextBox ID="TextBox1" runat="server" EnableViewState="false" Width="100%" />
										</td>
										<td style="padding-left: 3px;">
											<dx:ASPxButton ID="Button1" runat="server" EnableViewState="False" Text="Subscribe"
												AutoPostBack="False">
												<ClientSideEvents Click="function(s, e) { ASPxClientMenuBase.GetMenuCollection().HideAll(); return false; }" />
											</dx:ASPxButton>
										</td>
									</tr>
								</table>
							</Template>
						</dx:MenuItem>
					</Items>
				</dx:MenuItem>
			</Items>
		</dx:ASPxMenu>
	</div>
</asp:Content>