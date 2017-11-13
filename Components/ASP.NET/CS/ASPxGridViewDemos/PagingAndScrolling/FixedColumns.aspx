<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FixedColumns.aspx.cs"
    Inherits="PagingAndScrolling_FixedColumns" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxGridView ID="Grid" runat="server" DataSourceID="CustomersDataSource" KeyFieldName="CustomerID" Width="700">
        <Columns>
            <dx:GridViewDataColumn FieldName="ContactName" Width="150" FixedStyle="Left" />
            <dx:GridViewDataColumn FieldName="CompanyName" Width="180" FixedStyle="Left" />
            <dx:GridViewDataColumn FieldName="City" Width="130" />
            <dx:GridViewDataColumn FieldName="Region" Width="80" />
            <dx:GridViewDataColumn FieldName="Country" GroupIndex="1" />
            <dx:GridViewDataColumn FieldName="Address" Width="200" />
            <dx:GridViewDataColumn FieldName="PostalCode" Width="100" />
            <dx:GridViewDataColumn FieldName="Phone" Width="150" />
            <dx:GridViewDataColumn FieldName="Fax" Width="150" />
        </Columns>
        <Settings HorizontalScrollBarMode="Visible" />
        <SettingsBehavior AutoExpandAllGroups="true" />
        <Styles>
            <FixedColumn BackColor="LightYellow"></FixedColumn>
        </Styles>
    </dx:ASPxGridView>
    <ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>
