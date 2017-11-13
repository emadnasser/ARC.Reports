<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="GroupSortBySummary.aspx.vb"
	Inherits="Summary_SoryBySummary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxComboBox runat="server" ID="ddlGroupSummary" AutoPostBack="true" SelectedIndex="1" Caption="Sort by summary mode">
		<RootStyle CssClass="OptionsBottomMargin"></RootStyle>
		<Items>
			<dx:ListEditItem Value="None" />
			<dx:ListEditItem Value="Ascending" />
			<dx:ListEditItem Value="Descending" />
		</Items>
	</dx:ASPxComboBox>
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="InvoicesDataSource"
		KeyFieldName="OrderID" OnCustomUnboundColumnData="grid_CustomUnboundColumnData"
		Width="100%">
		<Columns>
			<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="City" VisibleIndex="3" />
			<dx:GridViewDataColumn FieldName="Region" VisibleIndex="4" />
			<dx:GridViewDataColumn FieldName="Country" GroupIndex="0" VisibleIndex="5" />
			<dx:GridViewDataColumn FieldName="UnitPrice" VisibleIndex="6" />
			<dx:GridViewDataColumn FieldName="Quantity" VisibleIndex="7" />
			<dx:GridViewDataTextColumn FieldName="Total" VisibleIndex="8" UnboundType="Decimal">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
		</Columns>
		<GroupSummary>
			<dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
		</GroupSummary>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext" 
		CommandText="SELECT c.CompanyName, i.City, i.Region, i.Country, i.Salesperson, i.OrderID, i.OrderDate, i.ProductID, i.ProductName, i.UnitPrice, i.Quantity, i.Discount, i.ExtendedPrice, i.Freight FROM Invoices AS i INNER JOIN Customers AS c ON i.CustomerID = c.CustomerId" />
</asp:Content>