<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EnableCallBacks.aspx.vb"
	Inherits="TabControl_EnableCallBacks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" SaveStateToCookies="True"
		TabAlign="Justify" TabPosition="Bottom" EnableCallBacks="True" ActivateTabPageAction="MouseOver"
		EnableHierarchyRecreation="True">
		<TabPages>
			<dx:TabPage Text="Original">
				<ContentCollection>
					<dx:ContentControl runat="server">
						<div id="Div1" runat="server" style="width: 400px; height: 302px; border: solid 1px #333333;">
							<dx:ASPxImage ID="Image1" runat="server" ImageUrl="Images/11561_original.jpg" AlternateText="Original photo" />
						</div>
					</dx:ContentControl>
				</ContentCollection>
			</dx:TabPage>
			<dx:TabPage Text="Cross-Process">
				<ContentCollection>
					<dx:ContentControl runat="server">
						<div id="Div2" runat="server" style="width: 400px; height: 302px; border: solid 1px #333333;">
							<dx:ASPxImage ID="Image2" runat="server" ImageUrl="Images/11561_C41_E6.jpg" AlternateText="Cross-Process photo (C41-E6)" />
						</div>
					</dx:ContentControl>
				</ContentCollection>
			</dx:TabPage>
			<dx:TabPage Text="Sepia">
				<ContentCollection>
					<dx:ContentControl runat="server">
						<div id="Div3" runat="server" style="width: 400px; height: 302px; border: solid 1px #333333;">
							<dx:ASPxImage ID="Image3" runat="server" ImageUrl="Images/11561bw.jpg" AlternateText="Sepia photo" />
						</div>
					</dx:ContentControl>
				</ContentCollection>
			</dx:TabPage>
		</TabPages>
		<TabStyle Width="100px">
		</TabStyle>
	</dx:ASPxPageControl>
</asp:Content>