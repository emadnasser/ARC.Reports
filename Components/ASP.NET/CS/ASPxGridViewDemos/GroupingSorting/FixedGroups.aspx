<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FixedGroups.aspx.cs"
    Inherits="GroupingSorting_FixedGroups" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxGridView ID="Grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
        KeyFieldName="CustomerID" Width="100%">
        <Columns>
            <dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="1" />
            <dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
            <dx:GridViewDataColumn FieldName="City" VisibleIndex="3" />
            <dx:GridViewDataColumn FieldName="Region" VisibleIndex="4" />
            <dx:GridViewDataColumn FieldName="Country" VisibleIndex="5" GroupIndex="0" />
        </Columns>
        <Settings ShowGroupPanel="True" VerticalScrollBarMode="Visible" VerticalScrollableHeight="300" />
        <SettingsBehavior AllowFixedGroups="true" />
        <SettingsPager Mode="ShowAllRecords" />
    </dx:ASPxGridView>
    <ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers"/>
</asp:Content>
