<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomJavaScriptProperties.aspx.vb"
	Inherits="CallbackPanel_CustomJavaScriptProperties" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function ShowPrevPage() {
			PerformCallback('prev');
		}
		function ShowNextPage() {
			PerformCallback('next');
		}
		function PerformCallback(command) {
			CallbackPanel.PerformCallback(CallbackPanel.cpPageIndex + ':' + command);
		}
		function UpdatePager() {
			var pageNumber = CallbackPanel.cpPageIndex + 1;
			var isFirst = (CallbackPanel.cpPageIndex == 0);
			var isLast = (CallbackPanel.cpPageIndex == (CallbackPanel.cpPageCount - 1));
			lbPageInfo.SetText('Page: ' + pageNumber + ' of ' + CallbackPanel.cpPageCount);
			btPrev.SetEnabled(!isFirst);
			btNext.SetEnabled(!isLast);
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="rpFilmCollection" runat="server" Width="400px" ShowHeader="False">
		<PanelCollection>
			<dx:PanelContent runat="server">
				<table>
					<tbody>
						<tr>
							<td>
								<dx:ASPxCallbackPanel runat="server" ID="CallbackPanel" ClientInstanceName="CallbackPanel"
									Width="100%" OnCallback="CallbackPanel_Callback" OnCustomJSProperties="rpFilmCollection_CustomJSProperties">
									<PanelCollection>
										<dx:PanelContent runat="server">
											<asp:MultiView ID="MultiView" runat="server" ActiveViewIndex="0">
												<asp:View ID="View1" runat="server">
													<table style="width: 100%">
														<tbody>
															<tr>
																<td style="padding-right: 10px;">
																	<dx:ASPxImage AlternateText="Hercules Unchained" ImageUrl="~/CallbackPanel/Images/Hercules.jpg"
																		ID="Image1" runat="server" Width="118px" Height="168px" ShowLoadingImage="true" />
																</td>
																<td style="vertical-align: top">
																	<span style="color: #333333"><b>Directed by:</b> Pietro Francisci<br />
																		<b>Year:</b> 1959<br />
																	</span>
																	<br />
																	<div>
																		While negotiating peace between two brothers contesting the throne of Thebes, an amnesiac Hercules is seduced by the evil Queen Omphale.
																	</div>
																</td>
															</tr>
														</tbody>
													</table>
												</asp:View>
												<asp:View ID="View2" runat="server">
													<table style="width:100%">
														<tbody>
															<tr>
																<td style="padding-right: 10px;">
																	<dx:ASPxImage AlternateText="Meet John Doe" ImageUrl="~/CallbackPanel/Images/MeetJohnDoe.jpg"
																		ID="Image2" runat="server" Width="118px" Height="168px" ShowLoadingImage="true"  />
																</td>
																<td style="vertical-align: top">
																	<span style="color: #333333"><b>Directed by:</b> Frank Capra<br />
																		<b>Year:</b> 1941<br />
																	</span>
																	<br />
																	<div>
																		A man needing money agrees to impersonate a nonexistent person who said he'd be committing suicide as a protest, and a political movement begins.
																	</div>
																</td>
															</tr>
														</tbody>
													</table>
												</asp:View>
												<asp:View ID="View3" runat="server">
													<table style="width:100%">
														<tbody>
															<tr>
																<td style="padding-right: 10px;">
																	<dx:ASPxImage AlternateText="Queen of the Amazons" ImageUrl="~/CallbackPanel/Images/QueenAmazons.jpg" ID="Image3"
																		runat="server" Width="118px" Height="168px" ShowLoadingImage="true"  />
																</td>
																<td style="vertical-align: top">
																	<span style="color: #333333"><b>Directed by:</b> Edward Finney<br />
																		<b>Year:</b> 1947<br />
																	</span>
																	<br />
																	<div>
																		A woman's husband has disappeared on an expedition into the jungle. She hires a guide to take her into the jungle to find him. However, they discover that he has been captured by a savage female tribe.
																	</div>
																</td>
															</tr>
														</tbody>
													</table>
												</asp:View>
											</asp:MultiView>
										</dx:PanelContent>
									</PanelCollection>
									<ClientSideEvents Init="function(s, e) { UpdatePager(); }" EndCallback="function(s, e){ UpdatePager(); }">
									</ClientSideEvents>
								</dx:ASPxCallbackPanel>
							</td>
						</tr>
						<tr>
							<td>
								<div class="Spacer" style="height: 10px;">
								</div>
							</td>
						</tr>
						<tr>
							<td>
								<table class="OptionsTable">
									<tbody>
										<tr>
											<td>
												<dx:ASPxLabel ID="lbPageInfo" runat="server" Text="" ClientInstanceName="lbPageInfo">
												</dx:ASPxLabel>
											</td>
											<td>
												<div class="Spacer" style="width: 10px;">
												</div>
											</td>
											<td>
												<dx:ASPxButton ID="btPrev" runat="server" Text="Prev" AutoPostBack="False" ClientInstanceName="btPrev">
													<ClientSideEvents Click="function(s, e) { ShowPrevPage(); }"></ClientSideEvents>
												</dx:ASPxButton>
											</td>
											<td>
												<dx:ASPxButton ID="btNext" runat="server" Text="Next" AutoPostBack="False" ClientInstanceName="btNext">
													<ClientSideEvents Click="function(s, e) { ShowNextPage(); }"></ClientSideEvents>
												</dx:ASPxButton>
											</td>
										</tr>
									</tbody>
								</table>
							</td>
						</tr>
					</tbody>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
</asp:Content>