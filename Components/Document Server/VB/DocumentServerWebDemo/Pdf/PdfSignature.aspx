<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PdfSignature.aspx.vb" Inherits="PdfSignature" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<script type="text/javascript">
		function BeginCallback() {
			callbackPanel.PerformCallback();
		}
	</script>
	<dx:ASPxCallbackPanel ID="callbackPanel" ClientInstanceName="callbackPanel" runat="server">
		<PanelCollection>
			<dx:PanelContent runat="server">
				<table>
					<tr>
						<td style="border:solid; border-width:thin">
						   <img runat="server" alt="Page" ID="pageImage" style="vertical-align:middle;width:580px" />
						</td>
						<td style="vertical-align:top;padding-left:30px">
							<dx:ASPxRoundPanel ID="roundPanel1" runat="server" ShowHeader="true" HeaderText="Demo options" Width="100%">
								<PanelCollection>
									<dx:PanelContent>
										<table class="OptionsTable">
											<tr>
												<td style="padding-right:30px;padding-left:30px"> 
													<dx:ASPxLabel ID="lblReason" runat="server" Text="Reason:" Wrap="False" /> 
												</td>
												<td> 
													<dx:ASPxTextBox ID="tbReason" runat="server" Text="" Width="100%" /> 
												</td>
											</tr>
											<tr>
												<td style="padding-right:30px;padding-left:30px"> 
													<dx:ASPxLabel ID="lblLocation" runat="server" Text="Location:" Wrap="False" /> 
												</td>
												<td> 
													<dx:ASPxTextBox ID="tbLocation" runat="server" Text="" Width="100%" /> 
												</td>
											</tr>
											<tr>
												<td style="padding-right:30px;padding-left:30px"> 
													<dx:ASPxLabel ID="lblContactInfo" runat="server" Text="Contact&nbsp;info:" /> 
												</td>
												<td> 
													<dx:ASPxTextBox ID="tbContactInfo" runat="server" Width="100%" /> 
												</td>
											</tr>
											<tr>   
												<td></td>
												<td style="padding-top:22px;padding-left:30px">
													 <dx:ASPxButton ID="btnSign" runat="server" Text="Sign and Download" AutoPostBack="False" 
																	ClientInstanceName="btnSign" Height="25px" Width="100%" OnClick="OnSignButtonClick" />
												</td>
											</tr>                               
										</table>                                    
									</dx:PanelContent>
								</PanelCollection>
							</dx:ASPxRoundPanel>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxCallbackPanel>
</asp:Content>