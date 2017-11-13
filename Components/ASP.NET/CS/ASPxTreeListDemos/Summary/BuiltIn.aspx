<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BuiltIn.aspx.cs"
    Inherits="Summary_BuiltIn" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" DataSourceID="DepartmentsDataSource"
        Width="100%" KeyFieldName="ID" ParentFieldName="ParentID">
        <Summary>
            <dx:TreeListSummaryItem FieldName="DepartmentName" ShowInColumn="DepartmentName" SummaryType="Count" />
            <dx:TreeListSummaryItem DisplayFormat="Max={0:C}" FieldName="Budget" ShowInColumn="Budget"
                SummaryType="Max" />
            <dx:TreeListSummaryItem SummaryType="Sum" FieldName="Budget" ShowInColumn="Budget"
                DisplayFormat="Sum={0:C}" />
        </Summary>
        <Columns>
            <dx:TreeListDataColumn FieldName="DepartmentName" VisibleIndex="0" Caption="Department" />
            <dx:TreeListDataColumn FieldName="Location" VisibleIndex="1" />
            <dx:TreeListDataColumn FieldName="Budget" VisibleIndex="2" DisplayFormat="{0:C}" />
        </Columns>
        <Settings ShowGroupFooter="True" ShowFooter="True" GridLines="Both" />
        <SettingsBehavior ExpandCollapseAction="NodeDblClick" />
    </dx:ASPxTreeList>
    <ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>
