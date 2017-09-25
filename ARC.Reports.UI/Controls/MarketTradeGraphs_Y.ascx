<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketTradeGraphs_Y.ascx.cs" Inherits="ARC.Reports.Controls.MarketTradeGraphs_Y" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>

<dx:WebChartControl ID="WebChartControl3" ClientInstanceName="Chart_3" CrosshairEnabled="True"
    Width="1000px" Height="480px" CssClass="AlignCenter TopLargeMargin" runat="server">

    <SeriesSerializable>
        <dx:Series Name="Market Share" ArgumentScaleType="DateTime" LegendName="Default Legend" ValueDataMembersSerializable="Percentage" ArgumentDataMember="date" CrosshairLabelPattern="Date: {A:d MMM}
Market Share: {V:n2}%">
            <ViewSerializable>
                <dx:LineSeriesView MarkerVisibility="True">
                    <LineMarkerOptions Size="1">
                    </LineMarkerOptions>
                </dx:LineSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel>
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
    </SeriesSerializable>
    <CrosshairOptions ArgumentLineColor="DeepSkyBlue" ArgumentLineStyle-Thickness="2"
        ShowOnlyInFocusedPane="False">
    </CrosshairOptions>
    <Legend AlignmentHorizontal="Right" Direction="LeftToRight" AlignmentVertical="BottomOutside" MarkerSize="18, 35" Visibility="False">
        <Border Visibility="True" />
    </Legend>
    <BorderOptions Visibility="False" />
    <DiagramSerializable>
        <dx:XYDiagram PaneDistance="4">
            <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True" InterlacedColor="244, 243, 237">
                <GridLines Visible="True"></GridLines>
                <Tickmarks MinorVisible="False" />
                <Label Staggered="True" TextPattern="{A:MM/yyyy}">
                </Label>
                <CrosshairAxisLabelOptions Pattern="MM/yyyy" />
                <DateTimeScaleOptions MeasureUnit="Day" GridAlignment="Day" AutoGrid="True" GridSpacing="6" WorkdaysOnly="True" />
            </AxisX>
            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                <Tickmarks MinorVisible="False" />
                <Label TextPattern="{V:G}">
                </Label>
            </AxisY>
            <DefaultPane Weight="2"></DefaultPane>
        </dx:XYDiagram>
    </DiagramSerializable>
</dx:WebChartControl>
