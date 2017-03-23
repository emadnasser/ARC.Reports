<%@ Page Title="ARC Reports - Market Share Details" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MarketShareDetails.aspx.cs" Inherits="ARC.Reports.MarketShareDetails" %>

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
         
        #MainContent_ASPxPageControl1_TPTCL_Label1_0 {
            float: right;
            margin-top: 4px;
            margin-right: 5px;
        }
    </style>
    <script>
        $(document).ready(function () {
            $(function () {
                $("#sidebar > ul > li > ul > li > ul > li:nth-child(2)").addClass("active");
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h4 class="header smaller lighter blue strong">Market Share Details</h4>
    <div class="row">
        <div class="col-xs-6 col-sm-4 col-md-12 col-lg-12">
            <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" Theme="DevEx" Width="100%" ActiveTabIndex="0" EnableTheming="True" OnTabClick="ASPxPageControl1_TabClick">
                <TabPages>
                    <dx:TabPage Text="Main Market">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <dx:ASPxGridView ID="ASPxGridView0" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback" KeyFieldName="Id">
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" Visible="false">
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Channel" VisibleIndex="0">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Operation" VisibleIndex="1">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Amount" VisibleIndex="2" Caption="Trade Value">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Transactions" VisibleIndex="3" Caption="Trades Count">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Percentage" VisibleIndex="4" Caption="Trade Value Share">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="TradeShare" VisibleIndex="5" Caption="Trade Share">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="MarketType" Visible="false">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataDateColumn FieldName="InsertedDate" VisibleIndex="6" Caption="Date">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataDateColumn>
                                    </Columns>
                                    <SettingsBehavior AllowFixedGroups="true" AllowGroup="true" />
                                    <SettingsPager Mode="ShowAllRecords" />
                                    <SettingsBehavior AllowSort="False" SortMode="DisplayText" />
                                    <%--<Settings ShowFooter="True" />--%>
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
                                        <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" Visible="false">
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Channel" VisibleIndex="0">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Operation" VisibleIndex="1">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Amount" VisibleIndex="2" Caption="Trade Value">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Transactions" VisibleIndex="3" Caption="Trades Count">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Percentage" VisibleIndex="4" Caption="Trade Value Share">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="TradeShare" VisibleIndex="5" Caption="Trade Share">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="MarketType" Visible="false">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataDateColumn FieldName="InsertedDate" VisibleIndex="6" Caption="Date">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataDateColumn>
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
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn FieldName="Sell_Total_Ammount" VisibleIndex="2" Caption="Sell Total Trades">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn FieldName="ETS_Share_Value" VisibleIndex="3" Caption="ETS Share Trades">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn FieldName="Market_Share_Value" VisibleIndex="4" Caption="Market Share Trades">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                            <CellStyle HorizontalAlign="Center">
                                            </CellStyle>
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn FieldName="Percentage" VisibleIndex="5" Caption="%">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
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
                    <dx:ASPxDateEdit ID="dateEdit" runat="server" EditFormat="Custom" UseMaskBehavior="True" EnableTheming="True" Theme="DevEx" AutoPostBack="true" OnValueChanged="dateEdit_ValueChanged" CalendarProperties-ShowClearButton="false" />
                    <asp:Label ID="Label1" runat="server" Text="Date:"></asp:Label>
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
        <dx:ASPxGridViewExporter ID="gridExport_0" runat="server" GridViewID="ASPxGridView0" FileName="Market Share Main"></dx:ASPxGridViewExporter>
        <dx:ASPxGridViewExporter ID="gridExport_1" runat="server" GridViewID="ASPxGridView1" FileName="Market Share Nomu"></dx:ASPxGridViewExporter>
    </div>
</asp:Content>
