<%@ Page Title="ARC Reports - Market Share Totals" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="_MarketShareTotals.aspx.cs" Inherits="ARC.Reports.Pages._MarketShareTotals" %>

<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

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
            <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" Theme="DevEx" Width="100%" ActiveTabIndex="0" EnableTheming="True" OnTabClick="ASPxPageControl1_TabClick" OnActiveTabChanged="ASPxPageControl1_ActiveTabChanged">
                <TabPages>
                    <dx:TabPage Text="Main Market">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <dx:ASPxGridView ID="ASPxGridView0" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback" KeyFieldName="Id">
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="s0" VisibleIndex="0" Caption="Channel" CellStyle-BackColor="#f5f7fa">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="s1" VisibleIndex="1" Caption="Trades Value">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="s3" VisibleIndex="3" Caption="Trade Value Share">
                                            <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="s2" VisibleIndex="2" Caption="Trades Count">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="s4" VisibleIndex="4" Caption="Trade Share">
                                            <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                    </Columns>
                                    <SettingsBehavior AllowFixedGroups="true" AllowGroup="true" />
                                    <SettingsPager Mode="ShowAllRecords" />
                                    <SettingsBehavior AllowSort="false" SortMode="DisplayText" />
                                </dx:ASPxGridView>
                                <dx:ASPxGridView ID="ASPxGridView6" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="false" OnCustomCallback="ASPxGridViews_CustomCallback" KeyFieldName="Channel" Settings-ShowFooter="true" OnCustomSummaryCalculate="ASPxGridView6_CustomSummaryCalculate">
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="Channel" VisibleIndex="0" Caption="Channel" FixedStyle="Left">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewBandColumn Name="_1" Caption="Jan" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_1" VisibleIndex="1" Caption="Shares" UnboundType="String">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_1" VisibleIndex="2" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_2" Caption="Feb" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_2" VisibleIndex="3" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_2" VisibleIndex="4" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_3" Caption="Mar" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_3" VisibleIndex="5" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_3" VisibleIndex="6" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_4" Caption="Apr" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_4" VisibleIndex="7" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_4" VisibleIndex="8" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="May" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_5" VisibleIndex="9" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_5" VisibleIndex="10" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Jun" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_6" VisibleIndex="11" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_6" VisibleIndex="12" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Jul" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_7" VisibleIndex="13" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_7" VisibleIndex="14" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Aug" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_8" VisibleIndex="15" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_8" VisibleIndex="16" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Sep" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_9" VisibleIndex="17" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_9" VisibleIndex="18" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Oct" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_10" VisibleIndex="19" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_10" VisibleIndex="20" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Nov" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_11" VisibleIndex="21" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_11" VisibleIndex="22" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Dec" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_12" VisibleIndex="23" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_12" VisibleIndex="24" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_13" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_13" VisibleIndex="25" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_13" VisibleIndex="26" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                    </Columns>
                                    <TotalSummary>
                                        <dx:ASPxSummaryItem FieldName="Channel" SummaryType="Sum" DisplayFormat="Average{0}" ShowInColumn="Channel" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s1" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_1" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t1" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_1" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s2" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_2" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t2" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_2" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s3" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_3" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t3" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_3" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s4" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_4" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t4" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_4" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s5" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_5" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t5" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_5" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s6" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_6" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t6" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_6" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s7" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_7" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t7" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_7" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s8" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_8" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t8" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_8" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s9" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_9" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t9" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_9" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s10" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_10" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t10" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_10" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s11" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_11" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t11" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_11" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s12" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_12" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t12" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_12" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s13" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_13" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t13" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_13" />
                                    </TotalSummary>
                                    <Styles>
                                        <Footer HorizontalAlign="Center" VerticalAlign="Middle">
                                        </Footer>
                                        <FixedColumn BackColor="#f5f7fa"></FixedColumn>
                                    </Styles>
                                    <%--<ClientSideEvents ColumnSorting="function(s, e) {MainContent_ASPxPageControl1_ASPxGridView6.PerformCallback();}" />--%>
                                    <SettingsPager Mode="ShowAllRecords" />

                                    <Settings ShowFooter="True"></Settings>

                                    <SettingsBehavior AllowSort="true" SortMode="Value" />
                                </dx:ASPxGridView>
                                <dx:ASPxGridView ID="ASPxGridView8" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback" KeyFieldName="Id" Settings-ShowFooter="true">
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="Channel" VisibleIndex="0" Caption="Channel" FixedStyle="Left" SortOrder="Ascending">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewBandColumn Name="_1" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_1" VisibleIndex="1" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_1" VisibleIndex="2" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_2" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_2" VisibleIndex="3" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_2" VisibleIndex="4" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_3" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_3" VisibleIndex="5" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_3" VisibleIndex="6" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                    </Columns>
                                    <TotalSummary>
                                        <dx:ASPxSummaryItem FieldName="Channel" SummaryType="Sum" DisplayFormat="Average{0}" ShowInColumn="Channel" />
                                        <dx:ASPxSummaryItem FieldName="MarketShare_1" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketShare_1" />
                                        <dx:ASPxSummaryItem FieldName="MarketTrades_1" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketTrades_1" />
                                        <dx:ASPxSummaryItem FieldName="MarketShare_2" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketShare_2" />
                                        <dx:ASPxSummaryItem FieldName="MarketTrades_2" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketTrades_2" />
                                        <dx:ASPxSummaryItem FieldName="MarketShare_3" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketShare_3" />
                                        <dx:ASPxSummaryItem FieldName="MarketTrades_3" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketTrades_3" />
                                    </TotalSummary>
                                    <Styles>
                                        <Footer HorizontalAlign="Center" VerticalAlign="Middle">
                                        </Footer>
                                        <FixedColumn BackColor="#f5f7fa"></FixedColumn>
                                    </Styles>
                                    <SettingsPager Mode="ShowAllRecords" />
                                    <Settings ShowFooter="True"></Settings>
                                    <SettingsBehavior AutoExpandAllGroups="true" />
                                    <SettingsBehavior AllowSort="true" SortMode="Value" />
                                </dx:ASPxGridView>
                                <br />
                                <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Export To Excel" OnClick="ASPxButton1_Click" Theme="DevEx">
                                </dx:ASPxButton>
                                <asp:Panel ID="pnlLastGrids_1" runat="server">
                                    <div class="hr hr-18 dotted hr-double" runat="server"></div>
                                    <br />
                                    <dx:ASPxGridView ID="ASPxGridView2" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback">
                                        <Columns>
                                            <dx:GridViewDataColumn FieldName="Buy_Total_Ammount" VisibleIndex="1" Caption="Buy Total Value">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Sell_Total_Ammount" VisibleIndex="2" Caption="Sell Total Value">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="ETS_Share_Value" VisibleIndex="3" Caption="ETS Share Value">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Market_Share_Index" VisibleIndex="4" Caption="Index">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="DiffDayNom" VisibleIndex="5" Caption="Change">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Market_Share_Value" VisibleIndex="6" Caption="Market Share Value">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Percentage" VisibleIndex="7" Caption="%">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                        </Columns>
                                        <SettingsPager Visible="False">
                                        </SettingsPager>
                                        <SettingsBehavior AllowSort="False" SortMode="DisplayText" />
                                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                        <EditFormLayoutProperties ColCount="2">
                                        </EditFormLayoutProperties>
                                    </dx:ASPxGridView>
                                    <div class="hr hr-18 dotted hr-double" runat="server"></div>
                                    <br />
                                    <dx:ASPxGridView ID="ASPxGridView4" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback">
                                        <Columns>
                                            <dx:GridViewDataColumn FieldName="Buy_Total_Ammount" VisibleIndex="1" Caption="Buy Total Trades">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Sell_Total_Ammount" VisibleIndex="2" Caption="Sell Total Trades">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="ETS_Share_Value" VisibleIndex="3" Caption="ETS Share Trades">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Market_Share_Value" VisibleIndex="4" Caption="Market Share Trades">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Percentage" VisibleIndex="5" Caption="%">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                        </Columns>
                                        <SettingsPager Visible="False">
                                        </SettingsPager>
                                        <SettingsBehavior AllowSort="False" SortMode="DisplayText" />
                                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                        <EditFormLayoutProperties ColCount="2">
                                        </EditFormLayoutProperties>
                                    </dx:ASPxGridView>
                                </asp:Panel>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                    <dx:TabPage Text="Nomu Market">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl2" runat="server">
                                <dx:ASPxGridView ID="ASPxGridView1" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="false" OnCustomCallback="ASPxGridViews_CustomCallback" KeyFieldName="Id">
                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="s0" VisibleIndex="0" Caption="Channel" CellStyle-BackColor="#f5f7fa">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="s1" VisibleIndex="1" Caption="Trades Value">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="s3" VisibleIndex="3" Caption="Trade Value Share">
                                            <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="s2" VisibleIndex="2" Caption="Trades Count">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="s4" VisibleIndex="4" Caption="Trade Share">
                                            <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                    </Columns>
                                    <SettingsBehavior AllowFixedGroups="true" AllowGroup="true" />
                                    <SettingsPager Mode="ShowAllRecords" />
                                    <SettingsBehavior AllowSort="False" SortMode="DisplayText" />
                                </dx:ASPxGridView>
                                <dx:ASPxGridView ID="ASPxGridView7" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="false" OnCustomCallback="ASPxGridViews_CustomCallback" KeyFieldName="Id" Settings-ShowFooter="true" OnCustomSummaryCalculate="ASPxGridView7_CustomSummaryCalculate" >
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="Channel" VisibleIndex="0" Caption="Channel" FixedStyle="Left">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewBandColumn Name="_1" Caption="Jan" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_1" VisibleIndex="1" Caption="Shares">
                                                    <PropertiesTextEdit></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_1" VisibleIndex="2" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_2" Caption="Feb" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_2" VisibleIndex="3" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_2" VisibleIndex="4" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_3" Caption="Mar" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_3" VisibleIndex="5" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_3" VisibleIndex="6" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_4" Caption="Apr" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_4" VisibleIndex="7" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_4" VisibleIndex="8" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="May" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_5" VisibleIndex="9" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_5" VisibleIndex="10" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Jun" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_6" VisibleIndex="11" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_6" VisibleIndex="12" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Jul" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_7" VisibleIndex="13" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_7" VisibleIndex="14" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Aug" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_8" VisibleIndex="15" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_8" VisibleIndex="16" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Sep" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_9" VisibleIndex="17" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_9" VisibleIndex="18" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Oct" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_10" VisibleIndex="19" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_10" VisibleIndex="20" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Nov" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_11" VisibleIndex="21" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_11" VisibleIndex="22" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Dec" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_12" VisibleIndex="23" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_12" VisibleIndex="24" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_13" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_13" VisibleIndex="25" Caption="Shares" >
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_13" VisibleIndex="26" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%" ></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                    </Columns>
                                    <TotalSummary>
                                        <dx:ASPxSummaryItem FieldName="Channel" SummaryType="Sum" DisplayFormat="Average{0}" ShowInColumn="Channel" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s1" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_1" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t1" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_1" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s2" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_2" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t2" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_2" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s3" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_3" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t3" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_3" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s4" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_4" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t4" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_4" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s5" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_5" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t5" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_5" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s6" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_6" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t6" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_6" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s7" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_7" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t7" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_7" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s8" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_8" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t8" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_8" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s9" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_9" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t9" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_9" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s10" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_10" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t10" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_10" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s11" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_11" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t11" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_11" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s12" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_12" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t12" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_12" />
                                        <dx:ASPxSummaryItem FieldName="Sm_s13" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketShare_13" />
                                        <dx:ASPxSummaryItem FieldName="Sm_t13" SummaryType="Custom" DisplayFormat="{0}%" ShowInColumn="MarketTrades_13" />
                                    </TotalSummary>
                                    <Styles>
                                        <Footer HorizontalAlign="Center" VerticalAlign="Middle">
                                        </Footer>
                                        <FixedColumn BackColor="#f5f7fa"></FixedColumn>
                                    </Styles>
                                    <SettingsPager Mode="ShowAllRecords" />
                                    <Settings ShowFooter="True"></Settings>
                                    <SettingsBehavior AutoExpandAllGroups="true" />
                                    <SettingsBehavior AllowSort="true" SortMode="Value" />
                                    
                                </dx:ASPxGridView>
                                <dx:ASPxGridView ID="ASPxGridView9" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="true" OnCustomCallback="ASPxGridViews_CustomCallback" KeyFieldName="Id" Settings-ShowFooter="true">
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="Channel" VisibleIndex="0" Caption="Channel" FixedStyle="Left">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewBandColumn Name="_1" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_1" VisibleIndex="1" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_1" VisibleIndex="2" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_2" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_2" VisibleIndex="3" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_2" VisibleIndex="4" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Name="_3" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_3" VisibleIndex="5" Caption="Shares">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                                                    <footercellstyle backcolor="#D7DCEA">
                                                    </footercellstyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_3" VisibleIndex="6" Caption="Trades">
                                                    <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                    </Columns>
                                    <TotalSummary>
                                        <dx:ASPxSummaryItem FieldName="Channel" SummaryType="Sum" DisplayFormat="Average{0}" ShowInColumn="Channel" />
                                        <dx:ASPxSummaryItem FieldName="MarketShare_1" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketShare_1" />
                                        <dx:ASPxSummaryItem FieldName="MarketTrades_1" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketTrades_1" />
                                        <dx:ASPxSummaryItem FieldName="MarketShare_2" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketShare_2" />
                                        <dx:ASPxSummaryItem FieldName="MarketTrades_2" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketTrades_2" />
                                        <dx:ASPxSummaryItem FieldName="MarketShare_3" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketShare_3" />
                                        <dx:ASPxSummaryItem FieldName="MarketTrades_3" SummaryType="Sum" DisplayFormat="{0}%" ShowInColumn="MarketTrades_3" />
                                    </TotalSummary>
                                    <Styles>
                                        <Footer HorizontalAlign="Center" VerticalAlign="Middle">
                                        </Footer>
                                        <FixedColumn BackColor="#f5f7fa"></FixedColumn>
                                    </Styles>
                                    <SettingsPager Mode="ShowAllRecords" />
                                    <Settings ShowFooter="True"></Settings>
                                    <SettingsBehavior AutoExpandAllGroups="true" />
                                    <SettingsBehavior AllowSort="true" SortMode="Value" />
                                </dx:ASPxGridView>
                                <br />
                                <dx:ASPxButton ID="ASPxButton2" runat="server" Text="Export To Excel" OnClick="ASPxButton2_Click" Theme="DevEx">
                                </dx:ASPxButton>
                                <asp:Panel ID="pnlLastGrids_2" runat="server">
                                    <div class="hr hr-18 dotted hr-double" runat="server"></div>
                                    <br />
                                    <dx:ASPxGridView ID="ASPxGridView3" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback">
                                        <Columns>
                                            <dx:GridViewDataColumn FieldName="Buy_Total_Ammount" VisibleIndex="1" Caption="Buy Total Value">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Sell_Total_Ammount" VisibleIndex="2" Caption="Sell Total Value">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="ETS_Share_Value" VisibleIndex="3" Caption="ETS Share Value">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Market_Share_Index" VisibleIndex="4" Caption="Index">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="DiffDayNom" VisibleIndex="5" Caption="Change">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Market_Share_Value" VisibleIndex="6" Caption="Market Share Value">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Percentage" VisibleIndex="7" Caption="%">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                        </Columns>
                                        <SettingsPager Visible="False">
                                        </SettingsPager>
                                        <SettingsBehavior AllowSort="False" SortMode="DisplayText" />
                                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                        <EditFormLayoutProperties ColCount="2">
                                        </EditFormLayoutProperties>
                                    </dx:ASPxGridView>
                                    <div class="hr hr-18 dotted hr-double" runat="server"></div>
                                    <br />
                                    <dx:ASPxGridView ID="ASPxGridView5" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback">
                                        <Columns>
                                            <dx:GridViewDataColumn FieldName="Buy_Total_Ammount" VisibleIndex="1" Caption="Buy Total Trades">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Sell_Total_Ammount" VisibleIndex="2" Caption="Sell Total Trades">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="ETS_Share_Value" VisibleIndex="3" Caption="ETS Share Trades">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Market_Share_Value" VisibleIndex="4" Caption="Market Share Trades">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                            <dx:GridViewDataColumn FieldName="Percentage" VisibleIndex="5" Caption="%">
                                                <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataColumn>
                                        </Columns>
                                        <SettingsPager Visible="False">
                                        </SettingsPager>
                                        <SettingsBehavior AllowSort="False" SortMode="DisplayText" />
                                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                        <EditFormLayoutProperties ColCount="2">
                                        </EditFormLayoutProperties>
                                    </dx:ASPxGridView>
                                </asp:Panel>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                </TabPages>
                <SpaceAfterTabsTemplate>
                    <dx:ASPxDateEdit ID="dateEdit" runat="server" EditFormat="Custom" UseMaskBehavior="True" EnableTheming="True" Theme="DevEx" AutoPostBack="True" OnValueChanged="dateEdit_ValueChanged" CalendarProperties-ShowClearButton="false" />
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
            <dx:ASPxTimer ID="ASPxTimer1" runat="server" Interval="10000">
                <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxPageControl1_ASPxGridView0.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView1.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView2.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView3.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView4.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView5.PerformCallback();
                }" />
            </dx:ASPxTimer>
            <dx:ASPxTimer ID="ASPxTimer2" runat="server" Interval="10000" Enabled="false">
                <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxPageControl1_ASPxGridView6.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView7.PerformCallback();
                }" />
            </dx:ASPxTimer>
            <dx:ASPxTimer ID="ASPxTimer3" runat="server" Interval="10000" Enabled="false">
                <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxPageControl1_ASPxGridView8.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView9.PerformCallback();
                }" />
            </dx:ASPxTimer>
        </div>
        <dx:ASPxGridViewExporter ID="gridExport_0" runat="server" GridViewID="ASPxGridView0" FileName="Market Share Totals Main - Daily"></dx:ASPxGridViewExporter>
        <dx:ASPxGridViewExporter ID="gridExport_1" runat="server" GridViewID="ASPxGridView1" FileName="Market Share Totals Nomu - Daily"></dx:ASPxGridViewExporter>
        <dx:ASPxGridViewExporter ID="gridExport_2" runat="server" GridViewID="ASPxGridView6" FileName="Market Share Totals Main - Monthly"></dx:ASPxGridViewExporter>
        <dx:ASPxGridViewExporter ID="gridExport_3" runat="server" GridViewID="ASPxGridView7" FileName="Market Share Totals Nomu - Monthly"></dx:ASPxGridViewExporter>
        <dx:ASPxGridViewExporter ID="gridExport_4" runat="server" GridViewID="ASPxGridView8" FileName="Market Share Totals Main - Yearly"></dx:ASPxGridViewExporter>
        <dx:ASPxGridViewExporter ID="gridExport_5" runat="server" GridViewID="ASPxGridView9" FileName="Market Share Totals Nomu - Yearly"></dx:ASPxGridViewExporter>
    </div>
</asp:Content>
