<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="NativeMode.aspx.vb"
	Inherits="Features_NativeMode" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		#NativeContainer textarea, 
		#NativeContainer select, 
		#NativeContainer input
		{
			font-family: Tahoma !important;
			font-size: 9pt !important;
		}
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<table class="OptionsTable" id="NativeContainer">
		<tr>
			<td style="width: 100px">
				<dx:ASPxLabel ID="lblTextBox" runat="server" Text="ASPxTextBox" />
			</td>
			<td>
				<dx:ASPxTextBox ID="TextBox" SkinID="None" runat="server" Native="True" Width="166px"
					Text="TextBox">
					<ClientSideEvents TextChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'TextChanged') }">
					</ClientSideEvents>
				</dx:ASPxTextBox>
			</td>
		</tr>
		<tr>
			<td style="vertical-align: top">
				<dx:ASPxLabel ID="lblMemo" runat="server" Text="ASPxMemo" />
			</td>
			<td>
				<dx:ASPxMemo ID="Memo" SkinID="None" runat="server" Native="True" Text="Memo" Height="70px"
					Width="166px">
					<ClientSideEvents TextChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'TextChanged') }">
					</ClientSideEvents>
				</dx:ASPxMemo>
			</td>
		</tr>
		<tr>
			<td style="vertical-align: top">
				<dx:ASPxLabel ID="lblListBox" runat="server" Text="ASPxListBox" />
			</td>
			<td>
				<dx:ASPxListBox ID="ListBox" SkinID="None" runat="server" Native="True" Height="70px"
					Width="170px">
					<Items>
						<dx:ListEditItem Text="Item 1" Value="Item1" />
						<dx:ListEditItem Text="Item 2" Value="Item2" />
						<dx:ListEditItem Text="Item 3" Value="Item3" />
						<dx:ListEditItem Text="Item 4" Value="Item4" />
						<dx:ListEditItem Text="Item 5" Value="Item5" />
						<dx:ListEditItem Text="Item 6" Value="Item6" />
						<dx:ListEditItem Text="Item 7" Value="Item7" />
						<dx:ListEditItem Text="Item 8" Value="Item8" />
						<dx:ListEditItem Text="Item 9" Value="Item9" />
					</Items>
					<ClientSideEvents SelectedIndexChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'SelectedIndexChanged') }">
					</ClientSideEvents>
				</dx:ASPxListBox>
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxLabel ID="lblComboBox" runat="server" Text="ASPxComboBox" />
			</td>
			<td>
				<dx:ASPxComboBox ID="ComboBox" SkinID="None" runat="server" Native="True" Width="170px"
					SelectedIndex="0">
					<Items>
						<dx:ListEditItem Text="Item 1" Value="Item1" />
						<dx:ListEditItem Text="Item 2" Value="Item2" />
						<dx:ListEditItem Text="Item 3" Value="Item3" />
						<dx:ListEditItem Text="Item 4" Value="Item4" />
						<dx:ListEditItem Text="Item 5" Value="Item5" />
						<dx:ListEditItem Text="Item 6" Value="Item6" />
						<dx:ListEditItem Text="Item 7" Value="Item7" />
						<dx:ListEditItem Text="Item 8" Value="Item8" />
						<dx:ListEditItem Text="Item 9" Value="Item9" />
					</Items>
					<ClientSideEvents SelectedIndexChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'SelectedIndexChanged') }">
					</ClientSideEvents>
				</dx:ASPxComboBox>
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxLabel ID="lblButton" runat="server" Text="ASPxButton" />
			</td>
			<td>
				<dx:ASPxButton ID="Button" SkinID="None" runat="server" AutoPostBack="False" Native="True"
					Text="Click here" >
					<ClientSideEvents Click="function(s, e) { DXEventMonitor.Trace(s, e, 'Click') }">
					</ClientSideEvents>
				</dx:ASPxButton>
			</td>
		</tr>
	</table>
	<br />
	<dx:EventMonitor runat="server" ID="EventMonitor" EventNames="TextChanged SelectedIndexChanged Click" EventLogWidth="500" />
</asp:Content>