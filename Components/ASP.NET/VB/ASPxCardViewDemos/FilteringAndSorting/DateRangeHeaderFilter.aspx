<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DateRangeHeaderFilter.aspx.vb" Inherits="FilteringAndSorting_DateRangeHeaderFilter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxComboBox ID="cmbHeaderFilterMode" runat="server" Caption="Header filter mode" AutoPostBack="true" SelectedIndex="0" ValueType="DevExpress.Web.GridHeaderFilterMode">
		<Items>
			<dx:ListEditItem Value="DateRangePicker" />
			<dx:ListEditItem Value="DateRangeCalendar" />
		</Items>
	</dx:ASPxComboBox>
	<br />
	<dx:ASPxCardView ID="CardView" runat="server" DataSourceID="ObjectDataSource1" Width="100%">
		<Columns>
			<dx:CardViewTextColumn FieldName="Patient" />
			<dx:CardViewTextColumn FieldName="Doctor" />
			<dx:CardViewTextColumn FieldName="Clinic" />
			<dx:CardViewDateColumn FieldName="VisitDate" Settings-AllowHeaderFilter="True" />
		</Columns>
		<Settings ShowHeaderPanel="true" ShowFilterBar="Visible" />
		<SettingsPager SettingsTableLayout-RowsPerPage="2" />
		<SettingsPopup HeaderFilter-Height="440" />
		<FormatConditions>
			<dx:CardViewFormatConditionHighlight FieldName="VisitDate" Expression="[VisitDate] < LocalDateTimeToday()" Format="RedText" />
			<dx:CardViewFormatConditionHighlight FieldName="VisitDate" Expression="[VisitDate] > LocalDateTimeToday()" Format="GreenText" />
		</FormatConditions>
	</dx:ASPxCardView>
	<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetInMemoryData" TypeName="DevExpress.Web.Demos.PatientsDataGenerator" />
</asp:Content>