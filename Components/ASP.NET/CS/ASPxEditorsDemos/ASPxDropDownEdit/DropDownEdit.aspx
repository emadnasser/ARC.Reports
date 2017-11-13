<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DropDownEdit.aspx.cs"
    Inherits="ASPxDropDownEdit_DropDownEdit" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function ClearSelection() {
            TreeList.SetFocusedNodeKey("");
            UpdateControls(null, "");
        }
        function UpdateSelection() {
            var employeeName = "";
            var focusedNodeKey = TreeList.GetFocusedNodeKey();
            if (focusedNodeKey != "")
                employeeName = TreeList.cpEmployeeNames[focusedNodeKey];
            UpdateControls(focusedNodeKey, employeeName);
        }
        function UpdateControls(key, text) {
            DropDownEdit.SetText(text);
            DropDownEdit.SetKeyValue(key);
            DropDownEdit.HideDropDown();
            UpdateButtons();
        }
        function UpdateButtons() {
            clearButton.SetEnabled(DropDownEdit.GetText() != "");
            selectButton.SetEnabled(TreeList.GetFocusedNodeKey() != "");
        }
        function OnDropDown() {
            TreeList.SetFocusedNodeKey(DropDownEdit.GetKeyValue());
            TreeList.MakeNodeVisible(TreeList.GetFocusedNodeKey());
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxDropDownEdit ID="DropDownEdit" runat="server" ClientInstanceName="DropDownEdit"
        Width="170px" AllowUserInput="False" AnimationType="None">
        <DropDownWindowStyle>
            <Border BorderWidth="0px" />
        </DropDownWindowStyle>
        <ClientSideEvents Init="UpdateSelection" DropDown="OnDropDown" />
        <DropDownWindowTemplate>
            <div>
                <dx:ASPxTreeList ID="TreeList" ClientInstanceName="TreeList" runat="server"
                    Width="500px" DataSourceID="ods" OnCustomJSProperties="TreeList_CustomJSProperties"
                    KeyFieldName="ID" ParentFieldName="EmployerId">
                    <Settings VerticalScrollBarMode="Auto" ScrollableHeight="150" />
                    <ClientSideEvents FocusedNodeChanged="function(s,e){ selectButton.SetEnabled(true); }" />
                    <BorderBottom BorderStyle="Solid" />
                    <SettingsBehavior AllowFocusedNode="true" AutoExpandAllNodes="true" FocusNodeOnLoad="false" />
                    <SettingsPager Mode="ShowAllNodes">
                    </SettingsPager>
                    <Styles>
                        <Node Cursor="pointer">
                        </Node>
                        <Indent Cursor="default">
                        </Indent>
                    </Styles>
                    <Columns>
                        <dx:TreeListTextColumn FieldName="FirstName" VisibleIndex="1">
                        </dx:TreeListTextColumn>
                        <dx:TreeListTextColumn FieldName="LastName" VisibleIndex="2">
                        </dx:TreeListTextColumn>
                        <dx:TreeListDateTimeColumn FieldName="HireDate" VisibleIndex="3">
                        </dx:TreeListDateTimeColumn>
                    </Columns>
                </dx:ASPxTreeList>
            </div>
            <table style="background-color: White; width: 100%;">
                <tr>
                    <td style="padding: 10px;">
                        <dx:ASPxButton ID="clearButton" ClientEnabled="false" ClientInstanceName="clearButton"
                            runat="server" AutoPostBack="false" Text="Clear">
                            <ClientSideEvents Click="ClearSelection" />
                        </dx:ASPxButton>
                    </td>
                    <td style="text-align: right; padding: 10px;">
                        <dx:ASPxButton ID="selectButton" ClientEnabled="false" ClientInstanceName="selectButton"
                            runat="server" AutoPostBack="false" Text="Select">
                            <ClientSideEvents Click="UpdateSelection" />
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="closeButton" runat="server" AutoPostBack="false" Text="Close">
                            <ClientSideEvents Click="function(s,e) { DropDownEdit.HideDropDown(); }" />
                        </dx:ASPxButton>
                    </td>
                </tr>
            </table>
        </DropDownWindowTemplate>
    </dx:ASPxDropDownEdit>
    <asp:ObjectDataSource ID="ods" runat="server" DataObjectTypeName="EmployeeEntry"
        TypeName="EmployeeSessionProvider" SelectMethod="Select">
    </asp:ObjectDataSource>
</asp:Content>
