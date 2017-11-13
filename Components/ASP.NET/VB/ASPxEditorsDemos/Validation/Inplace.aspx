<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Inplace.aspx.vb"
	Inherits="Validation_Inplace" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function OnNameValidation(s, e) {
			var name = e.value;
			if(name == null)
				return;
			if(name.length < 2)
				e.isValid = false;
		}
		function OnAgeValidation(s, e) {
			var age = e.value;
			if(age == null || age == "")
				return;
			var digits = "0123456789";
			for(var i = 0; i < age.length; i++) {
				if(digits.indexOf(age.charAt(i)) == -1) {
					e.isValid = false;
					break;
				}
			}
			if(e.isValid && age.charAt(0) == '0') {
				age = age.replace(/^0+/, "");
				if(age.length == 0)
					age = "0";
				e.value = age;
			}
			if(age < 18)
				e.isValid = false;
		}
		function OnArrivalDateValidation(s, e) {
			var selectedDate = s.date;
			if(selectedDate == null || selectedDate == false)
				return;
			var currentDate = new Date();
			if(currentDate.getFullYear() != selectedDate.getFullYear() || currentDate.getMonth() != selectedDate.getMonth())
				e.isValid = false;
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<div id="clientContainer">
		<table class="OptionsTable" runat="server" id="serverContainer">
			<tr>
				<td style="width: 80px;">                
					<dx:ASPxLabel runat="server" ID="NameLabel" AssociatedControlID="NameTextBox" Text="Name:" />
				</td>
				<td>
					<dx:ASPxTextBox runat="server" EnableClientSideAPI="True" Width="160px" ID="NameTextBox"
						ClientInstanceName="Name" OnValidation="NameTextBox_Validation">
						<ValidationSettings SetFocusOnError="True" ErrorText="Name must be at least two characters long">
							<RequiredField IsRequired="True" ErrorText="Name is required" />
						</ValidationSettings>
						<ClientSideEvents Validation="OnNameValidation" />
						<InvalidStyle BackColor="LightPink" />
					</dx:ASPxTextBox>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel runat="server" ID="AgeLabel" AssociatedControlID="AgeTextBox" Text="Age:" />
				</td>
				<td>
					<dx:ASPxTextBox runat="server" EnableClientSideAPI="True" Width="160px" ID="AgeTextBox"
						ClientInstanceName="Age" OnValidation="AgeTextBox_Validation">
						<ValidationSettings SetFocusOnError="True" ErrorText="Age must be greater than or equal 18" />
						<ClientSideEvents Validation="OnAgeValidation" />
						<InvalidStyle BackColor="LightPink" />
					</dx:ASPxTextBox>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel runat="server" ID="EmailLabel" AssociatedControlID="EmailTextBox" Text="E-mail:" />
				</td>
				<td>
					<dx:ASPxTextBox runat="server" EnableClientSideAPI="True" Width="160px" ID="EmailTextBox"
						ClientInstanceName="Email">
						<ValidationSettings SetFocusOnError="True">
							<RegularExpression ErrorText="Invalid e-mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
							<RequiredField IsRequired="True" ErrorText="E-mail is required" />
						</ValidationSettings>
						<InvalidStyle BackColor="LightPink" />
					</dx:ASPxTextBox>
				</td>
			</tr>
			<tr>
				<td>                
					<dx:ASPxLabel runat="server" ID="ArrivalLabel" AssociatedControlID="ArrivalDateEdit"
						Text="Arrival date:" />
				</td>
				<td>
					<dx:ASPxDateEdit runat="server" Width="160px" ID="ArrivalDateEdit"
						ClientInstanceName="ArrivalDate" OnValidation="ArrivalDateEdit_Validation">
						<ValidationSettings SetFocusOnError="True" ErrorText="Arrival date is required and must belong to the current month">
							<RequiredField IsRequired="True" ErrorText="" />
						</ValidationSettings>
						<ClientSideEvents Validation="OnArrivalDateValidation" />
						<InvalidStyle BackColor="LightPink" />
					</dx:ASPxDateEdit>
				</td>
			</tr>
			<tr>
				<td>
				</td>
				<td>
					<table>
						<tr>
							<td>
								<dx:ASPxButton ID="btnSubmit" runat="server" Text="Submit" />
							</td>
							<td style="padding-left: 8px">
								<dx:ASPxButton ID="btnClear" runat="server" AutoPostBack="False" Text="Clear"
									CausesValidation="False">
									<ClientSideEvents Click="function(s, e) { ASPxClientEdit.ClearEditorsInContainerById('clientContainer') }" />
								</dx:ASPxButton>
							</td>
						</tr>
					</table>
				</td>
			</tr>
		</table>
	</div>

	<div style="margin-top: 48px;">
		<div style="float: left">
			<div>ErrorDisplayMode:</div>
			<div class="TopPadding">
				<dx:ASPxRadioButtonList ID="rblErrorDisplayMode" runat="server"
					OnSelectedIndexChanged="OnSettingsChanged"
					SelectedIndex="0" AutoPostBack="True">
					<Items>
						<dx:ListEditItem Value="ImageWithText" />
						<dx:ListEditItem Value="ImageWithTooltip" />
						<dx:ListEditItem Value="Text" />
						<dx:ListEditItem Value="None" />
					</Items>
				</dx:ASPxRadioButtonList>
			</div>
		</div>
		<div style="float: left" class="LeftPadding">
			<div>
				&nbsp;
			</div>
			<div class="TopPadding">
				<dx:ASPxCheckBox ID="chbValidateOnLeave" runat="server" Checked="True" OnCheckedChanged="OnSettingsChanged"
					AutoPostBack="True" Text="ValidateOnLeave" />            
			</div>
			<div class="TopPadding">
				<dx:ASPxCheckBox ID="chbSetFocusOnError" runat="server" OnCheckedChanged="OnSettingsChanged"
					AutoPostBack="True" Text="SetFocusOnError" />
			</div>
		</div>
	</div>    

</asp:Content>