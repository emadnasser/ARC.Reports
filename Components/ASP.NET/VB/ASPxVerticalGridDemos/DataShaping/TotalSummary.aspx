<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TotalSummary.aspx.vb" Inherits="Data_Summaries_TotalSummary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxVerticalGrid ID="VerticalGrid" runat="server" DataSourceID="InvoicesDataSource" Width="100%">
		<Rows>
			<dx:VerticalGridTextRow FieldName="ProductName" />
			<dx:VerticalGridCategoryRow Caption="Company info">
				<Rows>
					<dx:VerticalGridTextRow FieldName="CompanyName" />
					<dx:VerticalGridTextRow FieldName="Address" />
					<dx:VerticalGridTextRow FieldName="Country" />
					<dx:VerticalGridTextRow FieldName="City" />
				</Rows>
			</dx:VerticalGridCategoryRow>
			<dx:VerticalGridCategoryRow Caption="Pricing">
				<Rows>
					<dx:VerticalGridTextRow FieldName="UnitPrice">
						<PropertiesTextEdit DisplayFormatString="c" />
					</dx:VerticalGridTextRow>
					<dx:VerticalGridTextRow FieldName="Quantity" />
					<dx:VerticalGridTextRow FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * Quantity * (1 - Discount)">
						<RecordStyle Font-Bold="true" />
						<PropertiesTextEdit DisplayFormatString="c" />
					</dx:VerticalGridTextRow>
				</Rows>
			</dx:VerticalGridCategoryRow>
		</Rows>
		<SettingsBehavior AllowRowExpanding="false" />
		<Settings ShowSummaryPanel="true" HorizontalScrollBarMode="Visible" HeaderAreaWidth="150" RecordWidth="150" ShowCategoryIndents="false" />
		<SettingsPager PageSize="10" />
		<TotalSummary>
			<dx:ASPxVerticalGridSummaryItem FieldName="Total" SummaryType="Sum" ValueDisplayFormat="<b>{0:c}</b>" />
		</TotalSummary>
	</dx:ASPxVerticalGrid>
	<ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext"
		CommandText="SELECT c.CompanyName AS CompanyName, i.OrderID, i.Country, i.City, i.Address, i.PostalCode, i.ProductName, i.UnitPrice, i.Quantity, i.Discount FROM Invoices as i INNER JOIN Customers as c ON c.CustomerId = i.CustomerId" />
</asp:Content>