<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditForm.aspx.cs" Inherits="GridEditing_EditForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
    <dx:ASPxCheckBox ID="chkMemoLocation" runat="server" Checked="False" OnCheckedChanged="chkMemoLocation_CheckedChanged" Text="Show memo at bottom" AutoPostBack="True" />
    <dx:ASPxCheckBox ID="chkNewRowLocation" runat="server" Checked="False" OnCheckedChanged="chkNewRowLocation_CheckedChanged" Text="Show New Item row at bottom" AutoPostBack="True" />
    <br />
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="DemoDataSource1" 
        KeyFieldName="EmployeeID" AutoGenerateColumns="False" Width="100%">
        <Columns>
            <dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowEditButton="true"  VisibleIndex="0" />
            <dx:GridViewDataTextColumn FieldName="FirstName" VisibleIndex="1">
                <EditFormSettings VisibleIndex="0" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataColumn FieldName="Title" VisibleIndex="4">
                <EditFormSettings VisibleIndex="1" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataMemoColumn FieldName="Notes" Visible="False">
                <EditFormSettings RowSpan="4" Visible="True" VisibleIndex="2" />
            </dx:GridViewDataMemoColumn>
            <dx:GridViewDataColumn FieldName="LastName" VisibleIndex="2">
                <EditFormSettings VisibleIndex="3" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="BirthDate" VisibleIndex="3">
                <EditFormSettings VisibleIndex="4" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="HireDate" VisibleIndex="5">
                <EditFormSettings VisibleIndex="5" />
            </dx:GridViewDataColumn>
        </Columns>
        <SettingsEditing EditFormColumnCount="3"/>
        <SettingsPager Mode="ShowAllRecords"/>
        <Settings ShowTitlePanel="true" />
        <SettingsText Title="Edit Form Editing" />
    </dx:ASPxGridView>
    <demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="EmployeeID" DataSourceID="EmployeesDataSource" />
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource"
        ContextTypeName="NorthwindContext"
        EnableDelete="True" EnableInsert="True" EnableUpdate="True"
        EntitySetName="Employees">
    </ef:EntityDataSource>
</asp:Content>
