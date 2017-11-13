<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ContextMenu.aspx.vb"
	Inherits="Features_ContextMenu" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<script type="text/javascript" src="../Scripts/ContextMenu.js"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table style="width: 100%">
		<tr>
			<td style="vertical-align: top; padding-right: 25px">
				<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" ClientInstanceName="DemoHtmlEditor" Width="640px" Height="470px">
					<ClientSideEvents ContextMenuShowing="OnContextMenuShowing" CustomCommand="OnCustomCommand" />
				</dx:ASPxHtmlEditor>
			</td>
			<td style="vertical-align: top; width: 100%">
				<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" >
					<SettingsItemCaptions Location="Top" />
					<Items>
						<dx:LayoutGroup Caption="Context Menu Settings" GroupBoxDecoration="HeadingLine">
							<Items>
								<dx:LayoutItem Caption="Type">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxComboBox ID="cbContextMenu" runat="server" AutoPostBack="true" Width="210px" >
												<Items>
													<dx:ListEditItem Text="HTML Editor" Value="True" />
													<dx:ListEditItem Text="Browser" Value="Default" />
													<dx:ListEditItem Text="None" Value="False" />
												</Items>
											</dx:ASPxComboBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Items">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxListBox ID="lbContextMenuItems" runat="server" SelectionMode="CheckColumn" 
												Width="210px" Height="310px" ValueType="System.String" EncodeHtml="false">
											</dx:ASPxListBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem ShowCaption="False">
									<ParentContainerStyle>
										<Paddings PaddingTop="15px" />
									</ParentContainerStyle>
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxButton ID="btnApply" runat="server" Text="Apply" Width="80px" >
											</dx:ASPxButton>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
							</Items>
						</dx:LayoutGroup>
					</Items>
				</dx:ASPxFormLayout>
			</td>
		</tr>
	</table>
</asp:Content>