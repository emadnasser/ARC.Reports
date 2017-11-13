<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="GridLinesTreeLines.aspx.cs"
    Inherits="Appearance_GridLines" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .infoPanel 
        {
            color: Black;
            background: #fffbba;
            margin: 10px 0 5px;
            padding: 10px;
            border: 1px solid #bbb;
        }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable">
        <tr>
            <td>
                <dx:ASPxComboBox ID="cmbGridLines" runat="server" AutoPostBack="True" SelectedIndex="0"
                    ValueType="System.String" Caption="Grid lines">
                    <Items>
                        <dx:ListEditItem Text="None" Value="0" />
                        <dx:ListEditItem Text="Horizontal" Value="1" />
                        <dx:ListEditItem Text="Vertical" Value="2" />
                        <dx:ListEditItem Text="Both" Value="3" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
            <td>
                <dx:ASPxCheckBox ID="chkTreeLines" runat="server" AutoPostBack="true" Text="Show tree lines" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="chkBorder" runat="server" AutoPostBack="true" Text="Show control's border" />
            </td>
        </tr>
    </table>
    <div id="infoPanel" runat="server" class="infoPanel">
        By design, the <b>DevExpress</b>, <b>Moderno</b>, <b>Metropolis</b> and <b>Office 2010</b> themes do not display tree lines and grid lines within the ASPxTreeList.
        Switch to a different theme to view and manipulate tree and grid line settings in this demo.
    </div>
    <br />
    <dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" DataSourceID="DepartmentsDataSource"
        Width="100%" KeyFieldName="ID" ParentFieldName="ParentID">
        <Columns>
            <dx:TreeListDataColumn FieldName="DepartmentName" Caption="Department" VisibleIndex="0" />
            <dx:TreeListDataColumn FieldName="Location" VisibleIndex="1" />
            <dx:TreeListDataColumn FieldName="Phone1" VisibleIndex="2" Caption="Phone" />
        </Columns>
        <SettingsBehavior AutoExpandAllNodes="True" ExpandCollapseAction="NodeDblClick" />
    </dx:ASPxTreeList>
    <ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>
