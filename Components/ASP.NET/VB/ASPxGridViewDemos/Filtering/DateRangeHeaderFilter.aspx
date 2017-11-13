<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DateRangeHeaderFilter.aspx.vb"
	Inherits="Filtering_HeaderFilter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxComboBox ID="cmbHeaderFilterMode" runat="server" Caption="Header filter mode"
		AutoPostBack="true" SelectedIndex="0" ValueType="DevExpress.Web.GridHeaderFilterMode">
		<Items>
			<dx:ListEditItem Value="DateRangePicker" />
			<dx:ListEditItem Value="DateRangeCalendar" />
		</Items>
	</dx:ASPxComboBox>
	<br />
	<dx:ASPxGridView ID="grid" runat="server" DataSourceID="ObjectDataSource1" Width="100%">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="Patient" />
			<dx:GridViewDataTextColumn FieldName="Doctor" />
			<dx:GridViewDataTextColumn FieldName="Clinic" />
			<dx:GridViewDataDateColumn FieldName="VisitDate" Width="300px" Settings-AllowHeaderFilter="True" />
		</Columns>
		<Settings ShowFilterBar="Visible" />
		<FormatConditions>
			<dx:GridViewFormatConditionHighlight FieldName="VisitDate" Expression="[VisitDate] < LocalDateTimeToday()" Format="LightRedFillWithDarkRedText" />
			<dx:GridViewFormatConditionHighlight FieldName="VisitDate" Expression="[VisitDate] > LocalDateTimeToday()" Format="GreenFillWithDarkGreenText" />
		</FormatConditions>
	</dx:ASPxGridView>
	<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetInMemoryData"
		TypeName="DevExpress.Web.Demos.PatientsDataGenerator" />
</asp:Content>