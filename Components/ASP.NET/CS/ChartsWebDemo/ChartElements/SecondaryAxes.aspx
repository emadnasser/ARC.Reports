<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SecondaryAxes.aspx.cs" Inherits="SecondaryAxes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">     
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblChartType" runat="server" Text="Chart Type:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbChartType" runat="server" Width="60px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ChangeChartType&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lbSeriesTwoAxisX" runat="server" Text="Series 2 Axis X:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbSeriesAxisX" runat="server" Width="125px">                         
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ChangeSeriesTwoAxisX&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>                    
                </tr>
                <tr>
                    <td><div class="Spacer" style="width: 100%;height: 5px"></div></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>     
                    <td></td>     
                    <td></td>     
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lbSeriesTwoAxisY" runat="server" Text="Series 2 Axis Y:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbSeriesAxisY" runat="server" Width="125px">                        
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ChangeSeriesTwoAxisY&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback">
        <SeriesSerializable>
            <dx:Series Name="Series 2">
                <Points>
                    <dx:SeriesPoint Values="40" ArgumentSerializable="A"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="30" ArgumentSerializable="B"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="25" ArgumentSerializable="C"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="22.5" ArgumentSerializable="D"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="21.25" ArgumentSerializable="E"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView></dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel ResolveOverlappingMode="JustifyAroundPoint" TextPattern="{A}: {V}">
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Series 1">
                <Points>
                    <dx:SeriesPoint Values="1700" ArgumentSerializable="A"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="900" ArgumentSerializable="B"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="500" ArgumentSerializable="C"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="300" ArgumentSerializable="D"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="200" ArgumentSerializable="E"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="150" ArgumentSerializable="F"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="125" ArgumentSerializable="G"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView>
                        <LineMarkerOptions Kind="Square"></LineMarkerOptions>
                    </dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel ResolveOverlappingMode="JustifyAroundPoint" TextPattern="{A}: {V}">
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <Legend Direction="BottomToTop" AlignmentHorizontal="Right">
            <Margins Bottom="10" Left="10" Right="10" Top="10" />
        </Legend>
        <BorderOptions Visibility="False" />
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Title-Text="" Title-Visibility="True" VisibleInPanesSerializable="-1">                    
                    <GridLines Visible="True"></GridLines>
                </AxisX>
                <AxisY Title-Visibility="True" VisibleInPanesSerializable="-1" Interlaced="True">                    
                    <GridLines MinorVisible="True"></GridLines>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
        <CrosshairOptions GroupHeaderPattern="{A}"/>
    </dx:WebChartControl>
</asp:Content>
