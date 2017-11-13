<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SortBySummary.aspx.vb"
	Inherits="SortBySummaryDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxComboBox ID="ddlSortByField" runat="server" AutoPostBack="true" Width="120"
		SelectedIndex="0" Caption="Sort the &quot;Sales Person&quot; Field by">
		<RootStyle CssClass="OptionsBottomMargin"></RootStyle>
		<Items>
			<dx:ListEditItem Text="Order Amount" Value="0" />
			<dx:ListEditItem Text="Quantity" Value="1" />
			<dx:ListEditItem Text="Discount (Avg)" Value="2" />
		</Items>
	</dx:ASPxComboBox>
	<dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="SalesPersonsDataSource"
		Width="100%">
		<Fields>
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Order Month" FieldName="OrderDate"
				ID="fieldOrderDate0" GroupInterval="DateMonth" />
			<dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Sales Person" FieldName="Sales_Person"
				ID="fieldSalesPerson" SortOrder="Descending">
				<HeaderStyle Font-Bold="True" />
			</dx:PivotGridField>
			<dx:PivotGridField AreaIndex="0" Caption="Year" FieldName="OrderDate" ID="fieldOrderDate1"
				GroupInterval="DateYear" />
			<dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Order Amount" FieldName="Extended_Price"
				ID="fieldExtended_Price" />
			<dx:PivotGridField Area="DataArea" AreaIndex="1" Caption="Quantity" FieldName="Quantity"
				ID="fieldQuantity" CellFormat-FormatString="#.##" CellFormat-FormatType="Numeric" />
			<dx:PivotGridField Area="DataArea" AreaIndex="2" Caption="Discount (Avg)" FieldName="Discount"
				ID="fieldDiscount" SummaryType="Average" CellFormat-FormatString="p" CellFormat-FormatType="Numeric" />
		</Fields>
		<OptionsView HorizontalScrollBarMode="Auto" />
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
</asp:Content>