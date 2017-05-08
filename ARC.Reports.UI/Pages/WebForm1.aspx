<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ARC.Reports.Pages.WebForm1" %>

<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
        Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
        OnCustomCallback="WebChartControl1_CustomCallback"
        ToolTipEnabled="False" CrosshairEnabled="True">
        <SeriesSerializable>
            <dx:Series Name="APT">
                <Points>
                    <dx:SeriesPoint ArgumentSerializable="1950" Values="546"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1960" Values="605"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1970" Values="656"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1980" Values="694"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1990" Values="721"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2000" Values="730"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2010" Values="728"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2020" Values="721"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2030" Values="704"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2040" Values="680"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2050" Values="650"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView>
                        <LineMarkerOptions Size="8"></LineMarkerOptions>
                    </dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel BackColor="Transparent" LineLength="5"
                        LineVisibility="False" ResolveOverlappingMode="JustifyAllAroundPoint">
                        <Border Visibility="False" />
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Branches">
                <Points>
                    <dx:SeriesPoint ArgumentSerializable="1950" Values="332"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1960" Values="417"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1970" Values="513"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1980" Values="614"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1990" Values="721"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2000" Values="836"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2010" Values="935"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2020" Values="1027"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2030" Values="1110"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2040" Values="1178"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2050" Values="1231"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView>
                        <LineMarkerOptions Size="8"></LineMarkerOptions>
                    </dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel BackColor="Transparent" LineLength="5"
                        LineVisibility="False" ResolveOverlappingMode="JustifyAllAroundPoint">
                        <Border Visibility="False" />
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="CTF">
                <Points>
                    <dx:SeriesPoint ArgumentSerializable="1950" Values="227"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1960" Values="283"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1970" Values="361"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1980" Values="471"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="1990" Values="623"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2000" Values="797"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2010" Values="982"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2020" Values="1189"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2030" Values="1416"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2040" Values="1665"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="2050" Values="1937"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView>
                        <LineMarkerOptions Size="8"></LineMarkerOptions>
                    </dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel Angle="-45" BackColor="Transparent" LineLength="5"
                        LineVisibility="False" ResolveOverlappingMode="JustifyAllAroundPoint">
                        <Border Visibility="False" />
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Interlaced="True" Title-Text="Years" VisibleInPanesSerializable="-1">
                    <WholeRange />
                    <GridLines Visible="True"></GridLines>
                    <Label>
                    </Label>
                </AxisX>
                <AxisY Title-Text="Population mid-year, millions" Title-Visibility="True" VisibleInPanesSerializable="-1">
                    <WholeRange AlwaysShowZeroLevel="False" />
                    <Label>
                    </Label>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Text="Historic, current and future population "></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.geohive.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
    </dx:WebChartControl>--%>

    <dx:WebChartControl ID="WebChartControl2" runat="server" CrosshairEnabled="True" Height="200px" Width="300px" DataSourceID="SqlDataSource1">
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX VisibleInPanesSerializable="-1" labelvisibilitymode="AutoGeneratedAndCustom" title-visibility="Default" visibility="True" >
                    <Strips>
                        <dx:Strip Name="Strip 1">
                            <MinLimit AxisValueSerializable="A" />
                            <MaxLimit AxisValueSerializable="B" />
                        </dx:Strip>
                    </Strips>
                    <ConstantLines>
                        <dx:ConstantLine AxisValueSerializable="B" Name="Constant Line 1">
                        </dx:ConstantLine>
                    </ConstantLines>
                    <CustomLabels>
                        <dx:CustomAxisLabel AxisValueSerializable="A" Name="Label 1">
                        </dx:CustomAxisLabel>
                        <dx:CustomAxisLabel AxisValueSerializable="A" Name="Label 2">
                        </dx:CustomAxisLabel>
                        <dx:CustomAxisLabel AxisValueSerializable="A" Name="Label 3">
                        </dx:CustomAxisLabel>
                        <dx:CustomAxisLabel AxisValueSerializable="A" Name="Label 4">
                        </dx:CustomAxisLabel>
                        <dx:CustomAxisLabel AxisValueSerializable="A" Name="Label 5">
                        </dx:CustomAxisLabel>
                    </CustomLabels>
                </AxisX>
                <AxisY VisibleInPanesSerializable="-1">
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
        <Legend Name="Default Legend" Visibility="True"></Legend>
        <SeriesSerializable>
            <dx:Series Name="Channel" ArgumentDataMember="Channel">
                <ViewSerializable>
                    <dx:LineSeriesView>
                    </dx:LineSeriesView>
                </ViewSerializable>
            </dx:Series>
        </SeriesSerializable>
    </dx:WebChartControl>

    <dx:WebChartControl ID="WebChartControl1" runat="server" CrosshairEnabled="True" DataSourceID="SqlDataSource1" Height="200px" Width="300px">
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX VisibleInPanesSerializable="-1">
                </AxisX>
                <AxisY VisibleInPanesSerializable="-1">
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
<Legend Name="Default Legend"></Legend>
        <SeriesSerializable>
            <dx:Series ArgumentDataMember="InsertedDate" Name="Series 1" ToolTipHintDataMember="Transactions" ValueDataMembersSerializable="Amount">
                <ViewSerializable>
                    <dx:LineSeriesView>
                    </dx:LineSeriesView>
                </ViewSerializable>
            </dx:Series>
        </SeriesSerializable>
    </dx:WebChartControl>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RepConnection %>" SelectCommand="SELECT * FROM [dbo].[Rep_001] WHERE MarketType = 'SAM'"></asp:SqlDataSource>
</asp:Content>
