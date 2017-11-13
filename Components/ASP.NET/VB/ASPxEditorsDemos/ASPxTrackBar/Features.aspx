<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.vb" Inherits="ASPxTrackBar_Features" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.dxeTBHSys.center 
		{
			margin: 60px auto;
		}
		.dxeTBVSys.center 
		{
			margin: auto;
		}
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<div style="float: left; width: 100%">
		<div style="float: left; width: 300px; height: 250px">
			<dx:ASPxTrackBar ID="trackBar" CssClass="center" runat="server" MinValue="0" MaxValue="50" Step="1" 
				LargeTickInterval="10" SmallTickFrequency="5" EnableViewState="false" />
		</div>
		<div style="float: left">
			<table class="OptionsTable">
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="orientationComboBox" Text="Orientation:" /></td>
					<td>
						<dx:ASPxComboBox ID="orientationComboBox" runat="server" AutoPostBack="true" Width="130px" SelectedIndex="0">
							<Items>
								<dx:ListEditItem Text="Horizontal" Value="1" />
								<dx:ListEditItem Text="Vertical" Value="2" />
							</Items>
						</dx:ASPxComboBox>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="directionComboBox" Text="Direction:" /></td>
					<td>
						<dx:ASPxComboBox ID="directionComboBox" runat="server" AutoPostBack="true" Width="130px" SelectedIndex="0">
							<Items>
								<dx:ListEditItem Text="Normal" Value="1" />
								<dx:ListEditItem Text="Reversed" Value="2" />
							</Items>
						</dx:ASPxComboBox>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="highlightModeComboBox" Text="ScaleLabelHighlightMode:" /></td>
					<td>
						<dx:ASPxComboBox ID="highlightModeComboBox" runat="server" AutoPostBack="true" Width="130px" SelectedIndex="0">
							<Items>
								<dx:ListEditItem Text="None" Value="1" />
								<dx:ListEditItem Text="AlongBarHighlight" Value="2" />
								<dx:ListEditItem Text="HandlePosition" Value="3" />
							</Items>
						</dx:ASPxComboBox>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="scalePositionComboBox" Text="ScalePosition:" /></td>
					<td>
						<dx:ASPxComboBox ID="scalePositionComboBox" runat="server" AutoPostBack="true" Width="130px" SelectedIndex="0">
							<Items>
								<dx:ListEditItem Text="LeftOrTop" Value="1" />
								<dx:ListEditItem Text="RightOrBottom" Value="2" />
								<dx:ListEditItem Text="Both" Value="3" />
								<dx:ListEditItem Text="None" Value="4" />
							</Items>
						</dx:ASPxComboBox>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="valueToolTipPositionComboBox" Text="ValueToolTipPosition:" /></td>
					<td>
						<dx:ASPxComboBox ID="valueToolTipPositionComboBox" runat="server" AutoPostBack="true" Width="130px" SelectedIndex="0">
							<Items>
								<dx:ListEditItem Text="LeftOrTop" Value="1" />
								<dx:ListEditItem Text="RightOrBottom" Value="2" />
								<dx:ListEditItem Text="None" Value="3" />
							</Items>
						</dx:ASPxComboBox>
					</td>
				</tr>
				<tr>
					<td colspan="2" style="padding-top: 10px">
						<dx:ASPxCheckBox ID="showDHCheckBox" runat="server" Text="ShowDragHandles" AutoPostBack="true" Checked="true" />
					</td>
				</tr>
				<tr>
					<td colspan="2">
						<dx:ASPxCheckBox ID="showButtonsCheckBox" runat="server" Text="ShowChangeButtons" AutoPostBack="true" Checked="true" />
					</td>
				</tr>
				<tr>
					 <td colspan="2">
						<dx:ASPxCheckBox ID="equalizeTickCheckBox" runat="server" Text="EqualTickMarks" AutoPostBack="true" Checked="false" />
					</td>
				</tr>
			</table>
		</div>
	</div>
</asp:Content>