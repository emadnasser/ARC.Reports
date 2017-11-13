<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="VirtualScrolling.aspx.vb"
	Inherits="HorzScrollBar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
		<dx:ASPxPivotGrid ID="pivotGrid" ClientInstanceName="pivotGrid" runat="server" DataSourceID="ProductReportsDataSource"
			Width="100%" Height="600px">
			<Fields>
				<dx:PivotGridField Area="RowArea" AreaIndex="0" FieldName="CategoryName" Caption="Category Name"
					ID="Category" />
				 <dx:PivotGridField Area="RowArea" AreaIndex="1" FieldName="ProductName" Caption="Product Name" ID="Product" />
				<dx:PivotGridField Area="ColumnArea" AreaIndex="0" FieldName="ShippedDate" Caption="Year"
					GroupInterval="DateYear" ID="fieldYear" UnboundFieldName="Year" />
				<dx:PivotGridField Area="ColumnArea" AreaIndex="1" FieldName="ShippedDate" Caption="Quarter"
					GroupInterval="DateQuarter" ID="Quarter" UnboundFieldName="Quarter" ValueFormat-FormatString="Qtr {0}"
					ValueFormat-FormatType="Numeric" />
				<dx:PivotGridField Area="ColumnArea" AreaIndex="2" FieldName="ShippedDate" Caption="Month"
					GroupInterval="DateMonth" ID="Month" UnboundFieldName="Month" />
				<dx:PivotGridField Area="ColumnArea" AreaIndex="3" FieldName="ShippedDate" Caption="Week of Month"
					GroupInterval="DateWeekOfMonth" ID="WeekOfMonth" UnboundFieldName="WeekOfMonth" />
				<dx:PivotGridField Area="DataArea" AreaIndex="0" FieldName="ProductSales" Caption="Product Sales"
					ID="Sales" />
			</Fields>
			<OptionsPager RowsPerPage="25" ColumnsPerPage="15" Visible="False" />
			<OptionsView VerticalScrollBarMode="Auto" ShowFilterHeaders="False" HorizontalScrollBarMode="Auto" VerticalScrollingMode="Virtual" HorizontalScrollingMode="Virtual" />
			<OptionsFilter NativeCheckBoxes="False" />
		</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="ProductReportsDataSource" ContextTypeName="NorthwindContext" CommandText="SELECT s.CategoryName, s.ProductName, s.ProductSales, i.ShippedDate FROM Sales_By_Categories as s
		INNER JOIN Invoices as i ON s.ProductName = i.ProductName WHERE i.ShippedDate IS NOT NULL" />
</asp:Content>