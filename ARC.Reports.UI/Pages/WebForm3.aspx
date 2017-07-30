<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ARC.Reports.Pages.WebForm3" %>

<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <dx:WebChartControl ID="WebChartControl1" runat="server" CrosshairEnabled="True" DataSourceID="SqlDataSource1" Height="400px" Width="1000px">
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX VisibleInPanesSerializable="-1;0" Color="Black" minorcount="9">
                    <GridLines Visible="True">
                    </GridLines>
                </AxisX>
                <AxisY VisibleInPanesSerializable="-1;0">
                </AxisY>
                <Panes>
                    <dx:XYDiagramPane Name="Pane 1" PaneID="0">
                    </dx:XYDiagramPane>
                </Panes>
            </dx:XYDiagram>
        </DiagramSerializable>
        <Legend Name="Default Legend"></Legend>
        <Legends>
            <dx:Legend AlignmentVertical="TopOutside" Name="Legend1">
            </dx:Legend>
        </Legends>
        <SeriesSerializable>
            <dx:Series ArgumentScaleType="DateTime" Name="Market Share" ValueDataMembersSerializable="Buy_Total_Ammount" LabelsVisibility="False">
                <ViewSerializable>
                    <dx:LineSeriesView>
                        <Indicators>
                            <dx:AverageTrueRange LegendName="Default Legend" Name="Average True Range 1" ShowInLegend="True">
                            </dx:AverageTrueRange>
                        </Indicators>
                    </dx:LineSeriesView>
                </ViewSerializable>
            </dx:Series>
            <dx:Series ColorDataMember="ETS_Share_Value" LegendName="Default Legend" Name="ETS Share Value" ValueDataMembersSerializable="ETS_Share_Value" ArgumentDataMember="date" ToolTipHintDataMember="ETS_Share_Value">
                <DataFilters>
                    <dx:DataFilter ColumnName="Buy_Total_Ammount" DataType="System.Decimal" />
                    <dx:DataFilter ColumnName="Market_Share_Index" DataType="System.Decimal" />
                </DataFilters>
                <ViewSerializable>
                    <dx:LineSeriesView PaneName="Pane 1">
                    </dx:LineSeriesView>
                </ViewSerializable>
            </dx:Series>
        </SeriesSerializable>
    </dx:WebChartControl>


    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RepConnection %>" SelectCommand="SELECT [Buy_Total_Ammount], [Sell_Total_Ammount], [ETS_Share_Value], [Market_Share_Value], [Market_Share_Index], [DiffDayNom], [DiffDayPer], [Percentage], [Market], [date], [Type] FROM [Rep_0011]"></asp:SqlDataSource>


</asp:Content>
