<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ExcelDataAware.aspx.vb" Inherits="Exporting_ExcelDataAware" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ToolbarExport runat="server" ID="ToolbarExport" ExportItemTypes="Xls,Xlsx,Csv" OnItemClick="ToolbarExport_ItemClick" />
	<dx:ASPxComboBox ID="ExportRowTypeComboBox" runat="server" AutoPostBack="true" Caption="Export row type">
		<RootStyle CssClass="OptionsBottomMargin"></RootStyle>
		<Items>
			<dx:ListEditItem Value="All" Selected="true" />
			<dx:ListEditItem Value="Selected" />
		</Items>
	</dx:ASPxComboBox>
	<dx:ASPxGridView ID="Grid" runat="server" KeyFieldName="ProductID" DataSourceID="ProductsDataSource" Width="100%">
		<Columns>
			<dx:GridViewCommandColumn ShowSelectCheckbox="True" SelectAllCheckboxMode="Page" />
			<dx:GridViewDataComboBoxColumn FieldName="CategoryID" Caption="Category Name" GroupIndex="0" Width="150">
				<PropertiesComboBox DataSourceID="CategoriesDataSource" ValueField="CategoryID" TextField="CategoryName" ValueType="System.Int32" />
			</dx:GridViewDataComboBoxColumn>
			<dx:GridViewDataTextColumn FieldName="ProductName" />
			<dx:GridViewDataTextColumn FieldName="QuantityPerUnit" />
			<dx:GridViewDataTextColumn FieldName="UnitPrice">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
			<dx:GridViewDataTextColumn FieldName="UnitsInStock" />
			<dx:GridViewDataTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * UnitsInStock">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
		</Columns>
		<GroupSummary>
			<dx:ASPxSummaryItem FieldName="ProductName" SummaryType="Count" ShowInGroupFooterColumn="ProductName" />
			<dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" ShowInGroupFooterColumn="Total" />
		</GroupSummary>
		<TotalSummary>
			<dx:ASPxSummaryItem FieldName="ProductName" SummaryType="Count" />
			<dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
		</TotalSummary>
		<Settings ShowGroupPanel="True" ShowFooter="True" ShowGroupFooter="VisibleAlways" />
		<SettingsPager PageSize="15" />
	</dx:ASPxGridView>
	<dx:ASPxGridViewExporter ID="Exporter" runat="server" GridViewID="Grid" />
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext" EntitySetName="Products" />
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
</asp:Content>