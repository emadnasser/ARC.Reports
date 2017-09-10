<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="ARC.Reports.Pages.WebForm4" %>

<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>

<form id="form1" runat="server">

<dx:WebChartControl ID="WebChartControl1" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
    Width="1000px" ClientInstanceName="Chart_1" CrosshairEnabled="True" DataSourceID="SqlDataSource1">
    <SeriesSerializable>
        <dx:Series Name="Market Share" LabelsVisibility="False" ArgumentDataMember="date" ValueDataMembersSerializable="Percentage" 
            CrosshairLabelPattern="Market Share: {V:n2}
            {HINT}:::&lt;br /&gt; At: {A}" LegendName="Default Legend" 
            ToolTipEnabled="True" ToolTipHintDataMember="ETS_Share_Value"
            ToolTipPointPattern="{A}{HINT}{V}">
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
    <Legend AlignmentHorizontal="Right" Direction="LeftToRight" AlignmentVertical="BottomOutside" MarkerSize="18, 35" Visibility="True">
        <Border Visibility="True" />
    </Legend>
    <BorderOptions Visibility="False" />
    <DiagramSerializable>
        <dx:XYDiagram PaneDistance="4">
            <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True" InterlacedColor="244, 243, 237">
                <GridLines Visible="False"></GridLines>
                <Label Staggered="True" TextPattern="{A:dd/MMM}">
                </Label>
                <CrosshairAxisLabelOptions Pattern="dd/MM/yyyy" />
                <DateTimeScaleOptions MeasureUnit="Day" GridAlignment="Day" AutoGrid="True" GridSpacing="6" WorkdaysOnly="True">
                    <WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></WorkdaysOptions>
                </DateTimeScaleOptions>
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
                <workdaysoptions workdays="Sunday, Monday, Tuesday, Wednesday, Thursday"></workdaysoptions>
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
            <DefaultPane Weight="2"></DefaultPane>
        </dx:XYDiagram>
    </DiagramSerializable>
</dx:WebChartControl>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RepConnection %>" SelectCommand="
        SELECT
MAX([ETS_Share_Value]) AS[ETS_Share_Value], MAX([Market_Share_Value]) AS[Market_Share_Value], MAX([Percentage]) AS[Percentage], CONVERT(VARCHAR(5), [date], 108) AS[date] FROM MarketShare_Graphs
WHERE[Type] = 'Value' AND[Market] = 'SAM' AND[date] = CONVERT(DATE, '2017-08-07')
GROUP BY CONVERT(VARCHAR(5), [date], 108)
ORDER BY[date]"></asp:SqlDataSource>
</form>

