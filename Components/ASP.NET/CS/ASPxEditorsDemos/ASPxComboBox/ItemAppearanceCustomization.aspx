<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ItemAppearanceCustomization.aspx.cs"
    Inherits="ASPxComboBox_ItemAppearanceCustomization" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .phone {
            color: #9C0006;
            font-style: italic;
        }
        .owner {
            color: #006100;
            background-color: #C6EFCE;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="customersComboBox" Width="260" ClientInstanceName="ClientCustomersComboBox" runat="server" DataSourceID="CustomersDataSource" ValueField="CustomerID"
        ValueType="System.String" TextFormatString="{0}" EnableCallbackMode="true" CallbackPageSize="30" SelectedIndex="0"
         OnItemTextCellPrepared="customersComboBox_ItemTextCellPrepared" OnItemRowPrepared="customersComboBox_ItemRowPrepared">
        <Columns>
            <dx:ListBoxColumn FieldName="ContactName" Width="160" />            
            <dx:ListBoxColumn FieldName="CompanyName" Width="220" />
            <dx:ListBoxColumn FieldName="Phone" />            
        </Columns>
    </dx:ASPxComboBox>
    <br />
    <b>Note: </b>Open the combo box's dropdown window to see how the appearance of items is customized. Hover an item to see a custom tooltip.
    <ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" OrderBy="it.ContactName, it.CompanyName" />
</asp:Content>
