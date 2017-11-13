<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomPopupMenu.aspx.cs"
    Inherits="Appearance_CustomPopupMenu" Title="Untitled Page" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxPivotGrid ID="pivotGrid" runat="server" ClientInstanceName="pivotGrid" DataSourceID="ProductReportsDataSource"
        OnPopupMenuCreated="pivotGrid_PopupMenuCreated" CssClass="" OnCustomCallback="pivotGrid_CustomCallback"
        Width="100%">
        <Fields>
            <dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Category" FieldName="CategoryName"
                ID="fieldCategoryName" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="0" Caption="Year" FieldName="ShippedDate"
                ID="fieldShippedDate" GroupInterval="DateYear" UnboundFieldName="UnboundColumn1" />
            <dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Sales" FieldName="ProductSales"
                ID="fieldProductSales" />
            <dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Products" FieldName="ProductName"
                ID="fieldProductName" />
        </Fields>
        <OptionsView HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
        <ClientSideEvents PopupMenuItemClick="function(s, e) {
    if(e.MenuItemName == 'Filter')
    pivotGrid.PerformCallback('F|' + e.FieldID + '|' + e.FieldValueIndex);
        }" />
    </dx:ASPxPivotGrid>
    <ef:EntityDataSource runat="server" ID="ProductReportsDataSource" ContextTypeName="NorthwindContext" EntitySetName="ProductReports" />
</asp:Content>
