<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="FormLayout.aspx.cs" Inherits="FormLayout_Overview" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap Form Layout Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Editors
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <demo:DemoItem runat="server" Title="Default Form Layout">
        <Description>
            <p>The Form Layout control simplifies the manner in which you create ASP.NET applications in Visual Studio. It allows you to quickly create form layouts of any complexity by combining the order and hierarchy of the control’s layout elements.</p>
        </Description>
        <Example>
            <dx:BootstrapFormLayout runat="server" ID="FormLayout1" ColCount="12">
                <Items>
                    <dx:BootstrapLayoutItem Caption="First Name" ColSpanMd="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:BootstrapTextBox runat="server" ID="TextBox1" Text="Andrew" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:BootstrapLayoutItem>
                    <dx:BootstrapLayoutItem Caption="Last Name" ColSpanMd="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:BootstrapTextBox runat="server" ID="TextBox2" Text="Fuller" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:BootstrapLayoutItem>
                    <dx:BootstrapLayoutItem Caption="Country" ColSpanMd="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:BootstrapTextBox runat="server" ID="TextBox3" Text="Austria" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:BootstrapLayoutItem>
                    <dx:BootstrapLayoutItem Caption="City" ColSpanMd="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:BootstrapTextBox runat="server" ID="TextBox4" Text="Graz" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:BootstrapLayoutItem>
                    <dx:BootstrapLayoutItem Caption="Address" ColSpanMd="12">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:BootstrapTextBox runat="server" ID="TextBox5" Text="Kirchgasse 6" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:BootstrapLayoutItem>
                    <dx:BootstrapLayoutItem Caption="Note" ColSpanMd="12">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:BootstrapMemo runat="server" ID="Memo1" Rows="4"
                                    Text="Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association." />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:BootstrapLayoutItem>
                    <dx:BootstrapLayoutItem ColSpanMd="12" ShowCaption="False" HorizontalAlign="Right">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:BootstrapButton ID="Button1" runat="server" Text="Submit" RenderOption="Primary" />
                                <dx:BootstrapButton ID="Button2" runat="server" Text="Cancel" RenderOption="Link" AutoPostBack="false">
                                    <ClientSideEvents Click="function(s, e) { document.location.reload(); }" />
                                </dx:BootstrapButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:BootstrapLayoutItem>
                </Items>
            </dx:BootstrapFormLayout>
        </Example>
        <CodeASPX>&lt;dx:BootstrapFormLayout runat="server" ID="FormLayout1" ColCount="12"&gt;
    &lt;Items&gt;
        &lt;dx:BootstrapLayoutItem Caption="First Name" ColSpanMd="6"&gt;
            &lt;LayoutItemNestedControlCollection&gt;
                &lt;dx:LayoutItemNestedControlContainer&gt;
                    &lt;dx:BootstrapTextBox runat="server" ID="TextBox1" Text="Andrew" /&gt;
                &lt;/dx:LayoutItemNestedControlContainer&gt;
            &lt;/LayoutItemNestedControlCollection&gt;
        &lt;/dx:BootstrapLayoutItem&gt;
        &lt;dx:BootstrapLayoutItem Caption="Last Name" ColSpanMd="6"&gt;
            &lt;LayoutItemNestedControlCollection&gt;
                &lt;dx:LayoutItemNestedControlContainer&gt;
                    &lt;dx:BootstrapTextBox runat="server" ID="TextBox2" Text="Fuller" /&gt;
                &lt;/dx:LayoutItemNestedControlContainer&gt;
            &lt;/LayoutItemNestedControlCollection&gt;
        &lt;/dx:BootstrapLayoutItem&gt;
        &lt;dx:BootstrapLayoutItem Caption="Country" ColSpanMd="6"&gt;
            &lt;LayoutItemNestedControlCollection&gt;
                &lt;dx:LayoutItemNestedControlContainer&gt;
                    &lt;dx:BootstrapTextBox runat="server" ID="TextBox3" Text="Austria" /&gt;
                &lt;/dx:LayoutItemNestedControlContainer&gt;
            &lt;/LayoutItemNestedControlCollection&gt;
        &lt;/dx:BootstrapLayoutItem&gt;
        &lt;dx:BootstrapLayoutItem Caption="City" ColSpanMd="6"&gt;
            &lt;LayoutItemNestedControlCollection&gt;
                &lt;dx:LayoutItemNestedControlContainer&gt;
                    &lt;dx:BootstrapTextBox runat="server" ID="TextBox4" Text="Graz" /&gt;
                &lt;/dx:LayoutItemNestedControlContainer&gt;
            &lt;/LayoutItemNestedControlCollection&gt;
        &lt;/dx:BootstrapLayoutItem&gt;
        &lt;dx:BootstrapLayoutItem Caption="Address" ColSpanMd="12"&gt;
            &lt;LayoutItemNestedControlCollection&gt;
                &lt;dx:LayoutItemNestedControlContainer&gt;
                    &lt;dx:BootstrapTextBox runat="server" ID="TextBox5" Text="Kirchgasse 6" /&gt;
                &lt;/dx:LayoutItemNestedControlContainer&gt;
            &lt;/LayoutItemNestedControlCollection&gt;
        &lt;/dx:BootstrapLayoutItem&gt;
        &lt;dx:BootstrapLayoutItem Caption="Note" ColSpanMd="12"&gt;
            &lt;LayoutItemNestedControlCollection&gt;
                &lt;dx:LayoutItemNestedControlContainer&gt;
                    &lt;dx:BootstrapMemo runat="server" ID="Memo1" Height="100px"
                        Text="Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association." /&gt;
                &lt;/dx:LayoutItemNestedControlContainer&gt;
            &lt;/LayoutItemNestedControlCollection&gt;
        &lt;/dx:BootstrapLayoutItem&gt;
        &lt;dx:BootstrapLayoutItem ColSpanMd="12" ShowCaption="False" HorizontalAlign="Right"&gt;
            &lt;LayoutItemNestedControlCollection&gt;
                &lt;dx:LayoutItemNestedControlContainer&gt;
                    &lt;dx:BootstrapButton ID="Button1" runat="server" Text="Submit" RenderOption="Primary" /&gt;
                    &lt;dx:BootstrapButton ID="Button2" runat="server" Text="Cancel" RenderOption="Link" AutoPostBack="false"&gt;
                        &lt;ClientSideEvents Click="function(s, e) { document.location.reload(); }" /&gt;
                    &lt;/dx:BootstrapButton&gt;
                &lt;/dx:LayoutItemNestedControlContainer&gt;
            &lt;/LayoutItemNestedControlCollection&gt;
        &lt;/dx:BootstrapLayoutItem&gt;
    &lt;/Items&gt;
&lt;/dx:BootstrapFormLayout&gt;</CodeASPX>
    </demo:DemoItem>
</asp:Content>
