<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomizationWindow.aspx.cs"
    Inherits="Shaping_CustomizationWindow" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function CwShow() {
            treeList.ShowCustomizationWindow();
            btnCustWin.SetText("Hide Customization Window");
        }
        function CwHide() {
            treeList.HideCustomizationWindow();
            btnCustWin.SetText("Show Customization Window");
        }
        function CwToggle() {
            if(treeList.IsCustomizationWindowVisible())
                CwHide();
            else
                CwShow();
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Show Customization Window" AutoPostBack="False"
        ClientInstanceName="btnCustWin" EnableClientSideAPI="True" UseSubmitBehavior="False" CssClass="OptionsBottomMargin">
        <ClientSideEvents Click="function(s, e) { CwToggle(); }" />
    </dx:ASPxButton>
    <dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" DataSourceID="DepartmentsDataSource"
        Width="100%" KeyFieldName="ID" ParentFieldName="ParentID" ClientInstanceName="treeList">
        <Columns>
            <dx:TreeListDataColumn FieldName="DepartmentName" Caption="Department" VisibleIndex="0" />
            <dx:TreeListDataColumn DisplayFormat="{0:C}" FieldName="Budget" VisibleIndex="1" />
            <dx:TreeListDataColumn FieldName="Phone1" Visible="False" />
            <dx:TreeListDataColumn FieldName="Phone2" Visible="False" />
            <dx:TreeListDataColumn FieldName="Location" Visible="False" />
        </Columns>
        <Settings GridLines="Both" />
        <SettingsBehavior AutoExpandAllNodes="True" ExpandCollapseAction="NodeDblClick" />
        <SettingsCustomizationWindow Enabled="True" PopupHorizontalOffset="2" />
        <ClientSideEvents Init="function() { CwShow(); }" CustomizationWindowCloseUp="function() { CwHide(); }" />
    </dx:ASPxTreeList>
    <ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>
