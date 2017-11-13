<%@ Page Language="vb"MasterPageFile="~/Site.master"  AutoEventWireup="true" CodeFile="NumberInWords.aspx.vb" Inherits="Miscellaneous_NumberInWords" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
		function OnNumberChanged(cmbEmployee) {
			tlResult.PerformCallback(spnNumber.GetValue().toString());
		}
	</script>
	<dx:ASPxRoundPanel ID="ASPxInputRoundPanel" runat="server" Width="100%" HeaderText="Input Data">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<table class="OptionsTable">
					<tr>
						<td class="style1" style="width: 100px;">
							<dx:ASPxLabel ID="lblNumber" runat="server" Text="Number: " AssociatedControlID="spnNumber">
							</dx:ASPxLabel>
						</td>
						<td class="style1">
							<dx:ASPxSpinEdit ID="spnNumber" ClientInstanceName="spnNumber" runat="server" Height="19px" Number="4321"  
								Width="100px" LargeIncrement="5" 
								MaxValue="32767" MinValue="1">
								<ClientSideEvents ValueChanged="function(s, e) { OnNumberChanged(s); }" />
							</dx:ASPxSpinEdit>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<br />
	<dx:ASPxRoundPanel ID="ASPxResultRoundPanel" runat="server" Height="84px" Width="100%" HeaderText="Result">
		<PanelCollection>
			<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
				<dx:ASPxTreeList ID="tlResult" ClientInstanceName="tlResult" runat="server" AutoGenerateColumns="False" Width="100%">
					<Columns>
						<dx:TreeListTextColumn Caption="Culture" Name="tlcCulture" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="0" Width="150px" FieldName="Culture">
						</dx:TreeListTextColumn>
						<dx:TreeListTextColumn AllowSort="False" Caption="Value" Name="tlcValue" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="1" FieldName="Value">
						</dx:TreeListTextColumn>
					</Columns>
				</dx:ASPxTreeList>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<br />
	</asp:Content>
<asp:Content ID="Content2" runat="server" 
	contentplaceholderid="CustomHeadHolder">
	<style type="text/css">
		.style1
		{
			height: 23px;
		}
	</style>
</asp:Content>