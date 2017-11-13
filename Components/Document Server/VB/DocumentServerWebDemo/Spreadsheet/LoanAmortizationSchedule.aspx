<%@ Page Language="vb" MasterPageFile="~/Site.master"  AutoEventWireup="true" CodeFile="LoanAmortizationSchedule.aspx.vb" Inherits="Spreadsheet_LoanAmortizationSchedule" %>
<%@ Register Src="~/UserControls/WorkbookPreviewControl.ascx" TagPrefix="dx" TagName="Preview" %>
<%@ Register Src="~/UserControls/SpreadsheetDocumentDownloader.ascx" TagPrefix="dx" TagName="DocumentDownloader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
	// <![CDATA[
		function UpdatePreview() {
			var spnLoanAmountValue = spnLoanAmount.GetValue();
			var spnLoanPeriodValue = spnLoanPeriod.GetValue();
			var spnInterestRateValue = spnInterestRate.GetValue();
			var edStartDateValue = edStartDate.GetDate();
			var previewFrame = document.getElementById("previewFrame");
			var params = "&" + "spnLoanAmount=" + encodeURIComponent(spnLoanAmountValue) +
													"&spnLoanPeriod=" + encodeURIComponent(spnLoanPeriodValue) +
													"&spnInterestRate=" + encodeURIComponent(spnInterestRateValue) +
													"&edStartDate=" + encodeURIComponent(GetDateForTransfer(edStartDateValue));
			clientPreviewControl.Update(params);
		}
		function GetDateForTransfer(date) {
			return FormatTo2Dig(date.getDate()) + "/" + FormatTo2Dig(date.getMonth()+1) + "/" + date.getFullYear();
		}
		function FormatTo2Dig(value) {
			if (value >= 0 && value < 10)
				return "0" + value;
			return "" + value;
		}
	// ]]> 
	</script>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Demo Options">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<table class="OptionsTable">
					<tr>
						<td>
							<dx:ASPxLabel ID="lblLoanAmount" runat="server" Text="Loan&nbsp;Amount: " AssociatedControlID="spnLoanAmount">
							</dx:ASPxLabel>
						</td>
						<td>
							<dx:ASPxSpinEdit ID="spnLoanAmount" ClientInstanceName="spnLoanAmount" runat="server" Height="19px" Number="19900"  
								NumberType="Integer" AllowNull="false" 
								Width="80px" MaxValue="200000" 
								MinValue="100" Increment="100" LargeIncrement="1000">
								<ClientSideEvents ValueChanged="function(s,e) { UpdatePreview(); }" />
							</dx:ASPxSpinEdit>
						</td>
						<td>
							<dx:ASPxLabel ID="lblLoanPeriod" runat="server" Text="Loan&nbsp;Period&nbsp;in&nbsp;Years: " AssociatedControlID="spnLoanAmount">
							</dx:ASPxLabel>
						</td>
						<td style="width:100%">
							<dx:ASPxSpinEdit ID="spnLoanPeriod" ClientInstanceName="spnLoanPeriod" runat="server" Height="19px" Number="2"  
								NumberType="Integer" AllowNull="false" 
								Width="90px" MaxValue="10" 
								MinValue="1">
								<ClientSideEvents ValueChanged="function(s,e) { UpdatePreview(); }" />
							</dx:ASPxSpinEdit>
						</td>
						<td></td>
					</tr>
					<tr>
						<td>
							<dx:ASPxLabel ID="lblInterestRate" runat="server" Text="Annual&nbsp;Interest&nbsp;Rate: " AssociatedControlID="spnInterestRate">
							</dx:ASPxLabel>
						</td>
						<td>
							<dx:ASPxSpinEdit ID="spnInterestRate" ClientInstanceName="spnInterestRate" runat="server" Height="19px" Number="0.055" 
								Width="80px" DisplayFormatString="p" Increment="0.0001" LargeIncrement="0.1" MinValue="0.0001" MaxValue="1" AllowNull="false">
								<ClientSideEvents ValueChanged="function(s,e) { UpdatePreview(); }" />
							</dx:ASPxSpinEdit>
						</td>
						<td>
							<dx:ASPxLabel ID="lblStartDate" runat="server" Text="Start&nbsp;Date&nbsp;of&nbsp;Loan: " AssociatedControlID="edStartDate">
							</dx:ASPxLabel>
						</td>
						<td>
							<dx:ASPxDateEdit ID="edStartDate" ClientInstanceName="edStartDate" runat="server" Width="90px">
								<ClientSideEvents Init="function(s, e) { var currentDate = s.GetDate(); if (!currentDate) { s.SetDate(new Date()); } }" ValueChanged="function(s,e) { UpdatePreview(); }"  />
							</dx:ASPxDateEdit>
						</td>
						<td style="vertical-align:bottom;">
							<dx:DocumentDownloader runat="server" ID="DocumentDownloader" OnRequestWorkbook="OnDocumentDownloaderRequestWorkbook" />
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<br />
	<dx:Preview runat="server" ID="previewControl" ClientInstanceName="clientPreviewControl" ShowOnlyFirstWorksheet="true" />
</asp:Content>