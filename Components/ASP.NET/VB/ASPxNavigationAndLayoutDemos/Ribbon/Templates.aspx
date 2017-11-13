<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Templates.aspx.vb"
	Inherits="Ribbon_Templates" %>
<asp:Content ID="Css" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.fileTabTemplateDiv {
			background: url(../Ribbon/Images/ArrowIcon.png) no-repeat center;
			width: 21px;
			height: 100%;
		}
		.contactTemplateDiv {
			float: left;
			text-align: left;
			margin-left: 25px;
			padding-top: 10px;
			line-height: 22px;
		}
		.searchTemplate {
			margin: 10px;
			padding-left: 5px;
		}
		.searchTemplate td {
			padding-right: 15px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRibbon ID="ASPxRibbon" runat="server" ClientInstanceName="Ribbon">
		<FileTabTemplate>
			<div id="FileTabTemplateDiv" class="fileTabTemplateDiv"></div>
		</FileTabTemplate>
		<Tabs>
			<dx:RibbonTab Text="Contact">
				<Groups>
					<dx:RibbonGroup Text="">
						<Items>
							<dx:RibbonTemplateItem Size="Large">
								<Template>
									<div class="contactTemplateDiv">
										<dx:ASPxImage ID="ASPxImage2" runat="server" ImageUrl="Images/LiveChat.png"></dx:ASPxImage>
										<br />
										Live Chat
									</div>
									<div class="contactTemplateDiv">
										<b>Technical Support</b>
										<br />
										Internet: <a href="javascript:void(0)">http://www.devexpress.com/Support/Center/</a>
										<br />
										Email: <a href="javascript:void(1)">support@devexpress.com</a>
									</div>
									<div class="contactTemplateDiv">
										<b>Corporate & Multi-Seat Pricing</b>
										<br />
										Tel: + 1 (818) 844 3383
										<br />
										Email: <a href="javascript:void(2)">CorpSales@devexpress.com</a> 
									</div>
								</Template>
							</dx:RibbonTemplateItem>
						</Items>
					</dx:RibbonGroup>
				</Groups>
			</dx:RibbonTab>
			<dx:RibbonTab Text="Search">
				<Groups>
					<dx:RibbonGroup Text="">
						<Items>
							<dx:RibbonTemplateItem Size="Large">
								<ItemStyle CssClass="searchTemplate" />
								<Template>
									<table>
										<tr>
											<td>
												<dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="550px"></dx:ASPxTextBox>
											</td>
											<td>
												<dx:ASPxButton ID="ASPxButton1" runat="server" Text="Search" AutoPostBack="false">
												</dx:ASPxButton>
											</td>
										</tr>
									</table>
									<dx:ASPxCheckBoxList runat="server" RepeatDirection="Horizontal" Border-BorderWidth="0px" Paddings-Padding="0px" RepeatColumns="4">
										<Items>
											<dx:ListEditItem Text="User tickets" />
											<dx:ListEditItem Text="Documentation" />
											<dx:ListEditItem Text="What's new" />
											<dx:ListEditItem Text="Code examples" />
										</Items>
									</dx:ASPxCheckBoxList>
								</Template>
							</dx:RibbonTemplateItem>
						</Items>
					</dx:RibbonGroup>
				</Groups>
			</dx:RibbonTab>
		</Tabs>
	</dx:ASPxRibbon>
	<dx:ASPxPopupMenu ID="ASPxPopupMenu1" runat="server" PopupHorizontalAlign="LeftSides" PopupVerticalAlign="Below" PopupAction="LeftMouseClick" PopupElementID="FileTabTemplateDiv">
		<Items>
			<dx:MenuItem Text="New"></dx:MenuItem>
			<dx:MenuItem Text="Open"></dx:MenuItem>
			<dx:MenuItem Text="Close" BeginGroup="true"></dx:MenuItem>
		</Items>
	</dx:ASPxPopupMenu>
</asp:Content>