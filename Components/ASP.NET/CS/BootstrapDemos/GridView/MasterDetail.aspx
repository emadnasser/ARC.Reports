<%@ Page Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="MasterDetail.aspx.cs" Inherits="GridView_MasterDetail" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap GridView - Master-Detail Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Grid View
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <demo:DemoItem runat="server" Title="Master-Detail View">
        <Description>
            <p>The Grid View control allows you to build master-detail layouts of any complexity and nesting depth by providing a detail row template, which defines the way detail data is presented.</p>
            <p>This demo demonstrates how you can use nested grid controls to visualize a simple master-detail relationship between two data tables. To achieve this goal, use the following steps.</p>
            <ol>
                <li>
                    Create two Grid View controls 
                </li>
                <li>
                    Bind the first grid (the master grid) to a master data source and enable its <strong>SettingsDetail.ShowDetailRow</strong> option. 
                </li>
                <li>
                    Bind the second grid (the detail grid) to a detail data source that uses a <strong>SessionParameter</strong> as a filtering criterion. 
                </li>
                <li>
                    Create a <strong>DetailRow</strong> template for the master grid and place the detail grid onto it. 
                </li>
                <li>
                    Finally, handle the detail grid's <strong>BeforePerformDataSelect</strong> event and specify the session value used as a filtering criterion. 
                </li>
            </ol>
        </Description>
        <Example>
            <dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="CustomersDataSource" KeyFieldName="CustomerID">
                <Columns>
                    <dx:BootstrapGridViewDataColumn FieldName="ContactName" />
                    <dx:BootstrapGridViewDataColumn FieldName="CompanyName" />
                    <dx:BootstrapGridViewDataColumn FieldName="City" />
                    <dx:BootstrapGridViewDataColumn FieldName="Country" />
                </Columns>
                <Templates>
                    <DetailRow>
                        <dx:BootstrapGridView ID="DetailGridView1" runat="server" DataSourceID="InvoicesDataSource" KeyFieldName="OrderID;ProductID"
                            OnBeforePerformDataSelect="detailGrid_DataSelect" OnCustomUnboundColumnData="detailGrid_CustomUnboundColumnData">
                            <Columns>
                                <dx:BootstrapGridViewDataColumn FieldName="OrderID" Caption="Order Id" />
                                <dx:BootstrapGridViewDataColumn FieldName="OrderDate" />
                                <dx:BootstrapGridViewDataColumn FieldName="ShipName" />
                                <dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice">
                                    <PropertiesTextEdit DisplayFormatString="c" />
                                </dx:BootstrapGridViewDataTextColumn>
                                <dx:BootstrapGridViewDataColumn FieldName="Quantity" Name="Quantity" />
                                <dx:BootstrapGridViewDataTextColumn FieldName="Total" UnboundType="Decimal">
                                    <PropertiesTextEdit DisplayFormatString="c" />
                                </dx:BootstrapGridViewDataTextColumn>
                            </Columns>
                            <Settings ShowFooter="True" />
                            <TotalSummary>
                                <dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" />
                                <dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
                                <dx:ASPxSummaryItem FieldName="Quantity" SummaryType="Sum" />
                            </TotalSummary>
                        </dx:BootstrapGridView>
                    </DetailRow>
                </Templates>
                <SettingsDetail ShowDetailRow="true" />
            </dx:BootstrapGridView>
            <ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
            <ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Invoices" Where="it.CustomerID = @CustomerID">
                <WhereParameters>
                    <asp:SessionParameter Name="CustomerID" SessionField="CustomerID" Type="String" />
                </WhereParameters>
            </ef:EntityDataSource>
        </Example>
        <CodeASPX>&lt;dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="CustomersDataSource" KeyFieldName="CustomerID"&gt;
    &lt;SettingsDetail ShowDetailRow="true" /&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="ContactName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="CompanyName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="City" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Country" /&gt;
    &lt;/Columns&gt;
    &lt;Templates&gt;
        &lt;DetailRow&gt;
            &lt;dx:BootstrapGridView ID="DetailGridView1" runat="server" DataSourceID="InvoicesDataSource" KeyFieldName="OrderID;ProductID"
                OnBeforePerformDataSelect="detailGrid_DataSelect" OnCustomUnboundColumnData="detailGrid_CustomUnboundColumnData"&gt;
                &lt;Columns&gt;
                    &lt;dx:BootstrapGridViewDataColumn FieldName="OrderID" Caption="Order Id" /&gt;
                    &lt;dx:BootstrapGridViewDataColumn FieldName="OrderDate" /&gt;
                    &lt;dx:BootstrapGridViewDataColumn FieldName="ShipName" /&gt;
                    &lt;dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice" /&gt;
                    &lt;dx:BootstrapGridViewDataColumn FieldName="Quantity" Name="Quantity" /&gt;
                    &lt;dx:BootstrapGridViewDataTextColumn FieldName="Total" UnboundType="Decimal" /&gt;
                &lt;/Columns&gt;
                &lt;TotalSummary&gt;
                    &lt;dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" /&gt;
                    &lt;dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" /&gt;
                    &lt;dx:ASPxSummaryItem FieldName="Quantity" SummaryType="Sum" /&gt;
                &lt;/TotalSummary&gt;
            &lt;/dx:BootstrapGridView&gt;
        &lt;/DetailRow&gt;
    &lt;/Templates&gt;
&lt;/dx:BootstrapGridView&gt;
&lt;ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" /&gt;
&lt;ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Invoices" Where="it.CustomerID = @CustomerID"&gt;
    &lt;WhereParameters&gt;
        &lt;asp:SessionParameter Name="CustomerID" SessionField="CustomerID" Type="String" /&gt;
    &lt;/WhereParameters&gt;
&lt;/ef:EntityDataSource&gt;</CodeASPX>
        <CodeCS>protected void Page_Load(object sender, EventArgs e) {
    if(!IsPostBack) {
        GridView1.DataBind();
        GridView1.DetailRows.ExpandRow(0);
    }
}
protected void detailGrid_DataSelect(object sender, EventArgs e) {
    Session["CustomerID"] = (sender as BootstrapGridView).GetMasterRowKeyValue();
}
protected void detailGrid_CustomUnboundColumnData(object sender, ASPxGridViewColumnDataEventArgs e) {
    if(e.Column.FieldName == "Total") {
        decimal price = (decimal)e.GetListSourceFieldValue("UnitPrice");
        int quantity = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"));
        e.Value = price * quantity;
    }
}</CodeCS>
    </demo:DemoItem>
</asp:Content>
