<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HeaderFilter.aspx.cs"
    Inherits="Filtering_HeaderFilter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCheckBox ID="hFModeCheckBox" runat="server" Text="Enable CheckedList mode" Checked="true" AutoPostBack="true" />
    <br />
    <dx:ASPxGridView ID="grid" runat="server" KeyFieldName="OrderID" DataSourceID="InvoicesDataSource" Width="100%"
        AutoGenerateColumns="False" OnHeaderFilterFillItems="grid_HeaderFilterFillItems">
        <Columns>
            <dx:GridViewDataColumn FieldName="CompanyName" />
            <dx:GridViewDataColumn FieldName="Country" />
            <dx:GridViewDataColumn FieldName="City" />
            <dx:GridViewDataTextColumn FieldName="UnitPrice">
                <PropertiesTextEdit DisplayFormatString="c" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataColumn FieldName="Quantity" />
            <dx:GridViewDataTextColumn FieldName="Discount">
                <PropertiesTextEdit DisplayFormatString="p0"/>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * Quantity * (1 - Discount)">
                <FooterCellStyle ForeColor="Brown" />
                <PropertiesTextEdit DisplayFormatString="c" />
            </dx:GridViewDataTextColumn>
        </Columns>
        <Settings ShowFooter="True" ShowHeaderFilterButton="true" />
        <SettingsPopup>
            <HeaderFilter Height="200"/>
        </SettingsPopup>
        <TotalSummary>
            <dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" />
            <dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
        </TotalSummary>
    </dx:ASPxGridView>
    <ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext" 
        CommandText="SELECT c.CompanyName, i.OrderID, i.Country, i.City, i.UnitPrice, i.Quantity, i.Discount FROM Invoices AS i INNER JOIN Customers AS c ON i.CustomerID = c.CustomerId ORDER BY c.CompanyName" />
</asp:Content>
