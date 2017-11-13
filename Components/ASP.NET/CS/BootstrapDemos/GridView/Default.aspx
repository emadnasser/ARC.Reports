<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="GridView_Overview" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    DevExpress Bootstrap Grid View for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Grid View
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <h2>Grid View Overview</h2>
    <p>The DevExpress Bootstrap Grid View is a full-featured tabular data presentation control that renders itself using Bootstrap CSS classes. It fully supports data editing and delivers numerous end-user data shaping features, including facilities for end-user data filtering, grouping and sorting. Both total and group summaries are also available out-of-the box.</p>
    <dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="DemoDataSource1" KeyFieldName="EmployeeID" EnableRowsCache="False">
        <Settings ShowGroupPanel="true" />
        <SettingsPager PageSize="5"></SettingsPager>
        <Columns>
            <dx:BootstrapGridViewDataColumn FieldName="FirstName" />
            <dx:BootstrapGridViewDataColumn FieldName="LastName" />
            <dx:BootstrapGridViewDataDateColumn FieldName="BirthDate" />
            <dx:BootstrapGridViewDataColumn FieldName="City" />
            <dx:BootstrapGridViewDataColumn FieldName="Country" />
        </Columns>
    </dx:BootstrapGridView>
    <demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="EmployeeID" DataSourceID="DataSource1"></demo:DemoDataSource>
    <ef:EntityDataSource runat="server" ID="DataSource1" ContextTypeName="NorthwindContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntitySetName="Employees">
    </ef:EntityDataSource>
    <p>The Grid View control allows you to create complex responsive layouts employing band columns, cell merging, and master-detail presentation. Additionally, the layouts of separate Grid View’s visual elements are customizable using templates.</p>
    <p>The Grid View has been designed to work with large data sources and supports data binding in server mode. In this mode, the grid only loads the records to be displayed on screen and delegates all data processing to the database server. The Grid View control automatically splits content across multiple pages and a built-in pager enables end-users to navigate through data. It also supports endless paging, in which the grid loads new rows when an end user scrolls the page.</p>
    <p>Extensive server-side and client-side APIs cover multiple popular customization scenarios and gives you full control over the grid’s behavior and presentation.</p>
</asp:Content>
