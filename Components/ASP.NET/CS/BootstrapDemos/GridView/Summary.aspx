<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Summary.aspx.cs" Inherits="GridView_Summary" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap GridView - Total and Group Summary Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Grid View
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <demo:DemoItem runat="server" Title="Total and Group Summary">
        <Description>
            <p>The Grid View control supports both total and group summaries.</p>
            <p>A total summary represents the value of an aggregate function calculated over all rows within the grid and is displayed within the grid footer, provided that the <strong>Settings.ShowFooter</strong> option is enabled. The Grid View stores its total summary items in the <strong>TotalSummary</strong> collection.</p>
            <p>A group summary represents the summary value calculated within a single group and is displayed in the group row or group footer. Group summaries are stored in the <strong>GroupSummary</strong> collection.</p>
        </Description>
        <Example>
            <dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="DataSource1" KeyFieldName="OrderID">
                <CssClassesPager PageNumber="hidden-sm hidden-xs" Ellipsis="hidden-sm hidden-xs" Summary="hidden-xs" />
                <Columns>
                    <dx:BootstrapGridViewDataColumn FieldName="Country" GroupIndex="0" />
                    <dx:BootstrapGridViewDataColumn FieldName="City" GroupIndex="1" />
                    <dx:BootstrapGridViewDataColumn FieldName="CompanyName" />
                    <dx:BootstrapGridViewDataColumn FieldName="Region" />
                    <dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice">
                        <PropertiesTextEdit DisplayFormatString="c" />
                    </dx:BootstrapGridViewDataTextColumn>
                    <dx:BootstrapGridViewDataColumn FieldName="Quantity" />
                    <dx:BootstrapGridViewDataTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * Quantity">
                        <PropertiesTextEdit DisplayFormatString="c" />
                    </dx:BootstrapGridViewDataTextColumn>
                </Columns>
                <Settings ShowGroupPanel="True" ShowFooter="True" />
                <SettingsPager NumericButtonCount="8"></SettingsPager>
                <GroupSummary>
                    <dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
                    <dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" />
                </GroupSummary>
                <TotalSummary>
                    <dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" />
                    <dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
                </TotalSummary>
            </dx:BootstrapGridView>
            <ef:EntityDataSource runat="server" ID="DataSource1" ContextTypeName="NorthwindContext"
                CommandText="SELECT c.CompanyName, i.City, i.Region, i.Country, i.Salesperson, i.OrderID, i.OrderDate, i.ProductID, i.ProductName, i.UnitPrice, i.Quantity, i.Discount, i.ExtendedPrice, i.Freight FROM Invoices AS i INNER JOIN Customers AS c ON i.CustomerID = c.CustomerId" />
        </Example>
        <CodeASPX>&lt;dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="DataSource1" KeyFieldName="OrderID"&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Country" GroupIndex="0" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="City" GroupIndex="1" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="CompanyName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Region" /&gt;
        &lt;dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice"&gt;
            &lt;PropertiesTextEdit DisplayFormatString="c" /&gt;
        &lt;/dx:BootstrapGridViewDataTextColumn&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Quantity" /&gt;
        &lt;dx:BootstrapGridViewDataTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * Quantity"&gt;
            &lt;PropertiesTextEdit DisplayFormatString="c" /&gt;
        &lt;/dx:BootstrapGridViewDataTextColumn&gt;
    &lt;/Columns&gt;
    &lt;Settings ShowGroupPanel="True" ShowFooter="True" /&gt;
    &lt;GroupSummary&gt;
        &lt;dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" /&gt;
        &lt;dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" /&gt;
    &lt;/GroupSummary&gt;
    &lt;TotalSummary&gt;
        &lt;dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" /&gt;
        &lt;dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" /&gt;
    &lt;/TotalSummary&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
    </demo:DemoItem>
</asp:Content>
