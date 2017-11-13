<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LineSeries.aspx.cs" Inherits="LineSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;"><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="95px" ClientInstanceName="chbShowLabels">
                        <ClientSideEvents CheckedChanged="function(s, e) {
	chart.PerformCallback(&quot;ShowLabels&quot;);
}" />
                    </dx:ASPxCheckBox></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblMarkerKind" runat="server" Text="Marker Kind:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbMarkerKind" runat="server" Width="130px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerKind&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblMarkerSize" runat="server" Text="Marker Size:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td style="width: 100%;">
                        <dx:ASPxComboBox ID="cbMarkerSize" runat="server" Width="50px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerSize&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
        Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
        OnCustomCallback="WebChartControl1_CustomCallback"
        ToolTipEnabled="False">
        <SeriesSerializable>
            <dx:Series Name="Europe">
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
                        <LineMarkerOptions size="8"></LineMarkerOptions>
                    </dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel BackColor="Transparent" LineLength="5" 
                                        LineVisibility="False" ResolveOverlappingMode="JustifyAllAroundPoint">
                        <Border Visibility="False" />
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Americas">
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
                        <LineMarkerOptions size="8"></LineMarkerOptions>
                    </dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel BackColor="Transparent" LineLength="5" 
                                        LineVisibility="False" ResolveOverlappingMode="JustifyAllAroundPoint">
                        <Border Visibility="False" />
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Africa">
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
                        <LineMarkerOptions size="8"></LineMarkerOptions>
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
                    <WholeRange/>
                    <GridLines visible="True"></GridLines>
                    <Label>
                    </Label>
                </AxisX>
                <AxisY Title-Text="Population mid-year, millions" Title-Visibility="True" VisibleInPanesSerializable="-1">
                    <WholeRange AlwaysShowZeroLevel="False"/>
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
    </dx:WebChartControl>
</asp:Content>
