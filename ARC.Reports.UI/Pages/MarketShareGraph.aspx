<%@ Page Title="ARC Reports - Market Share Graphs" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="MarketShareGraph.aspx.cs" Inherits="ARC.Reports.Pages.MarketShareGraph" %>

<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #MainContent_ASPxLabel1 {
            text-align: right;
            padding-top: 3px;
        }

        #MainContent_ASPxPageControl1_TPTCL_dateEdit_0 {
            float: right;
            margin-right: 40px
        }

        #MainContent_ASPxPageControl1_TPTCL_myOption_0 {
            float: right;
        }

        #MainContent_ASPxPageControl1_TPTCL_lblType_0 {
            float: right;
            margin-top: 4px;
            margin-right: 5px;
        }
    </style>
    <script>
        $(document).ready(function () {
            $(function () {
                $("#sidebar > ul > li > ul:nth-child(3) > li > ul > li:nth-child(3)").addClass("active");
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h4 class="header smaller lighter blue strong">Market Share Graphs</h4>
    <div class="row">
        <div class="col-xs-6 col-sm-4 col-md-12 col-lg-12">
            <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" Theme="DevEx" Width="100%" ActiveTabIndex="0" EnableTheming="True" OnTabClick="ASPxPageControl1_TabClick">
                <TabPages>
                    <dx:TabPage Text="Main Market">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <%--One Day--%>
                                <dx:WebChartControl ID="WebChartControl7" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
                                    Width="1000px" ClientInstanceName="chart" CrosshairEnabled="True" Visible="false">
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
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                                </workdaysoptions>
                                                <tickmarks length="2" />
                                                <Label Staggered="True" TextPattern="{A:HH:mm}">
                                                </Label>
                                                <CrosshairAxisLabelOptions Pattern="h:mm" />
                                                <DateTimeScaleOptions GridAlignment="Second" AutoGrid="False" GridSpacing="2" WorkdaysOnly="True" ScaleMode="Continuous" />
<WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                                </workdaysoptions>
                                            </AxisX>
                                            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                                                <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                <GridLines MinorVisible="True" Visible="False"></GridLines>
                                                <Label TextPattern="{V:G}">
                                                </Label>
                                            </AxisY>
                                            <SecondaryAxesY>
                                                <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="ETS Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                                                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                    <GridLines MinorVisible="True"></GridLines>
                                                    <Label TextPattern="{V:G}">
                                                    </Label>
                                                    <NumericScaleOptions AutoGrid="False" GridSpacing="100000000" />
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
                                <%--Daily--%>
                                <dx:WebChartControl ID="WebChartControl1" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
                                    Width="1000px" ClientInstanceName="chart" CrosshairEnabled="True" Visible="false">
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
                                            <AxisX Title-Text="Date" VisibleInPanesSerializable="1" Interlaced="True" InterlacedColor="244, 243, 237" MinorCount="1">
                                                <GridLines Visible="False"></GridLines>
                                                <Label Staggered="True" TextPattern="{A:dd/MMM}">
                                                </Label>
                                                <CrosshairAxisLabelOptions Pattern="dd/MM/yyyy" />
                                                <DateTimeScaleOptions MeasureUnit="Day" GridAlignment="Day" AutoGrid="True" GridSpacing="6" WorkdaysOnly="True" />
<WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                                </workdaysoptions>
                                            </AxisX>
                                            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                                                <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                <GridLines MinorVisible="True" Visible="False"></GridLines>
                                                <Label TextPattern="{V:G}">
                                                </Label>
                                            </AxisY>
                                            <SecondaryAxesY>
                                                <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="ETS Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                                                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                    <GridLines MinorVisible="True"></GridLines>
                                                    <Label TextPattern="{V:G}">
                                                    </Label>
                                                    <NumericScaleOptions AutoGrid="False" GridSpacing="100000000" />
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
                                <%--Monthly--%>
                                <dx:WebChartControl ID="WebChartControl2" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
                                    Width="1000px" ClientInstanceName="chart" CrosshairEnabled="True" Visible="false">
                                    <SeriesSerializable>
                                        <dx:Series Name="Market Share Value" ArgumentScaleType="DateTime" LabelsVisibility="False" ArgumentDataMember="date" ValueDataMembersSerializable="Market_Share_Value" CrosshairLabelPattern="{V:n2}%">
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
                                        <dx:Series Name="Market Share" ArgumentScaleType="DateTime" LegendName="Default Legend" ValueDataMembersSerializable="Percentage" ArgumentDataMember="date" CrosshairLabelPattern="{V:n2}" LabelsVisibility="False">
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
                                            <AxisX Title-Text="Date" VisibleInPanesSerializable="1" Interlaced="True" InterlacedColor="244, 243, 237">
                                                <GridLines Visible="False"></GridLines>
                                                <Label Staggered="True" TextPattern="{A:dd/MMM}">
                                                </Label>
                                                <CrosshairAxisLabelOptions Pattern="dd/MM/yyyy" />
                                                <DateTimeScaleOptions MeasureUnit="Day" GridAlignment="Day" AutoGrid="True" GridSpacing="6" />
<WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                                </workdaysoptions>
                                            </AxisX>
                                            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                                                <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                <GridLines MinorVisible="True" Visible="False"></GridLines>
                                                <Label TextPattern="{V:G}">
                                                </Label>
                                            </AxisY>
                                            <SecondaryAxesY>
                                                <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="ETS Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                                                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                    <GridLines MinorVisible="True"></GridLines>
                                                    <Label TextPattern="{V:G}">
                                                    </Label>
                                                    <NumericScaleOptions AutoGrid="False" GridSpacing="100000000" />
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
                                <%--Yearly--%>
                                <dx:WebChartControl ID="WebChartControl3" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
                                    Width="1000px" ClientInstanceName="chart" CrosshairEnabled="True" Visible="false">
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
                                            <AxisX Title-Text="Date" VisibleInPanesSerializable="1" Interlaced="True" InterlacedColor="244, 243, 237">
                                                <GridLines Visible="False"></GridLines>
                                                <Label Staggered="True" TextPattern="{A:MM/yyyy}">
                                                </Label>
                                                <CrosshairAxisLabelOptions Pattern="MM/yyyy" />
                                                <DateTimeScaleOptions MeasureUnit="Day" GridAlignment="Day" AutoGrid="True" GridSpacing="6" WorkdaysOnly="True" />
<WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                                </workdaysoptions>
                                            </AxisX>
                                            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                                                <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                <GridLines MinorVisible="True" Visible="False"></GridLines>
                                                <Label TextPattern="{V:G}">
                                                </Label>
                                            </AxisY>
                                            <SecondaryAxesY>
                                                <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="ETS Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                                                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                    <GridLines MinorVisible="True"></GridLines>
                                                    <Label TextPattern="{V:G}">
                                                    </Label>
                                                    <NumericScaleOptions AutoGrid="False" GridSpacing="100000000" />
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
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                    <dx:TabPage Text="Nomu Market">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl2" runat="server">
                                <%--One Day--%>
                                <dx:WebChartControl ID="WebChartControl8" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
                                    Width="1000px" ClientInstanceName="chart" CrosshairEnabled="True" Visible="false">
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
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                                </workdaysoptions>
                                                <tickmarks length="2" />
                                                <Label Staggered="True" TextPattern="{A:HH:mm}">
                                                </Label>
                                                <CrosshairAxisLabelOptions Pattern="h:mm" />
                                                <DateTimeScaleOptions GridAlignment="Second" AutoGrid="False" GridSpacing="2" WorkdaysOnly="True" ScaleMode="Continuous" />
<WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                                </workdaysoptions>
                                            </AxisX>
                                            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                                                <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                <GridLines MinorVisible="True" Visible="False"></GridLines>
                                                <Label TextPattern="{V:G}">
                                                </Label>
                                            </AxisY>
                                            <SecondaryAxesY>
                                                <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="ETS Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                                                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                    <GridLines MinorVisible="True"></GridLines>
                                                    <Label TextPattern="{V:G}">
                                                    </Label>
                                                    <NumericScaleOptions AutoGrid="False" GridSpacing="100000000" />
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
                                <%--Daily--%>
                                <dx:WebChartControl ID="WebChartControl4" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
                                    Width="1000px" ClientInstanceName="chart" CrosshairEnabled="True" Visible="false">
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
                                            <AxisX Title-Text="Date" VisibleInPanesSerializable="1" Interlaced="True" InterlacedColor="244, 243, 237">
                                                <GridLines Visible="False"></GridLines>
                                                <Label Staggered="True" TextPattern="{A:dd/MMM}">
                                                </Label>
                                                <CrosshairAxisLabelOptions Pattern="dd/MM/yyyy" />
                                                <DateTimeScaleOptions MeasureUnit="Day" GridAlignment="Day" AutoGrid="True" GridSpacing="6" WorkdaysOnly="True" />
<WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                                </workdaysoptions>
                                            </AxisX>
                                            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                                                <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                <GridLines MinorVisible="True" Visible="False"></GridLines>
                                                <Label TextPattern="{V:G}">
                                                </Label>
                                            </AxisY>
                                            <SecondaryAxesY>
                                                <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="ETS Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                                                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                    <GridLines MinorVisible="True"></GridLines>
                                                    <Label TextPattern="{V:G}">
                                                    </Label>
                                                    <NumericScaleOptions AutoGrid="False" GridSpacing="100000" />
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
                                <%--Monthly--%>
                                <dx:WebChartControl ID="WebChartControl5" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
                                    Width="1000px" ClientInstanceName="chart" CrosshairEnabled="True" Visible="false">
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
                                            <AxisX Title-Text="Date" VisibleInPanesSerializable="1" Interlaced="True" InterlacedColor="244, 243, 237">
                                                <GridLines Visible="False"></GridLines>
                                                <Label Staggered="True" TextPattern="{A:dd/MMM}">
                                                </Label>
                                                <CrosshairAxisLabelOptions Pattern="dd/MM/yyyy" />
                                                <DateTimeScaleOptions MeasureUnit="Day" GridAlignment="Day" AutoGrid="True" GridSpacing="6" WorkdaysOnly="True" />
<WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                                </workdaysoptions>
                                            </AxisX>
                                            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                                                <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                <GridLines MinorVisible="True" Visible="False"></GridLines>
                                                <Label TextPattern="{V:G}">
                                                </Label>
                                            </AxisY>
                                            <SecondaryAxesY>
                                                <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="ETS Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                                                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                    <GridLines MinorVisible="True"></GridLines>
                                                    <Label TextPattern="{V:G}">
                                                    </Label>
                                                    <NumericScaleOptions AutoGrid="False" GridSpacing="1000000" />
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
                                <%--Yearly--%>
                                <dx:WebChartControl ID="WebChartControl6" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
                                    Width="1000px" ClientInstanceName="chart" CrosshairEnabled="True" Visible="false">
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
                                            <AxisX Title-Text="Date" VisibleInPanesSerializable="1" Interlaced="True" InterlacedColor="244, 243, 237">
                                                <GridLines Visible="False"></GridLines>
                                                <Label Staggered="True" TextPattern="{A:MM/yyyy}">
                                                </Label>
                                                <CrosshairAxisLabelOptions Pattern="MM/yyyy" />
                                                <DateTimeScaleOptions MeasureUnit="Day" GridAlignment="Day" AutoGrid="True" GridSpacing="6" WorkdaysOnly="True" />
<WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                                                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                                </workdaysoptions>
                                            </AxisX>
                                            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                                                <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                                                <GridLines MinorVisible="True" Visible="False"></GridLines>
                                                <Label TextPattern="{V:G}">
                                                </Label>
                                            </AxisY>
                                            <SecondaryAxesY>
                                                <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="ETS Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                                                    <GridLines MinorVisible="True" Visible="True"></GridLines>
                                                    <Label TextPattern="{V:G}">
                                                    </Label>
                                                    <NumericScaleOptions AutoGrid="False" GridSpacing="1000000" />
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
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                </TabPages>
                <SpaceAfterTabsTemplate>
                    <dx:ASPxComboBox ID="myOption" runat="server" EnableTheming="True" SelectedIndex="0" Theme="DevEx" AutoPostBack="True" OnValueChanged="myOption_ValueChanged">
                        <Items>
                            <dx:ListEditItem Text="1 Day" Value="0" Selected="True" />
                            <dx:ListEditItem Text="5 Days" Value="1" />
                            <dx:ListEditItem Text="1 Month" Value="2" />
                            <dx:ListEditItem Text="1 Year" Value="3" />
                        </Items>
                    </dx:ASPxComboBox>
                    <asp:Label ID="lblType" runat="server" Text="Type:"></asp:Label>
                </SpaceAfterTabsTemplate>
            </dx:ASPxPageControl>
            <%--<dx:ASPxTimer ID="ASPxTimer1" runat="server" Interval="10000">
                <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxPageControl1_ASPxGridView0.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView1.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView2.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView3.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView4.PerformCallback();
                MainContent_ASPxPageControl1_ASPxGridView5.PerformCallback();
                }" />
            </dx:ASPxTimer>--%>
        </div>
    </div>
</asp:Content>
