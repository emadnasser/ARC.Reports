<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="Caption.aspx.vb" Inherits="Features_Caption" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.cellWithEditor {
			width: 400px;
			padding-bottom: 40px;

		}
		.cellWithDescription {
			padding-bottom: 40px;
		}
		.captionTextBox {
			margin-bottom:3px;
		}
		.description {
			line-height:22px
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
	<table>
		<tr>
			<td class="cellWithEditor">
				<dx:ASPxTextBox runat="server" ID="textBox" ClientInstanceName="textBox" Caption="Text Box" Text="Text" Width="120px">
				</dx:ASPxTextBox>
			</td>
			<td class="cellWithDescription">
				<dx:ASPxTextBox Caption="Caption = " runat="server" ID="textBoxCaption" Text="Text Box" MaxLength="30">
					<CaptionSettings ShowColon="false" />
					<ClientSideEvents KeyUp="function(s,e) { textBox.SetCaption(s.GetText()); }" />
				</dx:ASPxTextBox>
			</td>
		</tr>
		<tr >
			<td class="cellWithEditor" style="vertical-align:top;">
				<dx:ASPxComboBox ID="comboBox" ClientInstanceName="comboBox" runat="server" Caption="Combo Box" SelectedIndex="0" CaptionSettings-Position="Top" DropDownStyle="DropDown">
					<Items>
						<dx:ListEditItem Text="Item 1" Value="1" />
						<dx:ListEditItem Text="Item 2" Value="2" />
						<dx:ListEditItem Text="Item 3" Value="3" />
					</Items>
					<ValidationSettings RequiredField-IsRequired="true" />
				</dx:ASPxComboBox>
			</td>
			<td class="cellWithDescription">
				<dx:ASPxTextBox Caption="Caption = " runat="server" ID="comboBoxCaption" Text="Combo Box" CssClass="captionTextBox" MaxLength="30">
					<CaptionSettings ShowColon="false" />
					<ClientSideEvents KeyUp="function(s,e) { comboBox.SetCaption(s.GetText()); }" />
				</dx:ASPxTextBox>
				<span class="description">CaptionSettings.RequiredMarkDisplayMode="Auto" (default value) <br/>
				CaptionSettings.RequiredMark="*" (default value)<br/>
				CaptionSettings.Position = "Top"<br/>
				ValidationSettings.RequiredField.IsRequired = "true"</span>
			</td>
		</tr>
		<tr>
			<td class="cellWithEditor">
				<dx:ASPxMemo ID="memo" ClientInstanceName="memo" runat="server" Height="71px" Width="170px" Caption="Memo" Text="Text">
					<CaptionSettings Position="Top" RequiredMarkDisplayMode="Optional" OptionalMark=" (optional)" />
				</dx:ASPxMemo>
			</td>
			<td class="cellWithDescription">
				<dx:ASPxTextBox Caption="Caption = " runat="server" ID="memoCaption" Text="Memo" CssClass="captionTextBox" MaxLength="30">
					<CaptionSettings ShowColon="false" />
					<ClientSideEvents KeyUp="function(s,e) { memo.SetCaption(s.GetText()); }" />
				</dx:ASPxTextBox>
				<span class="description">CaptionSettings.Position = "Top"<br/>
				CaptionSettings.RequiredMarkDisplayMode="Optional"<br/>
				CaptionSettings.OptionalMark=" (optional)"</span>
			</td>
		</tr>
		<tr>
			<td class="cellWithEditor">
				<dx:ASPxRadioButtonList ID="radioButtonList" ClientInstanceName="radioButtonList" runat="server" Caption="Radio Button List" CaptionSettings-VerticalAlign="Middle">
					<Items>
						<dx:ListEditItem Text="Item 1" Value="1" />
						<dx:ListEditItem Text="Item 2" Value="2" />
					</Items>
				</dx:ASPxRadioButtonList>
			</td>
			<td class="cellWithDescription">
				<dx:ASPxTextBox Caption="Caption = " runat="server" ID="radioButtonListCaption" Text="Radio Button List" CssClass="captionTextBox"  MaxLength="30">
					<CaptionSettings ShowColon="false" />
					<ClientSideEvents KeyUp="function(s,e) { radioButtonList.SetCaption(s.GetText()); }" />
				</dx:ASPxTextBox>
				<span class="description">CaptionSettings.VerticalAlign = "Middle"</span>
			</td>
		</tr>
	</table>
</asp:Content>