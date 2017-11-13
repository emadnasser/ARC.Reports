<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TotalsLocation.aspx.vb"
	Inherits="TotalsLocationDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxComboBox ID="ddlTotalsLocation" runat="server" AutoPostBack="True" Width="120px"
		SelectedIndex="1" Caption="Totals Location">
		<RootStyle CssClass="OptionsBottomMargin"></RootStyle>
		<Items>
			<dx:ListEditItem Text="Near" Value="0" />
			<dx:ListEditItem Text="Far" Value="1" />
		</Items>
	</dx:ASPxComboBox>
	<dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="SalesPersonsDataSource"
		Width="100%">
		<Fields>
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Sales Person" FieldName="Sales_Person"
				ID="fieldSales_Person" />
			<dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Category Name" FieldName="CategoryName"
				ID="fieldCategoryName" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="0" Caption="Year" FieldName="OrderDate"
				ID="fieldOrderDate0" GroupInterval="DateYear" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="1" Caption="Month" FieldName="OrderDate"
				ID="fieldOrderDate1" GroupInterval="DateMonth" />
			<dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Quantity" FieldName="Quantity"
				ID="fieldQuantity" CellFormat-FormatString="#.##" CellFormat-FormatType="Numeric" />
		</Fields>
		<OptionsView ShowFilterHeaders="False" HorizontalScrollBarMode="Auto" />
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
</asp:Content>