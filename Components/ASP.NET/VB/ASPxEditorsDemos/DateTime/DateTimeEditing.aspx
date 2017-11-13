<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DateTimeEditing.aspx.vb"
	Inherits="Features_DateTimeEditing" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function cbTimeEditFormat_SelectedIndexChanged(s, e) {
			if(s.GetText() == "Custom") {
				cbTimeEditFormatString.SetEnabled(true);
				e.processOnServer=false;
			}
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable">
		<tr>
			<td>
				<dx:ASPxLabel ID="dateLabel" runat="server" AssociatedControlID="dateEdit" Text="ASPxDateEdit:" />
			</td>
			<td style="width: 50%">
				<dx:ASPxDateEdit ID="dateEdit" runat="server" EditFormat="Custom" Date="2009-11-02 09:23" Width="200">
					<TimeSectionProperties>
						<TimeEditProperties EditFormatString="hh:mm tt" />
					</TimeSectionProperties>
				</dx:ASPxDateEdit>
			</td>
			<td>
				<dx:ASPxLabel ID="dateEditFormatStringLabel" runat="server" AssociatedControlID="cbDateEditFormatString" 
					Text="EditFormatString:" />
			</td>
			<td>
				<dx:ASPxComboBox ID="cbDateEditFormatString" runat="server" SelectedIndex="3" AutoPostBack="true">
					<Items>
						<dx:ListEditItem Value="MM/dd/yyyy" />
						<dx:ListEditItem Value="d MMM yyyy" />
						<dx:ListEditItem Value="MMMM dd, yyyy" />
						<dx:ListEditItem Value="dd/MM/yyyy hh:mm tt" />
					</Items>
				</dx:ASPxComboBox>
			</td>

		</tr>
		<tr>
			<td rowspan="3"></td>
			<td rowspan="3"></td>
			<td>
				<dx:ASPxLabel ID="dateEditDisplayFormatLabel" runat="server" AssociatedControlID="cbDateDisplayFormatString" 
					Text="DisplayFormatString:" />
			</td>
			<td>
				<dx:ASPxComboBox ID="cbDateDisplayFormatString" runat="server" SelectedIndex="0" AutoPostBack="true">
					<Items>
						<dx:ListEditItem Text="None" />
						<dx:ListEditItem Value="dd MMM yyyy" />
						<dx:ListEditItem Value="ddd, MMMM dd, yyyy" />
					</Items>
				</dx:ASPxComboBox>
			</td>
		</tr>

		<tr>
			<td>
				<dx:ASPxLabel ID="dateEditUseMaskBehaviorLabel" runat="server" AssociatedControlID="chkMaskBehavior"
					Text="UseMaskBehavior:" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="chkMaskBehavior" runat="server" Checked="true" AutoPostBack="true" />
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxLabel ID="dateEditShowTimeSectionLabel" runat="server" AssociatedControlID="chkShowTimeSection"
					Text="ShowTimeSection:" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="chkShowTimeSection" runat="server" Checked="true" AutoPostBack="true" />
			</td>
		</tr>
		<tr>
			<td colspan="4">
				<div style="height: 48px"></div>
			</td>
		</tr>
		<%-- Time Edit --%>
		<tr>

			<td>
				<dx:ASPxLabel ID="timeLabel" runat="server" AssociatedControlID="timeEdit" Text="ASPxTimeEdit:" />
			</td>
			<td style="width: 50%">
				<dx:ASPxTimeEdit ID="timeEdit" runat="server" DateTime="2009/11/01 15:31:34" Width="200">
					<ValidationSettings ErrorDisplayMode="None" />
				</dx:ASPxTimeEdit>
			</td>
			<td>
				<dx:ASPxLabel ID="timeEditFormatLabel" runat="server" AssociatedControlID="cbTimeEditFormat" 
					Text="EditFormat:" />
			</td>
			<td>
				<dx:ASPxComboBox ID="cbTimeEditFormat" runat="server" SelectedIndex="0" AutoPostBack="true">
					<ClientSideEvents SelectedIndexChanged="cbTimeEditFormat_SelectedIndexChanged" />
				</dx:ASPxComboBox>                                
			</td>

		</tr>
		<tr>
			<td rowspan="2"></td>
			<td rowspan="2"></td>
			<td>
				<dx:ASPxLabel ID="timeEditFormatStringLabel" runat="server" AssociatedControlID="cbTimeEditFormatString" 
					Text="EditFormatString:" />
			</td>
			<td>
				<dx:ASPxComboBox ID="cbTimeEditFormatString" runat="server" SelectedIndex="0" AutoPostBack="true"
					ClientInstanceName="cbTimeEditFormatString">
					<Items>
						<dx:ListEditItem Text="None" />
						<dx:ListEditItem Value="h:mm:ss tt" />
						<dx:ListEditItem Value="dd/MM/yyyy HH:mm:ss" />
						<dx:ListEditItem Value="MMMM dd, yyyy hh:mm tt" />
					</Items>
				</dx:ASPxComboBox>
			</td>
		</tr>

		<tr>
			<td>
				<dx:ASPxLabel ID="timeEditDisplayFormatLabel" runat="server" AssociatedControlID="cbTimeDisplayFormatString" 
					Text="DisplayFormatString:" />
			</td>
			<td>
				<dx:ASPxComboBox ID="cbTimeDisplayFormatString" runat="server" SelectedIndex="0"
					AutoPostBack="true">
					<Items>
						<dx:ListEditItem Text="None" />
						<dx:ListEditItem Value="h:mm tt" />
						<dx:ListEditItem Value="h:mm:ss tt" />
					</Items>
				</dx:ASPxComboBox>                
			</td>
		</tr>

	</table>
</asp:Content>