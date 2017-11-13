<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="TreeView.aspx.cs" Inherits="Navigation_TreeView" MaintainScrollPositionOnPostback="true" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap TreeView Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap TreeView
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-9">
        <demo:DemoItem runat="server" Title="Default TreeView">
            <Description>
                <p>The TreeView is a control used to display hierarchical data in tree-like form. Each TreeView node is represented by a <strong>BootstrapTreeViewNode</strong> object and provides access to a collection of its sub-nodes through the <strong>Nodes</strong> collection property.</p>
            </Description>
            <Example>
                <dx:BootstrapTreeView ID="TreeView1" runat="server">
                    <CssClasses Control="ctrl-fixed-width-lg" />
                    <Nodes>
                        <dx:BootstrapTreeViewNode Text="Home" Expanded="true">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="News">
                                    <Nodes>
                                        <dx:BootstrapTreeViewNode Text="For Developers">
                                        </dx:BootstrapTreeViewNode>
                                        <dx:BootstrapTreeViewNode Text="Website news">
                                        </dx:BootstrapTreeViewNode>
                                    </Nodes>
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text="Our Mission">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                        <dx:BootstrapTreeViewNode Text="Products">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="Subscriptions / Packs">
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text=".NET Windows Forms Components">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                        <dx:BootstrapTreeViewNode Text="Support">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="Knowledge Base">
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text="Documentation">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                    </Nodes>
                </dx:BootstrapTreeView>
            </Example>
            <CodeASPX>&lt;dx:BootstrapTreeView ID="TreeView1" runat="server"&gt;
    &lt;Nodes&gt;
        &lt;dx:BootstrapTreeViewNode Text="Home" Expanded="true"&gt;
            &lt;Nodes&gt;
                &lt;dx:BootstrapTreeViewNode Text="News"&gt;
                    &lt;Nodes&gt;
                        &lt;dx:BootstrapTreeViewNode Text="For Developers"/&gt;
                        &lt;dx:BootstrapTreeViewNode Text="Website news"/&gt;
                    &lt;/Nodes&gt;
                &lt;/dx:BootstrapTreeViewNode&gt;
                &lt;dx:BootstrapTreeViewNode Text="Our Mission"/&gt;
            &lt;/Nodes&gt;
        &lt;/dx:BootstrapTreeViewNode&gt;
        &lt;dx:BootstrapTreeViewNode Text="Products"&gt;
            &lt;Nodes&gt;
                &lt;dx:BootstrapTreeViewNode Text="Subscriptions / Packs"/&gt;
                &lt;dx:BootstrapTreeViewNode Text=".NET Windows Forms Components"/&gt;
            &lt;/Nodes&gt;
        &lt;/dx:BootstrapTreeViewNode&gt;
        ...
    &lt;/Nodes&gt;
&lt;/dx:BootstrapTreeView&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Nodes Selection">
            <Description>
                <p>The TreeView control supports selection of nodes with a mouse click. To allow node selection, set the control’s <strong>AllowSelectNodes</strong> property to <strong>true</strong>. Note that only one node can be selected at a time.</p>
            </Description>
            <Example>
                <dx:BootstrapTreeView ID="TreeView2" runat="server" AllowSelectNode="true">
                    <CssClasses Control="ctrl-fixed-width-lg" />
                    <Nodes>
                        <dx:BootstrapTreeViewNode Text="Home" Expanded="true">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="News">
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text="Our Mission">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                        <dx:BootstrapTreeViewNode Text="Products" Expanded="true">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="Subscriptions / Packs">
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text=".NET Windows Forms Components">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                    </Nodes>
                </dx:BootstrapTreeView>
            </Example>
            <CodeASPX>&lt;dx:BootstrapTreeView ID="TreeView2" runat="server" AllowSelectNode="true"&gt;
    &lt;Nodes&gt;
        ...
    &lt;/Nodes&gt;
&lt;/dx:BootstrapTreeView></CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Load nodes on callbacks">
            <Description>
                <p>
                    The Tree View control can obtain its node from the server as needed using callbacks. When this mode is activated, the contents of collapsed nodes are not present on the client until these nodes are expanded. To specify whether to use the callback technology to transfer node data to from server, use the <strong>EnableCallBacks</strong> property.
                </p>
            </Description>
            <Example>
                <dx:BootstrapTreeView ID="TreeView3" runat="server" EnableCallBacks="true">
                    <CssClasses Control="ctrl-fixed-width-lg" />
                    <Nodes>
                        <dx:BootstrapTreeViewNode Text="Home">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="News">
                                    <Nodes>
                                        <dx:BootstrapTreeViewNode Text="For Developers">
                                        </dx:BootstrapTreeViewNode>
                                        <dx:BootstrapTreeViewNode Text="Website news">
                                        </dx:BootstrapTreeViewNode>
                                    </Nodes>
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text="Our Mission">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                        <dx:BootstrapTreeViewNode Text="Products">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="Subscriptions / Packs">
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text=".NET Windows Forms Components">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                    </Nodes>
                </dx:BootstrapTreeView>
            </Example>
            <CodeASPX>&lt;dx:BootstrapTreeView ID="TreeView3" runat="server" EnableCallBacks="true"&gt;
    &lt;Nodes&gt;
        ...
    &lt;/Nodes&gt;
&lt;/dx:BootstrapTreeView&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Hide Expand Buttons">
            <Description>
                <p>You can control whether to display the Tree View’s <strong>Hide (-)</strong> and <strong>Expand (+)</strong> buttons using the <strong>ShowExpandButtons</strong> property.</p>
            </Description>
            <Example>
                <dx:BootstrapTreeView ID="TreeView4" runat="server" ShowExpandButtons="false">
                    <CssClasses Control="ctrl-fixed-width-lg" />
                    <Nodes>
                        <dx:BootstrapTreeViewNode Text="Home" Expanded="true">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="News" Expanded="true">
                                    <Nodes>
                                        <dx:BootstrapTreeViewNode Text="For Developers">
                                        </dx:BootstrapTreeViewNode>
                                        <dx:BootstrapTreeViewNode Text="Website news">
                                        </dx:BootstrapTreeViewNode>
                                    </Nodes>
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text="Our Mission">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                        <dx:BootstrapTreeViewNode Text="Products" Expanded="true">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="Subscriptions / Packs">
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text=".NET Windows Forms Components">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                    </Nodes>
                </dx:BootstrapTreeView>
            </Example>
            <CodeASPX>&lt;dx:BootstrapTreeView ID="TreeView4" runat="server" ShowExpandButtons="false"&gt;
    &lt;Nodes&gt;
        ...
    &lt;/Nodes&gt;
&lt;/dx:BootstrapTreeView&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Auto PostBack">
            <Description>
                <p>The Auto Postback feature allows the Tree View control to automatically initiate a postback to the server when a node has been clicked, expanded, or collapsed.</p>
            </Description>
            <Example>
                <dx:BootstrapTreeView ID="TreeView5" runat="server" AutoPostBack="true">
                    <CssClasses Control="ctrl-fixed-width-lg" />
                    <Nodes>
                        <dx:BootstrapTreeViewNode Text="Home" Expanded="true">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="News">
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text="Our Mission">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                        <dx:BootstrapTreeViewNode Text="Products" Expanded="true">
                            <Nodes>
                                <dx:BootstrapTreeViewNode Text="Subscriptions / Packs">
                                </dx:BootstrapTreeViewNode>
                                <dx:BootstrapTreeViewNode Text=".NET Windows Forms Components">
                                </dx:BootstrapTreeViewNode>
                            </Nodes>
                        </dx:BootstrapTreeViewNode>
                    </Nodes>
                </dx:BootstrapTreeView>
            </Example>
            <CodeASPX>&lt;dx:BootstrapTreeView ID="TreeView5" runat="server" AutoPostBack="true"&gt;
    &lt;Nodes&gt;
        ...
    &lt;/Nodes&gt;
&lt;/dx:BootstrapTreeView&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Data Binding">
            <Description>
                <p>The Tree View control supports binding to a data source, which can be any object that implements the <strong>IHierarchicalEnumerable</strong> or <strong>IHierarchicalDataSource</strong> interface (e.g., <strong>SiteMapDataSource</strong>, <strong>XmlDataSource</strong>, etc.). A data-bound Tree View control automatically creates the <strong>BootstrapTreeViewNode</strong> objects and retrieves their property values from corresponding data items.</p>
                <p>To assign a data source to a Tree View, set the BootstrapTreeView control’s <strong>DataSourceID</strong> property.</p>
            </Description>
            <Example>
                <dx:BootstrapTreeView ID="TreeView6" runat="server" TextField="Title" DataSourceID="XmlDataSource1">
                    <CssClasses Control="ctrl-fixed-width-lg" />
                </dx:BootstrapTreeView>
                <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/HelpNav.xml" XPath="/namespace/*"></asp:XmlDataSource>
            </Example>
            <CodeASPX>&lt;dx:BootstrapTreeView ID="TreeView6" runat="server" TextField="Title" DataSourceID="XmlDataSource1"&gt;
&lt;/dx:BootstrapTreeView&gt;
&lt;asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/HelpNav.xml" XPath="/namespace/*"&gt;&lt;/asp:XmlDataSource&gt;</CodeASPX>
        </demo:DemoItem>
    </div>
    <div class="col-md-3">
        <div class="affix page-nav" id="page-navigation">
        </div>
    </div>
</asp:Content>
