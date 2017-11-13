<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSideAPI.aspx.cs"
    Inherits="NavBar_ClientSideAPI" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function GetNavBarGroup() {
            return NavBar.GetGroupByName(cbGroups.GetValue());
        }
        function GetNavBarItem() {
            return NavBar.GetItemByName(cbItems.GetValue());
        }
        function ToggleItemEnabled() {
            var item = GetNavBarItem();
            item.SetEnabled(chbItemEnabled.GetChecked());
            ShowProperties();
        }
        function ToggleItemVisible() {
            var item = GetNavBarItem();
            item.SetVisible(chbItemVisible.GetChecked());
            ShowProperties();
        }
        function ToggleItemSelected() {
            var item = GetNavBarItem();
            if (!item.GetVisible())
                chbItemSelected.SetChecked(false);
            else {
                NavBar.SetSelectedItem(chbItemSelected.GetChecked() ? GetNavBarItem() : null);
                ShowProperties();
            }
        }
        function ToggleGroupVisible() {
            GetNavBarGroup().SetVisible(chbGroupVisible.GetChecked());
        }
        function ToggleGroupExpanded() {
            GetNavBarGroup().SetExpanded(chbGroupExpanded.GetChecked());
        }
        function ChangeActiveGroup() {
            UpdateItemsCombo(GetNavBarGroup().name);
            ShowProperties();
        }
        function ChangeSelectedItem() {
            ShowProperties();
        }
        function GroupExpandedChanged(e) {
            if (e.group.GetExpanded())
                UpdateItemsCombo(e.group.name);
            else
                ShowProperties();
        }
        function GroupExpandedChanging(e) {
            if (!e.group.GetExpanded())
                NavBar.CollapseAll();
        }
        function SelectedItemChanged(e) {
            cbItems.SetValue(e.item.name);
            ShowProperties();
        }
        function UpdateItemsCombo(groupName) {
            cbGroups.SetValue(groupName);
            cbItems.ClearItems();
            var group = GetNavBarGroup();
            for (var i = 0; i < group.GetItemCount(); i++) {
                var item = group.GetItem(i);
                cbItems.AddItem(ASPxClientUtils.Trim(item.name), ASPxClientUtils.Trim(item.name));
            }
            cbItems.SetSelectedIndex(0);
            ShowProperties();
        }
        function ShowProperties() {
            chbGroupVisible.SetChecked(!GetNavBarGroup() ? false : GetNavBarGroup().GetVisible());
            chbGroupExpanded.SetChecked(!GetNavBarGroup() ? false : GetNavBarGroup().GetExpanded());
            chbItemEnabled.SetChecked(!GetNavBarItem() ? false : GetNavBarItem().GetEnabled());
            chbItemVisible.SetChecked(!GetNavBarItem() ? false : GetNavBarItem().GetVisible());
            chbItemSelected.SetChecked(GetNavBarItem() && GetNavBarItem() == NavBar.GetSelectedItem() ? true : false);
        }
        function ControlsInitialized() {
            UpdateItemsCombo(cbGroups.GetValue());
            ShowProperties();
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 20%; margin-right: 2%; min-height: 280px; padding-bottom:10xp;">
        <dx:ASPxNavBar ClientInstanceName="NavBar" ID="NavBar" runat="server" Width="100%"
            AllowSelectItem="True" EnableViewState="False">
            <GroupHeaderStyle HorizontalAlign="Left" />
            <ItemStyle HorizontalAlign="Left" />
            <ClientSideEvents ItemClick="function(s, e) { SelectedItemChanged(e); }" ExpandedChanged="function(s, e) { GroupExpandedChanged(e); }"
                ExpandedChanging="function(s, e) { GroupExpandedChanging(e); }" />
            <Groups>
                <dx:NavBarGroup Name="platform" Text="Platform">
                    <Items>
                        <dx:NavBarItem Name="Windows" Text="Windows">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="Linux" Text="Linux">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="Mac OS" Text="Mac OS">
                        </dx:NavBarItem>
                    </Items>
                </dx:NavBarGroup>
                <dx:NavBarGroup Expanded="False" Name="sql" Text="SQL Server">
                    <Items>
                        <dx:NavBarItem Name="MSSQL Server" Text="MSSQL Server">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="Oracle" Text="Oracle">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="InterBase" Text="InterBase">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="MySql" Text="MySql">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="DB2" Text="DB2">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="Sybase" Text="Sybase">
                        </dx:NavBarItem>
                    </Items>
                </dx:NavBarGroup>
                <dx:NavBarGroup Name="browser" Text="Browser" Expanded="False">
                    <Items>
                        <dx:NavBarItem Name="Internet Explorer" Text="Internet Explorer">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="Firefox" Text="Firefox">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="Opera" Text="Opera">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="Safari" Text="Safari">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="Netscape" Text="Netscape">
                        </dx:NavBarItem>
                    </Items>
                </dx:NavBarGroup>
                <dx:NavBarGroup Expanded="False" Name="language" Text="Language">
                    <Items>
                        <dx:NavBarItem Name="C#" Text="C#">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="Visual Basic" Text="Visual Basic">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="Object Pascal" Text="Object Pascal">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="J#" Text="J#">
                        </dx:NavBarItem>
                        <dx:NavBarItem Name="C++" Text="C++">
                        </dx:NavBarItem>
                    </Items>
                </dx:NavBarGroup>
            </Groups>
        </dx:ASPxNavBar>
    </div>
    <div style="float: left">
        <table class="OptionsTable">
            <tr>
                <td colspan="2">
                    <dx:ASPxCheckBox ID="chbClientVisible" runat="server" Checked="true" Text="Client Visible"
                        ClientInstanceName="chbClientVisible">
                        <ClientSideEvents CheckedChanged="function(s, e) { NavBar.SetVisible(chbClientVisible.GetChecked()) }">
                        </ClientSideEvents>
                    </dx:ASPxCheckBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel runat="server" Text="Choose group:" ID="lblGroups"
                        AssociatedControlID="cbGroups">
                    </dx:ASPxLabel>
                </td>
                <td>
                    <dx:ASPxComboBox runat="server" EnableViewState="False" Width="135px" ValueType="System.String"
                        ID="cbGroups" ClientInstanceName="cbGroups">
                        <ClientSideEvents SelectedIndexChanged="function(s, e) { ChangeActiveGroup(); }">
                        </ClientSideEvents>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <dx:ASPxCheckBox runat="server" Text="Visible" ID="chbGroupVisible" ClientInstanceName="chbGroupVisible">
                        <ClientSideEvents CheckedChanged="function(s, e) { ToggleGroupVisible(); }"></ClientSideEvents>
                    </dx:ASPxCheckBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <dx:ASPxCheckBox runat="server" Text="Expanded" ID="chbGroupExpanded" ClientInstanceName="chbGroupExpanded">
                        <ClientSideEvents CheckedChanged="function(s, e) { ToggleGroupExpanded(); }"></ClientSideEvents>
                    </dx:ASPxCheckBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel runat="server" Text="Choose item:" ID="lblItems"
                        AssociatedControlID="cbItems">
                    </dx:ASPxLabel>
                </td>
                <td>
                    <dx:ASPxComboBox runat="server" EnableViewState="False" Width="135px" ValueType="System.String"
                        ID="cbItems" SelectedIndex="0" ClientInstanceName="cbItems">
                        <ClientSideEvents SelectedIndexChanged="function(s, e) { ChangeSelectedItem(); }">
                        </ClientSideEvents>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <dx:ASPxCheckBox runat="server" Text="Enabled" ID="chbItemEnabled" ClientInstanceName="chbItemEnabled">
                        <ClientSideEvents CheckedChanged="function(s, e) { ToggleItemEnabled(); }"></ClientSideEvents>
                    </dx:ASPxCheckBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <dx:ASPxCheckBox runat="server" Text="Visible" ID="chbItemVisible" ClientInstanceName="chbItemVisible">
                        <ClientSideEvents CheckedChanged="function(s, e) { ToggleItemVisible(); }"></ClientSideEvents>
                    </dx:ASPxCheckBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <dx:ASPxCheckBox runat="server" Text="Select" ID="chbItemSelected" ClientInstanceName="chbItemSelected">
                        <ClientSideEvents CheckedChanged="function(s, e) { ToggleItemSelected(); }"></ClientSideEvents>
                    </dx:ASPxCheckBox>
                </td>
            </tr>
        </table>
    </div>
    <dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
        <ClientSideEvents ControlsInitialized="function(s, e) { ControlsInitialized(); }">
        </ClientSideEvents>
    </dx:ASPxGlobalEvents>
</asp:Content>
