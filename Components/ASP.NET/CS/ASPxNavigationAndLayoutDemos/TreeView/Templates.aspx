<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Templates.aspx.cs" Inherits="TreeView_Templates" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .node
        {
            border-collapse: separate;
            border-spacing: 4px;
            font: 14px Verdana !important;
        }
        .node td
        {
            vertical-align: middle;
        }
        .controlLink
        {
            color: #0C3C8C !important;
            font: 11px Verdana !important;
            text-decoration: none;
            display: block;
        }
        .controlDesc
        {
            color: #494B50;
            font-family: Verdana;
            font-size: 11px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxTreeView ID="treeView" runat="server" EnableHotTrack="False" Width="400px">
        <Nodes>
            <dx:TreeViewNode Text="ASP.NET AJAX Controls">
                <TextTemplate>
                    <table class="node">
                        <tr>
                            <td>
                                <img src="Images/Controls/asp.png" alt="ASP" />
                            </td>
                            <td>
                                <%# Eval("Text")%>
                            </td>
                        </tr>
                    </table>
                </TextTemplate>
                <Nodes>
                    <dx:TreeViewNode Text="HTML Editor for ASP.NET" Name="ASPxHTMLEditor™ Suite">
                        <Template>
                            <table class="node">
                                <tr>
                                    <td>
                                        <img src="Images/Controls/ASPxHtmlEditor.png" alt="ASPxHtmlEditor" />
                                    </td>
                                    <td>
                                        <a href="javascript:void(0);" class="controlLink">
                                            <%# Eval("Text") %>
                                        </a><span class="controlDesc">
                                            <%# Eval("Name") %>
                                        </span>
                                    </td>
                                </tr>
                            </table>
                        </Template>
                    </dx:TreeViewNode>
                    <dx:TreeViewNode Text="Menu for ASP.NET" Name="ASPxMenu™">
                        <Template>
                            <table class="node">
                                <tr>
                                    <td>
                                        <img src="Images/Controls/ASPxMenu.png" alt="ASPxMenu" />
                                    </td>
                                    <td>
                                        <a href="javascript:void(0);" class="controlLink">
                                            <%# Eval("Text") %>
                                        </a><span class="controlDesc">
                                            <%# Eval("Name") %>
                                        </span>
                                    </td>
                                </tr>
                            </table>
                        </Template>
                    </dx:TreeViewNode>
                    <dx:TreeViewNode Text="Data Editors for ASP.NET" Name="ASPxEditors™ Library">
                        <Template>
                            <table class="node">
                                <tr>
                                    <td>
                                        <img src="Images/Controls/ASPxEditors.png" alt="ASPxEditors" />
                                    </td>
                                    <td>
                                        <a href="javascript:void(0);" class="controlLink">
                                            <%# Eval("Text") %>
                                        </a><span class="controlDesc">
                                            <%# Eval("Name") %>
                                        </span>
                                    </td>
                                </tr>
                            </table>
                        </Template>
                    </dx:TreeViewNode>
                </Nodes>
            </dx:TreeViewNode>
            <dx:TreeViewNode Text="WinForms Controls">
                <TextTemplate>
                    <table class="node">
                        <tr>
                            <td>
                                <img src="Images/Controls/win.png" alt="Win" />
                            </td>
                            <td>
                                <%# Eval("Text")%>
                            </td>
                        </tr>
                    </table>
                </TextTemplate>
                <Nodes>
                    <dx:TreeViewNode Text="Grid and Data Editors for WinForms" Name="XtraGrid™ Suite">
                        <Template>
                            <table class="node">
                                <tr>
                                    <td>
                                        <img src="Images/Controls/XtraGrid.png" alt="XtraGrid" />
                                    </td>
                                    <td>
                                        <a href="javascript:void(0);" class="controlLink">
                                            <%# Eval("Text") %>
                                        </a><span class="controlDesc">
                                            <%# Eval("Name") %>
                                        </span>
                                    </td>
                                </tr>
                            </table>
                        </Template>
                    </dx:TreeViewNode>
                    <dx:TreeViewNode Text="OLAP Data Mining Control for WinForms" Name="XtraPivotGrid™ Suite">
                        <Template>
                            <table class="node">
                                <tr>
                                    <td>
                                        <img src="Images/Controls/XtraPivotGrid.png" alt="XtraPivotGrid" />
                                    </td>
                                    <td>
                                        <a href="javascript:void(0);" class="controlLink">
                                            <%# Eval("Text") %>
                                        </a><span class="controlDesc">
                                            <%# Eval("Name") %>
                                        </span>
                                    </td>
                                </tr>
                            </table>
                        </Template>
                    </dx:TreeViewNode>
                    <dx:TreeViewNode Text="TreeView-Grid Hybrid for WinForms" Name="XtraTreeList™ Suite">
                        <Template>
                            <table class="node">
                                <tr>
                                    <td>
                                        <img src="Images/Controls/XtraTreeList.png" alt="XtraTreeList" />
                                    </td>
                                    <td>
                                        <a href="javascript:void(0);" class="controlLink">
                                            <%# Eval("Text") %>
                                        </a><span class="controlDesc">
                                            <%# Eval("Name") %>
                                        </span>
                                    </td>
                                </tr>
                            </table>
                        </Template>
                    </dx:TreeViewNode>
                </Nodes>
            </dx:TreeViewNode>
        </Nodes>
        <Styles>
            <Link HoverFont-Underline="true">
            </Link>
        </Styles>
    </dx:ASPxTreeView>
</asp:Content>
