<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketShareGraphs_H.ascx.cs" Inherits="ARC.Reports.Controls.MarketShareGraphs_H" %>

<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>

<dx:WebChartControl ID="WebChartControl0" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin" ClientInstanceName="Chart_0"
    Width="1000px" CrosshairEnabled="True">
    <SeriesSerializable>
        <dx:Series Name="Market Share" ArgumentScaleType="DateTime" LabelsVisibility="False" ArgumentDataMember="date" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="Time: {A:hh:mm}
Market Share: {V:n2}%"
            LegendName="Default Legend">
            <ViewSerializable>
                <dx:LineSeriesView MarkerVisibility="True">
                    <LineMarkerOptions Size="1">
                    </LineMarkerOptions>
                </dx:LineSeriesView>
            </ViewSerializable>
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
            <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True" InterlacedColor="244, 243, 237" MinorCount="5">
                <GridLines Visible="False"></GridLines>
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                <Tickmarks Length="2" MinorVisible="False" />
                <Label Staggered="True" TextPattern="{A:HH:mm}">
                </Label>
                <CrosshairAxisLabelOptions Pattern="h:mm" />
                <DateTimeScaleOptions GridAlignment="Minute" AutoGrid="False" GridSpacing="10" WorkdaysOnly="True" ScaleMode="Continuous">
                    <WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                </DateTimeScaleOptions>
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
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

<%--            <dx:ASPxTimer ID="ASPxTimer1" runat="server" Interval="3000">
                <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxPageControl1_MarketShareGraphs_H_0_WebChartControl0.PerformCallback();
                }" />
            </dx:ASPxTimer>--%>
