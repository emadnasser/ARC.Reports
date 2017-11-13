<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="RightToLeft.aspx.cs" Inherits="Common_RightToLeft" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div dir="rtl" style="text-align: right">
        <div style="padding-bottom: 10px;">
            <dx:ASPxMenu ID="ASPxMenu1" runat="server" RenderIFrameForPopupElements="Default"
                ShowPopOutImages="Default" RightToLeft="True" AllowSelectItem="true">
                <Items>
                    <dx:MenuItem Text="Downloads">
                    </dx:MenuItem>
                    <dx:MenuItem Text="Purchase">
                        <Items>
                            <dx:MenuItem Text="Purchase Products and Upgrades">
                            </dx:MenuItem>
                            <dx:MenuItem Text="Purchase History">
                            </dx:MenuItem>
                            <dx:MenuItem Text="Manage and Assign Licenses">
                            </dx:MenuItem>
                        </Items>
                    </dx:MenuItem>
                    <dx:MenuItem Text="Help &amp; Support">
                        <Items>
                            <dx:MenuItem Text="Search Our Knowledge Base">
                            </dx:MenuItem>
                            <dx:MenuItem Text="Ask a Question">
                            </dx:MenuItem>
                            <dx:MenuItem Text="Report an Issue">
                            </dx:MenuItem>
                            <dx:MenuItem Text="Make a Suggestion">
                            </dx:MenuItem>
                            <dx:MenuItem Text="Your Issues">
                            </dx:MenuItem>
                        </Items>
                    </dx:MenuItem>
                    <dx:MenuItem Text="About Us">
                        <Items>
                            <dx:MenuItem Text="Case Studies">
                            </dx:MenuItem>
                            <dx:MenuItem Text="User Comments">
                            </dx:MenuItem>
                            <dx:MenuItem Text="Reviews and Publications">
                            </dx:MenuItem>
                            <dx:MenuItem Text="Our Awards">
                            </dx:MenuItem>
                        </Items>
                    </dx:MenuItem>
                </Items>
            </dx:ASPxMenu>
        </div>
        <div style="padding-top: 8px">
            <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" Width="100%" RightToLeft="True"
                ActiveTabIndex="0">
                <TabPages>
                    <dx:TabPage Text="Overview">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                DevExpress engineers feature-complete Presentation Controls, IDE Productivity Tools,
                                Business Application Frameworks, and Reporting Systems for Visual Studio. Whether
                                using WPF, Silverlight, ASP.NET or WinForms, DevExpress tools help you build and
                                deliver your best in the shortest time possible.
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                    <dx:TabPage Text="Help">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl2" runat="server">
                                The goal of the Developer Express Support Team is to provide our customers unrivaled
                                technical assistance when implementing DevExpress technologies. We are committed
                                to total customer satisfaction after purchase and will stop at nothing to ensure
                                that your experience using our products is profitable for you, your organization,
                                and by extension – your customers.
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                </TabPages>
            </dx:ASPxPageControl>
        </div>
    </div>
    <script type="text/javascript">
        if(ASPxClientUtils.ie && ASPxClientUtils.browserVersion > 7 && document.body.offsetWidth % 2 > 0)
            document.body.style.width = (document.body.offsetWidth - 1) + "px";
    </script>
</asp:Content>
