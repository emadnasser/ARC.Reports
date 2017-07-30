<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="ARC.Reports.Pages.WebForm4" %>

<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
        Width="700px" ClientInstanceName="chart" CrosshairEnabled="True">
        <SeriesSerializable>
            <dx:Series Name="Temperature (&#176;F)" ArgumentScaleType="DateTime" LabelsVisibility="True">
                <Points>
                    <dx:SeriesPoint Values="56.48" ArgumentSerializable="06/11/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="53.78" ArgumentSerializable="06/11/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="57.74" ArgumentSerializable="06/11/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="64.4" ArgumentSerializable="06/10/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="72.5" ArgumentSerializable="06/10/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="72.68" ArgumentSerializable="06/10/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="69.62" ArgumentSerializable="06/10/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="67.28" ArgumentSerializable="06/10/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="62.42" ArgumentSerializable="06/10/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="60.62" ArgumentSerializable="06/10/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="62.6" ArgumentSerializable="06/10/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="71.96" ArgumentSerializable="06/09/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="77.9" ArgumentSerializable="06/09/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="78.98" ArgumentSerializable="06/09/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="76.28" ArgumentSerializable="06/09/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="71.06" ArgumentSerializable="06/09/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="60.8" ArgumentSerializable="06/09/2008 06:00:00.000"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView></dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel Angle="90">
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Pressure (mbar)" ArgumentScaleType="DateTime" LabelsVisibility="False">
                <Points>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/11/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/11/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/11/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/10/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1020" ArgumentSerializable="06/10/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/10/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/10/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/10/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/10/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/10/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/10/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/09/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/09/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/09/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1024" ArgumentSerializable="06/09/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1024" ArgumentSerializable="06/09/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1024" ArgumentSerializable="06/09/2008 06:00:00.000"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:AreaSeriesView Transparency="0" PaneName="Pane 1" AxisYName="secondaryAxisY1" MarkerVisibility="False">
                    </dx:AreaSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel>
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Relative humidity (%)" ArgumentScaleType="DateTime" LabelsVisibility="False">
                <Points>
                    <dx:SeriesPoint Values="69" ArgumentSerializable="06/11/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="76" ArgumentSerializable="06/11/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="66" ArgumentSerializable="06/11/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="49" ArgumentSerializable="06/10/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="45" ArgumentSerializable="06/10/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="48" ArgumentSerializable="06/10/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="57" ArgumentSerializable="06/10/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="66" ArgumentSerializable="06/10/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="78" ArgumentSerializable="06/10/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="83" ArgumentSerializable="06/10/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="72" ArgumentSerializable="06/10/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="52" ArgumentSerializable="06/09/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="40" ArgumentSerializable="06/09/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="41" ArgumentSerializable="06/09/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="37" ArgumentSerializable="06/09/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="41" ArgumentSerializable="06/09/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="68" ArgumentSerializable="06/09/2008 06:00:00.000"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:SideBySideBarSeriesView BarWidth="1.4" PaneName="Pane 2" AxisYName="secondaryAxisY2"></dx:SideBySideBarSeriesView>
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
        <Legend AlignmentHorizontal="Left" Direction="LeftToRight" AlignmentVertical="BottomOutside"></Legend>
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Text="Weather in London"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram PaneDistance="4">
                <AxisX Title-Text="Date" VisibleInPanesSerializable="1" Interlaced="True">
                    <DateTimeScaleOptions MeasureUnit="Hour" GridAlignment="Hour" AutoGrid="False" GridSpacing="6" />
                    <Label Staggered="True" TextPattern="{A:dd/MM HH:mm}">
                    </Label>
                    <CrosshairAxisLabelOptions Pattern="{A:g}" />

                    <GridLines Visible="True"></GridLines>
                </AxisX>
                <AxisY Title-Text="Temperature, &#176;F" Title-Visibility="True" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                    <GridLines MinorVisible="True"></GridLines>
                    <Label TextPattern="{V:G}">
                    </Label>
                </AxisY>
                <SecondaryAxesY>
                    <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="Pressure, mbar" Title-Visibility="True" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                        <WholeRange Auto="False" MinValueSerializable="1014" MaxValueSerializable="1025" AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                        <GridLines Visible="True" MinorVisible="True"></GridLines>
                        <Label TextPattern="{V:G}">
                        </Label>
                        <NumericScaleOptions AutoGrid="False" GridSpacing="4" />
                    </dx:SecondaryAxisY>
                    <dx:SecondaryAxisY AxisID="1" Alignment="Near" Title-Text="Humidity, %" Title-Visibility="True" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="1" Name="secondaryAxisY2">
                        <ConstantLines>
                            <dx:ConstantLine AxisValueSerializable="100" ShowInLegend="False" Title-Visible="False" Name="ConstantLine1" />
                        </ConstantLines>
                        <WholeRange Auto="False" MinValueSerializable="0" MaxValueSerializable="120" AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                        <GridLines Visible="True" MinorVisible="True"></GridLines>
                        <Label TextPattern="{V:G}">
                        </Label>
                        <NumericScaleOptions AutoGrid="False" GridSpacing="50" />
                    </dx:SecondaryAxisY>
                </SecondaryAxesY>
                <DefaultPane Weight="2"></DefaultPane>
                <Panes>
                    <dx:XYDiagramPane PaneID="0" Name="Pane 1"></dx:XYDiagramPane>
                    <dx:XYDiagramPane PaneID="1" Weight="1.5" Name="Pane 2"></dx:XYDiagramPane>
                </Panes>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>


    <%--==========================================================================================================================================================================--%>

    <dx:WebChartControl ID="WebChartControl2" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
        Width="1000px" ClientInstanceName="chart" CrosshairEnabled="True" DataSourceID="SqlDataSource1">
        <SeriesSerializable>
            <dx:Series Name="Market Share Value" ArgumentScaleType="DateTime" LabelsVisibility="False" ArgumentDataMember="date" ValueDataMembersSerializable="Market_Share_Value">
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
            <dx:Series Name="ETS Share Value" ArgumentScaleType="DateTime" LabelsVisibility="False" ArgumentDataMember="date" ValueDataMembersSerializable="ETS_Share_Value">
                <ViewSerializable>
                    <dx:LineSeriesView AxisYName="secondaryAxisY1" MarkerVisibility="False" PaneName="Pane 1">
                    </dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel>
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Market Share" ArgumentScaleType="DateTime" LabelsVisibility="False" LegendName="Default Legend" ValueDataMembersSerializable="Percentage" ArgumentDataMember="date">
                <ViewSerializable>
                    <dx:LineSeriesView AxisYName="secondaryAxisY2" MarkerVisibility="False" PaneName="Pane 2">
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
        <Legend AlignmentHorizontal="Center" Direction="LeftToRight" AlignmentVertical="BottomOutside" MarkerSize="18, 35" Visibility="True">
            <Border Visibility="True" />
        </Legend>
        <BorderOptions Visibility="False" />
        <DiagramSerializable>
            <dx:XYDiagram PaneDistance="4">
                <AxisX Title-Text="Date" VisibleInPanesSerializable="1">
                    <Tickmarks MinorVisible="False" Visible="False" />
                    <Label Staggered="True" TextPattern="{A:dd}" Visible="False">
                    </Label>
                    <CrosshairAxisLabelOptions Pattern="dd/MM/yyyy" />
                </AxisX>
                <AxisY Title-Text="Market Share Value" Title-Visibility="True" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                    <GridLines MinorVisible="True" Visible="False"></GridLines>
                    <Label TextPattern="{V:G}">
                    </Label>
                </AxisY>
                <SecondaryAxesY>
                    <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="ETS Share Value" Title-Visibility="True" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                        <VisualRange AutoSideMargins="False" SideMarginsValue="0"></VisualRange>
<%--                        <WholeRange AlwaysShowZeroLevel="False" SideMarginsValue="0"></WholeRange>--%>
                        <WholeRange Auto="False" MinValueSerializable="90000000" MaxValueSerializable="2000000000" AutoSideMargins="False" SideMarginsValue="5"></WholeRange>
                        <GridLines Visible="True" MinorVisible="True"></GridLines>
                        <Label TextPattern="{V:G}">
                        </Label>
                        <NumericScaleOptions AutoGrid="False" GridSpacing="15" />
                    </dx:SecondaryAxisY>
                    <dx:SecondaryAxisY AxisID="1" Alignment="Near" Title-Text="Market Share" Title-Visibility="True" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="1" Name="secondaryAxisY2">
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
                    <dx:XYDiagramPane PaneID="0" Name="Pane 1"></dx:XYDiagramPane>
                    <dx:XYDiagramPane PaneID="1" Name="Pane 2"></dx:XYDiagramPane>
                </Panes>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>


    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RepConnection %>" SelectCommand="SELECT [Buy_Total_Ammount], [Sell_Total_Ammount], [ETS_Share_Value], [Market_Share_Value], [Market_Share_Index], [DiffDayNom], [DiffDayPer], [Percentage], [Market], [date], [Type] FROM [Rep_0011]"></asp:SqlDataSource>

</asp:Content>
