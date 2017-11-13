<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HeaderFilter.aspx.vb"
	Inherits="Filtering_HeaderFilter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCheckBox ID="hFModeCheckBox" runat="server" Text="Enable CheckedList mode" Checked="true" AutoPostBack="true" />
	<br />
	<dx:ASPxCardView ID="CardView" ClientInstanceName="CardView" runat="server" DataSourceID="InvoicesDataSource" Width="100%" OnHeaderFilterFillItems="CardView_HeaderFilterFillItems">
		<Columns>
			<dx:CardViewTextColumn FieldName="CompanyName" />
			<dx:CardViewTextColumn FieldName="Country" />
			<dx:CardViewTextColumn FieldName="City" />
			<dx:CardViewTextColumn FieldName="UnitPrice">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:CardViewTextColumn>
			<dx:CardViewTextColumn FieldName="Quantity" />
			<dx:CardViewTextColumn FieldName="Discount">
				<PropertiesTextEdit DisplayFormatString="p0" />
			</dx:CardViewTextColumn>
			<dx:CardViewTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * Quantity * (1 - Discount)">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:CardViewTextColumn>
		</Columns>
		<Settings ShowHeaderFilterButton="true" ShowHeaderPanel="true"/>
		<SettingsPager>
			<SettingsTableLayout RowsPerPage="2" />
		</SettingsPager>
		<SettingsPopup>
			<HeaderFilter Height="300" />
		</SettingsPopup>
	</dx:ASPxCardView>
	<ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext"
		CommandText="SELECT c.CompanyName AS CompanyName, i.OrderID, i.Country, i.City, i.UnitPrice, i.Quantity, i.Discount FROM Invoices as i INNER JOIN Customers as c ON c.CustomerId = i.CustomerId" />
</asp:Content>