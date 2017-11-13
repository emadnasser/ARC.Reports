<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RangeBarSeries.aspx.cs" Inherits="RangeBarSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin" ClientInstanceName="chart"
        CrosshairEnabled="False" ToolTipEnabled="True">
        <Legend AlignmentHorizontal="Right" AlignmentVertical="Top" Direction="LeftToRight"></Legend>
        <Titles>
            <dx:ChartTitle Text="Crude Oil Prices in 2015"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.eia.gov" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <SeriesSerializable>
            <dx:Series Name="Europe Brent" ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Min;Max"
                ToolTipPointPattern="{S}<br/>Month: {A:MMMM}<br/>Min Price: ${V1:0.00}<br/>Max Price: ${V2:0.00}">
                <ViewSerializable>
                    <dx:OverlappedRangeBarSeriesView></dx:OverlappedRangeBarSeriesView>
                </ViewSerializable>
            </dx:Series>
            <dx:Series Name="OK WTI" ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Min;Max"
                ToolTipPointPattern="{S}<br/>Month: {A:MMMM}<br/>Min Price: ${V1:0.00}<br/>Max Price: ${V2:0.00}">
                <ViewSerializable>
                    <dx:OverlappedRangeBarSeriesView BarWidth="0.2"></dx:OverlappedRangeBarSeriesView>
                </ViewSerializable>
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
