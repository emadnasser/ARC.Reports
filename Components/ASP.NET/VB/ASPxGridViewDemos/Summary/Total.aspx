<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Total.aspx.vb"
	Inherits="Summary_Total" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="InvoicesDataSource"
		KeyFieldName="OrderID" OnCustomUnboundColumnData="grid_CustomUnboundColumnData"
		Width="100%" AutoGenerateColumns="False">
		<Columns>
			<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="0" />
			<dx:GridViewDataColumn FieldName="City" VisibleIndex="1" />
			<dx:GridViewDataColumn FieldName="Region" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="Country" VisibleIndex="3" />
			<dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="4">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
			<dx:GridViewDataColumn FieldName="Quantity" VisibleIndex="5" Name="Quantity" />
			<dx:GridViewDataTextColumn FieldName="Total" VisibleIndex="6" UnboundType="Decimal">
				<FooterCellStyle ForeColor="Brown" />
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
		</Columns>
		<Settings ShowFooter="True" />
		<TotalSummary>
			<dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" />
			<dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
			<dx:ASPxSummaryItem FieldName="Quantity" SummaryType="Min" />
			<dx:ASPxSummaryItem FieldName="Quantity" SummaryType="Average" />
			<dx:ASPxSummaryItem FieldName="Quantity" SummaryType="Max" />
		</TotalSummary>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext" 
		CommandText="SELECT c.CompanyName, i.City, i.Region, i.Country, i.Salesperson, i.OrderID, i.OrderDate, i.ProductID, i.ProductName, i.UnitPrice, i.Quantity, i.Discount, i.ExtendedPrice, i.Freight FROM Invoices AS i INNER JOIN Customers AS c ON i.CustomerID = c.CustomerId" />
</asp:Content>