<%@ Page Title="ARC Reports - Market Share Graphs" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="MarketShareGraph.aspx.cs" Inherits="ARC.Reports.Pages.MarketShareGraph" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Src="~/Controls/MarketShareGraphs_H.ascx" TagName="MarketShareGraphs_H" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketShareGraphs_D.ascx" TagName="MarketShareGraphs_D" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketShareGraphs_M.ascx" TagName="MarketShareGraphs_M" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketShareGraphs_Y.ascx" TagName="MarketShareGraphs_Y" TagPrefix="em" %>

<%@ Register Src="~/Controls/MarketTradeGraphs_H.ascx" TagName="MarketTradeGraphs_H" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketTradeGraphs_D.ascx" TagName="MarketTradeGraphs_D" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketTradeGraphs_M.ascx" TagName="MarketTradeGraphs_M" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketTradeGraphs_Y.ascx" TagName="MarketTradeGraphs_Y" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketChannelsGraphs_D.ascx" TagName="MarketChannelsGraphs_D" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketChannelsGraphs_M.ascx" TagName="MarketChannelsGraphs_M" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketChannelsGraphs_Y.ascx" TagName="MarketChannelsGraphs_Y" TagPrefix="em" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #MainContent_ASPxLabel1 {
            text-align: right;
            padding-top: 3px;
        }

        #MainContent_ASPxPageControl1_TPTCL_myOption_0 {
            float: right;
            margin-right: 40px
        }

        #MainContent_ASPxPageControl1_TPTCL_Type_0
        {
            float: right;
            margin-right: 40px;
        }

        #MainContent_ASPxPageControl1_TPTCL_lblType_0 {
            float: right;
            margin-top: 4px;
            margin-right: 5px;
        }
    </style>
    <script>
        $(document).ready(function () {
            $(function () {
                $("#sidebar > ul > li > ul:nth-child(3) > li > ul > li:nth-child(3)").addClass("active");
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h4 class="header smaller lighter blue strong">Market Share Graphs</h4>
    <div class="row">
        <div class="col-xs-6 col-sm-4 col-md-12 col-lg-12">
            <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" Theme="DevEx" Width="100%" ActiveTabIndex="0" EnableTheming="True" OnTabClick="ASPxPageControl1_TabClick" Style="direction: ltr">
                <TabPages>
                    <dx:TabPage Text="Main Market">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <em:MarketShareGraphs_H id="MarketShareGraphs_H_0" runat="server" />
                                <em:MarketShareGraphs_D id="MarketShareGraphs_D_0" runat="server" />
                                <em:MarketShareGraphs_M id="MarketShareGraphs_M_0" runat="server" />
                                <em:MarketShareGraphs_Y id="MarketShareGraphs_Y_0" runat="server" />

                                <em:MarketTradeGraphs_H ID="MarketTradeGraphs_H_0" runat="server" />
                                <em:MarketTradeGraphs_D ID="MarketTradeGraphs_D_0" runat="server" />
                                <em:MarketTradeGraphs_M ID="MarketTradeGraphs_M_0" runat="server" />
                                <em:MarketTradeGraphs_Y ID="MarketTradeGraphs_Y_0" runat="server" />

                                <em:MarketChannelsGraphs_D ID="MarketChannelsGraphs_D_0" runat="server" />
                                <em:MarketChannelsGraphs_M ID="MarketChannelsGraphs_M_0" runat="server" />
                                <em:MarketChannelsGraphs_Y ID="MarketChannelsGraphs_Y_0" runat="server" />
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                    <dx:TabPage Text="Nomu Market">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl2" runat="server">
                                <em:MarketShareGraphs_H id="MarketShareGraphs_H_1" runat="server" />
                                <em:MarketShareGraphs_D id="MarketShareGraphs_D_1" runat="server" />
                                <em:MarketShareGraphs_M id="MarketShareGraphs_M_1" runat="server" />
                                <em:MarketShareGraphs_Y id="MarketShareGraphs_Y_1" runat="server" />

                                <em:MarketTradeGraphs_H ID="MarketTradeGraphs_H_1" runat="server" />
                                <em:MarketTradeGraphs_D ID="MarketTradeGraphs_D_1" runat="server" />
                                <em:MarketTradeGraphs_M ID="MarketTradeGraphs_M_1" runat="server" />
                                <em:MarketTradeGraphs_Y ID="MarketTradeGraphs_Y_1" runat="server" />
                                
                                <em:MarketChannelsGraphs_D ID="MarketChannelsGraphs_D_1" runat="server" />
                                <em:MarketChannelsGraphs_M ID="MarketChannelsGraphs_M_1" runat="server" />
                                <em:MarketChannelsGraphs_Y ID="MarketChannelsGraphs_Y_1" runat="server" />
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                </TabPages>
                <SpaceAfterTabsTemplate>
                    <dx:ASPxComboBox ID="myOption" runat="server" EnableTheming="True" SelectedIndex="0" Theme="DevEx" AutoPostBack="True" OnValueChanged="myOption_ValueChanged">
                        <Items>
                            <dx:ListEditItem Text="1 Day" Value="0" Selected="True" />
                            <dx:ListEditItem Text="5 Days" Value="1" />
                            <dx:ListEditItem Text="30 Days" Value="2" />
                            <dx:ListEditItem Text="1 Year" Value="3" />
                        </Items>
                    </dx:ASPxComboBox>
                    <asp:Label ID="lblType" runat="server" Text="Type:"></asp:Label>
                    <dx:ASPxComboBox ID="Type" runat="server" EnableTheming="True" SelectedIndex="0" Theme="DevEx" AutoPostBack="True" OnValueChanged="Type_ValueChanged">
                        <Items>
                            <dx:ListEditItem Text="Market Share Value" Value="Market Share" Selected="True"></dx:ListEditItem>
                            <dx:ListEditItem Text="Market Share Trade" Value="Market Value"></dx:ListEditItem>
                            <dx:ListEditItem Text="Market Share Channels" Value="Channels"></dx:ListEditItem>
                        </Items>
                    </dx:ASPxComboBox>
                </SpaceAfterTabsTemplate>
            </dx:ASPxPageControl>
            <%--            <dx:ASPxTimer ID="ASPxTimer1" runat="server" Interval="3000">
                <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxPageControl1_MarketShareGraphs_H_0_WebChartControl0.PerformCallback();
                MainContent_ASPxPageControl1_MarketShareGraphs_H_1_WebChartControl0.PerformCallback();
                }" />
            </dx:ASPxTimer>
            <dx:ASPxTimer ID="ASPxTimer2" runat="server" Interval="600000">
                <ClientSideEvents Tick="function(s, e) { 
                Chart_1.PerformCallback();
                Chart_2.PerformCallback();
                Chart_3.PerformCallback();
                Chart_5.PerformCallback();
                Chart_6.PerformCallback();
                Chart_7.PerformCallback();
                }" />
            </dx:ASPxTimer>--%>
        </div>
    </div>
</asp:Content>
