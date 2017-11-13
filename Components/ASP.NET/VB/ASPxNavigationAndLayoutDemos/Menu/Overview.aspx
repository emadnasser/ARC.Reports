<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxMenu ID="ASPxMenu1" runat="server">
		<Items>
			<dx:MenuItem Text="Home">
				<Image IconID="navigation_home_32x32" />
				<Items>
					<dx:MenuItem Text="News">
					</dx:MenuItem>
					<dx:MenuItem Text="Contact Us">
					</dx:MenuItem>
				</Items>
			</dx:MenuItem>
			<dx:MenuItem Text="Profile">
				<Image IconID="people_customer_32x32" />
				<Items>
					<dx:MenuItem Text="Change Password">
					</dx:MenuItem>
				</Items>
			</dx:MenuItem>
			<dx:MenuItem Text="Clients">
				<Image IconID="people_usergroup_32x32" />
			</dx:MenuItem>
			<dx:MenuItem Text="Reports">
				<Image IconID="programming_showtestreport_32x32" />
			</dx:MenuItem>
		</Items>
	</dx:ASPxMenu>
</asp:Content>