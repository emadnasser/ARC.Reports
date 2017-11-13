<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LoadOnDemand.aspx.vb"
	Inherits="RoundPanel_LoadOnDemand" %>
<asp:Content ID="Css1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.details {
			vertical-align: top;
			padding-left: 20px;
		}
		.details > div {
			width: 250px;
		}
		.photoHolder {
			padding: 6px;
			display: inline-block;
			border:1px solid #e0e0e0;
			height: 150px;
			width: 150px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="padding: 10px;">
		<p>Please click the panel header to toggle the panel's expansion state.</p>
		<dx:ASPxRoundPanel ID="ASPxRoundPanel1" ClientInstanceName="roundPanel" runat="server" LoadContentViaCallback="true"
			HeaderText="Contact Information" Collapsed="true" ShowCollapseButton="true" AllowCollapsingByHeaderClick="true"
			Width="470px">
			<PanelCollection>
				<dx:PanelContent ID="PanelContent1" runat="server">
					<table>
						<tbody>
							<tr>
								<td>
									<div class="photoHolder">
										<img alt="Maria Hernandez" src="../Content/Images/Contacts/Maria_Hernandez.jpg"
											width="150" height="150" />
									</div>
								</td>
								<td class="details">
									<div>
										<b>Name:</b>
										<p>
											Maria Hernandez
										</p>
									</div>
									<div>
										<b>Email:</b>
										<p>
											maria.hernandez@example.com
										</p>
									</div>
									<div>
										<b>Address:</b>
										<p>
											644 North Ranchford, Bangor, USA
										</p>
									</div>
									<div>
										<b>Phone:</b>
										<p>
											1 (207) 555-0032
										</p>
									</div>
								</td>
							</tr>
							<tr>
								<td colspan="2" style="padding-top: 15px;">The content of this round panel control was updated at <b><%=DateTime.Now.ToLongTimeString()%></b>
								</td>
							</tr>
							<tr>
								<td colspan="2" style="text-align: left; padding: 10px 0px;">
									<dx:ASPxButton ID="refreshButton" VerticalAlign="Middle" ClientInstanceName="refreshButton"
										runat="server" AutoPostBack="false" Text="Refresh Details">
										<Image IconID="actions_refresh_16x16gray">
										</Image>
										<ClientSideEvents Click="function(s,e){
												roundPanel.PerformCallback();
											}" />
									</dx:ASPxButton>
								</td>
							</tr>
						</tbody>
					</table>
				</dx:PanelContent>
			</PanelCollection>
		</dx:ASPxRoundPanel>
	</div>
</asp:Content>