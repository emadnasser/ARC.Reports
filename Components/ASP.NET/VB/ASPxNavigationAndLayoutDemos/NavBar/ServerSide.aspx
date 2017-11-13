<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ServerSide.aspx.vb"
	Inherits="NavBar_ServerSide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="margin-bottom: 16px;">
		<div style="float: left; width: 25%; margin-right: 2%; min-height: 410px; margin-bottom: 10px;">
			<dx:ASPxNavBar ID="ASPxNavBar1" runat="server" OnItemClick="ASPxNavBar1_ItemClick"
				Width="100%" OnHeaderClick="ASPxNavBar1_HeaderClick" AutoPostBack="True" AllowSelectItem="True"
				OnExpandedChanged="ASPxNavBar1_ExpandedChanged" OnExpandedChanging="ASPxNavBar1_ExpandedChanging">
				<GroupHeaderStyle HorizontalAlign="Left" />
				<ItemStyle HorizontalAlign="Left" />
				<Groups>
					<dx:NavBarGroup Name="developers" Text="Developers">
						<Items>
							<dx:NavBarItem Name="kevin" Text="Kevin">
								<Image Height="16px" Url="~/NavBar/Images/online.png" Width="16px" />
							</dx:NavBarItem>
							<dx:NavBarItem Name="john" Text="John">
								<Image Height="16px" Url="~/NavBar/Images/online.png" Width="16px" />
							</dx:NavBarItem>
							<dx:NavBarItem Name="barry" Text="Barry">
								<Image Height="16px" Url="~/NavBar/Images/online.png" Width="16px" />
							</dx:NavBarItem>
							<dx:NavBarItem Name="jane" Text="Jane">
								<Image Height="16px" Url="~/NavBar/Images/online.png" Width="16px" />
							</dx:NavBarItem>
							<dx:NavBarItem Name="bob" Text="Bob">
								<Image Height="16px" Url="~/NavBar/Images/online.png" Width="16px" />
							</dx:NavBarItem>
						</Items>
					</dx:NavBarGroup>
					<dx:NavBarGroup Name="support" Text="Support Engineers">
						<Items>
							<dx:NavBarItem Name="harry" Text="Harry">
								<Image Height="16px" Url="~/NavBar/Images/online.png" Width="16px" />
							</dx:NavBarItem>
							<dx:NavBarItem Name="steven" Text="Steven">
								<Image Height="16px" Url="~/NavBar/Images/online.png" Width="16px" />
							</dx:NavBarItem>
						</Items>
					</dx:NavBarGroup>
					<dx:NavBarGroup Text="Technical Writers" Name="writers">
						<Items>
							<dx:NavBarItem Text="Jeff" Name="jeff">
								<Image Height="16px" Url="~/NavBar/Images/online.png" Width="16px" />
							</dx:NavBarItem>
							<dx:NavBarItem Text="Jerry" Name="jerry">
								<Image Height="16px" Url="~/NavBar/Images/online.png" Width="16px" />
							</dx:NavBarItem>
							<dx:NavBarItem Text="Bill" Name="bill" Selected="True">
								<Image Height="16px" Url="~/NavBar/Images/online.png" Width="16px" />
							</dx:NavBarItem>
						</Items>
					</dx:NavBarGroup>
				</Groups>
			</dx:ASPxNavBar>
		</div>
		<div style="float: left">
			<table class="OptionsTable">
				<tr>
					<td>
						<dx:ASPxLabel runat="server" Text="Choose item:" ID="lblItems" AssociatedControlID="cbItems" />
					</td>
					<td>
						<dx:ASPxComboBox AutoPostBack="True" Width="150px" ID="ddlItems" runat="server" OnSelectedIndexChanged="ddlItems_SelectedIndexChanged"
							OnLoad="ddlItems_Load">
						</dx:ASPxComboBox>
					</td>
				</tr>
				<tr>
					<td>
					</td>
					<td>
						<dx:ASPxCheckBox AutoPostBack="true" ID="cbEnable" Checked="true" runat="server"
							OnCheckedChanged="cbEnable_CheckedChanged" Text="Enable" />
					</td>
				</tr>
				<tr>
					<td>
					</td>
					<td>
						<dx:ASPxCheckBox AutoPostBack="true" ID="cbVisible" Checked="true" runat="server"
							OnCheckedChanged="cbVisible_CheckedChanged" Text="Visible" />
					</td>
				</tr>
				<tr>
					<td>
					</td>
					<td>
						<dx:ASPxCheckBox AutoPostBack="true" ID="cbSelect" Checked="true" runat="server"
							OnCheckedChanged="cbSelect_CheckedChanged" Text="Expanded" />
					</td>
				</tr>
			</table>
		</div>
	</div>
	<dx:ServerEventMonitor ID="EventMonitor" runat="server" EventNames="ItemClick HeaderClick ExpandedChanging ExpandedChanged" EventLogWidth="540" />
</asp:Content>