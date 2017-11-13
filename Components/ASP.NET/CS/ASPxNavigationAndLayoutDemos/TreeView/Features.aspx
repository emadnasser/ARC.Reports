<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Features.aspx.cs" Inherits="TreeView_Features" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 40%; margin-right: 2%; min-height:100px;">
        <dx:ASPxTreeView ID="treeView" runat="server" AllowSelectNode="true" AllowCheckNodes="true">
            <Nodes>
                <dx:TreeViewNode Text="Home">
                    <Nodes>
                        <dx:TreeViewNode Text="News">
                            <Nodes>
                                <dx:TreeViewNode Text="For Developers">
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Text="Website news">
                                </dx:TreeViewNode>
                            </Nodes>
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Our Mission">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Our Customers">
                        </dx:TreeViewNode>
                    </Nodes>
                </dx:TreeViewNode>
                <dx:TreeViewNode Text="Products">
                    <Nodes>
                        <dx:TreeViewNode Text="Subscriptions / Packs">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text=".NET Windows Forms Components">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Reporting / Printing Suites">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="VCL Components and Tools">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="ASP.NET Components">
                        </dx:TreeViewNode>
                    </Nodes>
                </dx:TreeViewNode>
                <dx:TreeViewNode Text="Support">
                    <Nodes>
                        <dx:TreeViewNode Text="Knowledge Base">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Documentation">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Support Center">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Newsgroups">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Best Practicies">
                        </dx:TreeViewNode>
                    </Nodes>
                </dx:TreeViewNode>
            </Nodes>
        </dx:ASPxTreeView>
    </div>
    <div style="float: left">
        <table class="OptionsTable">
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAllowSelectNode" runat="server" AutoPostBack="True" CssClass="DemoCheckBox"
                        Checked="True" Text="AllowSelectNode" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAutoPostBack" runat="server" AutoPostBack="True" CssClass="DemoCheckBox"
                       Text="AutoPostBack" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbEnableAnimation" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="EnableAnimation" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbEnableHotTrack" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="EnableHotTrack" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbShowTreeLines" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="ShowTreeLines" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbShowExpandButtons" runat="server" AutoPostBack="True"
                        Checked="True" CssClass="DemoCheckBox" Text="ShowExpandButtons" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAllowCheckNodes" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="AllowCheckNodes" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbCheckNodesRecursive" runat="server" AutoPostBack="True" CssClass="DemoCheckBox"
                        Text="CheckNodesRecursive" OnCheckedChanged="CheckNodesRecursiveChanged" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
