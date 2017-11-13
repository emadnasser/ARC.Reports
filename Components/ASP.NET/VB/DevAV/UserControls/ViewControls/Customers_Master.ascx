<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Customers_Master.ascx.vb" Inherits="UserControls_ViewControls_Customers_Master" %>
<dx:ASPxGridView ID="CustomerGrid" ClientInstanceName="customerGrid" runat="server" Width="100%" KeyFieldName="Id" CssClass="customersGridView">
    <Columns>
        <dx:GridViewDataTextColumn FieldName="Name" Settings-AllowFilterBySearchPanel="True" />
        <dx:GridViewDataTextColumn Caption="Address" FieldName="BillingAddress.Line" Settings-AllowFilterBySearchPanel="True" />
        <dx:GridViewDataTextColumn Caption="City" FieldName="BillingAddress.City" Settings-AllowFilterBySearchPanel="True" />
        <dx:GridViewDataTextColumn Caption="State" FieldName="BillingAddress.State" />
        <dx:GridViewDataTextColumn Caption="Zipcode" FieldName="BillingAddress.ZipCode" />
        <dx:GridViewDataColumn Caption="Details" Width="10%">
            <DataItemTemplate>
                <div id='<%#Eval("ID")%>' onclick="DevAV.GridEditButton_Click(event)" class="gridEditButton" title="Edit Customer"></div>
            </DataItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
        </dx:GridViewDataColumn>
        <dx:GridViewDataTextColumn FieldName="Phone" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="Fax" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="Website" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="AnnualRevenue" Visible="false" PropertiesTextEdit-DisplayFormatString="C" />
        <dx:GridViewDataTextColumn Caption="Customer Status" FieldName="Status" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TotalStores" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TotalEmployees" Visible="false" />
    </Columns>
    <SettingsBehavior AllowFocusedRow="true" EnableCustomizationWindow="true" AllowClientEventsOnLoad="false" />
    <SettingsContextMenu Enabled="true">
        <ColumnMenuItemVisibility ShowFooter="false" ShowFilterRow="false" GroupByColumn="false" ShowGroupPanel="false" />
    </SettingsContextMenu>
    <Settings VerticalScrollBarMode="Auto" VerticalScrollableHeight="400" />
    <SettingsSearchPanel CustomEditorID="SearchBox"></SettingsSearchPanel>
    <SettingsPager AlwaysShowPager="true" ShowEmptyDataRows="true" PageSize="15"></SettingsPager>
    <ClientSideEvents FocusedRowChanged="DevAV.Page.CustomerGrid_FocusedRowChanged" ContextMenuItemClick="DevAV.Page.CustomerGrid_ContextMenuItemClick" CustomizationWindowCloseUp="DevAV.GridCustomizationWindow_CloseUp" />
    <SettingsPopup>
        <CustomizationWindow HorizontalAlign="LeftSides" VerticalAlign="Below" Width="220px" Height="300px" />
    </SettingsPopup>
    <Styles>
        <GroupPanel CssClass="groupPanel"></GroupPanel>
        <Table CssClass="dataTable"></Table>
        <FocusedRow CssClass="focusRow"></FocusedRow>
        <GroupPanel CssClass="groupPanel" />
    </Styles>
</dx:ASPxGridView>