<%@ Page Title="ARC Reports - Market Share Totals" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="MarketShareTotals2.aspx.cs" Inherits="ARC.Reports.Pages.MarketShareTotals2" %>

<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Src="~/Controls/MarketShareTotal_0MD.ascx" TagName="MarketShareTotal_0MD" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketShareTotal_1MM.ascx" TagName="MarketShareTotal_1MM" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketShareTotal_2MQ.ascx" TagName="MarketShareTotal_2MQ" TagPrefix="em" %>
<%@ Register Src="~/Controls/MarketShareTotal_3MY.ascx" TagName="MarketShareTotal_3MY" TagPrefix="em" %>

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
                                <em:MarketShareTotal_0MD ID="MarketShareTotal_0MD1" runat="server" />
                                <em:MarketShareTotal_1MM ID="MarketShareTotal_1MM" runat="server" />
                                <em:MarketShareTotal_2MQ ID="MarketShareTotal_2MQ" runat="server" />
                                <em:MarketShareTotal_3MY ID="MarketShareTotal_3MY" runat="server" />
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                    <dx:TabPage Text="Nomu Market" Name="1">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl2" runat="server">
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                </TabPages>
                <SpaceAfterTabsTemplate>
                    <dx:ASPxDateEdit ID="dateEdit" runat="server" UseMaskBehavior="True" EnableTheming="True" Theme="DevEx" AutoPostBack="True" OnValueChanged="dateEdit_ValueChanged" CalendarProperties-ShowClearButton="false" />
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

            <dx:ASPxDateEdit ID="ASPxDateEdit1" runat="server">
                <validationsettings display="Dynamic">
                </validationsettings>
            </dx:ASPxDateEdit>
            
        </div>
    </div>
</asp:Content>
