<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Filtering.aspx.cs" Inherits="GridView_Filtering" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap GridView Data Filtering Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Grid View
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-9">
    <demo:DemoItem runat="server" Title="Header Filter and Search Panel">
        <Description>
            <p>The Grid View control provides a powerful data filtering mechanism that displays a dropdown list of all unique values within a column. This dropdown list is invoked by activating the column header’s filter button.</p>
            <p>Additionally, the Grid View control allows you to filter data and highlight search results via an integrated easy-to-use Search Panel. To enable the Search Panel, set the <strong>SettingsSearchPanel.Visible</strong> property to <strong>true</strong>.</p>
        </Description>
        <Example>
            <dx:BootstrapGridView ID="GridView1" runat="server" KeyFieldName="OrderID" DataSourceID="DataSource1" AutoGenerateColumns="False">
                <CssClassesPager PageNumber="hidden-xs" Ellipsis="hidden-xs" Summary="hidden-md hidden-sm hidden-xs" />
                <Settings ShowHeaderFilterButton="true" ShowGroupPanel="true" />
                <SettingsSearchPanel Visible="true" ShowApplyButton="true" />
                <Columns>
                    <dx:BootstrapGridViewDataDateColumn FieldName="OrderDate" />
                    <dx:BootstrapGridViewDataColumn FieldName="CompanyName" />
                    <dx:BootstrapGridViewDataColumn FieldName="Country" />
                    <dx:BootstrapGridViewDataColumn FieldName="City" />
                    <dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice">
                        <PropertiesTextEdit DisplayFormatString="c" />
                    </dx:BootstrapGridViewDataTextColumn>
                    <dx:BootstrapGridViewDataTextColumn FieldName="Discount">
                        <PropertiesTextEdit DisplayFormatString="p0" />
                    </dx:BootstrapGridViewDataTextColumn>
                </Columns>
                <SettingsPager NumericButtonCount="7"></SettingsPager>
            </dx:BootstrapGridView>
            <ef:EntityDataSource runat="server" ID="DataSource1" ContextTypeName="NorthwindContext"
                CommandText="SELECT c.CompanyName, i.OrderID, i.Country, i.City, i.UnitPrice, i.Quantity, i.Discount, i.OrderDate FROM Invoices AS i INNER JOIN Customers AS c ON i.CustomerID = c.CustomerId ORDER BY c.CompanyName" />
        </Example>
        <CodeASPX>&lt;dx:BootstrapGridView ID="GridView1" runat="server" KeyFieldName="OrderID" DataSourceID="DataSource1" AutoGenerateColumns="False"&gt;
    &lt;Settings ShowHeaderFilterButton="true" ShowGroupPanel="true" /&gt;
    &lt;SettingsSearchPanel Visible="true" ShowApplyButton="true" /&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewDataDateColumn FieldName="OrderDate" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="CompanyName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Country" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="City" /&gt;
        &lt;dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice"&gt;
            &lt;PropertiesTextEdit DisplayFormatString="c" /&gt;
        &lt;/dx:BootstrapGridViewDataTextColumn&gt;
        &lt;dx:BootstrapGridViewDataTextColumn FieldName="Discount"&gt;
            &lt;PropertiesTextEdit DisplayFormatString="p0" /&gt;
        &lt;/dx:BootstrapGridViewDataTextColumn&gt;
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Header Filter with CheckedList mode">
        <Description>
            <p>The header filter can operate in <strong>CheckedList</strong>  mode, in which it displays a check box list allowing an end-user to specify multiple filtering criteria. You can enable the <strong>CheckedList</strong> mode for a column's header filter by setting the column's <strong>SettingsHeaderFilter.Mode</strong> property to <strong>GridHeaderFilterMode.CheckedList</strong>.</p>
        </Description>
        <Example>
            <dx:BootstrapGridView ID="GridView2" runat="server" KeyFieldName="ProductID" DataSourceID="DataSource2" AutoGenerateColumns="False">
                <Settings ShowHeaderFilterButton="true" />
                <CssClassesPager PageNumber="hidden-xs" Ellipsis="hidden-xs" Summary="hidden-md hidden-sm hidden-xs" />
                <Columns>
                    <dx:BootstrapGridViewDataDateColumn FieldName="ProductName">
                        <SettingsHeaderFilter Mode="CheckedList" />
                    </dx:BootstrapGridViewDataDateColumn>
                    <dx:BootstrapGridViewDataColumn FieldName="CategoryName">
                        <SettingsHeaderFilter Mode="CheckedList" />
                    </dx:BootstrapGridViewDataColumn>
                    <dx:BootstrapGridViewDataColumn FieldName="CompanyName" Caption="Supplier">
                        <SettingsHeaderFilter Mode="CheckedList" />
                    </dx:BootstrapGridViewDataColumn>
                    <dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice">
                        <SettingsHeaderFilter Mode="CheckedList" />
                        <PropertiesTextEdit DisplayFormatString="c" />
                    </dx:BootstrapGridViewDataTextColumn>
                </Columns>
                <SettingsPager NumericButtonCount="7"></SettingsPager>
            </dx:BootstrapGridView>
            <ef:EntityDataSource runat="server" ID="DataSource2" ContextTypeName="NorthwindContext"
                CommandText="SELECT p.ProductID, p.ProductName, c.CategoryName, s.CompanyName, p.UnitPrice FROM Products AS p INNER JOIN Categories AS c ON p.CategoryID = c.CategoryID INNER JOIN Suppliers AS s ON s.SupplierID = p.SupplierID" />
        </Example>
        <CodeASPX>&lt;dx:BootstrapGridView ID="GridView2" runat="server" KeyFieldName="ProductID" DataSourceID="DataSource2" AutoGenerateColumns="False"&gt;
    &lt;Settings ShowHeaderFilterButton="true" /&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewDataDateColumn FieldName="ProductName"&gt;
            &lt;SettingsHeaderFilter Mode="CheckedList" /&gt;
        &lt;/dx:BootstrapGridViewDataDateColumn&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="CategoryName"&gt;
            &lt;SettingsHeaderFilter Mode="CheckedList" /&gt;
        &lt;/dx:BootstrapGridViewDataColumn&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="CompanyName" Caption="Supplier"&gt;
            &lt;SettingsHeaderFilter Mode="CheckedList" /&gt;
        &lt;/dx:BootstrapGridViewDataColumn&gt;
        &lt;dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice"&gt;
            &lt;SettingsHeaderFilter Mode="CheckedList" /&gt;
            &lt;PropertiesTextEdit DisplayFormatString="c" /&gt;
        &lt;/dx:BootstrapGridViewDataTextColumn&gt;
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Advanced Filtering">
        <Description>
            <p>The Grid View control allows you to create custom filter values, define filter criteria and display these values within the column's filter dropdown. To do this, handle the <strong>HeaderFilterFillItems</strong> event. In this demo, custom filter values are displayed within the 'Total' and 'Quantity' columns' filter dropdowns.</p>
        </Description>
        <Example>
            <dx:BootstrapGridView ID="GridView3" runat="server" KeyFieldName="OrderID" DataSourceID="DataSource3" EnableRowsCache="false" AutoGenerateColumns="False" OnHeaderFilterFillItems="GridView2_HeaderFilterFillItems">
                <CssClassesPager PageNumber="hidden-xs" Ellipsis="hidden-xs" Summary="hidden-md hidden-sm hidden-xs" />
                <Columns>
                    <dx:BootstrapGridViewDataDateColumn FieldName="OrderDate"></dx:BootstrapGridViewDataDateColumn>
                    <dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice">
                        <PropertiesTextEdit DisplayFormatString="c" />
                    </dx:BootstrapGridViewDataTextColumn>
                    <dx:BootstrapGridViewDataColumn FieldName="Quantity" />
                    <dx:BootstrapGridViewDataTextColumn FieldName="Discount">
                        <PropertiesTextEdit DisplayFormatString="p0" />
                    </dx:BootstrapGridViewDataTextColumn>
                    <dx:BootstrapGridViewDataTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * Quantity * (1 - Discount)">
                        <PropertiesTextEdit DisplayFormatString="c" />
                    </dx:BootstrapGridViewDataTextColumn>
                </Columns>
                <Settings ShowHeaderFilterButton="true" />
                <SettingsPopup>
                    <HeaderFilter Height="200" />
                </SettingsPopup>
                <SettingsPager NumericButtonCount="7"></SettingsPager>
            </dx:BootstrapGridView>
            <ef:EntityDataSource runat="server" ID="DataSource3" ContextTypeName="NorthwindContext"
                CommandText="SELECT c.CompanyName, i.OrderID, i.Country, i.City, i.UnitPrice, i.Quantity, i.Discount, i.OrderDate FROM Invoices AS i INNER JOIN Customers AS c ON i.CustomerID = c.CustomerId ORDER BY c.CompanyName" />
        </Example>
        <CodeASPX>&lt;dx:BootstrapGridView ID="GridView2" runat="server" KeyFieldName="OrderID" DataSourceID="DataSource2"
    AutoGenerateColumns="False" OnHeaderFilterFillItems="GridView2_HeaderFilterFillItems"&gt;
    &lt;Settings ShowHeaderFilterButton="true" /&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewDataDateColumn FieldName="OrderDate" /&gt;
        &lt;dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice"&gt;
            &lt;PropertiesTextEdit DisplayFormatString="c" /&gt;
        &lt;/dx:BootstrapGridViewDataTextColumn&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Quantity" /&gt;
        &lt;dx:BootstrapGridViewDataTextColumn FieldName="Discount"&gt;
            &lt;PropertiesTextEdit DisplayFormatString="p0" /&gt;
        &lt;/dx:BootstrapGridViewDataTextColumn&gt;
        &lt;dx:BootstrapGridViewDataTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * Quantity * (1 - Discount)"&gt;
            &lt;PropertiesTextEdit DisplayFormatString="c" /&gt;
        &lt;/dx:BootstrapGridViewDataTextColumn&gt;
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
        <CodeCS>const int QuantityFilterStep = 10;
const int TotalFilterStep = 100;
protected void GridView2_HeaderFilterFillItems(object sender, ASPxGridViewHeaderFilterEventArgs e) {
    switch(e.Column.FieldName) {
        case "Total":
            PrepareTotalFilterItems(e);
            break;
        case "Quantity":
            PrepareQuantityFilterItems(e);
            break;
    }
}
protected virtual void PrepareTotalFilterItems(ASPxGridViewHeaderFilterEventArgs e) {
    e.Values.Clear();
    e.AddShowAll();
    for(int i = 0; i < 10; i++) {
        double start = TotalFilterStep * i;
        double end = start + TotalFilterStep - 0.01;
        e.AddValue(string.Format("from {0:c} to {1:c}", start, end), "", string.Format("[Total] >= {0} and [Total] <= {1}", start, end));
    }
    e.AddValue(string.Format("> {0:c}", 1000), "", "[Total] > 1000");
}
protected virtual void PrepareQuantityFilterItems(ASPxGridViewHeaderFilterEventArgs e) {
    int max = e.Values.Max(v => {
        int value = 0;
        if(int.TryParse(v.Value, out value))
            return value;
        return 0;
    });
    e.Values.Clear();
    e.AddShowAll();
    for(int i = 0; i < max / QuantityFilterStep + 1; i++) {
        int start = QuantityFilterStep * i;
        int end = start + QuantityFilterStep - 1;
        e.AddValue(string.Format("from {0} to {1}", start, end), "", string.Format("[Quantity] >= {0} and [Quantity] <= {1}", start, end));
    }
}</CodeCS>
    </demo:DemoItem>
        </div>
    <div class="col-md-3">
        <div class="affix" id="page-navigation">
        </div>
    </div>
</asp:Content>
