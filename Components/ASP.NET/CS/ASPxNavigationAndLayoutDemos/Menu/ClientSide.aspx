<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSide.aspx.cs"
    Inherits="Menu_ClientSide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="height: 190px;">
        <dx:ASPxMenu ID="ASPxMenu1" runat="server" AllowSelectItem="True" EnableViewState="False"
            ShowPopOutImages="True">
            <ClientSideEvents CloseUp="function(s, e) { DXEventMonitor.Trace(s, e, 'CloseUp') }"
                PopUp="function(s, e) { DXEventMonitor.Trace(s, e, 'PopUp') }" Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init') }"
                ItemClick="function(s, e) { DXEventMonitor.Trace(s, e, 'ItemClick') }" ItemMouseOut="function(s, e) { DXEventMonitor.Trace(s, e, 'ItemMouseOut') }"
                ItemMouseOver="function(s, e) { DXEventMonitor.Trace(s, e, 'ItemMouseOver') }" />
            <Items>
                <dx:MenuItem Text="Home" Name="home">
                    <Items>
                        <dx:MenuItem Text="News" Name="news">
                        </dx:MenuItem>
                        <dx:MenuItem Text="Our Mission" Name="ourMission">
                        </dx:MenuItem>
                        <dx:MenuItem Text="Our Awards" Name="ourAwards">
                        </dx:MenuItem>
                        <dx:MenuItem Text="Our Customers" Name="ourCustomers">
                        </dx:MenuItem>
                    </Items>
                </dx:MenuItem>
                <dx:MenuItem Text="Products" Name="products">
                    <Items>
                        <dx:MenuItem Text="Subscriptions / Packs" Name="subscriptionsAndPacks">
                        </dx:MenuItem>
                        <dx:MenuItem Text=".NET Windows Forms Components" Name="windowsFormsComponents">
                        </dx:MenuItem>
                        <dx:MenuItem Text="Reporting / Printing Suites" Name="reportingAndPrintingSuites">
                        </dx:MenuItem>
                        <dx:MenuItem Text="VCL Components and Tools" Name="vclComponentsAndTools">
                        </dx:MenuItem>
                        <dx:MenuItem Text="ASP.NET Components" Name="aspComponents">
                        </dx:MenuItem>
                    </Items>
                </dx:MenuItem>
                <dx:MenuItem Text="Downloads" Name="downloads">
                    <Items>
                        <dx:MenuItem Text="Application Framework Libraries" Name="applicationFrameworkLibraries">
                        </dx:MenuItem>
                        <dx:MenuItem Text="IDE Productivity Tools" Name="ideProductivityTools">
                        </dx:MenuItem>
                        <dx:MenuItem Text="ActiveX / COM Technologies" Name="activeXAndCOMTechnologies">
                        </dx:MenuItem>
                    </Items>
                </dx:MenuItem>
                <dx:MenuItem Text="Support" Name="support">
                    <Items>
                        <dx:MenuItem Text="Knowledge Base" Name="knowledgeBase">
                        </dx:MenuItem>
                        <dx:MenuItem Text="Online Documentation" Name="onlineDocumentation">
                        </dx:MenuItem>
                        <dx:MenuItem Text="Support Center" Name="supportCenter">
                        </dx:MenuItem>
                        <dx:MenuItem Text="Community and Blogs" Name="communityAndBlogs">
                        </dx:MenuItem>
                        <dx:MenuItem Text="Newsgroups" Name="newsgroups">
                        </dx:MenuItem>
                        <dx:MenuItem Text="Best Practicies" Name="bestPracticies">
                        </dx:MenuItem>
                    </Items>
                </dx:MenuItem>
            </Items>
        </dx:ASPxMenu>
    </div>
    <dx:EventMonitor runat="server" ID="EventMonitor" EventNames="Init, ItemClick, PopUp, CloseUp, ItemMouseOver, ItemMouseOut" />
</asp:Content>
