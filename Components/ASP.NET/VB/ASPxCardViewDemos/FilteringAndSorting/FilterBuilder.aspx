<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FilterBuilder.aspx.vb" Inherits="Filtering_FilterBuilder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<dx:ASPxCheckBox runat="server" ID="cbEnableTextTab" Text="Enable text tab" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
	<dx:ASPxCheckBox runat="server" ID="cbAllowHierarchicalColumns" Text="Allow hierarchical columns" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
	<dx:ASPxCheckBox runat="server" ID="cbShowAddDataSourceColumns" Text="Show all datasource columns" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
	<br />
	<dx:ASPxCardView ID="CardView" runat="server" DataSourceID="ProductsDataSource" OnFilterControlColumnsCreated="CardView_FilterControlColumnsCreated" EnableCardsCache="false" Width="100%">
		<Columns>
			<dx:CardViewTextColumn FieldName="ProductName" />
			<dx:CardViewComboBoxColumn FieldName="Category.CategoryName">
				<PropertiesComboBox DataSourceID="CategoriesDataSource" TextField="CategoryName" ValueField="CategoryName" ValueType="System.String" />
			</dx:CardViewComboBoxColumn>
			<dx:CardViewTextColumn FieldName="Supplier.CompanyName" />
			<dx:CardViewTextColumn FieldName="Supplier.ContactName" />
			<dx:CardViewSpinEditColumn FieldName="UnitPrice">
				<PropertiesSpinEdit DisplayFormatString="c" />
			</dx:CardViewSpinEditColumn>
			<dx:CardViewSpinEditColumn FieldName="UnitsInStock" />
			<dx:CardViewTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitsInStock*UnitPrice">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:CardViewTextColumn>
		</Columns>
		<Settings ShowFilterBar="Visible" />
		<SettingsPager>
			<SettingsTableLayout RowsPerPage="2" />
		</SettingsPager>
		<SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
	</dx:ASPxCardView>
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" Include="Category, Supplier" ContextTypeName="NorthwindContext" EntitySetName="Products"></ef:EntityDataSource>
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
</asp:Content>