<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FibonacciIndicators.aspx.cs" Inherits="FibonacciIndicators" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCallbackPanel ID="callbackPanel" runat="server" ClientInstanceName="callbackPanel" OnCallback="callbackPanel_Callback">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
                    <PanelCollection>
                        <dx:PanelContent runat="server">
                            <table>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <td>
                                                    <dx:ASPxLabel ID="lblKind" runat="server" Text="Kind:" />
                                                </td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cmbKind" runat="server" SelectedIndex="0" ValueType="System.String" ClientInstanceName="cmbKind">
                                                        <Items>
                                                            <dx:ListEditItem Value="0" Text="Fibonacci Arcs" />
                                                            <dx:ListEditItem Value="1" Text="Fibonacci Fans" />
                                                            <dx:ListEditItem Value="2" Text="Fibonacci Retracement" />
                                                        </Items>
                                                        <ClientSideEvents SelectedIndexChanged="function(s, e) { callbackPanel.PerformCallback(&quot;Kind&quot;); }" />
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td>
                                        <dx:ASPxCheckBox ID="chbLevel0" runat="server" Text="Show Level 0%" ClientInstanceName="chbLevel0">
                                            <ClientSideEvents CheckedChanged="function(s, e) { callbackPanel.PerformCallback(&quot;0&quot;); }" />
                                        </dx:ASPxCheckBox>
                                    </td>
                                    <td>
                                        <dx:ASPxCheckBox ID="chbLevel100" runat="server" Text="Show Level 100%" ClientInstanceName="chbLevel100">
                                            <ClientSideEvents CheckedChanged="function(s, e) { callbackPanel.PerformCallback(&quot;100&quot;); }" />
                                        </dx:ASPxCheckBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <dx:ASPxCheckBox ID="chbAdditionalLevels" runat="server" Text="Show Additional Levels" ClientInstanceName="chbAdditionalLevels">
                                            <ClientSideEvents CheckedChanged="function(s, e) { callbackPanel.PerformCallback(&quot;Additional&quot;); }" />
                                        </dx:ASPxCheckBox>
                                    </td>
                                    <td>
                                        <dx:ASPxCheckBox ID="chbLevel23_6" runat="server" Text="Show Level 23.6%" ClientInstanceName="chbLevel23_6">
                                            <ClientSideEvents CheckedChanged="function(s, e) { callbackPanel.PerformCallback(&quot;23.6&quot;); }" />
                                        </dx:ASPxCheckBox>
                                    </td>
                                    <td>
                                        <dx:ASPxCheckBox ID="chbLevel76_4" runat="server" Text="Show Level 76.4%" ClientInstanceName="chbLevel76_4">
                                            <ClientSideEvents CheckedChanged="function(s, e) { callbackPanel.PerformCallback(&quot;76.4&quot;); }" />
                                        </dx:ASPxCheckBox>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxRoundPanel>
                <dx:WebChartControl ID="WebChartControl1" runat="server" Height="420px" CssClass="AlignCenter TopLargeMargin"
                    Width="700px"  ClientInstanceName="chart" EnableViewState="False" 
                    SaveStateOnCallbacks="False"
                    DataSourceID="chartDataSource">
                    <Legend Visibility="False"></Legend>
                    <DiagramSerializable>
                        <dx:XYDiagram>
                            <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True">
                                <DateTimeScaleOptions GridAlignment="Month" WorkdaysOnly="True" AutoGrid="False" GridSpacing="0.5">
                                </DateTimeScaleOptions>
                                <GridLines Visible="True"></GridLines>
                            </AxisX>
                            <AxisY Title-Text="US Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">
                                <WholeRange AlwaysShowZeroLevel="False"  ></WholeRange>
                                <GridLines MinorVisible="True"></GridLines>
                            </AxisY>
                        </dx:XYDiagram>
                    </DiagramSerializable>
                    <SeriesSerializable>
                        <dx:Series Name="Apple Inc." ArgumentScaleType="DateTime" LabelsVisibility="False"
                            ArgumentDataMember="Date" ValueDataMembersSerializable="Low;High;Open;Close">                            
                            <ViewSerializable>
                                <dx:StockSeriesView LevelLineLength="0.3">
                                    <Indicators>
                                        <dx:FibonacciIndicator BaseLevelColor="Green" ShowLevel0="True" ShowLevel100="True" ShowLevel23_6="False" ShowLevel76_4="False" ShowAdditionalLevels="False" Name="Fibonacci Indicator 1">
                                            <Point1 ArgumentSerializable="09/13/2016 12:00:00.000" ValueLevel="Low"></Point1>
                                            <Point2 ArgumentSerializable="06/10/2016 12:00:00.000" ValueLevel="High"></Point2>
                                        </dx:FibonacciIndicator>
                                    </Indicators>
                                </dx:StockSeriesView>
                            </ViewSerializable>
                            <LabelSerializable>
                                <dx:StockSeriesLabel ResolveOverlappingMode="Default"></dx:StockSeriesLabel>
                            </LabelSerializable>
                        </dx:Series>
                    </SeriesSerializable>
                    <Titles>
                        <dx:ChartTitle Text="Apple Inc. Stock Prices"></dx:ChartTitle>
                        <dx:ChartTitle Alignment="Far" Dock="Bottom" Font="Tahoma, 8pt" Text="From www.quandl.com" TextColor="Gray"></dx:ChartTitle>
                    </Titles>
                    <BorderOptions Visibility="False" />
                </dx:WebChartControl>
                <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="MarketPrices" SelectMethod="GetAppleStockPrices"></asp:ObjectDataSource>    
            </dx:PanelContent>
        </PanelCollection>
        <Styles>
            <LoadingPanel HorizontalAlign="Center" VerticalAlign="Middle"></LoadingPanel>
        </Styles>
    </dx:ASPxCallbackPanel>
</asp:Content>
