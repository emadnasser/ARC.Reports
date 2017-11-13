<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxDockZone runat="server" ID="ASPxDockZone1" ZoneUID="DockZone" Height="220px" Width="250px">
	</dx:ASPxDockZone>
	<dx:ASPxDockPanel runat="server" ID="ASPxDockPanel1" OwnerZoneUID="DockZone" HeaderText="2D Bubble" ShowCloseButton="false" Height="220px" Width="250px">
		<Styles>
			<Content HorizontalAlign="Center" />
		</Styles>
		<ContentCollection>
			<dx:PopupControlContentControl>
				<dx:ASPxImage ID="ASPxImage1" runat="server" Height="140px" ImageUrl="~/Docking/Images/Charts/2DBubble.png" />
			</dx:PopupControlContentControl>
		</ContentCollection>
	</dx:ASPxDockPanel>
</asp:Content>