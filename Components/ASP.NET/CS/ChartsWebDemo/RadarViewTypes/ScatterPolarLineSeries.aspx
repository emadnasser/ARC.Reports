﻿<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ScatterPolarLineSeries.aspx.cs" Inherits="ScatterPolarLineSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table style="width: 100%;">
                <tr>
                    <td>
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="110px">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblMarkerKind" runat="server" Text="Marker Kind:" ClientInstanceName="labelMarkerKind"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td style="width: 100%;">
                        <dx:ASPxComboBox ID="cbMarkerKind" runat="server" Width="130px" ClientInstanceName="cmbMarkerKind">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerKind&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>                    
                    <td class="NoWrap"><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Function Type:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>                    
                    <td>
                        <dx:ASPxComboBox ID="cbFunctionType" runat="server" Width="130px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;FunctionType&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                </tr>
                <tr>
                    <td><div class="Spacer" style="width: 100%; height: 5px;"></div></td>
                </tr>
                <tr>
                    <td><dx:ASPxCheckBox ID="cbShowMarkers" runat="server" Text="Show Markers" Width="110px" ClientInstanceName="chbShowMarkers">
                        <ClientSideEvents CheckedChanged="function(s, e) {
	                        labelMarkerKind.SetEnabled(chbShowMarkers.GetChecked());
	                        labelMarkerSize.SetEnabled(chbShowMarkers.GetChecked());
	                        cmbMarkerKind.SetEnabled(chbShowMarkers.GetChecked());
	                        cmbMarkerSize.SetEnabled(chbShowMarkers.GetChecked());
	                        chart.PerformCallback(&quot;ShowMarkers&quot;);
                        }" />
                    </dx:ASPxCheckBox></td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblMarkerSize" runat="server" Text="Marker Size:" ClientInstanceName="labelMarkerSize"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td style="width: 100%;">
                        <dx:ASPxComboBox ID="cbMarkerSize" runat="server" Width="130px" ClientInstanceName="cmbMarkerSize">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerSize&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>                    
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback">
        <SeriesSerializable>
            <dx:Series Name="Function" ArgumentScaleType="Numerical" LabelsVisibility="False" ToolTipPointPattern="{A}: {V:F2}">
                <ViewSerializable>
                    <dx:ScatterPolarLineSeriesView Closed="False" MarkerVisibility="False">
                        <LineMarkerOptions Size="8"></LineMarkerOptions>
                    </dx:ScatterPolarLineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:RadarPointSeriesLabel ResolveOverlappingMode="HideOverlapped" TextPattern="{V:N2}">
                    </dx:RadarPointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <Legend Visibility="False"></Legend>
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Text="Function in Polar Coordinates"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:PolarDiagram StartAngleInDegrees="270">
                <AxisX>
                    <Label TextPattern="{A:G0}">
                    </Label>
                </AxisX>
                <AxisY>
                     <WholeRange AutoSideMargins="False" SideMarginsValue="0">
                    </WholeRange>
                </AxisY>
            </dx:PolarDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>
</asp:Content>