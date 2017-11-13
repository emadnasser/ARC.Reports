<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MultipleTotals.aspx.vb"
	Inherits="MultipleTotalsDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td colspan="3">
				<dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Select Totals to Show:" Font-Bold="True" />
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxCheckBox ID="average" runat="server" Text="Average" Checked="True" AutoPostBack="True" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="min" runat="server" Text="Min" Checked="True" AutoPostBack="True" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="sum" runat="server" Text="Sum" Checked="True" AutoPostBack="True" />
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxCheckBox ID="count" runat="server" Text="Count" Checked="True" AutoPostBack="True" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="stdev" runat="server" Text="StdDev" AutoPostBack="True" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="var" runat="server" Text="Var" AutoPostBack="True" />
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxCheckBox ID="max" runat="server" Text="Max" Checked="True" AutoPostBack="True" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="stdevp" runat="server" Text="StdDevp" AutoPostBack="True" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="varp" runat="server" Text="Varp" AutoPostBack="True" />
			</td>
		</tr>
	</table>
	<dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="SalesPersonDataSource"
		Width="100%">
		<Fields>
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Category Name" FieldName="CategoryName"
				ID="fieldCategoryName" TotalsVisibility="CustomTotals">
				<CustomTotals>
					<dx:PivotGridCustomTotal SummaryType="Average" />
					<dx:PivotGridCustomTotal />
					<dx:PivotGridCustomTotal SummaryType="Max" />
					<dx:PivotGridCustomTotal SummaryType="Min" />
					<dx:PivotGridCustomTotal SummaryType="Count" />
				</CustomTotals>
			</dx:PivotGridField>
			<dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Product Name" FieldName="ProductName"
				ID="fieldProductName" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="1" Caption="Year" FieldName="OrderDate"
				ID="fieldOrderDate" GroupInterval="DateYear" />
			<dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Quantity" FieldName="Quantity"
				ID="fieldQuantity" CellFormat-FormatString="#.##" CellFormat-FormatType="Numeric" />
			<dx:PivotGridField Area="DataArea" AreaIndex="1" Caption="Extended Price" FieldName="Extended_Price"
				ID="fieldExtended_Price" SummaryType="Max" />
		</Fields>
		<OptionsView ShowFilterHeaders="False" HorizontalScrollBarMode="Auto" />
		<OptionsFilter NativeCheckBoxes="False" />
		<OptionsPager RowsPerPage="20" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="SalesPersonDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
</asp:Content>