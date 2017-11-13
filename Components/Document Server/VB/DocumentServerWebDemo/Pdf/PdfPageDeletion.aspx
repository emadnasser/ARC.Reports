<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PdfPageDeletion.aspx.vb" Inherits="PdfPageDeletion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCallbackPanel ID="callbackPanel" ClientInstanceName="deleteCallbackPanel"
		runat="server" OnCallback="OnCallback">
		<PanelCollection>
			<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
				<dx:ASPxRoundPanel ID="roundPanel1" runat="server" ShowHeader="true" HeaderText="Demo options"
					Width="100%">
					<PanelCollection>
						<dx:PanelContent>
							<table class="OptionsTable">
								<tr>
									<td style="vertical-align:baseline">
										<dx:ASPxButton ID="btnDeletePage" runat="server" Text="Delete current page" AutoPostBack="false" Height="25px">
											<ClientSideEvents Click="function(s, e) { deleteCallbackPanel.PerformCallback(); }" />
										</dx:ASPxButton>
									</td>
								</tr>
							</table>
						</dx:PanelContent>
					</PanelCollection>
				</dx:ASPxRoundPanel>
				<br />
				<dx:PdfPageViewer ID="pdfPageViewer" runat="server" />
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxCallbackPanel>
</asp:Content>