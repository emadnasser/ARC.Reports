﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ARC.Reports.Pages.WebForm2" %>

<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <dx:WebChartControl ID="WebChartControl2" runat="server" Height="420px" CssClass="AlignCenter TopLargeMargin"
        Width="1000px" ClientInstanceName="chart" EnableViewState="False" DataSourceID="SqlDataSource1" CrosshairEnabled="True" PaletteName="Concourse">
        <borderoptions visibility="False" />
                <DiagramSerializable>
                    <dx:SwiftPlotDiagram>
                        <AxisX VisibleInPanesSerializable="-1">
                        </AxisX>
                        <AxisY VisibleInPanesSerializable="-1">
                        </AxisY>
                    </dx:SwiftPlotDiagram>
        </DiagramSerializable>
        <legend alignmenthorizontal="Left"></legend>
        <Legends>
            <dx:Legend Name="Legend1">
            </dx:Legend>
            <dx:Legend Name="Legend2">
            </dx:Legend>
        </Legends>
        <SeriesSerializable>
            <dx:Series ArgumentDataMember="Date" ArgumentScaleType="DateTime" LegendName="Default Legend" LegendTextPattern="d" LabelsVisibility="False"
                Name="Series 1" ValueDataMembersSerializable="Percentage; ETS_Share_Value; Market_Share_Value">
                
                <ViewSerializable>
                    <dx:SwiftPlotSeriesView>
                    </dx:SwiftPlotSeriesView>
                </ViewSerializable>
            
                <LabelSerializable>
                    <dx:StockSeriesLabel ResolveOverlappingMode="Default"></dx:StockSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
    </dx:WebChartControl>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RepConnection %>"
        SelectCommand="SELECT [Buy_Total_Ammount], [Sell_Total_Ammount], [ETS_Share_Value], [Market_Share_Value], [Market_Share_Index], [DiffDayNom], [DiffDayPer], [Percentage], [Market], [date], [Type] FROM [Rep_0011] 
        WHERE MONTH([date]) = MONTH(GETDATE()) AND [Type] = 'Value' AND Market = 'SAM'"></asp:SqlDataSource>
</asp:Content>

<%--
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="420px" CssClass="AlignCenter TopLargeMargin"
        Width="700px" ClientInstanceName="chart" EnableViewState="False" OnCustomCallback="WebChartControl1_CustomCallback"
        DataSourceID="chartDataSource">
        <borderoptions visibility="False" />
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True">
                    <DateTimeScaleOptions GridAlignment="Month" WorkdaysOnly="True" AutoGrid="False" GridSpacing="0.5">
                    </DateTimeScaleOptions>
                    <GridLines Visible="True"></GridLines>
                </AxisX>
                <AxisY Title-Text="US Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">
                    <WholeRange AlwaysShowZeroLevel="False" ></WholeRange>
                    <GridLines MinorVisible="True"></GridLines>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
        <legend alignmenthorizontal="Left"></legend>
        <SeriesSerializable>
            <dx:Series Name="Apple Inc." ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Low;High;Open;Close"> 
                <ViewSerializable>
                    <dx:StockSeriesView LevelLineLength="0.3">
                        <Indicators>
                            <dx:MedianPrice Name="Median Price" ShowInLegend="True">
                                <linestyle thickness="2" />
                            </dx:MedianPrice>
                        </Indicators>
                    </dx:StockSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:StockSeriesLabel ResolveOverlappingMode="Default"></dx:StockSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <Titles>
            <dx:ChartTitle Text="Stock Prices"></dx:ChartTitle>
            <dx:ChartTitle Alignment="Far" Dock="Bottom" Font="Tahoma, 8pt" Text="From www.quandl.com" TextColor="Gray"></dx:ChartTitle>
        </Titles>
    </dx:WebChartControl>
--%>
