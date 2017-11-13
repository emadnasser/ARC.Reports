<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Pager.aspx.cs" Inherits="Navigation_Pager" MaintainScrollPositionOnPostback="true" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap Pager Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Pager
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <div class="col-md-9">
        <demo:DemoItem runat="server" Title="Default Pager">
            <Description>
                <p>The Pager control provides a visual interface for custom paging in your web application.</p>
                <p>By default, the pager displays a summary indicating the current page number out of the total page count, and navigation buttons. The number of simultaneously displayed navigation buttons is controlled by the <strong>NumericButtonCount</strong> property.</p>
                <p>To implement your custom paging logic, use the <strong>PageIndexChanging</strong> and <strong>PageIndexChanged</strong> events.</p>
                <p>Note that navigating between pages initiates a postback, which causes reloading the entire web page if the Pager control is not wrapped in an AJAX-enabled container. For demonstration purposes, this demo displays the Pager control within the <strong>asp:UpdatePanel</strong></p>
            </Description>
            <Example>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <dx:BootstrapPager ID="Pager1" runat="server" NumericButtonCount="5" ItemCount="1000">
                            <CssClasses PageNumber="hidden-xs" Ellipsis="hidden-xs" />
                        </dx:BootstrapPager>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPager ID="Pager1" runat="server" NumericButtonCount="5" ItemCount="1000"&gt;
&lt;/dx:BootstrapPager&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="With PageSize Item">
            <Description>
                <p>The Page Size item provides a visual interface to specify the number of data items to be displayed within a single page. To enable the Page Size item, set the <strong>PageSizeItemSettings.Visible</strong> property to <strong>true</strong>.</p>
            </Description>
            <Example>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <dx:BootstrapPager ID="Pager2" runat="server" ItemCount="1000" NumericButtonCount="5" Width="100%">
                            <CssClasses PageNumber="hidden-xs" Ellipsis="hidden-xs" />
                            <PageSizeItemSettings Visible="True">
                            </PageSizeItemSettings>
                        </dx:BootstrapPager>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPager ID="Pager2" runat="server" ItemCount="1000" NumericButtonCount="5" Width="100%"&gt;
    &lt;PageSizeItemSettings Visible="True"&gt;
    &lt;/PageSizeItemSettings&gt;
&lt;/dx:BootstrapPager&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="With First and Last Buttons">
            <Description>
                <p>The First and Last pager buttons allow an end-user to quickly navigate to the first or last page of the paginated content. The visibility of the First and Last buttons is controlled by the <strong>FirstPageButton.Visible</strong> and <strong>LastPageButton.Visible</strong> properties respectively.</p>
            </Description>
            <Example>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <dx:BootstrapPager ID="Pager3" runat="server" ItemCount="1000" NumericButtonCount="5">
                            <CssClasses PageNumber="hidden-xs" Ellipsis="hidden-xs" />
                            <FirstPageButton Visible="true"></FirstPageButton>
                            <LastPageButton Visible="true"></LastPageButton>
                        </dx:BootstrapPager>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPager ID="Pager3" runat="server" ItemCount="1000" NumericButtonCount="5" Width="100%"&gt;
    &lt;FirstPageButton Visible="true" /&gt;
    &lt;LastPageButton Visible="true" /&gt;
&lt;/dx:BootstrapPager&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Without Summary">
            <Description>
                <p>It is possible to hide the summary from the pager. You can achieve this goal by setting the <strong>Summary.Visible</strong> property to <strong>false</strong>.</p>
            </Description>
            <Example>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <dx:BootstrapPager ID="Pager4" runat="server" ItemCount="1000" NumericButtonCount="5">
                            <CssClasses PageNumber="hidden-xs" Ellipsis="hidden-xs" />
                            <Summary Visible="false"/>
                        </dx:BootstrapPager>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPager ID="Pager4" runat="server" ItemCount="1000" NumericButtonCount="5"&gt;
    &lt;Summary Visible="false"/&gt;
&lt;/dx:BootstrapPager&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Without Numeric Buttons">
            <Description>
                <p>You can hide numeric navigation buttons from the pager leaving only the Prev and Next buttons. To achieve this, set the <strong>ShowNumericButtons</strong> property to <strong>false</strong>.</p>
            </Description>
            <Example>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <dx:BootstrapPager ID="BootstrapPager4" runat="server" ItemCount="1000" ShowNumericButtons="false">
                        </dx:BootstrapPager>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPager ID="BootstrapPager4" runat="server" ItemCount="1000" ShowNumericButtons="false"&gt;
&lt;/dx:BootstrapPager&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Hide Disabled Buttons">
            <Description>
                <p>The Pager control can automatically hide currently disabled navigation buttons (e.g., hide the Next and Last buttons when the last page is displayed). To activate this behavior, set the <strong>ShowDisabledButtons</strong> property to false.</p>
            </Description>
            <Example>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <dx:BootstrapPager ID="Pager5" runat="server" ItemCount="1000" NumericButtonCount="5" ShowDisabledButtons="false">
                            <CssClasses PageNumber="hidden-xs" Ellipsis="hidden-xs" />
                        </dx:BootstrapPager>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPager ID="Pager5" runat="server" ItemCount="1000" NumericButtonCount="5" ShowDisabledButtons="false"&gt;
&lt;/dx:BootstrapPager&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Ellipsis Mode">
            <Description>
                <p>The ellipsis mode determines where in the pager the ellipsis symbol is placed to indicate page numbers that are omitted. The Pager control can display the ellipsis symbol inside or outside the range of pages, or never display the ellipsis symbol. To specify the ellipsis mode, assign the required <strong>PagerEllipsisMode</strong> enumeration value to the Pager control’s <strong>EllipsisMode</strong> property.</p>
            </Description>
            <Example>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <dx:BootstrapPager ID="Pager6" runat="server" ItemCount="1000" EllipsisMode="OutsideNumeric" NumericButtonCount="5" PageIndex="5">
                            <CssClasses PageNumber="hidden-xs" Ellipsis="hidden-xs" />
                        </dx:BootstrapPager>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPager ID="Pager6" runat="server" ItemCount="1000" EllipsisMode="OutsideNumeric" NumericButtonCount="5" PageIndex="5"&gt;
&lt;/dx:BootstrapPager&gt;</CodeASPX>
        </demo:DemoItem>
    </div>
    <div class="col-md-3">
        <div class="affix" id="page-navigation">
        </div>
    </div>
</asp:Content>
