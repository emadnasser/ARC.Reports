<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClearButton.aspx.vb" Inherits="Features_ClearButton" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<script type="text/javascript">
		function displayComboBoxValue() {
			var value = ComboBox.GetValue();
			ValueLabel.SetText('Value = ' + (value === null ? 'null' : value));
		}
		function onInit() {
			ComboBox.SetFocus();
			displayComboBoxValue();
		}
	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
	<table>
		<tbody>
			<tr>
				<td>
					<dx:ASPxComboBox ID="ComboBox" ClientInstanceName="ComboBox" DataSourceID="ProgLanguageDataSource" Caption="Language"
						TextField="Name" ValueField="ID" runat="server">
						<ClearButton DisplayMode="OnHover"></ClearButton>
						<ClientSideEvents Init="onInit" ValueChanged="displayComboBoxValue" />
					</dx:ASPxComboBox>
				</td>
				<td style="padding-left: 1em;">
					<dx:ASPxLabel ID="ValueLabel" ClientInstanceName="ValueLabel" runat="server"></dx:ASPxLabel>
				</td>
			</tr>
		</tbody>
	</table>
	<asp:XmlDataSource ID="ProgLanguageDataSource" runat="server" DataFile="~/App_Data/ProgLanguages.xml" />
</asp:Content>