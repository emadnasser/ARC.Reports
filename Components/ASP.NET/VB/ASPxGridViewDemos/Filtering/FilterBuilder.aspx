<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FilterBuilder.aspx.vb" Inherits="Filtering_FilterBuilder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<dx:ASPxCheckBox runat="server" ID="cbEnableTextTab" Text="Enable text tab" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
	<dx:ASPxCheckBox runat="server" ID="cbAllowHierarchicalColumns" Text="Allow hierarchical columns" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
	<dx:ASPxCheckBox runat="server" ID="cbShowAddDataSourceColumns" Text="Show all datasource columns" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
	<br />
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="ProductsDataSource" OnFilterControlColumnsCreated="grid_FilterControlColumnsCreated" EnableRowsCache="false" Width="100%">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="ProductName" />
			<dx:GridViewDataComboBoxColumn FieldName="Category.CategoryName">
				<PropertiesComboBox DataSourceID="CategoriesDataSource" TextField="CategoryName" ValueField="CategoryName" ValueType="System.String" />
			</dx:GridViewDataComboBoxColumn>
			<dx:GridViewDataTextColumn FieldName="Supplier.CompanyName" />
			<dx:GridViewDataTextColumn FieldName="Supplier.ContactName" />
			<dx:GridViewDataSpinEditColumn FieldName="UnitPrice">
				<PropertiesSpinEdit DisplayFormatString="c" />
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataSpinEditColumn FieldName="UnitsInStock" />
			<dx:GridViewDataTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice*UnitsInStock">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
		</Columns>
		<Settings ShowFilterBar="Visible" />
		<SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" Include="Category, Supplier" ContextTypeName="NorthwindContext" EntitySetName="Products"></ef:EntityDataSource>
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
</asp:Content>