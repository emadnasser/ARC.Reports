<%@ Page Title="ARC Reports - Market Share Totals" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="~/Pages/MarketShareTotals.aspx.cs" Inherits="ARC.Reports.Pages.MarketShareTotals" %>

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
    </style>
    <script>
        $(document).ready(function () {
            $(function () {
                $("#sidebar > ul > li > ul > li > ul > li:nth-child(1)").addClass("active");
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h4 class="header smaller lighter blue strong">Market Share Totals</h4>
    <div class="row">
        <div class="col-xs-6 col-sm-4 col-md-12 col-lg-12">
            <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" Theme="DevEx" Width="100%" ActiveTabIndex="0" EnableTheming="True" OnTabClick="ASPxPageControl1_TabClick">
                <TabPages>
                    <dx:TabPage Text="Main Market">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <dx:ASPxGridView ID="ASPxGridView0" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback" KeyFieldName="Id">
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="s0" VisibleIndex="0" Caption="Channel">
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
                                <br />

                                <dx:ASPxGridView ID="ASPxGridView6" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="false" KeyFieldName="Id">
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="Channel" VisibleIndex="0" Caption="Channel" FixedStyle="Left">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewBandColumn Caption="Jan" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_1" VisibleIndex="1" Caption="Shares">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_1" VisibleIndex="2" Caption="Trades">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Feb" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_2" VisibleIndex="3" Caption="Shares">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_2" VisibleIndex="4" Caption="Trades">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Mar" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_3" VisibleIndex="5" Caption="Shares">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_3" VisibleIndex="6" Caption="Trades">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Apr" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_4" VisibleIndex="7" Caption="Shares">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_4" VisibleIndex="8" Caption="Trades">
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
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_5" VisibleIndex="10" Caption="Trades">
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
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_6" VisibleIndex="12" Caption="Trades">
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
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_7" VisibleIndex="3" Caption="Trades">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Aug" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_8" VisibleIndex="14" Caption="Shares">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_8" VisibleIndex="15" Caption="Trades">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Sep" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_9" VisibleIndex="16" Caption="Shares">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_9" VisibleIndex="17" Caption="Trades">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Oct" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_10" VisibleIndex="18" Caption="Shares">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_10" VisibleIndex="19" Caption="Trades">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Nov" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_11" VisibleIndex="20" Caption="Shares">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_11" VisibleIndex="21" Caption="Trades">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                        <dx:GridViewBandColumn Caption="Dec" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="MarketShare_12" VisibleIndex="22" Caption="Shares">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="MarketTrades_12" VisibleIndex="23" Caption="Trades">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                                    <CellStyle HorizontalAlign="Center" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:GridViewBandColumn>
                                    </Columns>
                                    <Styles>
                                        <FixedColumn BackColor="LightYellow"></FixedColumn>
                                    </Styles>
                                    <SettingsPager Mode="ShowAllRecords" />
                                    <SettingsBehavior AllowSort="False" SortMode="DisplayText" />
                                    <SettingsBehavior AutoExpandAllGroups="true" />
                                </dx:ASPxGridView>
                                <br />
                                <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Export To Excel" OnClick="ASPxButton1_Click" Theme="DevEx">
                                </dx:ASPxButton>
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
                                        <dx:GridViewDataColumn FieldName="Market_Share_Value" VisibleIndex="4" Caption="Market Share Value">
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
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                    <dx:TabPage Text="Nomu Market">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl2" runat="server">
                                <dx:ASPxGridView ID="ASPxGridView1" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback">
                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="s0" VisibleIndex="0" Caption="Channel">
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
                                <br />
                                <dx:ASPxButton ID="ASPxButton2" runat="server" Text="Export To Excel" OnClick="ASPxButton2_Click" Theme="DevEx">
                                </dx:ASPxButton>
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
                                        <dx:GridViewDataColumn FieldName="Market_Share_Value" VisibleIndex="4" Caption="Market Share Value">
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
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                </TabPages>
                <SpaceAfterTabsTemplate>
                    <asp:Label ID="lblType" runat="server" Text="Type:"></asp:Label>
                    <dx:ASPxComboBox ID="myOption" runat="server" EnableTheming="True" SelectedIndex="0" Theme="DevEx" AutoPostBack="True" OnValueChanged="myOption_ValueChanged">
                        <Items>
                            <dx:ListEditItem Text="Daily" Value="0" Selected="True" />
                            <dx:ListEditItem Text="Monthly" Value="1" />
                            <dx:ListEditItem Text="Yearly" Value="2" />
                        </Items>
                    </dx:ASPxComboBox>

                    <asp:Label ID="lblDate" runat="server" Text="Date:"></asp:Label>
                    <dx:ASPxDateEdit ID="dateEdit" runat="server" EditFormat="Custom" UseMaskBehavior="True" EnableTheming="True" Theme="DevEx" AutoPostBack="True" OnValueChanged="dateEdit_ValueChanged" CalendarProperties-ShowClearButton="false" />
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
        </div>
        <dx:ASPxGridViewExporter ID="gridExport_0" runat="server" GridViewID="ASPxGridView0" FileName="Market Share Totals Main"></dx:ASPxGridViewExporter>
        <dx:ASPxGridViewExporter ID="gridExport_1" runat="server" GridViewID="ASPxGridView1" FileName="Market Share Totals Nomu"></dx:ASPxGridViewExporter>
    </div>
</asp:Content>
