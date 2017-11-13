<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Localization.aspx.cs" Inherits="Accessibility_Localization" meta:resourcekey="PageResource1" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <script type="text/javascript">
        function LanguageComboBox_SelectedIndexChanged(s, e) {
            ASPxClientUtils.SetCookie("DXCurrentLanguage", s.GetValue());
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="LanguageComboBox" runat="server" AutoPostBack="True" meta:resourcekey="ASPxComboBoxResource1">
        <Items>
            <dx:ListEditItem Text="English" Value="en" meta:resourcekey="ListEditItemResource1" />
            <dx:ListEditItem Text="Русский" Value="ru" meta:resourcekey="ListEditItemResource2" />
            <dx:ListEditItem Text="Deutsch" Value="de" meta:resourcekey="ListEditItemResource3" />
        </Items>
        <ClientSideEvents SelectedIndexChanged="LanguageComboBox_SelectedIndexChanged" />
    </dx:ASPxComboBox>
    <br />
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="DemoDataSource1" KeyFieldName="EmployeeID" AutoGenerateColumns="False" Width="100%" meta:resourcekey="gridResource1">
        <Columns>
            <dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowEditButton="true" VisibleIndex="0" />
            <dx:GridViewDataTextColumn FieldName="FirstName" meta:resourcekey="GridViewDataTextColumnResource1">
                <EditFormSettings VisibleIndex="0" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataColumn FieldName="LastName" meta:resourcekey="GridViewDataColumnResource1">
                <EditFormSettings VisibleIndex="1" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="HomePhone" meta:resourcekey="GridViewDataColumnResource2">
                <EditFormSettings VisibleIndex="2" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="BirthDate" meta:resourcekey="GridViewDataColumnResource3">
                <EditFormSettings VisibleIndex="3" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="HireDate" meta:resourcekey="GridViewDataColumnResource4">
                <EditFormSettings VisibleIndex="4" />
            </dx:GridViewDataColumn>
        </Columns>
        <Settings ShowGroupPanel="True" ShowFilterRow="True" ShowFilterRowMenu="true" />
        <SettingsEditing EditFormColumnCount="3" />
        <SettingsPager PageSize="5" PageSizeItemSettings-Visible="true" PageSizeItemSettings-ShowAllItem="true"/>
    </dx:ASPxGridView>
    <demo:DemoDataSource runat="server" ID="DemoDataSource1" DataSourceID="EmployeesDataSource" IdentityKey="EmployeeID" />
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" EnableInsert="true" EnableUpdate="true" />
</asp:Content>
