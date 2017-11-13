<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AreaStackedSeries.aspx.cs" Inherits="AreaStackedSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">            
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
        Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
        OnCustomCallback="WebChartControl1_CustomCallback" ToolTipEnabled="False" CrosshairEnabled="False"
        SeriesDataMember = "Region" DataSourceID="chartDataSource">
        <Legend AlignmentHorizontal="Center" AlignmentVertical="BottomOutside" Direction="LeftToRight"></Legend>
        <Titles>
            <dx:ChartTitle Text="DevAV Sales"></dx:ChartTitle>
        </Titles>
        <SeriesTemplate ArgumentScaleType="DateTime" ArgumentDataMember="Year" ValueDataMembersSerializable="Sales" LabelsVisibility="True">
            <ViewSerializable>
                <dx:StackedAreaSeriesView></dx:StackedAreaSeriesView>
            </ViewSerializable>
        </SeriesTemplate>        
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Title-Text="Years" VisibleInPanesSerializable="-1">
                    <WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                    <DateTimeScaleOptions MeasureUnit="Year" GridAlignment="Year" />                    
                </AxisX>
                <AxisY Title-Text="Millions of Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1" Interlaced="True">                    
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
        <BorderOptions Visibility="False" />
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetSalesByLast10Years"></asp:ObjectDataSource>
</asp:Content>
