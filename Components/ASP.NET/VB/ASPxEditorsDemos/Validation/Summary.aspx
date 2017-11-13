<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Summary.aspx.vb"
	Inherits="Validation_Summary" %>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="CustomHeadHolder">
	<style type="text/css">
		#summaryContainer ul
		{
			list-style: disc;
		}
		#summaryContainer ol
		{
			list-style: decimal;
		}
	</style>
	<%--start highlighted block--%>
	<script type="text/javascript">
		function OnClearButtonClick(s, e) {
			ASPxClientEdit.ClearEditorsInContainerById("form");
		}
		function OnBirthdayValidation(s, e) {
			var birthday = e.value;
			if(!birthday)
				return;
			var today = new Date();
			var msecPerYear = 1000 * 60 * 60 * 24 * 365;
			var years = (today.getTime() - birthday.getTime()) / msecPerYear;
			if(years < 14) {
				e.isValid = false;
				e.errorText = "You should be at least 14 years old";
			}
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
	<div style="float: left">
		<table id="form" class="OptionsTable">
			<tr>
				<td style="width: 80px">
					<dx:ASPxLabel ID="lblName" runat="server" Text="Name:" AssociatedControlID="tbName" />
				</td>
				<td>
					<dx:ASPxTextBox ID="tbName" runat="server" Width="200px">
						<ValidationSettings>
							<RequiredField IsRequired="True" ErrorText="Name is required" />
							<RegularExpression ValidationExpression=".{2,}" ErrorText="Name should contain at least two letters" />
						</ValidationSettings>
					</dx:ASPxTextBox>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="lblBirthday" runat="server" Text="Birthday:" AssociatedControlID="deBirthday" />
				</td>
				<td>
					<dx:ASPxDateEdit ID="deBirthday" runat="server" Width="200px">
						<ClientSideEvents Validation="OnBirthdayValidation" />
						<ValidationSettings>
							<RequiredField IsRequired="True" ErrorText="Birthday is required" />
						</ValidationSettings>
					</dx:ASPxDateEdit>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="lblOccupation" runat="server" Text="Occupation:" AssociatedControlID="cbOccupation" />
				</td>
				<td>
					<dx:ASPxComboBox ID="cbOccupation" runat="server" Width="200px" DropDownStyle="DropDown"
						DataSourceID="OccupationsDataSource" ValueField="OccupationName" TextField="OccupationName" MaxLength="128"
						IncrementalFilteringMode="StartsWith">
						<ValidationSettings>
							<RequiredField IsRequired="True" ErrorText="Occupation is required" />
						</ValidationSettings>
					</dx:ASPxComboBox>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="lblEmail" runat="server" Text="Email:" AssociatedControlID="tbEmail" />
				</td>
				<td>
					<dx:ASPxTextBox ID="tbEmail" runat="server" Width="200px">
						<ValidationSettings>
							<RequiredField IsRequired="True" ErrorText="E-mail is required" />
							<RegularExpression ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
								ErrorText="Invalid e-mail" />
						</ValidationSettings>
					</dx:ASPxTextBox>
				</td>
			</tr>
			<tr>
				<td>                
				</td>
				<td>
					<table style="margin-top: 12px;">
						<tr>
							<td>
								<dx:ASPxButton ID="btnSubmit" runat="server" Text="Submit" />
							</td>
							<td style="padding-left: 8px">
								<dx:ASPxButton ID="btnClear" runat="server" Text="Clear" AutoPostBack="False" UseSubmitBehavior="False"
									CausesValidation="False">
									<ClientSideEvents Click="OnClearButtonClick" />
								</dx:ASPxButton>
							</td>
						</tr>
					</table>
				</td>
			</tr>
		</table>
	</div>
	<div style="float: left; margin-left: 2%" id="summaryContainer">
		<dx:ASPxValidationSummary ID="vsValidationSummary1" runat="server" RenderMode="BulletedList"
			Width="250px" ClientInstanceName="validationSummary">
		</dx:ASPxValidationSummary>                
	</div>

	<div style="clear: both; padding-top: 32px">
		<div>
			<b>Validation Summary Settings:</b>
		</div>
		<table class="OptionsTable TopMargin" style="margin-left:16px">
			<tr>
				<td>
					<dx:ASPxLabel ID="lblRenderMode" runat="server" Text="RenderMode:" AssociatedControlID="rblRenderMode" />
				</td>
				<td>
					<dx:ASPxRadioButtonList ID="rblRenderMode" runat="server" SelectedIndex="0" AutoPostBack="True"
						RepeatDirection="Horizontal">
						<Paddings Padding="0" />
						<Border BorderStyle="None" />
						<Items>
							<dx:ListEditItem Value="BulletedList" />
							<dx:ListEditItem Value="OrderedList" />
							<dx:ListEditItem Value="Table" />
						</Items>
					</dx:ASPxRadioButtonList>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="lblShowErrorAsLink" runat="server" Text="ShowErrorAsLink:" AssociatedControlID="chbShowErrorAsLink" />
				</td>
				<td>
					<dx:ASPxCheckBox ID="chbShowErrorAsLink" runat="server" AutoPostBack="True" Checked="True" />
				</td>
			</tr>
		</table>
		<div style="margin-top: 16px">
			<b>Editors Settings:</b>
		</div>
		<table class="OptionsTable TopMargin" style="margin-left:16px">
			<tr>
				<td>
					<dx:ASPxLabel ID="lblSetFocusOnError" runat="server" Text="SetFocusOnError:" AssociatedControlID="chbSetFocusOnError" />
				</td>
				<td>
					<dx:ASPxCheckBox ID="chbSetFocusOnError" runat="server" AutoPostBack="True" />
				</td>
			</tr>
		</table>
	</div>
	<ef:EntityDataSource runat="server" ID="OccupationsDataSource" ContextTypeName="EditorsSampleDBContext" 
		EntitySetName="Occupations" OrderBy="it.OccupationName" />
</asp:Content>