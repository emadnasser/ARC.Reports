<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PreviewRow.aspx.cs"
    Inherits="Rows_PreviewRow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="EmployeesDataSource"
        KeyFieldName="EmployeeID" PreviewFieldName="Notes" Width="100%">
        <Columns>
            <dx:GridViewDataColumn FieldName="FirstName" VisibleIndex="0" />
            <dx:GridViewDataColumn FieldName="Title" VisibleIndex="3" />
            <dx:GridViewDataColumn FieldName="LastName" VisibleIndex="1" />
            <dx:GridViewDataColumn FieldName="BirthDate" VisibleIndex="2" />
            <dx:GridViewDataColumn FieldName="HireDate" VisibleIndex="4" />
        </Columns>
        <Settings ShowPreview="True" />
        <SettingsPager PageSize="5">
        </SettingsPager>
    </dx:ASPxGridView>
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
</asp:Content>
