<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FilterBuilder.aspx.cs" Inherits="Filtering_FilterBuilder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCheckBox runat="server" ID="cbEnableTextTab" Text="Enable text tab" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
    <dx:ASPxCheckBox runat="server" ID="cbAllowHierarchicalColumns" Text="Allow hierarchical columns" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
    <dx:ASPxCheckBox runat="server" ID="cbShowAddDataSourceColumns" Text="Show all datasource columns" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
    <br />
    <%--TODO EnableRecordsCache--%>
    <%--TODO Columns--%>
    <dx:ASPxVerticalGrid ID="VerticalGrid" runat="server" DataSourceID="ProductsDataSource" EnableRecordsCache="false" OnFilterControlColumnsCreated="VerticalGrid_FilterControlColumnsCreated" Width="100%">
        <Rows>
            <dx:VerticalGridCategoryRow Caption="Product Info">
                <Rows>
                    <dx:VerticalGridDataRow FieldName="ProductName" />
                    <dx:VerticalGridComboBoxRow FieldName="Category.CategoryName">
                        <PropertiesComboBox DataSourceID="CategoriesDataSource" TextField="CategoryName" ValueField="CategoryName" ValueType="System.String" />
                    </dx:VerticalGridComboBoxRow>
                    <dx:VerticalGridBinaryImageRow FieldName="Category.Picture" Caption="Category" Settings-ShowInFilterControl="False">
                        <PropertiesBinaryImage ImageWidth="240" ImageHeight="150" ToolTipField="Category.CategoryName" />
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
        <Settings ShowFilterBar="Visible" HorizontalScrollBarMode="Visible" RecordWidth="250" ShowCategoryIndents="false" />
        <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
    </dx:ASPxVerticalGrid>
    <ef:EntityDataSource runat="server" ID="ProductsDataSource" Include="Category, Supplier" ContextTypeName="NorthwindContext" EntitySetName="Products"></ef:EntityDataSource>
    <ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
</asp:Content>
