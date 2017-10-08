<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketShareTotal_0D.ascx.cs" Inherits="ARC.Reports.Controls.MarketShareTotal_0D" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<div class="row">
    <div class="col-xs-6 col-sm-4 col-md-12 col-lg-12">
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
        <br />
        <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Export To Excel" OnClick="ASPxButton1_Click" Theme="DevEx">
        </dx:ASPxButton>
        <asp:Panel ID="pnlLastGrids_1" runat="server">
            <div class="hr hr-18 dotted hr-double" runat="server"></div>
            <br />
            <dx:ASPxGridView ID="ASPxGridView1" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback">
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
            <dx:ASPxGridView ID="ASPxGridView2" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback">
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
        <dx:ASPxTimer ID="ASPxTimer" runat="server" Interval="20000" Enabled="false">
            <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxPageControl1_MarketShareTotal_0D_ASPxGridView0.PerformCallback();
                MainContent_ASPxPageControl1_MarketShareTotal_0D_ASPxGridView1.PerformCallback();
                MainContent_ASPxPageControl1_MarketShareTotal_0D_ASPxGridView2.PerformCallback();
                MainContent_ASPxPageControl1_MarketShareTotal_0D1_ASPxGridView0.PerformCallback();
                MainContent_ASPxPageControl1_MarketShareTotal_0D1_ASPxGridView1.PerformCallback();
                MainContent_ASPxPageControl1_MarketShareTotal_0D1_ASPxGridView2.PerformCallback();
                }" />
        </dx:ASPxTimer>
    </div>
    <dx:ASPxGridViewExporter ID="gridExport_0" runat="server" GridViewID="ASPxGridView0" FileName="Market Share Totals Main - Daily"></dx:ASPxGridViewExporter>
</div>
