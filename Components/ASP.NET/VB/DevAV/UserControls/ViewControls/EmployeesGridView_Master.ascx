<%@ Control Language="vb" AutoEventWireup="true" CodeFile="EmployeesGridView_Master.ascx.vb" Inherits="UserControls_ViewControls_EmployeesGridView_Master" %>
<dx:ASPxGridView ID="EmployeesGrid" ClientInstanceName="employeesGrid" runat="server" Width="100%" AutoGenerateColumns="false" 
    KeyFieldName="Id" KeyboardSupport="true" EnableRowsCache="false" CssClass="employeesGridView">
    <Columns>
        <dx:GridViewDataTextColumn FieldName="FirstName" Settings-AllowFilterBySearchPanel="True" />
        <dx:GridViewDataTextColumn FieldName="LastName" Settings-AllowFilterBySearchPanel="True" />
        <dx:GridViewDataTextColumn FieldName="Title" Settings-AllowFilterBySearchPanel="True" />
        <dx:GridViewDataDateColumn FieldName="BirthDate" Width="15%">
            <PropertiesDateEdit DisplayFormatString="MM/dd/yyyy" />
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataDateColumn FieldName="HireDate" Width="15%">
            <PropertiesDateEdit DisplayFormatString="MM/dd/yyyy" />
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataColumn Caption="Details" Width="10%">
            <DataItemTemplate>
                <div id='<%#Eval("ID")%>' onclick="DevAV.GridEditButton_Click(event)" class="gridEditButton" title="Edit Employee"></div>
            </DataItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
        </dx:GridViewDataColumn>
        <dx:GridViewDataTextColumn FieldName="Department" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="Email" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="HomePhone" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MobilePhone" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PersonalProfile" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="Prefix" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="Skype" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="Status" Visible="false" />
    </Columns>
    <SettingsBehavior AllowFocusedRow="true" EnableCustomizationWindow="true" AllowClientEventsOnLoad="false" />
    <SettingsPager AlwaysShowPager="true" ShowEmptyDataRows="true" PageSize="15" />
    <Settings VerticalScrollBarMode="Auto" VerticalScrollableHeight="400" />
    <SettingsContextMenu Enabled="true">
        <ColumnMenuItemVisibility ShowFooter="false" ShowFilterRow="false" GroupByColumn="false" ShowGroupPanel="false" />
    </SettingsContextMenu>
    <SettingsPopup>
        <CustomizationWindow HorizontalAlign="LeftSides" VerticalAlign="Below" Width="220px" Height="300px" />
    </SettingsPopup>
    <SettingsSearchPanel CustomEditorID="SearchBox" HighlightResults="True" ColumnNames="FirstName; LastName"></SettingsSearchPanel>
    <ClientSideEvents Init="DevAV.Page.EmployeesGrid_Init" FocusedRowChanged="DevAV.Page.EmployeesGrid_FocusedRowChanged" EndCallback="DevAV.Page.EmployeesGrid_EndCallback" 
        ContextMenuItemClick="DevAV.Page.EmployeesGrid_ContextMenuItemClick" CustomizationWindowCloseUp="DevAV.GridCustomizationWindow_CloseUp" />
    <Styles>
        <Table CssClass="dataTable"></Table>
        <Header CssClass="header"></Header>
        <FocusedRow CssClass="focusRow"></FocusedRow>
        <GroupPanel CssClass="groupPanel" />
    </Styles>
</dx:ASPxGridView>