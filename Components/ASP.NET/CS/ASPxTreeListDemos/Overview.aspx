<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Overview.aspx.cs" Inherits="Overview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    <dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False"
        DataSourceID="DepartmentsDataSource" Width="100%"
        KeyFieldName="ID" ParentFieldName="ParentID">
        <Columns>
            <dx:TreeListDataColumn FieldName="DepartmentName" Caption="Department" />
            <dx:TreeListDataColumn FieldName="Budget" DisplayFormat="{0:C}" />
            <dx:TreeListDataColumn FieldName="Location" />
        </Columns>
        <SettingsBehavior ExpandCollapseAction="NodeDblClick" />
        <Settings ScrollableHeight="250" VerticalScrollBarMode="Auto" />
    </dx:ASPxTreeList>
    <ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>
