<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EnableCallBacks.aspx.cs"
    Inherits="NavBar_EnableCallBacks" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function NBChangeExpanded(expand) {
            if (expand)
                ASPxNavBarClientControl.ExpandAll();
            else
                ASPxNavBarClientControl.CollapseAll();
        }
        function GetNavBar() {
            return ASPxNavBarClientControl;
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxPopupMenu ID="ASPxPopupMenu1" runat="server" PopupElementID="ASPxNavBar1">
        <ClientSideEvents ItemClick="function(s, e) { NBChangeExpanded(e.item.name == 'expand'); }">
        </ClientSideEvents>
        <Items>
            <dx:MenuItem Text="Expand All" Name="expand">
            </dx:MenuItem>
            <dx:MenuItem BeginGroup="True" Text="Collapse All" Name="collapse">
            </dx:MenuItem>
        </Items>
    </dx:ASPxPopupMenu>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Charts.xml"
        XPath="//Chart" />
    <dx:ASPxNavBar Width="560px" ClientInstanceName="ASPxNavBarClientControl" ID="ASPxNavBar1"
        runat="server" DataSourceID="XmlDataSource1" EnableClientSideAPI="True" EnableCallBacks="True"
        EnableAnimation="True" OnGroupDataBound="ASPxNavBar1_GroupDataBound">
        <GroupContentTemplate>
            <table>
                <tr>
                    <td>
                        <dx:ASPxImage ID="Image1" runat="server" ImageUrl='<%# Container.EvalDataItem("BigImageUrl") %>'
                            AlternateText='<%# Container.EvalDataItem("View") %>' />
                    </td>
                    <td style="vertical-align:top; padding: 2px 8px; color: #707070;">
                        <dx:ASPxLabel ID="Label2" runat="server" Text='<%# Container.EvalDataItem("Description") %>' />
                    </td>
                </tr>
            </table>
        </GroupContentTemplate>
    </dx:ASPxNavBar>
    <p class="Note">
        <strong>Note</strong>: The sample pictures which are used in this demo were created with our
        <a href="http://www.devexpress.com/Products/NET/WinForms/XtraCharts/" target="_blank">
            XtraCharts</a> suite.
    </p>
</asp:Content>
