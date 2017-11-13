<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RangeBarSideBySideSeries.aspx.cs" Inherits="RangeBarSideBySideSeries" %>
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
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
        CrosshairEnabled="False" ToolTipEnabled="True">
        <Legend AlignmentHorizontal="Right" AlignmentVertical="Top" Direction="LeftToRight"></Legend>
        <Titles>
            <dx:ChartTitle Text="Crude Oil Prices in 2005"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.eia.gov" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <SeriesSerializable>
            <dx:Series Name="ANS West Coast" ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Min;Max"
                ToolTipPointPattern="{S}<br/>Month: {A:MMMM}<br/>Min Price: ${V1:0.00}<br/>Max Price: ${V2:0.00}">
                <ViewSerializable>
                    <dx:SideBySideRangeBarSeriesView></dx:SideBySideRangeBarSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:RangeBarSeriesLabel Indent="3" TextPattern="{V:F2}">
                    </dx:RangeBarSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="West Texas Intermediate" ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Min;Max"
                ToolTipPointPattern="{S}<br/>Month: {A:MMMM}<br/>Min Price: ${V1:0.00}<br/>Max Price: ${V2:0.00}">
                <ViewSerializable>
                    <dx:SideBySideRangeBarSeriesView></dx:SideBySideRangeBarSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:RangeBarSeriesLabel Indent="3" TextPattern="{V:F2}">
                    </dx:RangeBarSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Title-Text="Dates" VisibleInPanesSerializable="-1">
                    <DateTimeScaleOptions MeasureUnit="Month" GridAlignment="Month" />
                    <Label TextPattern="{A:MMMM}">
                    </Label>
                </AxisX>
                <AxisY Title-Text="$ per barrel" Title-Visibility="True" VisibleInPanesSerializable="-1" Interlaced="True">
                    <WholeRange AlwaysShowZeroLevel="False"  ></WholeRange>
                    <GridLines MinorVisible="True"></GridLines>
                    <Label TextPattern="{V:N0}">
                    </Label>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
        <BorderOptions Visibility="False" />
    </dx:WebChartControl>
</asp:Content>
