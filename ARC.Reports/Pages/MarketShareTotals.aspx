<%@ Page Title="ARC Reports - Market Share Totals" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MarketShareTotals.aspx.cs" Inherits="ARC.Reports.MarketShareTotals" %>

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
                                    <%--<Settings ShowFooter="True" />--%>
                                </dx:ASPxGridView>
                                <br />
                                <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Export To Excel" OnClick="ASPxButton1_Click" Theme="DevEx">
                                </dx:ASPxButton>
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
                }" />
            </dx:ASPxTimer>
        </div>
        <dx:ASPxGridViewExporter ID="gridExport_0" runat="server" GridViewID="ASPxGridView0" FileName="Market Share Totals Main"></dx:ASPxGridViewExporter>
        <dx:ASPxGridViewExporter ID="gridExport_1" runat="server" GridViewID="ASPxGridView1" FileName="Market Share Totals Nomu"></dx:ASPxGridViewExporter>
    </div>
</asp:Content>
