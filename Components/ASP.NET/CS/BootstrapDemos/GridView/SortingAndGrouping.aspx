<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="SortingAndGrouping.aspx.cs" Inherits="GridView_GroupingAndSorting" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap GridView Sorting and Grouping Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Grid View
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <demo:DemoItem runat="server" Title="Sorting And Grouping">
        <Description>
            <p>The Grid View control supports sorting and grouping by an unlimited number of columns.</p>
            <p>An end-user can sort the grid by clicking the header of a column by which the grid should be sorted. The sort order is indicated by an arrow glyph within the sorted column. The grid can be sorted against multiple columns by clicking the required column headers while holding down the <kbd>shift</kbd> key.</p>
            <p>The grouping feature allows an end-user to group data within the grid by dragging column headers to the group panel.</p>
            <p> The <strong>SettingsBehavior.AllowSort</strong> property defines whether or not the grid can be sorted. Data grouping is allowed if the <strong>SettingsBehavior.AllowGroup</strong> and <strong>SettingsBehavior.AllowSort</strong> grid properties are set to <strong>true</strong>. The group panel's visibility is controlled by the <strong>Settings.ShowGroupPanel</strong> option.</p>
        </Description>
        <Example>
            <div class="form-inline">
                <dx:BootstrapComboBox runat="server" ID="cbFields" ValueType="System.Int32" SelectedIndex="0" Caption="Group by">
                    <Items>
                        <dx:BootstrapListEditItem Text="Country" Value="0" />
                        <dx:BootstrapListEditItem Text="Country, City" Value="1" />
                        <dx:BootstrapListEditItem Text="Company Name" Value="2" />
                    </Items>
                    <ClientSideEvents SelectedIndexChanged="function(s) { gridView1.PerformCallback(s.GetValue()) }" />
                </dx:BootstrapComboBox>
                <div class="form-group btn-toolbar">
                    <dx:BootstrapButton runat="server" ID="btnCollapse" Text="Collapse All Rows" UseSubmitBehavior="false"
                        AutoPostBack="false">
                        <ClientSideEvents Click="function() { gridView1.CollapseAll() }" />
                    </dx:BootstrapButton>
                    <dx:BootstrapButton runat="server" ID="btnExpand" Text="Expand All Rows" UseSubmitBehavior="false"
                        AutoPostBack="false">
                        <ClientSideEvents Click="function() { gridView1.ExpandAll() }" />
                    </dx:BootstrapButton>
                </div>
            </div>
            <br />
            <dx:BootstrapGridView ID="GridView1" ClientInstanceName="gridView1" runat="server" DataSourceID="CustomersDataSource"
                KeyFieldName="CustomerID" OnCustomCallback="GridView1_CustomCallback">
                <CssClassesPager PageNumber="hidden-sm hidden-xs" Ellipsis="hidden-sm hidden-xs" Summary="hidden-xs" />
                <Columns>
                    <dx:BootstrapGridViewDataColumn FieldName="ContactName" />
                    <dx:BootstrapGridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
                    <dx:BootstrapGridViewDataColumn FieldName="City" />
                    <dx:BootstrapGridViewDataColumn FieldName="Region" />
                    <dx:BootstrapGridViewDataColumn FieldName="Country" />
                </Columns>
                <Settings ShowGroupPanel="True" />
                <SettingsPager NumericButtonCount="8"></SettingsPager>
            </dx:BootstrapGridView>
            <ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
        </Example>
        <CodeASPX>&lt;dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="CustomersDataSource" KeyFieldName="CustomerID"&gt;
    &lt;Settings ShowGroupPanel="True" /&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="ContactName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="CompanyName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="City" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Region" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Country" /&gt;
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
    </demo:DemoItem>
</asp:Content>
