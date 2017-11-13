<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Scale.aspx.vb" Inherits="ASPxTrackBar_Scale" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.center {
			margin: 60px auto;
		}
	</style>
	<%--start highlighted block--%>
	<script type="text/javascript">
		function CheckValueRange() {
			var maxValue = maxSpinEdit.GetValue(),
				minValue = minSpinEdit.GetValue();            
			return maxValue <= minValue ? "MaxValue must be great or equal of MinValue" : null;
		}
		function CheckLargeTickValue(value) {
			var maxValue = maxSpinEdit.GetValue(),
				minValue = minSpinEdit.GetValue();
			return value < minValue || value > maxValue ? 'Value must be in the range ' + minValue + '...' + maxValue : null;
		}
		function CheckTickCount() {
			var maxValue = maxSpinEdit.GetValue(),
				minValue = minSpinEdit.GetValue();
				smallTickFrequency = smallTickFrequencySpinEdit.GetValue(),
				largeTickInterval = largeTickIntervalSpinEdit.GetValue();
			var tickCount = ((maxValue - minValue) / largeTickInterval) * smallTickFrequency;
			return tickCount >= 50 ? "The number of ticks is too large. Please correct settings " : null; 
		}
		function CheckLargeTickInterval() {
			var maxValue = maxSpinEdit.GetValue(),
				minValue = minSpinEdit.GetValue(),
				value = largeTickIntervalSpinEdit.GetValue();
			return value > maxValue - minValue ? "LargeTickInterval must be less than the track bar value range" : null;
		}


		function OnRangeValidation(s, e) {
			var errorText = CheckTickCount();
			if(!errorText)
				errorText = CheckValueRange();
			if (errorText) {
				e.isValid = false;
				e.errorText = errorText;
			}
		}
		function OnLargeTickValueValidation(s, e) {
			var errorText = CheckLargeTickValue();
			if (errorText) {
				e.isValid = false;
				e.errorText = errorText;
			}
		}
		function OnSmallTickFrequencyValidation(s, e) {
			var errorText = CheckTickCount();
			if (errorText) {
				e.isValid = false;
				e.errorText = errorText;
			}
		}
		function OnLargeTickIntervalValidation(s, e) {
			var errorText = CheckTickCount();
			if(!errorText)
				errorText = CheckLargeTickInterval();
			if (errorText) {
				e.isValid = false;
				e.errorText = errorText;
			}
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<div style="float: left; width: 100%">
		<div style="float: left; width: 300px; height: 250px">
			<dx:ASPxTrackBar ID="trackBar" CssClass="center" runat="server" EnableViewState="false" ScalePosition="Both" Width="256" />
		</div>
		<div style="float: left;">
			 <table class="OptionsTable">
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="predefinedSettingsComboBox" Text="Predefined Settings:" /></td>
					<td>
						 <dx:ASPxComboBox ID="predefinedSettingsComboBox" runat="server" AutoPostBack="true" Width="120"
							OnValueChanged="OnPredefinedSettingsComboBoxValueChanged">
							<Items>
								<dx:ListEditItem Text="Simple" Value="0" />
								<dx:ListEditItem Text="Offsets" Value="1" />
								<dx:ListEditItem Text="Large Ticks Only" Value="2" />
								<dx:ListEditItem Text="Unbalanced" Value="3" />
							</Items>
						</dx:ASPxComboBox>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="minValueSpinEdit" Text="MinValue:" /></td>
					<td>
						<dx:ASPxSpinEdit ID="minValueSpinEdit" runat="server" NumberType="Float" Number="0" Width="70" ClientInstanceName="minSpinEdit" AllowNull="false">
							<ClientSideEvents Validation="OnRangeValidation" />
							<ValidationSettings Display="Static" ErrorDisplayMode="ImageWithTooltip" ValidateOnLeave="false">
							   <RequiredField IsRequired="true" ErrorText="Please, set value" /> 
							</ValidationSettings>
						</dx:ASPxSpinEdit>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="maxValueSpinEdit" Text="MaxValue:" /></td>
					<td>
						<dx:ASPxSpinEdit ID="maxValueSpinEdit" runat="server" NumberType="Float" Number="50" Width="70" ClientInstanceName="maxSpinEdit" AllowNull="false">
							<ClientSideEvents Validation="OnRangeValidation" />
							<ValidationSettings Display="Static" ErrorDisplayMode="ImageWithTooltip" ValidateOnLeave="false">
								<RequiredField IsRequired="true" ErrorText="Please, set value" /> 
							</ValidationSettings>
						</dx:ASPxSpinEdit>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="largeTickIntervalSpinEdit" Text="LargeTickInterval:" /></td>
					<td>
						<dx:ASPxSpinEdit ID="largeTickIntervalSpinEdit" runat="server" MinValue="0.1" MaxValue="1000" NumberType="Float" Width="70" Number="10" ClientInstanceName="largeTickIntervalSpinEdit" AllowNull="false">
							<ClientSideEvents Validation="OnLargeTickIntervalValidation" />
							<ValidationSettings Display="Static" ErrorDisplayMode="ImageWithTooltip" ValidateOnLeave="false">
							   <RequiredField IsRequired="true" ErrorText="Please, set value" /> 
							</ValidationSettings>
						</dx:ASPxSpinEdit>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="smallTickFrequencySpinEdit" Text="SmallTickFrequency:" /></td>
					<td>
						<dx:ASPxSpinEdit ID="smallTickFrequencySpinEdit" runat="server" NumberType="Integer" Width="70" MinValue="1" MaxValue="20" Number="2" ClientInstanceName="smallTickFrequencySpinEdit" AllowNull="false">
							<ClientSideEvents Validation="OnSmallTickFrequencyValidation" />
							<ValidationSettings Display="Static" ErrorDisplayMode="ImageWithTooltip" ValidateOnLeave="false">
							   <RequiredField IsRequired="true" ErrorText="Please, set value" /> 
							</ValidationSettings>
						</dx:ASPxSpinEdit>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="largeTickStartValueSpinEdit" Text="LargeTickStartValue:" /></td>
					<td>
						<dx:ASPxSpinEdit ID="largeTickStartValueSpinEdit" runat="server" NumberType="Float" Width="70" Number="0" ClientInstanceName="largeTickStartValueSpinEdit" AllowNull="false">
							<ValidationSettings Display="Static" ErrorDisplayMode="ImageWithTooltip" ValidateOnLeave="false">
							   <RequiredField IsRequired="true" ErrorText="Please, set value" /> 
							</ValidationSettings>
							<ClientSideEvents Validation="OnLargeTickValueValidation" />
						</dx:ASPxSpinEdit>
					</td>
				</tr>
				 <tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="largeTickEndValueSpinEdit" Text="LargeTickEndValue:" /></td>
					<td>
						<dx:ASPxSpinEdit ID="largeTickEndValueSpinEdit" runat="server" NumberType="Float" Width="70" Number="50" ClientInstanceName="largeTickEndValueSpinEdit" AllowNull="false">
							<ValidationSettings Display="Static" ErrorDisplayMode="ImageWithTooltip" ValidateOnLeave="false">
							   <RequiredField IsRequired="true" ErrorText="Please, set value" /> 
							</ValidationSettings>
							<ClientSideEvents Validation="OnLargeTickValueValidation" />
						</dx:ASPxSpinEdit>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel runat="server" AssociatedControlID="stepSpinEdit" Text="Step:" /></td>
					<td>
						<dx:ASPxSpinEdit ID="stepSpinEdit" runat="server" MinValue="0.5" MaxValue="2" Width="70" NumberType="Float" Number="1" AllowNull="false">
							<ValidationSettings Display="Static" ErrorDisplayMode="ImageWithTooltip" ValidateOnLeave="false">
							   <RequiredField IsRequired="true" ErrorText="Please, set value" />
							</ValidationSettings>
						</dx:ASPxSpinEdit>
					</td>
				</tr>
			</table>
			<br />
			<dx:ASPxButton runat="server" Text="Apply" AutoPostBack="true" CausesValidation="true" />
		</div>
	   </div>
</asp:Content>