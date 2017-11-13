<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="RightToLeft.aspx.vb" Inherits="Accessibility_RightToLeft" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="text-align: right;" dir="rtl">
		<table class="OptionsTable">
			<tr>
				<td style="width: 80px">
					<dx:ASPxLabel runat="server" ID="FirstNameLabel" Text="First Name:" AssociatedControlID="FirstNameBox" RightToLeft="True" />
				</td>
				<td>
					<dx:ASPxTextBox runat="server" ID="FirstNameBox" RightToLeft="True" Width="200px" />
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel runat="server" ID="LastNameLabel" Text="Last Name:" AssociatedControlID="LastNameBox" RightToLeft="True" />
				</td>
				<td>
					<dx:ASPxTextBox runat="server" ID="LastNameBox" RightToLeft="True" Width="200px" />
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel runat="server" ID="GenderLabel" Text="Gender:" RightToLeft="True" />
				</td>
				<td>
					<dx:ASPxRadioButton ID="MaleRadio" runat="server" Text="Male" Checked="true" GroupName="gender" RightToLeft="True" />
					<dx:ASPxRadioButton ID="FemaleRadio" runat="server" Text="Female" GroupName="gender" RightToLeft="True" />
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel runat="server" ID="BirthdayLabel" Text="Birthday:" AssociatedControlID="BirthdayBox" RightToLeft="True" />
				</td>
				<td>
					<dx:ASPxDateEdit runat="server" ID="BirthdayBox" RightToLeft="True" Width="200px" />
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel runat="server" ID="CountryLabel" Text="Country:" AssociatedControlID="CountryCombo" RightToLeft="True" />
				</td>
				<td>
					<dx:ASPxComboBox runat="server" ID="CountryCombo" DataSourceID="CountriesDataSource" ValueField="CountryName" TextField="CountryName" Width="200px" RightToLeft="True" />
				</td>
			</tr>
			<tr>
				<td>
				</td>
				<td>
					<dx:ASPxButton runat="server" ID="btnCreateAccount" Text="Create Account" RightToLeft="True" AutoPostBack="false" />
				</td>
			</tr>
		</table>
	</div>
	<ef:EntityDataSource runat="server" ID="CountriesDataSource" ContextTypeName="WorldCitiesContext" EntitySetName="Countries" OrderBy="it.CountryName" />
	<script type="text/javascript">
		if(ASPxClientUtils.ie && ASPxClientUtils.browserVersion > 7 && document.body.offsetWidth % 2 > 0)
			document.body.style.width = (document.body.offsetWidth - 1) + "px";
	</script>
</asp:Content>