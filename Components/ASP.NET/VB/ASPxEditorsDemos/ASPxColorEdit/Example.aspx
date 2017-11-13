<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Example.aspx.vb"
	Inherits="ASPxColorEdit_Example" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="Server">
	<style type="text/css">
		.ActionLabel {
			padding-right: 14px;
			text-align: left;
		}
		.ActionIndent {
			padding-top: 7px;
		}
	</style>
	<%--start highlighted block--%>
	<script type="text/javascript">
		function ColorChangedHandler(s, e) {
			CallbackPanel.PerformCallback();
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="float: left">
		<div>
			<table class="OptionsTable">
				<tr>
					<td>
						<dx:ASPxLabel ID="lblBackColor" runat="server" Text="Header background color:" AssociatedControlID="ColorEditHeaderBackColor" />
					</td>
					<td>
						<dx:ASPxColorEdit runat="server" ID="ColorEditHeaderBackColor" Color="#dedede">
							<ClientSideEvents ColorChanged="ColorChangedHandler" />
						</dx:ASPxColorEdit>
					</td>
				</tr>
				<tr>
					<td>
						<dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Background color:" AssociatedControlID="ColorEditBackColor" />
					</td>
					<td>
						<dx:ASPxColorEdit runat="server" ID="ColorEditBackColor" Color="#f7f7f7">
							<ClientSideEvents ColorChanged="ColorChangedHandler" />
						</dx:ASPxColorEdit>
					</td>
				</tr>
				<tr>
					<td>
						<dx:ASPxLabel ID="lblBorderColor" runat="server" Text="Border color:" AssociatedControlID="ColorEditBorderColor" />
					</td>
					<td>
						<dx:ASPxColorEdit runat="server" ID="ColorEditBorderColor" Color="#808080">
							<ClientSideEvents ColorChanged="ColorChangedHandler" />
						</dx:ASPxColorEdit>
					</td>
				</tr>
				<tr>
					<td>
						<dx:ASPxLabel ID="lblForeColor" runat="server" Text="Font color:" AssociatedControlID="ColorEditForeColor" />
					</td>
					<td>
						<dx:ASPxColorEdit runat="server" ID="ColorEditForeColor" Color="#000000">
							<ClientSideEvents ColorChanged="ColorChangedHandler" />
						</dx:ASPxColorEdit>
					</td>
				</tr>
			</table>
		</div>
		<div style="margin-top: 40px">
			<dx:ASPxCallbackPanel runat="server" ID="CallbackPanel" ClientInstanceName="CallbackPanel" Width="275px" Height="119px" OnCallback="OnCallBack">
				<PanelCollection>
					<dx:PanelContent ID="PanelContent1" runat="server">
						<dx:ASPxRoundPanel runat="server" ID="RoundPanel" EnableTheming="False">
							<PanelCollection>
								<dx:PanelContent ID="PanelContent2" runat="server">
									<div style="width: 250px; height: 60px;">
										Content
									</div>
								</dx:PanelContent>
							</PanelCollection>
							<HeaderStyle>
								<BorderBottom BorderWidth="0px" />
							</HeaderStyle>
							<Border BorderWidth="1" BorderStyle="Solid" />
						</dx:ASPxRoundPanel>
					</dx:PanelContent>
				</PanelCollection>
			</dx:ASPxCallbackPanel>
		</div>
	</div>
	<div style="float: right;">
		<table class="OptionsTable">
			<tr>
				<td>
					<dx:ASPxLabel ID="labelEnableCustomColors" runat="server" Text="Enable Custom Colors:" AssociatedControlID="ASPxCheckBoxEnableCustomColors" />
				</td>
				<td>
					<dx:ASPxCheckBox ID="ASPxCheckBoxEnableCustomColors" runat="server" Checked="true"/>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="labelColumns" runat="server" Text="Column Count:" AssociatedControlID="ASPxSpinEditColumns" />
				</td>
				<td>
					<dx:ASPxSpinEdit ID="ASPxSpinEditColumns" runat="server" Number="8" MinValue="1" MaxValue="30" AllowNull="false">
					</dx:ASPxSpinEdit>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="labelPalettes" runat="server" Text="Palette:" AssociatedControlID="ASPxComboBoxPalettes"/>
				</td>
				<td>
					<dx:ASPxComboBox ID="ASPxComboBoxPalettes" runat="server">
						<Items>
							<dx:ListEditItem Text="Default" Value="0" Selected="true"/>
							<dx:ListEditItem Text="Gray"  Value="1"/>
							<dx:ListEditItem Text="Red" Value="2"/>
							<dx:ListEditItem Text="Green" Value="3"/>
							<dx:ListEditItem Text="Blue" Value="4"/>
						</Items>
					</dx:ASPxComboBox>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxButton ID="ASPxButtonApply" runat="server" Text="Apply" Width="65" AutoPostBack="true"/>
				</td>
			</tr>
		</table>
	</div>
</asp:Content>