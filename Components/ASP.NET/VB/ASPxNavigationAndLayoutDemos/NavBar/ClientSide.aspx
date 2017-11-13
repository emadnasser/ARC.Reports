<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSide.aspx.vb"
	Inherits="NavBar_ClientSide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="min-height: 210px;margin-bottom:10px;">
		<dx:ASPxNavBar ID="ASPxNavBar1" runat="server" AllowSelectItem="True" EnableViewState="False"
			Width="200" style="margin: 0 auto;">
			<GroupHeaderStyle HorizontalAlign="Left" />
			<ItemStyle HorizontalAlign="Left" />
			<ClientSideEvents ExpandedChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'ExpandedChanged') }"
				ExpandedChanging="function(s, e) { DXEventMonitor.Trace(s, e, 'ExpandedChanging') }"
				HeaderClick="function(s, e) { DXEventMonitor.Trace(s, e, 'HeaderClick') }" Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init') }"
				ItemClick="function(s, e) { DXEventMonitor.Trace(s, e, 'ItemClick') }" />
			<Groups>
				<dx:NavBarGroup Text="Products">
					<Items>
						<dx:NavBarItem Text="Subscriptions / Packs" Name="packs" Selected="True">
						</dx:NavBarItem>
						<dx:NavBarItem Text=".NET Windows Forms Components" Name="net">
						</dx:NavBarItem>
						<dx:NavBarItem Text="Reporting / Printing Suites" Name="report">
						</dx:NavBarItem>
						<dx:NavBarItem Text="VCL Components and Tools" Name="vcl">
						</dx:NavBarItem>
						<dx:NavBarItem Text="ASP.NET Components" Name="asp">
						</dx:NavBarItem>
					</Items>
				</dx:NavBarGroup>
			</Groups>
		</dx:ASPxNavBar>
	</div>
	<dx:EventMonitor runat="server" ID="EventMonitor" EventNames="Init ItemClick HeaderClick ExpandedChanging ExpandedChanged" EventLogWidth="540" />
</asp:Content>