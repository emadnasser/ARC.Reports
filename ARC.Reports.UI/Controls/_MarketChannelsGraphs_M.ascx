<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="_MarketChannelsGraphs_M.ascx.cs" Inherits="ARC.Reports.Controls.MarketChannelsGraphs_M" %>


<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>

<dx:WebChartControl ID="WebChartControl2" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
    Width="1000px" ClientInstanceName="Chart_2" CrosshairEnabled="True">
    <SeriesSerializable>
        <dx:Series Name="Market Share Value" ArgumentScaleType="DateTime" LabelsVisibility="False" ArgumentDataMember="date" ValueDataMembersSerializable="Market_Share_Value" CrosshairLabelPattern="{V:n2}%" Visible="False">
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
        <dx:Series Name="ETS Share Value" ArgumentScaleType="DateTime" LabelsVisibility="False" ArgumentDataMember="date" ValueDataMembersSerializable="ETS_Share_Value" CrosshairLabelPattern="{V:n2}" Visible="False">
            <ViewSerializable>
                <dx:LineSeriesView MarkerVisibility="True" PaneName="Pane 1">
                    <LineMarkerOptions Kind="Diamond" Size="1">
                    </LineMarkerOptions>
                </dx:LineSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:PointSeriesLabel>
                </dx:PointSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series Name="Market Share" ArgumentScaleType="DateTime" LegendName="Default Legend" ValueDataMembersSerializable="Percentage" ArgumentDataMember="date" CrosshairLabelPattern="Date: {A:d MMM}
{HINT}{S}: {V:n2}%" CrosshairEnabled="True" CrosshairLabelVisibility="True">
            <ViewSerializable>
                <dx:LineSeriesView MarkerVisibility="True" PaneName="Pane 2">
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
                <CrosshairAxisLabelOptions Pattern="{A:dd-MMM}" />
                <GridLines Visible="True"></GridLines>
                <DateTimeScaleOptions MeasureUnit="Day" AutoGrid="False" GridSpacing="2" ScaleMode="Continuous" GridAlignment="Day" WorkdaysOnly="True" >
<WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                </DateTimeScaleOptions>
            </AxisX>
            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1" Alignment="Zero">
                <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                <ScaleBreaks>
                    <dx:ScaleBreak Edge1Serializable="1000000000" Edge2Serializable="100" Name="Scale Break 1" />
                    <dx:ScaleBreak Edge1Serializable="0" Edge2Serializable="0" Name="Scale Break 2" Visible="False" />
                    <dx:ScaleBreak Edge1Serializable="0" Edge2Serializable="0" Name="Scale Break 3" Visible="False" />
                </ScaleBreaks>
                <ScaleBreakOptions Color="192, 80, 77" />
                <Tickmarks MinorVisible="False" />
                <Label TextPattern="{V:G}">
                </Label>
            </AxisY>
            <DefaultPane Weight="2"></DefaultPane>
        </dx:XYDiagram>
    </DiagramSerializable>
</dx:WebChartControl>
