<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomDrawAxisLabels.aspx.cs" Inherits="CustomDrawAxisLabels" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">   
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbCustomDraw" runat="server" Text="Custom&nbsp;Draw">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;CustomDraw&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td>
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show&nbsp;Labels">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
                        </dx:ASPxCheckBox>                        
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomDrawAxisLabel="WebChartControl1_CustomDrawAxisLabel" OnCustomCallback="WebChartControl1_CustomCallback">
        <SeriesSerializable>
            <dx:Series Name="All items" ArgumentScaleType="DateTime">
                <Points>
                    <dx:SeriesPoint Values="0.1" ArgumentSerializable="03/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="0.2" ArgumentSerializable="04/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="0.2" ArgumentSerializable="05/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="0.2" ArgumentSerializable="06/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="0.1" ArgumentSerializable="07/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="0.3" ArgumentSerializable="08/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="0.1" ArgumentSerializable="09/01/2016 00:00:00.000"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView></dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel ResolveOverlappingMode="Default"></dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Energy" ArgumentScaleType="DateTime">
                <Points>
                    <dx:SeriesPoint Values="0.9" ArgumentSerializable="03/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="3.4" ArgumentSerializable="04/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1.2" ArgumentSerializable="05/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1.3" ArgumentSerializable="06/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="-1.6" ArgumentSerializable="07/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="0" ArgumentSerializable="08/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="2.9" ArgumentSerializable="09/01/2016 00:00:00.000"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView></dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel ResolveOverlappingMode="Default"></dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Food" ArgumentScaleType="DateTime">
                <Points>
                    <dx:SeriesPoint Values="-0.2" ArgumentSerializable="03/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="0.2" ArgumentSerializable="04/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="-0.2" ArgumentSerializable="05/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="-0.1" ArgumentSerializable="06/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="0" ArgumentSerializable="07/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="0" ArgumentSerializable="08/01/2016 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="0" ArgumentSerializable="09/01/2016 00:00:00.000"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView></dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel ResolveOverlappingMode="Default"></dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <BorderOptions Visibility="False"></BorderOptions>
        <Titles>
            <dx:ChartTitle Text="US Consumer Price Index"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.bls.gov" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram LabelsResolveOverlappingMinIndent="3">
                <AxisX Title-Text="Months" VisibleInPanesSerializable="-1">
                    <DateTimeScaleOptions MeasureUnit="Month" GridAlignment="Month"/>
                    <Label Staggered="True" textPattern="{A:y}">
                    </Label>
                    
                </AxisX>
                <AxisY Title-Text="Change" VisibleInPanesSerializable="-1">
                    
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>
</asp:Content>
