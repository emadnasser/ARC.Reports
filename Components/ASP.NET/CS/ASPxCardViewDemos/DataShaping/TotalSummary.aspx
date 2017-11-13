<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TotalSummary.aspx.cs" Inherits="Data_Summaries_TotalSummary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCardView ID="CardView" runat="server" DataSourceID="InvoicesDataSource" Width="100%">
        <Columns>
            <dx:CardViewTextColumn FieldName="CompanyName" />
            <dx:CardViewTextColumn FieldName="Country" />
            <dx:CardViewTextColumn FieldName="City" />
            <dx:CardViewTextColumn FieldName="UnitPrice">
                <PropertiesTextEdit DisplayFormatString="c" />
            </dx:CardViewTextColumn>
            <dx:CardViewTextColumn FieldName="Quantity" />
            <dx:CardViewTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * Quantity * (1 - Discount)">
                <PropertiesTextEdit DisplayFormatString="<b>{0:c}</b>" />
            </dx:CardViewTextColumn>
        </Columns> 
        <Settings ShowSummaryPanel="true" />
        <SettingsBehavior AllowEllipsisInText="True"></SettingsBehavior>
        <TotalSummary>
            <dx:ASPxCardViewSummaryItem FieldName="Total" SummaryType="Sum" ValueDisplayFormat="<b>{0:c}</b>"/>
        </TotalSummary>
        <Styles>
            <Card Height="1px" />
        </Styles>  
    </dx:ASPxCardView>
    <ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext"
        CommandText="SELECT c.CompanyName AS CompanyName, i.OrderID, i.Country, i.City, i.UnitPrice, i.Quantity, i.Discount FROM Invoices as i INNER JOIN Customers as c ON c.CustomerId = i.CustomerId" />
</asp:Content>
