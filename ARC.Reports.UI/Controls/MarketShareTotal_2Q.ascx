<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketShareTotal_2Q.ascx.cs" Inherits="ARC.Reports.Controls.MarketShareTotal_2Q" %>

<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<div class="row">
    <div class="col-xs-6 col-sm-4 col-md-12 col-lg-12">
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
                <dx:GridViewBandColumn Name="_2" Caption="Feb" HeaderStyle-HorizontalAlign="Center">
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
                <dx:GridViewBandColumn Name="_3" Caption="Mar" HeaderStyle-HorizontalAlign="Center">
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
                <dx:GridViewBandColumn Name="_4" Caption="Apr" HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="MarketShare_4" VisibleIndex="7" Caption="Shares">
                            <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                            <HeaderStyle HorizontalAlign="Center" />
                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                            <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="MarketTrades_4" VisibleIndex="8" Caption="Trades">
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
            </TotalSummary>
            <Styles>
                <Footer HorizontalAlign="Center" VerticalAlign="Middle">
                </Footer>
                <FixedColumn BackColor="#f5f7fa"></FixedColumn>
            </Styles>
            <SettingsPager Mode="ShowAllRecords" />

            <Settings ShowFooter="True"></Settings>

            <SettingsBehavior AllowSort="true" SortMode="Value" />
        </dx:ASPxGridView>
        <br />
        <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Export To Excel" OnClick="ASPxButton1_Click" Theme="DevEx">
        </dx:ASPxButton>
        <dx:ASPxTimer ID="ASPxTimer2" runat="server" Interval="10000">
            <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxPageControl1_MarketShareTotal_2Q_ASPxGridView6.PerformCallback();
                MainContent_ASPxPageControl1_MarketShareTotal_2Q1_ASPxGridView6.PerformCallback();
                }" />
        </dx:ASPxTimer>
    </div>
    <dx:ASPxGridViewExporter ID="gridExport_2" runat="server" GridViewID="ASPxGridView6" FileName="Market Share Totals Main - Monthly"></dx:ASPxGridViewExporter>
</div>
