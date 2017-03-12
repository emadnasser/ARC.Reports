<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="ARC.Reports.Report" %>

<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h1>Market Share Value:</h1>
    </div>
    <br />
    <div class="col-xs-6 col-sm-4 col-md-4 col-lg-12">

        <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" Theme="DevEx" Width="100%" ActiveTabIndex="0" EnableTheming="True" OnTabClick="ASPxPageControl1_TabClick">
            <TabPages>
                <dx:TabPage Text="Main Market">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <dx:ASPxGridView ID="ASPxGridView0" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback">
                                <Columns>
                                    <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" VisibleIndex="0" Visible="false">
                                        <HeaderStyle HorizontalAlign="Center" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Operation" VisibleIndex="2">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Channel" VisibleIndex="1">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Amount" VisibleIndex="3">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Transactions" VisibleIndex="4">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Percentage" VisibleIndex="5">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="MarketType" VisibleIndex="6" Visible="false">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataDateColumn FieldName="InsertedDate" VisibleIndex="7" Visible="false">
                                    </dx:GridViewDataDateColumn>
                                </Columns>
                                <SettingsBehavior AllowFixedGroups="true" AllowGroup="true" />
                                <SettingsPager Mode="ShowAllRecords" />
                                <SettingsBehavior AllowSort="False" SortMode="DisplayText" />
                            </dx:ASPxGridView>
                            <div class="hr hr-18 dotted hr-double" runat="server"></div>
                            <br />
                            <dx:ASPxGridView ID="ASPxGridView2" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback">
                                <Columns>
                                    <dx:GridViewDataColumn FieldName="Buy_Total_Ammount" VisibleIndex="1" Caption="Buy Total Ammount">
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataColumn>
                                    <dx:GridViewDataColumn FieldName="Sell_Total_Ammount" VisibleIndex="2" Caption="Sell Total Ammount">
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
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="Second Market">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <dx:ASPxGridView ID="ASPxGridView1" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback">
                                <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                <Columns>
                                    <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" VisibleIndex="0" Visible="false">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Operation" VisibleIndex="2">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Channel" VisibleIndex="1">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Amount" VisibleIndex="3">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Transactions" VisibleIndex="4">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Percentage" VisibleIndex="5">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="MarketType" VisibleIndex="6" Visible="false">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataDateColumn FieldName="InsertedDate" VisibleIndex="7" Visible="false">
                                    </dx:GridViewDataDateColumn>
                                </Columns>
                                <SettingsBehavior AllowFixedGroups="true" AllowGroup="true" />
                                <SettingsPager Mode="ShowAllRecords" />
                                <SettingsBehavior AllowSort="False" SortMode="DisplayText" />
                            </dx:ASPxGridView>
                            <div class="hr hr-18 dotted hr-double" runat="server"></div>
                            <br />
                            <dx:ASPxGridView ID="ASPxGridView3" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback">
                                <Columns>
                                    <dx:GridViewDataColumn FieldName="Buy_Total_Ammount" VisibleIndex="1" Caption="Buy Total Ammount">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataColumn>
                                    <dx:GridViewDataColumn FieldName="Sell_Total_Ammount" VisibleIndex="2" Caption="Sell Total Ammount">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataColumn>
                                    <dx:GridViewDataColumn FieldName="ETS_Share_Value" VisibleIndex="3" Caption="ETS Share Value">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                                        <CellStyle HorizontalAlign="Center">
                                        </CellStyle>
                                    </dx:GridViewDataColumn>
                                    <dx:GridViewDataColumn FieldName="Market_Share_Value" VisibleIndex="4" Caption="Market Share Value">
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
        </dx:ASPxPageControl>
        <dx:ASPxTimer ID="ASPxTimer1" runat="server" Interval="10000">
            <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxPageControl1_ASPxGridView0.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView1.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView2.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView3.PerformCallback();
                }" />
        </dx:ASPxTimer>
    </div>
</asp:Content>
