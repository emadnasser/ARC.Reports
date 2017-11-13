<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Navigation_Overview" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    DevExpress Bootstrap Navigation for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Navigation
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <h2>Navigation Overview</h2>
    <p>The DevExpress Bootstrap Controls suite ships with a set of navigation tools that will help you build easy-to-navigate websites and web applications.</p>
    <div class="overview-panel">
        <div class="o-header">
            <dx:BootstrapMenu ID="Menu1" runat="server" ShowPopOutImages="true">
                <Items>
                    <dx:BootstrapMenuItem Text="Home">
                    </dx:BootstrapMenuItem>
                    <dx:BootstrapMenuItem Text="Products" Selected="true">
                    </dx:BootstrapMenuItem>
                    <dx:BootstrapMenuItem Text="Support">
                        <Items>
                            <dx:BootstrapMenuItem Text="Knowledge Base">
                            </dx:BootstrapMenuItem>
                            <dx:BootstrapMenuItem Text="Documentation">
                            </dx:BootstrapMenuItem>
                            <dx:BootstrapMenuItem Text="Support Center">
                            </dx:BootstrapMenuItem>
                            <dx:BootstrapMenuItem Text="Newsgroups">
                            </dx:BootstrapMenuItem>
                            <dx:BootstrapMenuItem Text="Best Practicies">
                            </dx:BootstrapMenuItem>
                        </Items>
                    </dx:BootstrapMenuItem>
                </Items>
            </dx:BootstrapMenu>
        </div>
        <div class="o-body clearfix">
            <div>
                <dx:BootstrapTreeView ID="TreeView1" runat="server">
                    <Nodes>
                        <dx:BootstrapTreeViewNode Text="ASP.NET Components" Expanded="true">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="Bootstrap">
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text="Classic WebForms">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                        <dx:BootstrapTreeViewNode Text="MVC Components">
                        </dx:BootstrapTreeViewNode>
                        <dx:BootstrapTreeViewNode Text="Subscriptions / Packs">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="Universal"></dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text="DXperience"></dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text="ASP.NET"></dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                    </Nodes>
                </dx:BootstrapTreeView>
            </div>
            <div class="container-fluid hidden-xs">
                <div class="row">
                    <div class="col-md-6 text-muted small">
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent at massa nec ex ornare tempor a vitae ligula. Proin eleifend dui vel magna dignissim, finibus efficitur purus varius. Sed quis diam eu lorem convallis accumsan molestie eget ante. Praesent tincidunt lectus sit amet libero ultrices imperdiet. Donec luctus molestie venenatis. Nam volutpat nisl leo, at facilisis dui feugiat at. Donec volutpat in ante at ullamcorper. Ut sollicitudin lobortis lorem id scelerisque. In vitae blandit mauris. Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                        <p>Fusce at augue viverra, interdum ligula non, venenatis neque. Nulla blandit et ligula ac feugiat. Suspendisse at nibh sagittis, egestas ex semper, vestibulum sapien. Sed dui metus, finibus ac cursus quis, feugiat et augue.</p>
                    </div>
                    <div class="col-md-6 text-muted small">
                        <p>Nunc eget nisi non purus aliquam interdum. Curabitur tellus elit, elementum id mi eget, porttitor ultrices odio. Suspendisse mi massa, dignissim malesuada libero a, ultrices scelerisque massa. Cras interdum commodo diam, sit amet tristique lacus. Aenean ante felis, vehicula eu placerat quis, aliquet at tortor. Nullam pretium purus dolor, vitae consectetur nibh consectetur ut. In quam erat, posuere vitae tortor at, gravida vestibulum mi.</p>
                        <p>Etiam scelerisque neque at lectus convallis, sed volutpat lorem vehicula. Aenean hendrerit lorem vel nulla lobortis, vel auctor dolor viverra. Nullam sed erat id ex dignissim vehicula vel id odio.</p>
                    </div>
                </div>
            </div>
        </div>
        <div class="o-footer clearfix">
            <dx:BootstrapPager ID="Pager1" runat="server" NumericButtonCount="5" ItemCount="100">
                <CssClasses PageNumber="hidden-xs" Ellipsis="hidden-xs" Control="pull-right" />
            </dx:BootstrapPager>
        </div>
    </div>
    <p>The following controls are included:</p>
    <ul>
        <li>The Ajax-enabled Menu, Accordion, and Tree View controls visualize the structure of your web application’s resources using hierarchical data presentation. These controls can function in a data-bound mode, in which they automatically retrieve their items from a hierarchical data source such as a <strong>SiteMapDataSource</strong> or <strong>XmlDataSource</strong>.</li>
        <li>The standalone Pager control provides a user interface that you can use to implement custom page navigation within your web application.</li>
        <li>The Popup Control is used to display overlapping temporary windows that appear separately from an application's main window, and are typically used to display quick reference information.</li>
    </ul>
</asp:Content>
