﻿<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Pie3DSeries.aspx.cs" Inherits="Pie3DSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;"><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" ClientInstanceName="chbShowLabels">
                        <ClientSideEvents CheckedChanged="function(s, e) {
	chart.PerformCallback(&quot;ShowLabels&quot;);
	labelLabelPosition.SetEnabled(chbShowLabels.GetChecked());
	cmbLabelPosition.SetEnabled(chbShowLabels.GetChecked());
}" />
                 </dx:ASPxCheckBox></td>
                    <td style="width: 100%;">
                        <table style="width: 100%">
                            <tr>
                                <td style="width: 100%;text-align: right;" class="NoWrap"><dx:ASPxLabel ID="lblLabelPosition" runat="server" Text="Label Position:" ClientInstanceName="labelLabelPosition"/></td>                    
                                <td><div class="Spacer" style="width: 5px;"></div></td>
                                <td>
                                    <dx:ASPxComboBox ID="cbLabelPosition" runat="server" Width="100px" ClientInstanceName="cmbLabelPosition">
                                        <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;LabelPosition&quot;); }" />                    
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td><div class="Spacer" style="width: 100%;height: 5px"></div></td>
                </tr>
                <tr>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbValueAsPercent" runat="server" Text="Value As Percent">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ValueAsPercent&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>                    
                    <td style="width: 100%;">
                        <table style="width: 100%">
                            <tr>
                                <td class="NoWrap"><dx:ASPxLabel ID="lbExplodeDistance" runat="server" Text="Explode Distance:"/></td>                    
                                <td><div class="Spacer" style="width: 5px;"></div></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="spinExplodeDistance" ClientInstanceName="spinExplodeDistance" runat="server" Width="50px" MinValue="10" MaxValue="100">
                                        <ClientSideEvents ValueChanged="function(s, e) { chart.PerformCallback(&quot;ExplodeDistance&quot;); }" />
                                    </dx:ASPxSpinEdit>
                                </td>
                                <td><div class="Spacer" style="width: 10px;"></div></td>
                                <td class="NoWrap"><dx:ASPxLabel ID="lblExplodedPoints" runat="server" Text="Exploded Points:"/></td>
                                <td><div class="Spacer" style="width: 5px;"></div></td>
                                <td>
                                    <dx:ASPxComboBox ID="cbExplodedPoints" runat="server" Width="100px" ClientInstanceName="cbExplodedPoints">
                                        <ClientSideEvents Init="function(s, e) { spinExplodeDistance.SetEnabled(cbExplodedPoints.GetSelectedIndex() != 0) }"
                                                          SelectedIndexChanged="function(s, e) {
    spinExplodeDistance.SetEnabled(cbExplodedPoints.GetSelectedIndex() != 0);
    chart.PerformCallback(&quot;ExplodedPoints&quot;);     
}" />
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback">
        <SeriesSerializable>
            <dx:Series Name="Area of Countries" LegendTextPattern="{A}">
                <Points>
                    <dx:SeriesPoint Values="17.0752" ArgumentSerializable="Russia" SeriesPointID="0"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="9.98467" ArgumentSerializable="Canada" SeriesPointID="1"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="9.63142" ArgumentSerializable="USA" SeriesPointID="2"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="9.59696" ArgumentSerializable="China" SeriesPointID="3"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="8.511965" ArgumentSerializable="Brazil" SeriesPointID="4"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="7.68685" ArgumentSerializable="Australia" SeriesPointID="5"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="3.28759" ArgumentSerializable="India" SeriesPointID="6"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="81.2" ArgumentSerializable="Others" SeriesPointID="7"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:Pie3DSeriesView ExplodedDistancePercentage ="10.0" ></dx:Pie3DSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:Pie3DSeriesLabel Position="Radial" ColumnIndent="20" Font="Tahoma, 8pt, style=Bold" TextPattern="{VP:P0}">
                    </dx:Pie3DSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Text="Area of Countries"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.nationmaster.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:SimpleDiagram3D RotationType="UseAngles" RotationOrder="ZXY" RotationAngleX="-35" RotationAngleZ="15" LabelsResolveOverlappingMinIndent="3"></dx:SimpleDiagram3D>
        </DiagramSerializable>
    </dx:WebChartControl>
</asp:Content>