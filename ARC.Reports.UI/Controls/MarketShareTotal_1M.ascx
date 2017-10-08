<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketShareTotal_1M.ascx.cs" Inherits="ARC.Reports.Controls.MarketShareTotal_1M" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

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
                <dx:GridViewBandColumn Caption="May" HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" Cursor="default"></HeaderStyle>
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="MarketShare_5" VisibleIndex="9" Caption="Shares">
                            <PropertiesTextEdit DisplayFormatString="{0}%"></PropertiesTextEdit>
                            <HeaderStyle HorizontalAlign="Center" />
                            <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                            <CellStyle HorizontalAlign="Center" BackColor="#D7DCEA" />
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
                            <FooterCellStyle BackColor="#D7DCEA">
                            </FooterCellStyle>
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
            <SettingsPager Mode="ShowAllRecords" />

            <Settings ShowFooter="True"></Settings>

            <SettingsBehavior AllowSort="true" SortMode="Value" />
        </dx:ASPxGridView>
        <br />
        <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Export To Excel" OnClick="ASPxButton1_Click" Theme="DevEx">
        </dx:ASPxButton>
        <dx:ASPxTimer ID="ASPxTimer" runat="server" Interval="60000" Enabled="false">
            <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxPageControl1_MarketShareTotal_1M_ASPxGridView6.PerformCallback();
                MainContent_ASPxPageControl1_MarketShareTotal_1M1_ASPxGridView6.PerformCallback();
                }" />
        </dx:ASPxTimer>
    </div>
    <dx:ASPxGridViewExporter ID="gridExport_2" runat="server" GridViewID="ASPxGridView6" FileName="Market Share Totals Main - Monthly"></dx:ASPxGridViewExporter>
</div>
