<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Products_Master.ascx.vb" Inherits="UserControls_ViewControls_Products_Master" %>
<dx:ASPxGridView ID="ProductGrid" ClientInstanceName="productGrid" runat="server" KeyFieldName="Id" Width="100%" CssClass="productsGridView">
    <Columns>
        <dx:GridViewDataTextColumn Caption="Product Name" FieldName="Name" Settings-AllowFilterBySearchPanel="True" />
        <dx:GridViewDataTextColumn FieldName="Cost" PropertiesTextEdit-DisplayFormatString="C" />
        <dx:GridViewDataTextColumn FieldName="SalePrice" PropertiesTextEdit-DisplayFormatString="C" />
        <dx:GridViewDataTextColumn FieldName="RetailPrice" PropertiesTextEdit-DisplayFormatString="C" />
        <dx:GridViewDataTextColumn Caption="Inventory" FieldName="CurrentInventory" />
        <dx:GridViewDataTextColumn FieldName="Manufacturing" />
        <dx:GridViewDataCheckColumn Caption="Backordered" FieldName="Backorder" />
        <dx:GridViewDataTextColumn FieldName="Category" Visible="false" />
        <dx:GridViewDataDateColumn FieldName="ProductionStart" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="Available" Visible="false" />
        <dx:GridViewDataTextColumn Caption="Support" FieldName="Support.FullName" Visible="false" />
    </Columns>
    <Settings VerticalScrollBarMode="Auto" VerticalScrollableHeight="400" />
    <SettingsSearchPanel CustomEditorID="SearchBox"></SettingsSearchPanel>
    <SettingsBehavior AllowFocusedRow="true" AllowClientEventsOnLoad="false" EnableCustomizationWindow="true" />
    <SettingsPager AlwaysShowPager="true" ShowEmptyDataRows="true" PageSize="15"></SettingsPager>
    <SettingsContextMenu Enabled="true">
        <ColumnMenuItemVisibility ShowFooter="false" ShowFilterRow="false" GroupByColumn="false" ShowGroupPanel="false" />
    </SettingsContextMenu>
    <SettingsPopup>
        <CustomizationWindow HorizontalAlign="LeftSides" VerticalAlign="Below" />
    </SettingsPopup>
    <ClientSideEvents FocusedRowChanged="DevAV.Page.ProductGrid_FocusedRowChanged" ContextMenuItemClick="DevAV.Page.ProductGrid_ContextMenuItemClick" CustomizationWindowCloseUp="DevAV.GridCustomizationWindow_CloseUp" />
    <Styles>
        <Table CssClass="dataTable"></Table>
        <Header CssClass="header"></Header>
        <GroupPanel CssClass="groupPanel" />
    </Styles>
</dx:ASPxGridView>