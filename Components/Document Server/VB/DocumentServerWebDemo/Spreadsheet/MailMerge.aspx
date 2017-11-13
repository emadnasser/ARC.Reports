<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MailMerge.aspx.vb"
	Inherits="Spreadsheet_MailMerge" %>
<%@ Register Src="~/UserControls/WorkbookPreviewControl.ascx" TagPrefix="dx" TagName="Preview" %>
<%@ Register Src="~/UserControls/SpreadsheetDocumentDownloader.ascx" TagPrefix="dx" TagName="DocumentDownloader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
	// <![CDATA[
		function UpdatePreview() {
			var teStatementNumberValue = teStatementNumber.GetValue();
			var teStreetAddressValue = teStreetAddress.GetValue();
			var teZipCodeValue = teZipCode.GetValue();
			var teCustomerIDValue = teCustomerID.GetValue();
			var teCityValue = teCity.GetValue();
			var tePhoneValue = tePhone.GetValue();
			var teCustomerNameValue = teCustomerName.GetValue();
			var teStateValue = teState.GetValue();
			var teEmailValue = teEmail.GetValue();
			var previewFrame = document.getElementById("previewFrame");
			var params = "&" + "statementNumber=" + encodeURIComponent(teStatementNumberValue) +
															"&streetAddress=" + encodeURIComponent(teStreetAddressValue) +
															"&zipCode=" + encodeURIComponent(teZipCodeValue) +
															"&CustomerID=" + encodeURIComponent(teCustomerIDValue) +
															"&city=" + encodeURIComponent(teCityValue) +
															"&phone=" + encodeURIComponent(tePhoneValue) +
															"&customerName=" + encodeURIComponent(teCustomerNameValue) +
															"&state=" + encodeURIComponent(teStateValue) +
															"&email=" + encodeURIComponent(teEmailValue);
			clientPreviewControl.Update(params);
		}
	// ]]> 
	</script>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Demo Options">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<table class="OptionsTable">
					<tr>
						<td>
							<dx:ASPxLabel ID="lblStatementNumber" runat="server" Text="Statement&nbsp;Number:"
								AssociatedControlID="teStatementNumber">
							</dx:ASPxLabel>
						</td>
						<td class="column2Style">
							<dx:ASPxTextBox ID="teStatementNumber" ClientInstanceName="teStatementNumber" runat="server"
								Height="20px" Width="145
								px" Text="No.">
								<ClientSideEvents ValueChanged="function(s, e) { UpdatePreview(); }" />
							</dx:ASPxTextBox>
						</td>
						<td>
							<dx:ASPxLabel ID="lblStreetAddress" runat="server" Text="Street&nbsp;Address:" AssociatedControlID="teStreetAddress">
							</dx:ASPxLabel>
						</td>
						<td>
							<dx:ASPxTextBox ID="teStreetAddress" ClientInstanceName="teStreetAddress" runat="server"
								Height="20px" Width="155px" Text="NE&nbsp;74th&nbsp;St,&nbsp;Town&nbsp;Center">
								<ClientSideEvents ValueChanged="function(s, e) { UpdatePreview(); }" />
							</dx:ASPxTextBox>
						</td>
						<td rowspan="5" style="vertical-align:top; text-align:right;">
							<dx:DocumentDownloader runat="server" ID="DocumentDownloader" OnRequestWorkbook="OnDocumentDownloaderRequestWorkbook" Inline="false" />
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxLabel ID="lblCustomerID" runat="server" Text="Customer&nbsp;ID:" AssociatedControlID="teCustomerID"
								Height="13px" Width="94px" Style="margin-top: 0px">
							</dx:ASPxLabel>
						</td>
						<td class="column2Style">
							<dx:ASPxTextBox ID="teCustomerID" ClientInstanceName="teCustomerID" runat="server"
								Height="20px" Width="145px" Text="ABC12345">
								<ClientSideEvents ValueChanged="function(s, e) { UpdatePreview(); }" />
							</dx:ASPxTextBox>
						</td>
						<td>
							<dx:ASPxLabel ID="lblCity" runat="server" Text="City: " AssociatedControlID="teCity">
							</dx:ASPxLabel>
						</td>
						<td>
							<dx:ASPxTextBox ID="teCity" ClientInstanceName="teCity" runat="server" Width="155px"
								Text="Redmond">
								<ClientSideEvents ValueChanged="function(s, e) { UpdatePreview(); }" />
							</dx:ASPxTextBox>
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxLabel ID="lblCustomerName" runat="server" Text="Customer Name:" AssociatedControlID="teCustomerName">
							</dx:ASPxLabel>
						</td>
						<td class="column2Style">
							<dx:ASPxTextBox ID="teCustomerName" ClientInstanceName="teCustomerName" runat="server"  Width="145px"
								Text="Margaret Peacock">
								<ClientSideEvents ValueChanged="function(s, e) { UpdatePreview(); }" />
							</dx:ASPxTextBox>
						</td>
						<td>
							<dx:ASPxLabel ID="lblState" Text="State:" AssociatedControlID="teState" runat="server">
							</dx:ASPxLabel>
						</td>
						<td>
							<dx:ASPxTextBox ID="teState" Width="155px" ClientInstanceName="teState" runat="server"
								Text="WA">
								<ClientSideEvents ValueChanged="function(s, e) { UpdatePreview(); }" />
							</dx:ASPxTextBox>
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxLabel ID="lblEmail" AssociatedControlID="teEmail" runat="server" Text="E-mail:">
							</dx:ASPxLabel>
						</td>
						<td class="column2Style">

							<dx:ASPxTextBox ID="teEmail" runat="server" ClientInstanceName="teEmail" Height="17px" Text="mpeacock@example.net" Width="145px">
								<ClientSideEvents ValueChanged="function(s, e) { UpdatePreview(); }" />
							</dx:ASPxTextBox>

						</td>
						<td>
							<dx:ASPxLabel ID="lblZipCode" runat="server" Text="ZIP&nbsp;Code:" AssociatedControlID="teZipCode"
								Height="13px" Width="76px">
							</dx:ASPxLabel>
						</td>
						<td style="width: 100%">
							<dx:ASPxTextBox ID="teZipCode" ClientInstanceName="teZipCode" runat="server" Height="20px"
								Width="155px" Text="98052">
								<ClientSideEvents ValueChanged="function(s, e) { UpdatePreview(); }" />
							</dx:ASPxTextBox>
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxLabel ID="lblPhone" runat="server" Text="Phone:" AssociatedControlID="tePhone">
							</dx:ASPxLabel>
						</td>
						<td class="column2Style">
							<dx:ASPxTextBox ID="tePhone" ClientInstanceName="tePhone" Width="145px" Text="(206)555-812"
								runat="server">
								<ClientSideEvents ValueChanged="function(s, e) { UpdatePreview(); }" />
							</dx:ASPxTextBox>
						</td>
						<td>
						</td>
						<td>
						</td>
						<td>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<br />
	<dx:Preview runat="server" ID="previewControl" ClientInstanceName="clientPreviewControl" />
</asp:Content>
<asp:Content ID="Content2" runat="server" 
	contentplaceholderid="CustomHeadHolder">
	<style type="text/css">
		.style1
		{
			width: 158px;
		}
		.column2Style
		{
			padding-right:40px !important;
			margin-right:10px;
			width: 400px;
		}
	</style>
</asp:Content>