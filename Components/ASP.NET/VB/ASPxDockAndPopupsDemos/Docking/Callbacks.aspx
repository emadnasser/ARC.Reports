<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="Callbacks.aspx.vb" Inherits="Docking_Callbacks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<p>Move the dock panel between zones to see the feature in action.</p>
	<dx:ASPxDockPanel runat="server" ID="employeesPanel" ClientInstanceName="employeesPanel" DragElement="Window"
		PanelUID="dockPanel" OwnerZoneUID="developmentDepartmentZone" HeaderText="Employees" ShowCloseButton="false"
		Height="410px" Width="340px" LoadContentViaCallback="OnDockStateChange" OnLoad="employeesPanel_Load">
		<Styles>
			<Content>
				<Paddings PaddingLeft="17px" PaddingRight="17px" PaddingTop="13px" />
			</Content>
		</Styles>
	</dx:ASPxDockPanel>
	<table>
		<tr>
			<td>
				<dx:ASPxDockZone runat="server" ID="developmentDepartmentZone" Width="340px" ZoneUID="developmentDepartmentZone"
					Height="410px">
					<BackgroundImage ImageUrl="~/Docking/Images/Callbacks/bgDevelopmentDep.png" />
				</dx:ASPxDockZone>
			</td>
			<td style="padding-left: 13px;">
				<dx:ASPxDockZone runat="server" ID="designDepartmentZone" ZoneUID="designDepartmentZone" Width="340px"
					Height="410px">
					<BackgroundImage ImageUrl="~/Docking/Images/Callbacks/bgDesignDep.png" />
				</dx:ASPxDockZone>
			</td>
		</tr>
	</table>
</asp:Content>