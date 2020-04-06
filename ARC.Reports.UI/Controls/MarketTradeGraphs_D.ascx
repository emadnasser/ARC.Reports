<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketTradeGraphs_D.ascx.cs" Inherits="ARC.Reports.Controls.MarketTradeGraphs_D" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>

<dx:WebChartControl ID="WebChartControl1" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
    Width="1000px" ClientInstanceName="Chart_1" CrosshairEnabled="True">
    <SeriesSerializable>
        <dx:Series Name="Market Share" ArgumentScaleType="DateTime" LabelsVisibility="True" ArgumentDataMember="date" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="Date: {A:d MMM}
Market Share: {V:n2}%" LegendName="Default Legend">
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
            <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True" InterlacedColor="244, 243, 237">
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                                </workdaysoptions>
                <Tickmarks MinorVisible="False" />
                <Label Staggered="True" TextPattern="{A:dd/MMM}">
                </Label>
                <CrosshairAxisLabelOptions Pattern="dd/MM/yyyy" />
                <GridLines Visible="True"></GridLines>
                <DateTimeScaleOptions MeasureUnit="Day" GridAlignment="Day" AutoGrid="True" GridSpacing="6" WorkdaysOnly="True" >
<WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                </DateTimeScaleOptions>
            </AxisX>
            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                <Tickmarks MinorVisible="False" />
                <Label TextPattern="{V:G}">
                </Label>
                <NumericScaleOptions AutoGrid="False" />
            </AxisY>
            <DefaultPane Weight="2"></DefaultPane>
        </dx:XYDiagram>
    </DiagramSerializable>
</dx:WebChartControl>
