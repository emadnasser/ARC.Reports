<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Exporting.aspx.vb" Inherits="Exporting_Exporting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ToolbarExport runat="server" ID="ToolbarExport" ExportItemTypes="Pdf,Xls,Xlsx,Rtf" OnItemClick="ToolbarExport_ItemClick" />
	<dx:ASPxVerticalGrid ID="VerticalGrid" runat="server" DataSourceID="ProductsDataSource" EnableRecordsCache="false" Width="100%">
		<Rows>
			<dx:VerticalGridCategoryRow Caption="Product Info">
				<Rows>
					<dx:VerticalGridDataRow FieldName="ProductName" />
					<dx:VerticalGridDataRow FieldName="Category.CategoryName" Visible="false" />
					<dx:VerticalGridBinaryImageRow FieldName="Category.Picture" Caption="Category">
						<PropertiesBinaryImage ImageHeight="150" ExportImageSettings-Width="240" ExportImageSettings-Height="150" ToolTipField="Category.CategoryName" />
						<RecordStyle HorizontalAlign="Center" />
					</dx:VerticalGridBinaryImageRow>
					<dx:VerticalGridSpinEditRow FieldName="UnitPrice" PropertiesSpinEdit-DisplayFormatString="c" />
					<dx:VerticalGridDataRow FieldName="UnitsInStock" />
					<dx:VerticalGridSpinEditRow FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitsInStock*UnitPrice" PropertiesSpinEdit-DisplayFormatString="c">
					</dx:VerticalGridSpinEditRow>
				</Rows>
			</dx:VerticalGridCategoryRow>
			<dx:VerticalGridCategoryRow Caption="Supplier Info">
				<Rows>
					<dx:VerticalGridDataRow FieldName="Supplier.CompanyName" />
					<dx:VerticalGridDataRow FieldName="Supplier.ContactName" />
				</Rows>
			</dx:VerticalGridCategoryRow>
		</Rows>
		<SettingsBehavior AllowRowExpanding="false" />
		<Settings HorizontalScrollBarMode="Visible" RecordWidth="250" ShowCategoryIndents="false" />
	</dx:ASPxVerticalGrid>
	<div class="Note">
		<b>Note:</b>
		If you export grouped data to RTF, be sure to open the resulting file with an editor that fully supports RTF, including tables. 
		For instance, Microsoft WordPad does not support this feature, and thus the file may appear corrupt.
	</div>
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" Include="Category, Supplier" ContextTypeName="NorthwindContext" EntitySetName="Products"></ef:EntityDataSource>
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
	<dx:ASPxVerticalGridExporter ID="verticalGridExport" runat="server" VerticalGridID="VerticalGrid" />
</asp:Content>