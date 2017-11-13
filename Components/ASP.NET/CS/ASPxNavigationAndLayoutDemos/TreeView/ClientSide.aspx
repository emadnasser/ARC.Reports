<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ClientSide.aspx.cs" Inherits="TreeView_ClientSide" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function GetCurrentNode() {
            return treeView.GetNodeByName(ddNodes.GetKeyValue());
        }
        function ToggleEnabled() {
            GetCurrentNode().SetEnabled(chbEnabled.GetChecked());
        }
        function ToggleVisible() {
            GetCurrentNode().SetVisible(chbVisible.GetChecked());
        }
        function ToggleSelect() {
            var node = chbSelected.GetChecked() ? GetCurrentNode() : null;
            treeView.SetSelectedNode(node);
        }
        function ToggleCheck() {
            GetCurrentNode().SetChecked(chbChecked.GetChecked());
        }
        function ToggleExpand() {
            GetCurrentNode().SetExpanded(chbExpanded.GetChecked());
        }
        function OnExpandAllClick(s, e) {
            if(chbExpanded.GetEnabled())
                chbExpanded.SetChecked(true);
            treeView.ExpandAll();
        }
        function OnCollapseAllClick(s, e) {
            if (chbExpanded.GetEnabled())
                chbExpanded.SetChecked(false);
            treeView.CollapseAll();
        }
        function InitializePropertiesEditors() {
            var node = GetCurrentNode();
            chbVisible.SetChecked(node.GetVisible());
            chbEnabled.SetChecked(node.GetEnabled());
            chbSelected.SetChecked(treeView.GetSelectedNode() == node);
            chbChecked.SetChecked(node.GetChecked());
            chbExpanded.SetChecked(node.GetExpanded());
            chbExpanded.SetEnabled(node.GetNodeCount() > 0);
        }
        function OnTreeViewInit(s, e) {
            InitializePropertiesEditors();
        }
        function OnTreeViewNodeClick(s, e) {
            tvNodes.SetSelectedNode(tvNodes.GetNodeByName(e.node.name));
            ddNodes.SetKeyValue(e.node.name);
            ddNodes.SetText(e.node.GetText());
            InitializePropertiesEditors();
        }
        function OnTreeViewCheckedChanged(s, e) {
            InitializePropertiesEditors();
        }
        function OnTreeViewExpandedChanged(s, e) {
            InitializePropertiesEditors();
        }
        function OnNodesTreeViewNodeClick(s, e) {
            ddNodes.SetKeyValue(e.node.name);
            ddNodes.SetText(e.node.GetText());
            ddNodes.HideDropDown();
            InitializePropertiesEditors();
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 45%; margin-right: 2%">
        <dx:ASPxTreeView ID="treeView" runat="server" DataSourceID="XmlDataSource1" ClientInstanceName="treeView"
            AllowSelectNode="true" AllowCheckNodes="true" CheckNodesRecursive="true">
            <ClientSideEvents NodeClick="OnTreeViewNodeClick" CheckedChanged="OnTreeViewCheckedChanged"
                ExpandedChanged="OnTreeViewExpandedChanged" Init="OnTreeViewInit" />
        </dx:ASPxTreeView>
    </div>
    <div style="float: left;">
        <table class="OptionsTable">
            <tr>
                <td>
                    <dx:ASPxLabel runat="server" Text="Choose node:" EnableViewState="False" ID="lblNodes"
                        AssociatedControlID="ddNodes" />
                </td>
                <td>
                    <dx:ASPxDropDownEdit ID="ddNodes" runat="server" ClientInstanceName="ddNodes" AllowUserInput="false" Width="200px">
                        <DropDownWindowTemplate>
                            <dx:ASPxTreeView ID="tvNodes" runat="server" ClientInstanceName="tvNodes" DataSourceID="XmlDataSource1"
                                AllowSelectNode="true" ShowExpandButtons="false">
                                <ClientSideEvents NodeClick="OnNodesTreeViewNodeClick" />
                            </dx:ASPxTreeView>
                        </DropDownWindowTemplate>
                    </dx:ASPxDropDownEdit>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <dx:ASPxCheckBox runat="server" ID="chbEnabled" Checked="true" Text="Enabled" ClientInstanceName="chbEnabled">
                        <ClientSideEvents CheckedChanged="function(s, e) { ToggleEnabled(); }"></ClientSideEvents>
                    </dx:ASPxCheckBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <dx:ASPxCheckBox runat="server" ID="chbVisible" Checked="true" Text="Visible" ClientInstanceName="chbVisible">
                        <ClientSideEvents CheckedChanged="function(s, e) { ToggleVisible(); }"></ClientSideEvents>
                    </dx:ASPxCheckBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <dx:ASPxCheckBox runat="server" ID="chbSelected" Checked="true" Text="Selected" ClientInstanceName="chbSelected">
                        <ClientSideEvents CheckedChanged="function(s, e) { ToggleSelect(); }"></ClientSideEvents>
                    </dx:ASPxCheckBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <dx:ASPxCheckBox runat="server" ID="chbChecked" Checked="true" Text="Checked" ClientInstanceName="chbChecked">
                        <ClientSideEvents CheckedChanged="function(s, e) { ToggleCheck(); }"></ClientSideEvents>
                    </dx:ASPxCheckBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <dx:ASPxCheckBox runat="server" ID="chbExpanded" Checked="true" Text="Expanded" ClientInstanceName="chbExpanded">
                        <ClientSideEvents CheckedChanged="function(s, e) { ToggleExpand(); }"></ClientSideEvents>
                    </dx:ASPxCheckBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="padding-top:16px">
                    <table class="OptionsTable">
                        <tr>
                            <td>
                                <dx:ASPxButton ID="btnExpandAll" runat="server" Text="Expand all" AutoPostBack="false"
                                    EnableViewState="false">
                                    <ClientSideEvents Click="OnExpandAllClick" />
                                </dx:ASPxButton>
                            </td>
                            <td>
                                <dx:ASPxButton ID="btnCollapseAll" runat="server" Text="Collapse all" AutoPostBack="false"
                                    EnableViewState="false">
                                    <ClientSideEvents Click="OnCollapseAllClick" />
                                </dx:ASPxButton>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/TreeView/ChemicalElements.xml">
    </asp:XmlDataSource>
</asp:Content>
