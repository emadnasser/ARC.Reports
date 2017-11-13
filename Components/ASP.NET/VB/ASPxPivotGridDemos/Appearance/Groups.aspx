<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Groups.aspx.vb"
	Inherits="Features_Groups" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td>
				<dx:ASPxButton ID="ExpandAll" runat="server" ToolTip="Expand All Groups" Style="vertical-align: middle;"
					OnClick="buttonExpandAll_Click" Text="Expand All Groups" />
			</td>
			<td>
				<dx:ASPxButton ID="CollapseAll" runat="server" ToolTip="Collapse All Groups" Style="vertical-align: middle;"
					OnClick="buttonCollapseAll_Click" Text="Collapse All Groups" />
			</td>
		</tr>
	</table>
	<dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="ProductReportsDataSource"
		CustomizationFieldsLeft="600" CustomizationFieldsTop="400" ClientInstanceName="pivotGrid"
		Width="100%">
		<Fields>
			<dx:PivotGridField Area="RowArea" AreaIndex="0" FieldName="CategoryName" Caption="Category Name"
				ID="Category" GroupIndex="0" InnerGroupIndex="0">
				<CustomTotals>
					<dx:PivotGridCustomTotal SummaryType="Average" />
					<dx:PivotGridCustomTotal />
					<dx:PivotGridCustomTotal SummaryType="Min" />
					<dx:PivotGridCustomTotal SummaryType="Max" />
				</CustomTotals>
			</dx:PivotGridField>
			<dx:PivotGridField Area="ColumnArea" AreaIndex="0" FieldName="ShippedDate" Caption="Year"
				GroupInterval="DateYear" ID="Year" GroupIndex="1" InnerGroupIndex="0" UnboundFieldName="Year" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="1" FieldName="ShippedDate" Caption="Quarter"
				GroupInterval="DateQuarter" ID="Quarter" ExpandedInFieldsGroup="False" GroupIndex="1"
				InnerGroupIndex="1" UnboundFieldName="Quarter" ValueFormat-FormatString="Qtr {0}"
				ValueFormat-FormatType="Numeric" />
			<dx:PivotGridField Area="DataArea" AreaIndex="0" FieldName="ProductSales" Caption="Product Sales"
				ID="Sales" ExpandedInFieldsGroup="False" GroupIndex="2" InnerGroupIndex="0" />
			<dx:PivotGridField Area="RowArea" AreaIndex="1" FieldName="ProductName" Caption="Product Name"
				ID="Product" GroupIndex="0" InnerGroupIndex="1" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="2" Caption="Month" FieldName="ShippedDate"
				GroupInterval="DateMonth" Visible="False" ID="Month" GroupIndex="1" InnerGroupIndex="2"
				UnboundFieldName="Month" />
			<dx:PivotGridField ID="AvgSale" Area="DataArea" AreaIndex="1" Caption="Average Sale"
				FieldName="ProductSales" SummaryType="Average" Visible="False" ExpandedInFieldsGroup="False"
				GroupIndex="2" InnerGroupIndex="1" />
			<dx:PivotGridField ID="MinSale" Area="DataArea" AreaIndex="1" Caption="Min Sale"
				FieldName="ProductSales" SummaryType="Min" Visible="False" GroupIndex="2" InnerGroupIndex="2" />
		</Fields>
		<Groups>
			<dx:PivotGridWebGroup Caption="Category - Product" />
			<dx:PivotGridWebGroup Caption="Year - Quarter" />
			<dx:PivotGridWebGroup Caption="Sales Sum, Min, Average" />
		</Groups>
		<OptionsView ShowFilterHeaders="False" HorizontalScrollBarMode="Auto" />
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="ProductReportsDataSource" ContextTypeName="NorthwindContext" CommandText="SELECT s.CategoryName, s.ProductName, s.ProductSales, i.ShippedDate FROM Sales_By_Categories as s
		INNER JOIN Invoices as i ON s.ProductName = i.ProductName WHERE i.ShippedDate IS NOT NULL" />
</asp:Content>