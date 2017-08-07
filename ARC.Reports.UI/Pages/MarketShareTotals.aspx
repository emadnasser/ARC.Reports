<%@ Page Title="ARC Reports - Market Share Totals" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="MarketShareTotals.aspx.cs" Inherits="ARC.Reports.Pages.MarketShareTotals" %>

<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Src="~/Controls/MarketShareTotal_0D.ascx" TagName="MarketShareTotal_0D" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketShareTotal_1M.ascx" TagName="MarketShareTotal_1M" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketShareTotal_2Q.ascx" TagName="MarketShareTotal_2Q" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketShareTotal_3Y.ascx" TagName="MarketShareTotal_3Y" TagPrefix="em" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #MainContent_ASPxLabel1 {
            text-align: right;
            padding-top: 3px;
        }

        #MainContent_ASPxPageControl1_TPTCL_dateEdit_0 {
            float: right;
            margin-right: 40px
        }

        #MainContent_ASPxPageControl1_TPTCL_myOption_0 {
            float: right;
            margin-right: 40px;
        }

        #MainContent_ASPxPageControl1_TPTCL_lblType_0 {
            float: right;
            margin-top: 4px;
            margin-right: 5px;
        }

        #MainContent_ASPxPageControl1_TPTCL_lblDate_0 {
            float: right;
            margin-top: 4px;
            margin-right: 5px;
        }

        .tblLast {
            background-color: #808080 !important;
            font-weight: bold;
            color: white;
        }

        .highVal {
            color: green;
        }

        .lowVal {
            color: red;
        }
    </style>
    <script>
        $(document).ready(function () {
            $(function () {
                $("#sidebar > ul > li > ul:nth-child(3) > li > ul > li:nth-child(1)").addClass("active");
            });
        });

        function OnColumnSorting(s, e) {
            if (e.column.fieldName == "Channel") {
                e.cancel = true;
                s.PerformCallback("Channel");
            }
            else if (e.column.fieldName == "MarketShare_1") {
                e.cancel = true;
                s.PerformCallback("MarketShare_1");
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h4 class="header smaller lighter blue strong">Market Share Totals</h4>
    <div class="row">
        <div class="col-xs-6 col-sm-4 col-md-12 col-lg-12">
            <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" Theme="DevEx" Width="100%" ActiveTabIndex="0" EnableTheming="True" OnTabClick="ASPxPageControl1_TabClick">
                <TabPages>
                    <dx:TabPage Text="Main Market" Name="0">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <em:MarketShareTotal_0D ID="MarketShareTotal_0D" Visible="false" runat="server" />
                                <em:MarketShareTotal_1M ID="MarketShareTotal_1M" Visible="false" runat="server" />
                                <em:MarketShareTotal_2Q ID="MarketShareTotal_2Q" Visible="false" runat="server" />
                                <em:MarketShareTotal_3Y ID="MarketShareTotal_3Y" Visible="false" runat="server" />
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                    <dx:TabPage Text="Nomu Market" Name="1">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl2" runat="server">
                                <em:MarketShareTotal_0D ID="MarketShareTotal_0D1" Visible="false" runat="server" />
                                <em:MarketShareTotal_1M ID="MarketShareTotal_1M1" Visible="false" runat="server" />
                                <em:MarketShareTotal_2Q ID="MarketShareTotal_2Q1" Visible="false" runat="server" />
                                <em:MarketShareTotal_3Y ID="MarketShareTotal_3Y1" Visible="false" runat="server" />
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                </TabPages>
                <SpaceAfterTabsTemplate>
                    <dx:ASPxDateEdit ID="dateEdit" runat="server" UseMaskBehavior="True" EnableTheming="True" Theme="DevEx" AutoPostBack="True" OnValueChanged="dateEdit_ValueChanged" CalendarProperties-ShowClearButton="false" CalendarProperties-ShowWeekNumbers="false" CalendarProperties-FirstDayOfWeek="Sunday" />
                    <asp:Label ID="lblDate" runat="server" Text="Date:"></asp:Label>
                    <dx:ASPxComboBox ID="myOption" runat="server" EnableTheming="True" SelectedIndex="0" Theme="DevEx" AutoPostBack="True" OnValueChanged="myOption_ValueChanged">
                        <Items>
                            <dx:ListEditItem Text="Daily" Value="0" Selected="True" />
                            <dx:ListEditItem Text="Monthly" Value="1" />
                            <dx:ListEditItem Text="Quarterly" Value="2" />
                            <dx:ListEditItem Text="Yearly" Value="3" />
                        </Items>
                    </dx:ASPxComboBox>
                    <asp:Label ID="lblType" runat="server" Text="Type:"></asp:Label>
                </SpaceAfterTabsTemplate>
            </dx:ASPxPageControl>
        </div>
    </div>
</asp:Content>
