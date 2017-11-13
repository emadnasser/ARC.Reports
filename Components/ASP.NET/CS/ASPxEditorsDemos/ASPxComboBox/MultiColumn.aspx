<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MultiColumn.aspx.cs"
    Inherits="ASPxComboBox_MultiColumn" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="CmbCustomers" runat="server" Width="170px" DropDownWidth="550"
        DropDownStyle="DropDownList" DataSourceID="CustomersDataSource" ValueField="CustomerID"
        ValueType="System.String" TextFormatString="{0}" EnableCallbackMode="true" IncrementalFilteringMode="StartsWith"
        CallbackPageSize="30">
        <Columns>
            <dx:ListBoxColumn FieldName="ContactName" Width="130px" />
            <dx:ListBoxColumn FieldName="CompanyName" Width="100%" />
            <dx:ListBoxColumn FieldName="Country" Width="70px" />
            <dx:ListBoxColumn FieldName="Phone" Width="100px" />
        </Columns>
    </dx:ASPxComboBox>
    <ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" OrderBy="it.ContactName, it.CompanyName" />
</asp:Content>
