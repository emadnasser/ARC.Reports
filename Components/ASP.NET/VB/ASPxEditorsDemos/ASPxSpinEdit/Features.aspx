<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.vb"
	Inherits="ASPxSpinEdit_Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<div style="float: left; width: 100%">
		<div style="float: left; width: 200px">
			<dx:ASPxSpinEdit ID="ASPxSpinEdit1" runat="server" Number="1">
				<SpinButtons ShowIncrementButtons="False" ShowLargeIncrementButtons="True" />
			</dx:ASPxSpinEdit>
		</div>
		<div style="float: left">
			<div>
				ShowIncrementButtons = False
			</div>
			<div class="TopPadding">
				ShowLargeIncrementButtons = True
			</div>
		</div>
	</div>
	<div style="float: left; width: 100%; clear: both; margin-top: 32px">
		<div style="float: left; width: 200px">
			<dx:ASPxSpinEdit ID="ASPxSpinEdit2" runat="server" Number="10" NumberType="Integer"
				Increment="2" HorizontalAlign="Right">
				<Paddings PaddingRight="5px" />
				<SpinButtons Position="Left" ShowLargeIncrementButtons="True" />
			</dx:ASPxSpinEdit>
		</div>
		<div style="float: left">
			<div>
				NumberType = Integer
			</div>
			<div class="TopPadding">
				Increment = 2
			</div>
			<div class="TopPadding">
				LargeIncrement = 10
			</div>
		</div>
	</div>
	<div style="float: left; width: 100%; clear: both; margin-top: 32px">
		<div style="float: left; width: 200px">
			<dx:ASPxSpinEdit ID="ASPxSpinEdit3" runat="server" Number="13" NumberType="Integer"
				MinValue="10" MaxValue="16">
			</dx:ASPxSpinEdit>
		</div>
		<div style="float: left">
			<div>
				NumberType = Integer
			</div>
			<div class="TopPadding">
				MinValue = 10
			</div>
			<div class="TopPadding">
				MaxValue = 16
			</div>
		</div>
	</div>
	<div style="float: left; width: 100%; clear: both; margin-top: 32px">
		<div style="float: left; width: 200px">
			<dx:ASPxSpinEdit ID="ASPxSpinEdit4" runat="server" Number="55.12" DecimalPlaces="2" DisplayFormatString="{0:C}">
			</dx:ASPxSpinEdit>
		</div>
		<div style="float: left">
			<div>
				DecimalPlaces = 2
			</div>
			<div class="TopPadding">
				DisplayFormatString = {0:C}
			</div>
			<div class="TopPadding">
				<table class="OptionsTable">
					<tr>
						<td>
							Page UI Culture:&nbsp;
						</td>
						<td>
							<dx:ASPxComboBox ID="cmbCultureSelector" runat="server" SelectedIndex="0" Width="120px">
								<Items>
									<dx:ListEditItem Value="en-US" Text="English (USA)" />
									<dx:ListEditItem Value="it-IT" Text="Italian" />
								</Items>
								<ClientSideEvents SelectedIndexChanged="function(s, e) { document.location.href = '?cult=' + s.GetSelectedItem().value; }" />
							</dx:ASPxComboBox>
						</td>
					</tr>
				</table>
			</div>
		</div>
	</div>

</asp:Content>