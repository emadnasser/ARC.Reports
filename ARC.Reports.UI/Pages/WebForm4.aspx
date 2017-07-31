<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="ARC.Reports.Pages.WebForm4" %>

<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


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
            <dx:Series Name="Market Share" ArgumentScaleType="DateTime" LegendName="Default Legend" ValueDataMembersSerializable="Percentage" ArgumentDataMember="date">
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
                <AxisX Title-Text="Date" VisibleInPanesSerializable="1">
                    <Tickmarks MinorVisible="False" Visible="False" />
                    <Label Staggered="True" TextPattern="{A:dd}" Visible="False">
                    </Label>
                    <CrosshairAxisLabelOptions Pattern="dd/MM/yyyy" />
                </AxisX>
                <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                    <GridLines MinorVisible="True" Visible="False"></GridLines>
                    <Label TextPattern="{V:G}">
                    </Label>
                </AxisY>
                <SecondaryAxesY>
                    <dx:SecondaryAxisY AxisID="0" Alignment="Near" Title-Text="ETS Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
<%--                        <WholeRange AlwaysShowZeroLevel="False" SideMarginsValue="0"></WholeRange>--%>
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
                    <dx:XYDiagramPane PaneID="1" Name="Pane 2"></dx:XYDiagramPane>
                </Panes>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>


    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RepConnection %>" SelectCommand="SELECT [Buy_Total_Ammount], [Sell_Total_Ammount], [ETS_Share_Value], [Market_Share_Value], [Market_Share_Index], [DiffDayNom], [DiffDayPer], [Percentage], [Market], [date], [Type] FROM [Rep_0011]"></asp:SqlDataSource>

</asp:Content>
