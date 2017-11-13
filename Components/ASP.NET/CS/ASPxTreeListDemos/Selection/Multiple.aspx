<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Multiple.aspx.cs"
    Inherits="Selection_Multiple" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function treeList_CustomDataCallback(s, e) { 
            document.getElementById('treeListCountCell').innerHTML = e.result;
        }
        function treeList_SelectionChanged(s, e) { 
            window.setTimeout(function() { s.PerformCustomDataCallback(''); }, 0)
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable OptionsBottomMargin" style="width: 100%">
        <tr>
            <td>
                <dx:ASPxCheckBox ID="chkRecursive" runat="server" Text="Recursive" AutoPostBack="true"
                    Wrap="False" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="chkAllowAll" runat="server" Text="Show 'Select All' check box"
                    AutoPostBack="true" Wrap="False" />
            </td>
            <td style="width: 100%">
            </td>
            <td>
                <dx:ASPxComboBox ID="cmbMode" runat="server" AutoPostBack="true" SelectedIndex="0"
                    OnSelectedIndexChanged="cmbMode_SelectedIndexChanged" Caption="Allow select">
                    <Items>
                        <dx:ListEditItem Value="All nodes" />
                        <dx:ListEditItem Value="Child nodes" />
                        <dx:ListEditItem Value="Parent nodes" />
                        <dx:ListEditItem Value="Level > 2" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
    </table>
    <dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" DataSourceID="DepartmentsDataSource"
        Width="100%" KeyFieldName="ID" ParentFieldName="ParentID" OnCustomDataCallback="treeList_CustomDataCallback"
        OnDataBound="treeList_DataBound">
        <Columns>
            <dx:TreeListDataColumn FieldName="DepartmentName" Caption="Department"  VisibleIndex="0" />
            <dx:TreeListDataColumn FieldName="Budget" VisibleIndex="1" DisplayFormat="{0:C}" />
            <dx:TreeListDataColumn FieldName="Location" VisibleIndex="2" />
        </Columns>
        <SettingsBehavior ExpandCollapseAction="NodeDblClick" />
        <SettingsSelection Enabled="True" />
        <ClientSideEvents SelectionChanged="treeList_SelectionChanged" CustomDataCallback="treeList_CustomDataCallback" />
    </dx:ASPxTreeList>
    <br />
    <table class="OptionsTable">
        <tr>
            <td>
                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Selected node count:" />
            </td>
            <td id="treeListCountCell">
                <asp:Literal ID="countLiteral" runat="server" />
            </td>
        </tr>
    </table>
    <ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>
