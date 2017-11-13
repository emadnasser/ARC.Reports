<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Funnel3DSeries.aspx.cs" Inherits="Funnel3DSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table style="width: 100%;">
                <tr>
                    <td class="NoWrap" ><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" ClientInstanceName="chbShowLabels" Width="90px">
                        <ClientSideEvents CheckedChanged="function(s, e) {
	chart.PerformCallback(&quot;ShowLabels&quot;);
	labelLabelPosition.SetEnabled(chbShowLabels.GetChecked());
	cmbLabelPosition.SetEnabled(chbShowLabels.GetChecked());
	cmbValueAsPercent.SetEnabled(chbShowLabels.GetChecked());
}" />
                    </dx:ASPxCheckBox></td>  
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblLabelPosition" runat="server" Text="Label Position:" ClientInstanceName="labelLabelPosition"/></td>                    
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbLabelPosition" runat="server" Width="95px" ClientInstanceName="cmbLabelPosition">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;LabelPosition&quot;); }" />                    
                        </dx:ASPxComboBox>
                    </td> 
                    <td style="width: 100%;"> <div class="Spacer" style="width: 100%;"></div></td>                                     
                    <td class="NoWrap"><dx:ASPxLabel ID="lbPointDistance" runat="server" Text="Point Distance:"/></td>                    
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxSpinEdit ID="spinPointDistance" runat="server" Width="60px" MinValue="0" MaxValue="30">
                            <ClientSideEvents ValueChanged="function(s, e) { chart.PerformCallback(&quot;PointDistance&quot;); }" />
                        </dx:ASPxSpinEdit>
                    </td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblHoleRadius" runat="server" Text="Hole Radius(%):"/></td>                    
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxSpinEdit ID="spinHoleRadius" runat="server" Width="60px" MinValue="0" MaxValue="100">
                            <ClientSideEvents ValueChanged="function(s, e) { chart.PerformCallback(&quot;HoleRadius&quot;); }" />
                        </dx:ASPxSpinEdit>
                    </td>
                </tr>
                <tr><td><div class="Spacer" style="width: 100%;height: 5px"></div></td></tr>
                <tr>
                    <td>
                        <dx:ASPxCheckBox ID="cbValueAsPercent" runat="server" Text="Value as Percent" ClientInstanceName="cmbValueAsPercent" Width="120px">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ValueAsPercent&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td></td>  
                    <td></td>                    
                    <td></td>
                    <td></td>  
                    <td style="width: 100%;"><div class="Spacer" style="width: 100%;"></div></td>                                     
                    <td class="NoWrap"><dx:ASPxLabel ID="lbHeightToWidthRatio" runat="server" Text="Height / Width:"/></td>                    
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbHeightToWidthRatio" runat="server" Width="60px" ClientInstanceName="cmbHeightToWidthRatio">                                                
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;HeightToWidthRatio&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback1">
        <SeriesSerializable>
            <dx:Series Name="Website Visitor Trend" LegendTextPattern="{A}: {VP:P0}">
                <Points>
                    <dx:SeriesPoint Values="9152" ArgumentSerializable="Visited a Website"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="6870" ArgumentSerializable="Downloaded a Trial"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="5121" ArgumentSerializable="Contacted to Support"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="2224" ArgumentSerializable="Subscribed"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1670" ArgumentSerializable="Renewed"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:Funnel3DSeriesView PointDistance="10"></dx:Funnel3DSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:Funnel3DSeriesLabel LineLength="40" TextPattern="{A}: {VP:P2}">
                    </dx:Funnel3DSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <Legend AlignmentHorizontal="Right" AlignmentVertical="Bottom"></Legend>
        <BorderOptions Visibility="False"></BorderOptions>
        <Titles>
            <dx:ChartTitle Text="Website Visitor Trend"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:FunnelDiagram3D RotationMatrixSerializable="1;0;0;0;0;0.866025403784439;0.5;0;0;-0.5;0.866025403784439;0;0;0;0;1" RuntimeRotation="True" RuntimeZooming="True" RuntimeScrolling="True"></dx:FunnelDiagram3D>
        </DiagramSerializable>
    </dx:WebChartControl>
</asp:Content>
