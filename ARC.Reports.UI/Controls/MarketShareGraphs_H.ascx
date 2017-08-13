<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketShareGraphs_H.ascx.cs" Inherits="ARC.Reports.Controls.MarketShareGraphs_H" %>

<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>

<dx:WebChartControl ID="WebChartControl0" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin" ClientInstanceName="Chart_0"
    Width="1000px" CrosshairEnabled="True">
    <SeriesSerializable>
        <dx:Series Name="Market Share Value" ArgumentScaleType="DateTime" LabelsVisibility="False" ArgumentDataMember="date" ValueDataMembersSerializable="Market_Share_Value" CrosshairLabelPattern="{V:n2}">
            <ViewSerializable>
                <dx:LineSeriesView MarkerVisibility="True">
                    <LineMarkerOptions Kind="Square" Size="1">
                    </LineMarkerOptions>
                </dx:LineSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:PointSeriesLabel Angle="90">
                </dx:PointSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series Name="ETS Share Value" ArgumentScaleType="DateTime" LabelsVisibility="False" ArgumentDataMember="date" ValueDataMembersSerializable="ETS_Share_Value" CrosshairLabelPattern="{V:n2}">
            <ViewSerializable>
                <dx:LineSeriesView AxisYName="secondaryAxisY1" MarkerVisibility="True" PaneName="Pane 1">
                    <LineMarkerOptions Kind="Diamond" Size="1">
                    </LineMarkerOptions>
                </dx:LineSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:PointSeriesLabel>
                </dx:PointSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series Name="Market Share" ArgumentScaleType="DateTime" LegendName="Default Legend" ValueDataMembersSerializable="Percentage" ArgumentDataMember="date" CrosshairLabelPattern="{V:n2}%" LabelsVisibility="False">
            <ViewSerializable>
                <dx:LineSeriesView AxisYName="secondaryAxisY2" MarkerVisibility="True" PaneName="Pane 2">
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
    <Legend AlignmentHorizontal="Right" Direction="LeftToRight" AlignmentVertical="BottomOutside" MarkerSize="18, 35" Visibility="True">
        <Border Visibility="True" />
    </Legend>
    <BorderOptions Visibility="False" />
    <DiagramSerializable>
        <dx:XYDiagram PaneDistance="4">
            <AxisX Title-Text="Date" VisibleInPanesSerializable="1" Interlaced="True" InterlacedColor="244, 243, 237" MinorCount="5">
                <GridLines Visible="False"></GridLines>
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                <Tickmarks Length="2" />
                <Label Staggered="True" TextPattern="{A:HH:mm}">
                </Label>
                <CrosshairAxisLabelOptions Pattern="h:mm" />
                <DateTimeScaleOptions GridAlignment="Second" AutoGrid="False" GridSpacing="2" WorkdaysOnly="True" ScaleMode="Continuous" />
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
            </AxisX>
            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                <WholeRange Auto="False" MaxValueSerializable="1000000000" MinValueSerializable="0"></WholeRange>
                <GridLines MinorVisible="True" Visible="False"></GridLines>
                <Label TextPattern="{V:G}">
                </Label>
            </AxisY>
            <SecondaryAxesY>
                <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="ETS Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                    <WholeRange Auto="False" MaxValueSerializable="1000000000" MinValueSerializable="0"></WholeRange>
                    <GridLines MinorVisible="True"></GridLines>
                    <Label TextPattern="{V:G}">
                    </Label>
                </dx:SecondaryAxisY>
                <dx:SecondaryAxisY AxisID="1" Alignment="Near" Title-Text="Market Share" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="1" Name="secondaryAxisY2">
                    <VisualRange AutoSideMargins="False" SideMarginsValue="0"></VisualRange>
                    <WholeRange Auto="False" MinValueSerializable="0" MaxValueSerializable="40" AutoSideMargins="False" SideMarginsValue="5"></WholeRange>
                    <GridLines Visible="True" MinorVisible="True"></GridLines>
                    <Label TextPattern="{V:G}">
                    </Label>
                    <NumericScaleOptions AutoGrid="False" GridSpacing="15" />
                </dx:SecondaryAxisY>
            </SecondaryAxesY>
            <DefaultPane Weight="2"></DefaultPane>
            <Panes>
                <dx:XYDiagramPane PaneID="0" Name="Pane 1" Weight="2"></dx:XYDiagramPane>
                <dx:XYDiagramPane PaneID="1" Name="Pane 2" Weight="1.8"></dx:XYDiagramPane>
            </Panes>
        </dx:XYDiagram>
    </DiagramSerializable>
</dx:WebChartControl>
