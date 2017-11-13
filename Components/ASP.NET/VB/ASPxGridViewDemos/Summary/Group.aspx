<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Group.aspx.vb"
	Inherits="Summary_Group" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="InvoicesDataSource"
		KeyFieldName="OrderID" OnCustomUnboundColumnData="grid_CustomUnboundColumnData"
		Width="100%">
		<Columns>
			<dx:GridViewDataColumn FieldName="Country" VisibleIndex="0" GroupIndex="0" />
			<dx:GridViewDataColumn FieldName="City" VisibleIndex="1" GroupIndex="1" />
			<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="Region" VisibleIndex="3" />
			<dx:GridViewDataColumn FieldName="UnitPrice" VisibleIndex="4" />
			<dx:GridViewDataColumn FieldName="Quantity" VisibleIndex="5" />
			<dx:GridViewDataTextColumn FieldName="Total" VisibleIndex="6" UnboundType="Decimal">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
		</Columns>
		<Settings ShowGroupPanel="True" />
		<GroupSummary>
			<dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
			<dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" />
		</GroupSummary>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext" 
		CommandText="SELECT c.CompanyName, i.City, i.Region, i.Country, i.Salesperson, i.OrderID, i.OrderDate, i.ProductID, i.ProductName, i.UnitPrice, i.Quantity, i.Discount, i.ExtendedPrice, i.Freight FROM Invoices AS i INNER JOIN Customers AS c ON i.CustomerID = c.CustomerId" />
</asp:Content>