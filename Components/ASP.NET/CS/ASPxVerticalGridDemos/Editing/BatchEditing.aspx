<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BatchEditing.aspx.cs" Inherits="Editing_BatchEditing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable BottomMargin">
        <tr>
            <td>
                <dx:ASPxLabel ID="StartEditActionLabel" runat="server" Text="Start edit action:" AssociatedControlID="StartEditActionCombo" />
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="StartEditActionCombo" AutoPostBack="true" SelectedIndex="2">
                    <Items>
                        <dx:ListEditItem Value="Click" />
                        <dx:ListEditItem Value="DblClick" />
                        <dx:ListEditItem Value="FocusedCellClick" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="HighlightDeletedRowsLabel" runat="server" Text="Highlight deleted records:" AssociatedControlID="cbHighlightDeletedItems" />
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="cbHighlightDeletedItems" AutoPostBack="true" Checked="true" />
            </td>
        </tr>
    </table>
    <br />
    <dx:ASPxVerticalGrid ID="VerticalGrid" runat="server" DataSourceID="DemoDataSource" KeyFieldName="ProductID" ClientInstanceName="grid" Width="100%">
        <Rows>
            <dx:VerticalGridCommandRow ShowNewButtonInHeader="true" ShowDeleteButton="True">
                <RecordStyle HorizontalAlign="Center" />
            </dx:VerticalGridCommandRow>
            <dx:VerticalGridCategoryRow Caption="Product Info">
                <Rows>
                    <dx:VerticalGridTextRow FieldName="ProductName">
                        <PropertiesTextEdit>
                            <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" />
                        </PropertiesTextEdit>
                    </dx:VerticalGridTextRow>
                    <dx:VerticalGridComboBoxRow FieldName="CategoryID" Caption="Category Name">
                        <PropertiesComboBox DataSourceID="CategoriesDataSource" ValueType="System.Int32" ValueField="CategoryID" TextField="CategoryName">
                            <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" />
                        </PropertiesComboBox>
                    </dx:VerticalGridComboBoxRow>
                    <dx:VerticalGridComboBoxRow FieldName="SupplierID" Caption="Supplier">
                        <PropertiesComboBox DataSourceID="SuppliersDataSource" ValueType="System.Int32" ValueField="SupplierID" TextField="CompanyName">
                            <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" />
                        </PropertiesComboBox>
                    </dx:VerticalGridComboBoxRow>
                </Rows>
            </dx:VerticalGridCategoryRow>
            <dx:VerticalGridCategoryRow Caption="Details">
                <Rows>
                    <dx:VerticalGridTextRow FieldName="QuantityPerUnit" />
                    <dx:VerticalGridSpinEditRow FieldName="UnitPrice">
                        <PropertiesSpinEdit DisplayFormatString="c" DisplayFormatInEditMode="true" MinValue="0" MaxValue="60000">
                            <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" />
                        </PropertiesSpinEdit>
                    </dx:VerticalGridSpinEditRow>
                    <dx:VerticalGridSpinEditRow FieldName="UnitsInStock">
                        <PropertiesSpinEdit MinValue="0" MaxValue="10000" />
                    </dx:VerticalGridSpinEditRow>
                    <dx:VerticalGridCheckRow FieldName="Discontinued">
                        <PropertiesCheckEdit AllowGrayed="true" AllowGrayedByClick="false" />
                    </dx:VerticalGridCheckRow>
                </Rows>
            </dx:VerticalGridCategoryRow>
        </Rows>
        <SettingsEditing Mode="Batch" />
        <SettingsBehavior AllowRowExpanding="false" AllowEllipsisInText="true" />
        <Settings HorizontalScrollBarMode="Visible" RecordWidth="150" ShowCategoryIndents="false" />
        <SettingsPager PageSize="10" />
    </dx:ASPxVerticalGrid>
    <demo:DemoDataSource runat="server" ID="DemoDataSource" IdentityKey="ProductID" DataSourceID="ProductsDataSource" IsSiteMode="True"></demo:DemoDataSource>
    <ef:EntityDataSource runat="server" ID="ProductsDataSource"
        ContextTypeName="NorthwindContext"
        EnableDelete="True" EnableInsert="True" EnableUpdate="True"
        EntitySetName="Products">
    </ef:EntityDataSource>
    <ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories"></ef:EntityDataSource>
    <ef:EntityDataSource runat="server" ID="SuppliersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Suppliers"></ef:EntityDataSource>
</asp:Content>
