<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Exporting.aspx.cs" Inherits="Exporting_Exporting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ToolbarExport runat="server" ID="ToolbarExport" ExportItemTypes="Pdf,Xls,Xlsx,Rtf" IsDataAwareXls="true" IsDataAwareXlsx="true" OnItemClick="ToolbarExport_ItemClick" />
    <dx:ASPxCardView ID="cardView" runat="server" DataSourceID="ProductsDataSource" KeyFieldName="ProductID" AutoGenerateColumns="False">
        <Columns>
            <dx:CardViewTextColumn FieldName="ProductName" />
            <dx:CardViewTextColumn FieldName="UnitPrice">
                <PropertiesTextEdit DisplayFormatString="c" />
            </dx:CardViewTextColumn>
            <dx:CardViewTextColumn FieldName="QuantityPerUnit" />
            <dx:CardViewComboBoxColumn FieldName="CategoryID" Caption="Category Name">
                <PropertiesComboBox DataSourceID="CategoriesDataSource" TextField="CategoryName" ValueField="CategoryID" ValueType="System.Int32" />
            </dx:CardViewComboBoxColumn>
            <dx:CardViewCheckColumn FieldName="Discontinued" />
        </Columns>
        <CardLayoutProperties>
            <Items>
                <dx:CardViewLayoutGroup Caption="Product" GroupBoxDecoration="HeadingLine">
                    <Items>
                        <dx:CardViewColumnLayoutItem Caption="Name" ColumnName="ProductName" />
                        <dx:CardViewColumnLayoutItem ColumnName="CategoryID" />
                    </Items>
                </dx:CardViewLayoutGroup>
                <dx:CardViewLayoutGroup Caption="Details" GroupBoxDecoration="HeadingLine">
                    <Items>
                        <dx:CardViewColumnLayoutItem ColumnName="UnitPrice" />
                        <dx:CardViewColumnLayoutItem ColumnName="QuantityPerUnit" />
                        <dx:CardViewColumnLayoutItem ColumnName="Discontinued" />
                    </Items>
                </dx:CardViewLayoutGroup>
            </Items>
        </CardLayoutProperties>
        <SettingsPager>
            <SettingsTableLayout RowsPerPage="2" ColumnCount="2" />
        </SettingsPager>
        <Styles>
            <Card Height="1" />
        </Styles>
    </dx:ASPxCardView>
    <dx:ASPxCardViewExporter ID="cardViewExport" runat="server" CardViewID="cardView" CardWidth="300" />
    <ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext" EntitySetName="Products" />
    <ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
</asp:Content>
