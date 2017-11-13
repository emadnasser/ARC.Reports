<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PriceIndicators.aspx.cs" Inherits="PriceIndicators" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <table>
                    <tr>
                        <td class="NoWrap"><dx:ASPxLabel ID="lblPriceIndicator" runat="server" Text="Price Indicator:" /></td>
                        <td><div class="Spacer" style="width: 5px;"></div></td>
                        <td>
                            <dx:ASPxComboBox ID="cmbPriceIndicator" runat="server" SelectedIndex="0" ValueType="System.String" ClientInstanceName="cmbPriceIndicator">
                                <Items>
                                    <dx:ListEditItem Value="0" Text="Median Price" />
                                    <dx:ListEditItem Value="1" Text="Typical Price" />
                                    <dx:ListEditItem Value="2" Text="Weighted Close" />
                                </Items>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Indicator&quot;); }" />
                            </dx:ASPxComboBox>
                        </td>
                        <td style="width: 100%;"><div class="Spacer" style="width: 10px;"></div></td>
                        <td class="NoWrap"><dx:ASPxLabel ID="lblThickness" runat="server" Text="Thickness:"/></td>
                        <td><div class="Spacer" style="width: 5px;"></div></td>
                        <td>
                            <dx:ASPxSpinEdit ID="spnThickness" runat="server" Width="50px" MaxValue="10" MinValue="1">
                                <ClientSideEvents ValueChanged="function(s, e) { chart.PerformCallback(&quot;Thickness&quot;);}" />
                            </dx:ASPxSpinEdit>
                        </td>
                        <td><div class="Spacer" style="width: 10px;"></div></td>
                        <td class="NoWrap"><dx:ASPxLabel ID="lblColor" runat="server" Text="Color:"/></td>
                        <td><div class="Spacer" style="width: 5px;"></div></td>
                        <td>
                            <dx:ASPxComboBox ID="cbColor" runat="server" Width="100px" ValueType="System.String">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Color&quot;); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr><td><div class="Spacer" style="width: 100%;height: 5px"></div></td></tr>
                    <tr>
                        <td><div class="Spacer"></div></td>
                        <td><div class="Spacer"></div></td>
                        <td><div class="Spacer"></div></td>
                        <td><div class="Spacer"></div></td>
                        <td><div class="Spacer"></div></td>
                        <td><div class="Spacer"></div></td>
                        <td><div class="Spacer"></div></td>
                        <td><div class="Spacer"></div></td>
                        <td class="NoWrap"><dx:ASPxLabel ID="lblDashStyle" runat="server" Text="Dash Style:"/></td>
                        <td><div class="Spacer" style="width: 5px;"></div></td>
                        <td>
                            <dx:ASPxComboBox ID="cbDashStyle" runat="server" Width="100px">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;DashStyle&quot;); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="420px" CssClass="AlignCenter TopLargeMargin"
        Width="700px"  ClientInstanceName="chart" EnableViewState="False" OnCustomCallback="WebChartControl1_CustomCallback"
        DataSourceID="chartDataSource">
        <borderoptions visibility="False" />
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
        <legend alignmenthorizontal="Left"></legend>
        <SeriesSerializable>
            <dx:Series Name="Apple Inc." ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Low;High;Open;Close">                
                <ViewSerializable>
                    <dx:StockSeriesView LevelLineLength="0.3">
                        <Indicators>
                            <dx:MedianPrice Name="Median Price" ShowInLegend="True">
                                <linestyle thickness="2" />
                            </dx:MedianPrice>
                        </Indicators>
                    </dx:StockSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:StockSeriesLabel ResolveOverlappingMode="Default"></dx:StockSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <Titles>
            <dx:ChartTitle Text="Stock Prices"></dx:ChartTitle>
            <dx:ChartTitle Alignment="Far" Dock="Bottom" Font="Tahoma, 8pt" Text="From www.quandl.com" TextColor="Gray"></dx:ChartTitle>
        </Titles>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="MarketPrices" SelectMethod="GetPartialAppleStockPrices"></asp:ObjectDataSource>    
</asp:Content>
