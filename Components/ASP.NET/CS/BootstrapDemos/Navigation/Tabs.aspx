<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Tabs.aspx.cs" Inherits="Navigation_Tabs" MaintainScrollPositionOnPostback="true" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap Tab Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Tabs
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-9">
        <demo:DemoItem runat="server" Title="Default Page Control">
            <Description>
                <p>The Page Control presents content as a set of tabbed pages. Each page in the Page Control serves as a separate container of child controls allowing you to associate specific page content with each displayed tab.</p>
                <p>To only display tabs without associated content, use the Tab Control. Unlike the Page Control, the Tab Control provides only navigation means and requires you to manually update specific content to reflect the change of a selected tab.</p>
            </Description>
            <Example>
                <dx:BootstrapPageControl ID="PageControl1" runat="server">
                    <TabPages>
                        <dx:BootstrapTabPage Text="Home">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl0" runat="server" SupportsDisabledAttribute="True">
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sem lorem, rutrum at tincidunt aliquam, vulputate sit amet tellus. In hac habitasse platea dictumst. Morbi in dui a massa volutpat tristique. Aenean ultrices, elit ac commodo vestibulum, nisl neque pharetra est, id egestas neque leo dignissim augue. Vestibulum sodales metus at est maximus dictum. Quisque cursus felis id nisi auctor, volutpat imperdiet neque feugiat. Sed aliquet elit sem, ut vulputate lectus ultricies sit amet. Sed in velit dui.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                        <dx:BootstrapTabPage Text="Products">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl1" runat="server" SupportsDisabledAttribute="True">
Quisque imperdiet risus quis nisl vulputate, a pharetra tortor ornare. Ut mi lectus, porttitor quis semper eu, lacinia id leo. Sed in nisl a neque consequat ultrices. Aliquam non sagittis nulla, nec tempus nibh. Cras aliquam nulla in elit iaculis accumsan. Ut eu lorem sagittis, volutpat arcu eu, mollis elit. Suspendisse aliquet magna diam, nec tristique mi cursus eu. Donec venenatis cursus ipsum, ut egestas turpis sodales vitae.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                        <dx:BootstrapTabPage Text="Support">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl2" runat="server" SupportsDisabledAttribute="True">
Aenean gravida tristique velit ac ornare. Maecenas ultricies metus sit amet ligula malesuada, in faucibus nulla cursus. Aenean sit amet vulputate lorem, commodo suscipit nulla. Nunc non vulputate nibh. Nam sapien magna, accumsan id dui sit amet, euismod rhoncus nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla quis feugiat augue. Sed turpis nibh, porta quis congue ut, mattis id purus. Donec auctor felis sit amet orci ornare, aliquet ultrices ipsum lacinia.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                    </TabPages>
                </dx:BootstrapPageControl>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPageControl ID="BootstrapPageControl1" runat="server"&gt;
    &lt;TabPages&gt;
        &lt;dx:BootstrapTabPage Text="Home"&gt;
            &lt;ContentCollection&gt;
                &lt;dx:ContentControl ID="ContentControl0" runat="server" SupportsDisabledAttribute="True"&gt;
                    ...
                &lt;/dx:ContentControl&gt;
            &lt;/ContentCollection&gt;
        &lt;/dx:BootstrapTabPage&gt;
        &lt;dx:BootstrapTabPage Text="Products"&gt;
            &lt;ContentCollection&gt;
                &lt;dx:ContentControl ID="ContentControl1" runat="server" SupportsDisabledAttribute="True"&gt;
                    ...
                &lt;/dx:ContentControl&gt;
            &lt;/ContentCollection&gt;
        &lt;/dx:BootstrapTabPage&gt;
        &lt;dx:BootstrapTabPage Text="Support"&gt;
            &lt;ContentCollection&gt;
                &lt;dx:ContentControl ID="ContentControl2" runat="server" SupportsDisabledAttribute="True"&gt;
                    ...
                &lt;/dx:ContentControl&gt;
            &lt;/ContentCollection&gt;
        &lt;/dx:BootstrapTabPage&gt;
    &lt;/TabPages&gt;
&lt;/dx:BootstrapPageControl></CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Tab Alignment">
            <Description>
                <p>Use the <strong>TabAlign</strong> property to specify the alignment of tabs within the control. The following modes are supported.</p>
                <ul>
                    <li>Justify</li>
                    <li>Left</li>
                    <li>Right</li>
                </ul>
            </Description>
            <Example>
                <dx:BootstrapPageControl ID="PageControl2" runat="server" TabAlign="Justify">
                    <TabPages>
                        <dx:BootstrapTabPage Text="Home">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl9" runat="server" SupportsDisabledAttribute="True">
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sem lorem, rutrum at tincidunt aliquam, vulputate sit amet tellus. In hac habitasse platea dictumst. Morbi in dui a massa volutpat tristique. Aenean ultrices, elit ac commodo vestibulum, nisl neque pharetra est, id egestas neque leo dignissim augue. Vestibulum sodales metus at est maximus dictum. Quisque cursus felis id nisi auctor, volutpat imperdiet neque feugiat. Sed aliquet elit sem, ut vulputate lectus ultricies sit amet. Sed in velit dui.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                        <dx:BootstrapTabPage Text="Products">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl10" runat="server" SupportsDisabledAttribute="True">
Quisque imperdiet risus quis nisl vulputate, a pharetra tortor ornare. Ut mi lectus, porttitor quis semper eu, lacinia id leo. Sed in nisl a neque consequat ultrices. Aliquam non sagittis nulla, nec tempus nibh. Cras aliquam nulla in elit iaculis accumsan. Ut eu lorem sagittis, volutpat arcu eu, mollis elit. Suspendisse aliquet magna diam, nec tristique mi cursus eu. Donec venenatis cursus ipsum, ut egestas turpis sodales vitae.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                        <dx:BootstrapTabPage Text="Support">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl11" runat="server" SupportsDisabledAttribute="True">
Aenean gravida tristique velit ac ornare. Maecenas ultricies metus sit amet ligula malesuada, in faucibus nulla cursus. Aenean sit amet vulputate lorem, commodo suscipit nulla. Nunc non vulputate nibh. Nam sapien magna, accumsan id dui sit amet, euismod rhoncus nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla quis feugiat augue. Sed turpis nibh, porta quis congue ut, mattis id purus. Donec auctor felis sit amet orci ornare, aliquet ultrices ipsum lacinia.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                    </TabPages>
                </dx:BootstrapPageControl>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPageControl ID="BootstrapPageControl1" runat="server" TabAlign="Justify"&gt;
    &lt;TabPages&gt;
        ...
    &lt;/TabPages&gt;
&lt;/dx:BootstrapPageControl></CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Load Content on Callbacks">
            <Description>
                <p>The Page Control exposes the <strong>EnableCallbacks</strong> property allowing you to specify whether or not to use callbacks to obtain page contents from the server. If the property is set to <strong>true</strong>, only the content of the active page is sent to the client during the first request. The content of every other page is obtained from the server only once - when the page is first activated. The page content is loaded using a callback without refreshing the entire page.</p>
                <p>If the property is set to <strong>false</strong>, the contents of all pages are sent to the client with the first response, and switching the active page never initiates a callback.</p>
            </Description>
            <Example>
                <dx:BootstrapPageControl ID="PageControl3" runat="server" EnableCallBacks="true">
                    <TabPages>
                        <dx:BootstrapTabPage Text="Home">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl3" runat="server" SupportsDisabledAttribute="True">
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sem lorem, rutrum at tincidunt aliquam, vulputate sit amet tellus. In hac habitasse platea dictumst. Morbi in dui a massa volutpat tristique. Aenean ultrices, elit ac commodo vestibulum, nisl neque pharetra est, id egestas neque leo dignissim augue. Vestibulum sodales metus at est maximus dictum. Quisque cursus felis id nisi auctor, volutpat imperdiet neque feugiat. Sed aliquet elit sem, ut vulputate lectus ultricies sit amet. Sed in velit dui.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                        <dx:BootstrapTabPage Text="Products">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl4" runat="server" SupportsDisabledAttribute="True">
Quisque imperdiet risus quis nisl vulputate, a pharetra tortor ornare. Ut mi lectus, porttitor quis semper eu, lacinia id leo. Sed in nisl a neque consequat ultrices. Aliquam non sagittis nulla, nec tempus nibh. Cras aliquam nulla in elit iaculis accumsan. Ut eu lorem sagittis, volutpat arcu eu, mollis elit. Suspendisse aliquet magna diam, nec tristique mi cursus eu. Donec venenatis cursus ipsum, ut egestas turpis sodales vitae.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                        <dx:BootstrapTabPage Text="Support">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl5" runat="server" SupportsDisabledAttribute="True">
Aenean gravida tristique velit ac ornare. Maecenas ultricies metus sit amet ligula malesuada, in faucibus nulla cursus. Aenean sit amet vulputate lorem, commodo suscipit nulla. Nunc non vulputate nibh. Nam sapien magna, accumsan id dui sit amet, euismod rhoncus nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla quis feugiat augue. Sed turpis nibh, porta quis congue ut, mattis id purus. Donec auctor felis sit amet orci ornare, aliquet ultrices ipsum lacinia.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                    </TabPages>
                </dx:BootstrapPageControl>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPageControl ID="BootstrapPageControl1" runat="server" EnableCallBacks="true"&gt;
    &lt;TabPages&gt;
        ...
    &lt;/TabPages&gt;
&lt;/dx:BootstrapPageControl></CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Auto PostBack">
            <Description>
                <p>If the <strong>AutoPostBack</strong> property is set to <strong>true</strong>, the Page Control works in a “Server Mode”. In this mode, changing an active page causes a postback to refresh the entire web page. Note that when the <strong>AutoPostBack</strong> property is set to <strong>true</strong>, the <strong>EnableCallbacks</strong> property is not in effect.</p>
            </Description>
            <Example>
                <dx:BootstrapPageControl ID="PageControl4" runat="server" AutoPostBack="true">
                    <TabPages>
                        <dx:BootstrapTabPage Text="Home">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl6" runat="server" SupportsDisabledAttribute="True">
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sem lorem, rutrum at tincidunt aliquam, vulputate sit amet tellus. In hac habitasse platea dictumst. Morbi in dui a massa volutpat tristique. Aenean ultrices, elit ac commodo vestibulum, nisl neque pharetra est, id egestas neque leo dignissim augue. Vestibulum sodales metus at est maximus dictum. Quisque cursus felis id nisi auctor, volutpat imperdiet neque feugiat. Sed aliquet elit sem, ut vulputate lectus ultricies sit amet. Sed in velit dui.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                        <dx:BootstrapTabPage Text="Products">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl7" runat="server" SupportsDisabledAttribute="True">
Quisque imperdiet risus quis nisl vulputate, a pharetra tortor ornare. Ut mi lectus, porttitor quis semper eu, lacinia id leo. Sed in nisl a neque consequat ultrices. Aliquam non sagittis nulla, nec tempus nibh. Cras aliquam nulla in elit iaculis accumsan. Ut eu lorem sagittis, volutpat arcu eu, mollis elit. Suspendisse aliquet magna diam, nec tristique mi cursus eu. Donec venenatis cursus ipsum, ut egestas turpis sodales vitae.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                        <dx:BootstrapTabPage Text="Support">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl8" runat="server" SupportsDisabledAttribute="True">
Aenean gravida tristique velit ac ornare. Maecenas ultricies metus sit amet ligula malesuada, in faucibus nulla cursus. Aenean sit amet vulputate lorem, commodo suscipit nulla. Nunc non vulputate nibh. Nam sapien magna, accumsan id dui sit amet, euismod rhoncus nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla quis feugiat augue. Sed turpis nibh, porta quis congue ut, mattis id purus. Donec auctor felis sit amet orci ornare, aliquet ultrices ipsum lacinia.
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                    </TabPages>
                </dx:BootstrapPageControl>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPageControl ID="BootstrapPageControl1" runat="server" AutoPostBack="true"&gt;
    &lt;TabPages&gt;
        ...
    &lt;/TabPages&gt;
&lt;/dx:BootstrapPageControl></CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Data Binding">
            <Description>
                <p>This demo illustrates how the Tab Control can be populated with tab information taken from a data source. The Tab Control supports standard data binding - any object that implements the <strong>IHierarchicalEnumerable</strong> or <strong>IHierarchicalDataSource</strong> interface may be used as a data source for this control.</p>
                <p>In this sample, the Tab Control is bound to the <strong>XmlDataSource</strong> component that obtains data from an xml file.</p>
            </Description>
            <Example>
                <dx:BootstrapTabControl ID="TabControl1" runat="server" DataSourceID="XmlDataSource1"
                    NavigateUrlField="id" NavigateUrlFormatString="~/Navigation/Tabs.aspx?id={0}">
                </dx:BootstrapTabControl>
                <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Platforms.xml"
                    XPath="//product"></asp:XmlDataSource>
            </Example>
            <CodeASPX>&lt;dx:BootstrapTabControl ID="BootstrapTabControl1" runat="server" DataSourceID="XmlDataSource1"
    NavigateUrlField="id" NavigateUrlFormatString="~/Navigation/Tabs.aspx?id={0}"&gt;
&lt;/dx:BootstrapTabControl&gt;
&lt;asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Platforms.xml" XPath="//product"&gt;&lt;/asp:XmlDataSource></CodeASPX>
        </demo:DemoItem>
    </div>
    <div class="col-md-3">
        <div class="affix page-nav" id="page-navigation">
        </div>
    </div>
</asp:Content>
