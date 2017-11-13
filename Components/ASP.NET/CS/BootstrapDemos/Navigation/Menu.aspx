<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Navigation_Menu" MaintainScrollPositionOnPostback="true" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap Menu Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Menu
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-9">
        <demo:DemoItem runat="server" Title="Default Menu">
            <Description>
                <p>By default, the Menu control has a tree-like structure with root items aligned horizontally and sub-items available in drop-down menus. Each menu item is represented by a <strong>BootstrapMenuItem</strong> object and provides access to a collection of its sub-items through the <strong>Items</strong> collection property. The horizontal Menu re-orients its root items vertically if the display width is insufficient.</p>
            </Description>
            <Example>
                <dx:BootstrapMenu ID="Menu1" runat="server" ShowPopOutImages="true">
                    <Items>
                        <dx:BootstrapMenuItem Text="Home" IconCssClass="glyphicon glyphicon-home">
                            <Items>
                                <dx:BootstrapMenuItem Text="News">
                                    <Items>
                                        <dx:BootstrapMenuItem Text="For Developers">
                                        </dx:BootstrapMenuItem>
                                        <dx:BootstrapMenuItem Text="Website news">
                                        </dx:BootstrapMenuItem>
                                    </Items>
                                </dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="Our Mission" BeginGroup="true">
                                </dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="Our Customers">
                                </dx:BootstrapMenuItem>
                            </Items>
                        </dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Products">
                            <Items>
                                <dx:BootstrapMenuItem Text="Subscriptions / Packs">
                                </dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text=".NET Windows Forms Components">
                                </dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="Reporting / Printing Suites">
                                </dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="VCL Components and Tools">
                                </dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="ASP.NET Components">
                                </dx:BootstrapMenuItem>
                            </Items>
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
            </Example>
            <CodeASPX>&lt;dx:BootstrapMenu ID="Menu1" runat="server" ShowPopOutImages="true"&gt;
    &lt;Items&gt;
        &lt;dx:BootstrapMenuItem Text="Home"&gt;
            &lt;Items&gt;
                &lt;dx:BootstrapMenuItem Text="News"&gt;
                    &lt;Items&gt;
                        &lt;dx:BootstrapMenuItem Text="For Developers"/&gt;
                        &lt;dx:BootstrapMenuItem Text="Website news"/&gt;
                    &lt;/Items&gt;
                &lt;/dx:BootstrapMenuItem&gt;
                &lt;dx:BootstrapMenuItem Text="Our Mission" BeginGroup="true"/&gt;
                ...
            &lt;/Items&gt;
        &lt;/dx:BootstrapMenuItem&gt;
        &lt;dx:BootstrapMenuItem Text="Products"/&gt;
        &lt;dx:BootstrapMenuItem Text="Support"/&gt;
    &lt;/Items&gt;
&lt;/dx:BootstrapMenu&gt;
            </CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Vertical Orientation">
            <Description>
                <p>By default, if the display resolution allows, the Menu arranges its items horizontally. To switch to the vertical orientation, set the Menu control’s <strong>Orientation</strong> property to <strong>Vertical</strong>. Note that a horizontally oriented menu can still be displayed vertically to fit a low-resolution display.</p>
            </Description>
            <Example>
                <dx:BootstrapMenu ID="Menu2" runat="server" Orientation="Vertical">
                    <CssClasses Control="ctrl-fixed-width" />
                    <Items>
                        <dx:BootstrapMenuItem Text="Item 1">
                            <Items>
                                <dx:BootstrapMenuItem Text="SubItem 1">
                                    <Items>
                                        <dx:BootstrapMenuItem Text="SubItem 4"></dx:BootstrapMenuItem>
                                    </Items>
                                </dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="SubItem 2"></dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="SubItem 3"></dx:BootstrapMenuItem>
                            </Items>
                        </dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item 2"></dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item 3"></dx:BootstrapMenuItem>
                    </Items>
                </dx:BootstrapMenu>
            </Example>
            <CodeASPX>&lt;dx:BootstrapMenu ID="Menu2" runat="server" Orientation="Vertical"&gt;
    &lt;Items&gt;
        &lt;dx:BootstrapMenuItem Text="Item 1"/&gt;
            &lt;Items&gt;
                &lt;dx:BootstrapMenuItem Text="SubItem 1"&gt;
                    &lt;Items&gt;
                        &lt;dx:BootstrapMenuItem Text="SubItem 4"/&gt;
                    &lt;/Items&gt;
                &lt;/dx:BootstrapMenuItem&gt;
                &lt;dx:BootstrapMenuItem Text="SubItem 2"/&gt;
                &lt;dx:BootstrapMenuItem Text="SubItem 3"/&gt;
            &lt;/Items&gt;
        &lt;/dx:BootstrapMenuItem&gt;
        &lt;dx:BootstrapMenuItem Text="Item 2"/&gt;
        &lt;dx:BootstrapMenuItem Text="Item 3"/&gt;
    &lt;/Items&gt;
&lt;/dx:BootstrapMenu&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Item AutoWidth">
            <Description>
                <p>To control how root menu item widths are calculated, use the <strong>ItemAutoWidth</strong> property. When this property is set to <stong>true</strong>, root items are automatically resized to fit the Menu control's width.</p>
            </Description>
            <Example>
                <dx:BootstrapMenu ID="Menu3" runat="server" ItemAutoWidth="true" ShowPopOutImages="true">
                    <Items>
                        <dx:BootstrapMenuItem Text="Item 1">
                            <Items>
                                <dx:BootstrapMenuItem Text="SubItem 1">
                                    <Items>
                                        <dx:BootstrapMenuItem Text="SubItem 4"></dx:BootstrapMenuItem>
                                    </Items>
                                </dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="SubItem 2"></dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="SubItem 3"></dx:BootstrapMenuItem>
                            </Items>
                        </dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item 2"></dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item 3"></dx:BootstrapMenuItem>
                    </Items>
                </dx:BootstrapMenu>
            </Example>
            <CodeASPX>&lt;dx:BootstrapMenu ID="Menu3" runat="server" ItemAutoWidth="true"&gt;
    &lt;Items&gt;
        &lt;dx:BootstrapMenuItem Text="Item 1"/&gt;
            &lt;Items&gt;
                &lt;dx:BootstrapMenuItem Text="SubItem 1"&gt;
                    &lt;Items&gt;
                        &lt;dx:BootstrapMenuItem Text="SubItem 4"/&gt;
                    &lt;/Items&gt;
                &lt;/dx:BootstrapMenuItem&gt;
                &lt;dx:BootstrapMenuItem Text="SubItem 2"/&gt;
                &lt;dx:BootstrapMenuItem Text="SubItem 3"/&gt;
            &lt;/Items&gt;
        &lt;/dx:BootstrapMenuItem&gt;
        &lt;dx:BootstrapMenuItem Text="Item 2"/&gt;
        &lt;dx:BootstrapMenuItem Text="Item 3"/&gt;
    &lt;/Items&gt;
&lt;/dx:BootstrapMenu&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Item Selection">
            <Description>
                <p>The Menu control supports selection of root items with a mouse click. To allow item selection, set the Menu control’s <strong>AllowSelectItem</strong> property to <strong>true</strong>. Note that only one item can be selected at a time.</p>
            </Description>
            <Example>
                <dx:BootstrapMenu ID="Menu4" runat="server" AllowSelectItem="true">
                    <Items>
                        <dx:BootstrapMenuItem Text="Item 1"></dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item 2"></dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item 3"></dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item 4">
                            <Items>
                                <dx:BootstrapMenuItem Text="Sub Item 1">
                                </dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="Sub Item 2">
                                </dx:BootstrapMenuItem>
                            </Items>
                        </dx:BootstrapMenuItem>
                    </Items>
                </dx:BootstrapMenu>
            </Example>
            <CodeASPX>&lt;dx:BootstrapMenu ID="Menu4" runat="server" AllowSelectItem="true"&gt;
    &lt;Items&gt;
        &lt;dx:BootstrapMenuItem Text="Item 1"/&gt;
        &lt;dx:BootstrapMenuItem Text="Item 2"/&gt;
        &lt;dx:BootstrapMenuItem Text="Item 3"/&gt;
        &lt;dx:BootstrapMenuItem Text="Item 4"&gt;
            &lt;Items&gt;
                &lt;dx:BootstrapMenuItem Text="Sub Item 1"/&gt;
                &lt;dx:BootstrapMenuItem Text="Sub Item 2"/&gt;
            &lt;/Items&gt;
        &lt;/dx:BootstrapMenuItem&gt;
    &lt;/Items&gt;
&lt;/dx:BootstrapMenu&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Item Checking">
            <Description>
                <p>This feature allows you to arrange menu items into logical check groups in which items behave as radio buttons. You can assign a check group to an item by setting the item’s <strong>GroupName</strong> property. Within a logical check group only one item can be selected at a time. The Menu control allows you to define an unlimited number of check groups for both root items and sub-items.</p>
            </Description>
            <Example>
                <dx:BootstrapMenu ID="Menu5" runat="server">
                    <Items>
                        <dx:BootstrapMenuItem Text="Item 1" GroupName="Group1"></dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item With Subitems">
                            <Items>
                                <dx:BootstrapMenuItem Text="Sub Item 1" GroupName="SubItemGroup1" Checked="true">
                                </dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="Sub Item 2" GroupName="SubItemGroup2">
                                </dx:BootstrapMenuItem>
                                <dx:BootstrapMenuItem Text="Sub Item 3" GroupName="SubItemGroup3">
                                </dx:BootstrapMenuItem>
                            </Items>
                        </dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item 3" GroupName="Group3" Checked="true"></dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item 4" GroupName="Group4"></dx:BootstrapMenuItem>
                    </Items>
                </dx:BootstrapMenu>
            </Example>
            <CodeASPX>&lt;dx:BootstrapMenu ID="Menu5" runat="server"&gt;
    &lt;Items&gt;
        &lt;dx:BootstrapMenuItem Text="Item 1" GroupName="Group1"/&gt;
        &lt;dx:BootstrapMenuItem Text="Item With Subitems"&gt;
            &lt;Items&gt;
                &lt;dx:BootstrapMenuItem Text="Sub Item 1" GroupName="SubItemGroup1" Checked="true"/&gt;
                &lt;dx:BootstrapMenuItem Text="Sub Item 2" GroupName="SubItemGroup2"/&gt;
                &lt;dx:BootstrapMenuItem Text="Sub Item 3" GroupName="SubItemGroup3"/&gt;
            &lt;/Items&gt;
        &lt;/dx:BootstrapMenuItem&gt;
        &lt;dx:BootstrapMenuItem Text="Item 3" GroupName="Group3" Checked="true"/&gt;
        &lt;dx:BootstrapMenuItem Text="Item 4" GroupName="Group4"/&gt;
    &lt;/Items&gt;
&lt;/dx:BootstrapMenu&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Auto Postback">
            <Description>
                <p>The Auto Postback feature allows the Menu control to automatically initiate a postback to the server when a menu item has been clicked.</p>
            </Description>
            <Example>
                <dx:BootstrapMenu ID="Menu6" runat="server" AutoPostBack="true">
                    <Items>
                        <dx:BootstrapMenuItem Text="Item 1"></dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item 2"></dx:BootstrapMenuItem>
                        <dx:BootstrapMenuItem Text="Item 3"></dx:BootstrapMenuItem>
                    </Items>
                </dx:BootstrapMenu>
            </Example>
            <CodeASPX>&lt;dx:BootstrapMenu ID="Menu6" runat="server" AutoPostBack="true"&gt;
    &lt;Items&gt;
        &lt;dx:BootstrapMenuItem Text="Item 1"/&gt;
        &lt;dx:BootstrapMenuItem Text="Item 2"/&gt;
        &lt;dx:BootstrapMenuItem Text="Item 3"/&gt;
    &lt;/Items&gt;
&lt;/dx:BootstrapMenu&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Data Binding">
            <Description>
                <p>The Menu control supports binding to a data source, which can be any object that implements the <strong>IHierarchicalEnumerable</strong> or <strong>IHierarchicalDataSource</strong> interface (e.g., <strong>SiteMapDataSource</strong>, <strong>XmlDataSource</strong>, etc.). A data-bound Menu control automatically creates the <strong>BootstrapMenuItem</strong> objects and retrieves their property values from corresponding data items.</p>
                <p>To assign a data source to a menu, set the Menu control’s <strong>DataSourceID</strong> property.</p>
            </Description>
            <Example>
                <dx:BootstrapMenu ID="Menu7" runat="server" DataSourceID="XmlDataSource1" TextField="Title" Orientation="Vertical">
                    <CssClasses Control="ctrl-fixed-width" />
                </dx:BootstrapMenu>
                <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/HelpNav.xml" XPath="/namespace/*"></asp:XmlDataSource>
            </Example>
            <CodeASPX>&lt;dx:BootstrapMenu ID="Menu7" runat="server" DataSourceID="XmlDataSource1" TextField="Title" Orientation="Vertical"&gt;
&lt;/dx:BootstrapMenu&gt;
&lt;asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/HelpNav.xml" XPath="/namespace/*"&gt;&lt;/asp:XmlDataSource></CodeASPX>
        </demo:DemoItem>
    </div>
    <div class="col-md-3">
        <div class="affix page-nav" id="page-navigation">
        </div>
    </div>
</asp:Content>
