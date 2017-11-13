<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="ClientSideAPI.aspx.vb" Inherits="Docking_ClientSideAPI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
	<link href="../Docking/CSS/ClientSideAPI.css" rel="Stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function OnZoneChanged(s, e) {
			var panel = GetCurrentDockPanel();
			var zone = GetCurrentDockZone();
			if(zone)
				panel.Dock(GetCurrentDockZone(), panel.GetVisibleIndex());
			else
				panel.MakeFloat();
		}
		function ChangeVisibleIndex() {
			var panel = GetCurrentDockPanel();
			panel.SetVisibleIndex(seVisibleIndex.GetValue());
		}
		function ChangePanelVisibility() {
			var panel = GetCurrentDockPanel();
			panel.SetVisible(cbPanelVisibility.GetValue());
		}
		function ShowProperties() {
			var panel = GetCurrentDockPanel();
			var item = cbDockZones.FindItemByValue(panel.IsDocked() ? panel.GetOwnerZone().zoneUID : 'none');
			cbDockZones.SetSelectedIndex(item.index);
			cbPanelVisibility.SetValue(panel.GetVisible());
			seVisibleIndex.SetValue(panel.GetVisibleIndex());
		}
		function GetCurrentDockPanel() {
			return manager.GetPanelByUID(cbDockPanels.GetValue());
		}
		function GetCurrentDockZone() {
			return manager.GetZoneByUID(cbDockZones.GetValue());
		}
	</script>
	<%--end highlighted block--%>
	<dx:ASPxGlobalEvents runat="server">
		<ClientSideEvents ControlsInitialized="function(s, e) { ShowProperties(); }"/>
	</dx:ASPxGlobalEvents>
	<dx:ASPxDockManager runat="server" ID="dockManager" ClientInstanceName="manager">
		<ClientSideEvents
			AfterDock="function(s, e) { ShowProperties(); }"
			EndPanelDragging="function(s, e) { ShowProperties(); }"
			PanelCloseUp="function(s, e) { ShowProperties(); }"
		/>
	</dx:ASPxDockManager>

	<dx:ASPxDockPanel runat="server" ID="panel1" PanelUID="panel1"
		OwnerZoneUID="zone1" VisibleIndex="0"
		HeaderText="2D Pie" FooterText="Model: Simple" DragElement="Window">
		<ContentCollection>
			<dx:PopupControlContentControl>
				<dx:ASPxImage runat="server" ID="panel1Image" ImageUrl="~/Docking/Images/Charts/2DPie.png" ShowLoadingImage="true" Height="125px">
				</dx:ASPxImage>
			</dx:PopupControlContentControl>
		</ContentCollection>
	</dx:ASPxDockPanel>
	<dx:ASPxDockPanel runat="server" ID="panel2" PanelUID="panel2"
		OwnerZoneUID="zone1" VisibleIndex="1"
		HeaderText="3D Bubble" FooterText="Model: Sphere" DragElement="Window">
		<ContentCollection>
			<dx:PopupControlContentControl>
				<dx:ASPxImage runat="server" ID="panel2Image" ImageUrl="~/Docking/Images/Charts/3DBubble.png" ShowLoadingImage="true" Height="125px">
				</dx:ASPxImage>
			</dx:PopupControlContentControl>
		</ContentCollection>
	</dx:ASPxDockPanel>
	<dx:ASPxDockPanel runat="server" ID="panel3" PanelUID="panel3"
		OwnerZoneUID="zone2" VisibleIndex="0"
		HeaderText="3D Bar" FooterText="Model: Box" DragElement="Window">
		<ContentCollection>
			<dx:PopupControlContentControl>
				<dx:ASPxImage runat="server" ID="ASPxImage1" ImageUrl="~/Docking/Images/Charts/3DManhattanBar.png" ShowLoadingImage="true" Height="125px">
				</dx:ASPxImage>
			</dx:PopupControlContentControl>
		</ContentCollection>
	</dx:ASPxDockPanel>
	<dx:ASPxDockPanel runat="server" ID="panel4" PanelUID="panel4"
		OwnerZoneUID="zone2" VisibleIndex="1"
		HeaderText="2D Bubble" FooterText="Model: Ring" DragElement="Window">
		<ContentCollection>
			<dx:PopupControlContentControl>
				<dx:ASPxImage runat="server" ID="ASPxImage2" ImageUrl="~/Docking/Images/Charts/2DBubble.png" ShowLoadingImage="true" Height="125px">
				</dx:ASPxImage>
			</dx:PopupControlContentControl>
		</ContentCollection>
	</dx:ASPxDockPanel>
	<div style="width: 511px; float: left;">
		<dx:ASPxDockZone runat="server" ID="dockZone1" ClientInstanceName="zone1" CssClass="zone left"
			ZoneUID="zone1">
		</dx:ASPxDockZone>
		<dx:ASPxDockZone runat="server" ID="ASPxDockZone1" ClientInstanceName="zone1" CssClass="zone"
			ZoneUID="zone2">
		</dx:ASPxDockZone>
	</div>
	<div style="padding-left: 10px; float: right;">
		<table class="OptionsTable">
			<tr>
				<td>
					<dx:ASPxLabel runat="server" Text="Choose panel:" ID="lblDockPanels" AssociatedControlID="cbDockPanels">
					</dx:ASPxLabel>
				</td>
				<td>
					<dx:ASPxComboBox runat="server" ID="cbDockPanels" ClientInstanceName="cbDockPanels"
						Width="100px" EnableViewState="false" SelectedIndex="0">
						<ClientSideEvents SelectedIndexChanged="function(s, e) { ShowProperties(); }" />
						<Items>
							<dx:ListEditItem Text="2D Pie" Value="panel1"/>
							<dx:ListEditItem Text="3D Bubble" Value="panel2"/>
							<dx:ListEditItem Text="3D Bar" Value="panel3"/>
							<dx:ListEditItem Text="2D Bubble" Value="panel4"/>
						</Items>
					</dx:ASPxComboBox>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Visible index:">
					</dx:ASPxLabel>
				</td>
				<td>
					<dx:ASPxSpinEdit runat="server" ID="seVisibleIndex" ClientInstanceName="seVisibleIndex"
						MinValue="0" MaxValue="3" Width="100px">
						<ClientSideEvents NumberChanged="function(s, e) { ChangeVisibleIndex();} " />
					</dx:ASPxSpinEdit>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="lblDockTo" runat="server" Text="Dock to:">
					</dx:ASPxLabel>
				</td>
				<td>
					<dx:ASPxComboBox runat="server" ID="cbDockZones" SelectedIndex="0" ClientInstanceName="cbDockZones" Width="100px">
						<ClientSideEvents SelectedIndexChanged="OnZoneChanged"/>
						<Items>
							<dx:ListEditItem Text="None" Value="none" />
							<dx:ListEditItem Text="Left zone" Value="zone1"/>
							<dx:ListEditItem Text="Right zone" Value="zone2"/>
						</Items>
					</dx:ASPxComboBox>
				</td>
			</tr>
			 <tr>
				<td colspan="2">
					<dx:ASPxCheckBox runat="server" Text="Visible" ID="cbPanelVisibility" ClientInstanceName="cbPanelVisibility">
						<ClientSideEvents CheckedChanged="function(s, e) { ChangePanelVisibility();}" />
					</dx:ASPxCheckBox>
				</td>
			</tr>
		</table>
	</div>
</asp:Content>