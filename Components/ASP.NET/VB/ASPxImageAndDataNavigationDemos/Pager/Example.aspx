<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Example.aspx.vb"
	Inherits="Pager_Example" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel Width="400px" ShowHeader="False" ID="ASPxRoundPanel1" runat="server">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent2" runat="server">
				<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
					<asp:View ID="View1" runat="server">
						<dx:ASPxImage AlternateText="Hercules Unchained" ImageUrl="~/Pager/Images/Hercules.jpg"
							ID="Image1" runat="server" Width="98px" style="float: left" ShowLoadingImage="true" />
						<div style="float: left; width: 260px; margin-left: 10px">
							<span style="color: #333333">
								<b>Directed by:</b> Pietro Francisci<br />
								<b>Year:</b> 1959<br />
							</span>
							<br />
							<span>
								While negotiating peace between two brothers contesting the throne of Thebes, an amnesiac Hercules is seduced by the evil Queen Omphale.
							</span>
						</div>
					</asp:View>
					<asp:View ID="View2" runat="server">
						<dx:ASPxImage AlternateText="Meet John Doe" ImageUrl="~/Pager/Images/MeetJohnDoe.jpg"
							ID="Image2" runat="server" Width="98px" style="float: left" ShowLoadingImage="true" />
						<div style="float: left; width: 260px; margin-left: 10px">
							<span style="color: #333333"><b>Directed by:</b> Frank Capra<br />
								<b>Year:</b> 1941<br />
							</span>
							<br />
							<span>
								A man needing money agrees to impersonate a nonexistent person who said he'd be committing suicide as a protest, and a political movement begins.
							</span>
						</div>
					</asp:View>
					<asp:View ID="View3" runat="server">
						<dx:ASPxImage AlternateText="Queen of the Amazons" ImageUrl="~/Pager/Images/QueenAmazons.jpg" ID="Image3"
							runat="server" Width="98px" style="float: left" ShowLoadingImage="true" />
						<div style="float: left; width: 260px; margin-left: 10px">
							<span style="color: #333333"><b>Directed by:</b> Edward Finney<br />
								<b>Year:</b> 1947<br />
							</span>
							<br />
							<span>
								A woman's husband has disappeared on an expedition into the jungle. She hires a guide to take her into the jungle to find him. However, they discover that he has been captured by a savage female tribe.
							</span>
						</div>
					</asp:View>
				</asp:MultiView>
				<br />
				<dx:ASPxPager ID="ASPxPager1" runat="server" ItemCount="3" ItemsPerPage="1" OnPageIndexChanged="ASPxPager1_PageIndexChanged" 
					style="float: left; clear: both; margin-top: 16px">
					<LastPageButton Visible="True">
					</LastPageButton>
					<FirstPageButton Visible="True">
					</FirstPageButton>
					<Summary Position="Inside" Text="Page {0} of {1} " />
				</dx:ASPxPager>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
</asp:Content>