<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Accordion.aspx.cs" Inherits="Navigation_Accordion" MaintainScrollPositionOnPostback="true" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap Accordion Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Accordion
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-9">
    <demo:DemoItem runat="server" Title="Default Accordion">
        <Description>
            <p>The Accordion control allows you to provide navigation capabilities to your web application. The control displays navigation items arranged in collapsible groups. Groups within the Accordion can be accessed through the Groups property. Each group has a collection of items available through the <strong>BootstrapAccordionGroup.Items</strong> property.</p>
        </Description>
        <Example>
            <dx:BootstrapAccordion ID="Accordion1" runat="server">
                <CssClasses Control="ctrl-fixed-width" />
                <Groups>
                    <dx:BootstrapAccordionGroup Text="Tables">
                        <Items>
                            <dx:BootstrapAccordionItem Text="Users" IconCssClass="glyphicon glyphicon-user">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="Tasks" IconCssClass="glyphicon glyphicon-tasks">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="Scheduler" IconCssClass="glyphicon glyphicon-calendar">
                            </dx:BootstrapAccordionItem>
                        </Items>
                    </dx:BootstrapAccordionGroup>
                    <dx:BootstrapAccordionGroup Text="Analysis">
                        <Items>
                            <dx:BootstrapAccordionItem Text="Dashboard" IconCssClass="glyphicon glyphicon-dashboard">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="KPI" IconCssClass="glyphicon glyphicon-scale">
                            </dx:BootstrapAccordionItem>
                        </Items>
                    </dx:BootstrapAccordionGroup>
                </Groups>
            </dx:BootstrapAccordion>
        </Example>
        <CodeASPX>&lt;dx:BootstrapAccordion ID="Accordion1" runat="server"&gt;
    &lt;Groups&gt;
        &lt;dx:BootstrapAccordionGroup Text="Tables"&gt;
            &lt;Items&gt;
                &lt;dx:BootstrapAccordionItem Text="Users"/&gt;
                &lt;dx:BootstrapAccordionItem Text="Tasks"/&gt;
                &lt;dx:BootstrapAccordionItem Text="Scheduler"/&gt;
            &lt;/Items&gt;
        &lt;/dx:BootstrapAccordionGroup&gt;
        &lt;dx:BootstrapAccordionGroup Text="Analysis"&gt;
            &lt;Items&gt;
                &lt;dx:BootstrapAccordionItem Text="Dashboard"/&gt;
                &lt;dx:BootstrapAccordionItem Text="KPI"/&gt;
            &lt;/Items&gt;
        &lt;/dx:BootstrapAccordionGroup&gt;
    &lt;/Groups&gt;
&lt;/dx:BootstrapAccordion&gt;</CodeASPX>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Items Selection">
        <Description>
            <p>The Accordion control supports selection of items with a mouse click. To allow item selection, set the Accordion control’s <strong>AllowSelectItem</strong> property to <strong>true</strong>. Note that only one item can be selected at a time.</p>
        </Description>
        <Example>
            <dx:BootstrapAccordion ID="Accordion2" runat="server" AllowSelectItem="true">
                <CssClasses Control="ctrl-fixed-width" />
                <Groups>
                    <dx:BootstrapAccordionGroup Text="Tables">
                        <Items>
                            <dx:BootstrapAccordionItem Text="Users" IconCssClass="glyphicon glyphicon-user">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="Tasks" IconCssClass="glyphicon glyphicon-tasks">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="Scheduler" IconCssClass="glyphicon glyphicon-calendar">
                            </dx:BootstrapAccordionItem>
                        </Items>
                    </dx:BootstrapAccordionGroup>
                    <dx:BootstrapAccordionGroup Text="Analysis">
                        <Items>
                            <dx:BootstrapAccordionItem Text="Dashboard" IconCssClass="glyphicon glyphicon-dashboard">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="KPI" IconCssClass="glyphicon glyphicon-scale">
                            </dx:BootstrapAccordionItem>
                        </Items>
                    </dx:BootstrapAccordionGroup>
                </Groups>
            </dx:BootstrapAccordion>
        </Example>
        <CodeASPX>&lt;dx:BootstrapAccordion ID="Accordion2" runat="server" AllowSelectItem="true"&gt;
    &lt;Groups&gt;
        ...
    &lt;/Groups&gt;
&lt;/dx:BootstrapAccordion&gt;</CodeASPX>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Auto Collapse">
        <Description>
            <p>When the Auto Collapse feature is activated, only one Accordion group can be expanded at a time. To activate this functionality, set the Accordion control’s <strong>AutoCollapse</strong> property to true.</p>
        </Description>
        <Example>
            <dx:BootstrapAccordion ID="Accordion3" runat="server" AutoCollapse="true">
                <CssClasses Control="ctrl-fixed-width" />
                <Groups>
                    <dx:BootstrapAccordionGroup Text="Tables">
                        <Items>
                            <dx:BootstrapAccordionItem Text="Users" IconCssClass="glyphicon glyphicon-user">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="Tasks" IconCssClass="glyphicon glyphicon-tasks">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="Scheduler" IconCssClass="glyphicon glyphicon-calendar">
                            </dx:BootstrapAccordionItem>
                        </Items>
                    </dx:BootstrapAccordionGroup>
                    <dx:BootstrapAccordionGroup Text="Analysis">
                        <Items>
                            <dx:BootstrapAccordionItem Text="Dashboard" IconCssClass="glyphicon glyphicon-dashboard">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="KPI" IconCssClass="glyphicon glyphicon-scale">
                            </dx:BootstrapAccordionItem>
                        </Items>
                    </dx:BootstrapAccordionGroup>
                </Groups>
            </dx:BootstrapAccordion>
        </Example>
        <CodeASPX>&lt;dx:BootstrapAccordion ID="Accordion3" runat="server" AutoCollapse="true"&gt;
    &lt;Groups&gt;
        ...
    &lt;/Groups&gt;
&lt;/dx:BootstrapAccordion&gt;</CodeASPX>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Auto PostBack">
        <Description>
            <p>The Auto Postback feature allows the Accordion control to automatically initiate a postback to the server when a Accordion item has been clicked.</p>
        </Description>
        <Example>
            <dx:BootstrapAccordion ID="Accordion4" runat="server" AutoPostBack="true">
                <CssClasses Control="ctrl-fixed-width" />
                <Groups>
                    <dx:BootstrapAccordionGroup Text="Tables">
                        <Items>
                            <dx:BootstrapAccordionItem Text="Users" IconCssClass="glyphicon glyphicon-user">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="Tasks" IconCssClass="glyphicon glyphicon-tasks">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="Scheduler" IconCssClass="glyphicon glyphicon-calendar">
                            </dx:BootstrapAccordionItem>
                        </Items>
                    </dx:BootstrapAccordionGroup>
                    <dx:BootstrapAccordionGroup Text="Analysis">
                        <Items>
                            <dx:BootstrapAccordionItem Text="Dashboard" IconCssClass="glyphicon glyphicon-dashboard">
                            </dx:BootstrapAccordionItem>
                            <dx:BootstrapAccordionItem Text="KPI" IconCssClass="glyphicon glyphicon-scale">
                            </dx:BootstrapAccordionItem>
                        </Items>
                    </dx:BootstrapAccordionGroup>
                </Groups>
            </dx:BootstrapAccordion>
        </Example>
        <CodeASPX>&lt;dx:BootstrapAccordion ID="Accordion4" runat="server" AutoPostBack="true"&gt;
    &lt;Groups&gt;
        ...
    &lt;/Groups&gt;
&lt;/dx:BootstrapAccordion&gt;</CodeASPX>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Data Binding">
        <Description>
            <p>The Accordion control supports binding to a data source which can be any object that implements the <strong>IHierarchicalEnumerable</strong> or <strong>IHierarchicalDataSource</strong> interface (e.g., <strong>SiteMapDataSource</strong>, <strong>XmlDataSource</strong>, etc.). A data-bound Accordion control automatically creates its groups and items and retrieves their property values from corresponding data items.</p>
            <p>To assign a data source to a Accordion control, set its <strong>DataSourceID</strong> property.</p>
        </Description>
        <Example>
            <dx:BootstrapAccordion ID="Accordion5" runat="server" DataSourceID="XmlDataSource1" AutoCollapse="true">
                <CssClasses Control="ctrl-fixed-width" />
                <GroupDataFields TextField="Title" />
                <ItemDataFields TextField="Title" />
            </dx:BootstrapAccordion>
            <asp:XmlDataSource runat="server" ID="XmlDataSource1" DataFile="~/App_Data/xcrm.xml" XPath="/XCRM/*"></asp:XmlDataSource>
        </Example>
        <CodeASPX>&lt;dx:BootstrapAccordion ID="Accordion5" runat="server" DataSourceID="XmlDataSource1" AutoCollapse="true"&gt;
    &lt;GroupDataFields TextField="Title" /&gt;
    &lt;ItemDataFields TextField="Title" /&gt;
&lt;/dx:BootstrapAccordion&gt;
&lt;asp:XmlDataSource runat="server" ID="XmlDataSource1" DataFile="~/App_Data/xcrm.xml" XPath="/XCRM/*"&gt;&lt;/asp:XmlDataSource&gt;</CodeASPX>
    </demo:DemoItem>
    </div>
    <div class="col-md-3">
        <div class="affix page-nav" id="page-navigation">
        </div>
    </div>
</asp:Content>
