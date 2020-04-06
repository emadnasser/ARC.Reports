<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketShareTotal_3Y.ascx.cs" Inherits="ARC.Reports.Controls.MarketShareTotal_3Y" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<div class="row">
    <div class="col-xs-6 col-sm-4 col-md-12 col-lg-12">
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
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
        <dx:ASPxTimer ID="ASPxTimer" runat="server" Interval="120000" Enabled="false">
            <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxPageControl1_MarketShareTotal_3Y_ASPxGridView8.PerformCallback();
                MainContent_ASPxPageControl1_MarketShareTotal_3Y1_ASPxGridView8.PerformCallback();
                }" />
        </dx:ASPxTimer>
    </div>
    <dx:ASPxGridViewExporter ID="gridExport_4" runat="server" GridViewID="ASPxGridView8" FileName="Market Share Totals Main - Yearly"></dx:ASPxGridViewExporter>
</div>
