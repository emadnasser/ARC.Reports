<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ResolveOverlappingPie3D.aspx.cs" Inherits="ResolveOverlappingPie3D" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">  
                <table style="width: 100%;">
                    <tr>
                        <td>
                            <dx:ASPxCheckBox ID="ASPxCheckBoxResolveOverlapping" runat="server" Text="Resolve Overlapping" Wrap="False" ClientInstanceName="chbResolveOverlapping">
                                <ClientSideEvents CheckedChanged="function(s, e) { 
labelIndent.SetEnabled(chbResolveOverlapping.GetChecked());
spinIndent.SetEnabled(chbResolveOverlapping.GetChecked());
chart.PerformCallback(&quot;custom&quot;);
}" />
                            </dx:ASPxCheckBox>
                        </td>
                        <td style="width: 100%;"></td>
                        <td><dx:ASPxLabel ID="lblIndent" runat="server" Text="Indent:" ClientInstanceName="labelIndent"/></td>
                        <td><div class="Spacer" style="width: 5px;"></div></td>
                        <td>
                            <dx:ASPxSpinEdit ID="ASPxSpinEditIndent" runat="server" Height="21px" Number="0" width="100px" ClientInstanceName="spinIndent" >
                                <ClientSideEvents ValueChanged="function(s, e) {
chart.PerformCallback(&quot;custom&quot;);
}" />
                                    </dx:ASPxSpinEdit>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" EnableViewState="False" OnCustomCallback="WebChartControl_CustomCallback">
        <SeriesSerializable>
            <dx:Series Name="Population by Country" LegendTextPattern="{VP:P0}  {A}">
                <Points>
                    <dx:SeriesPoint Values="1304.5" ArgumentSerializable="China" SeriesPointID="0"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1094.583" ArgumentSerializable="India" SeriesPointID="1"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="296.4104" ArgumentSerializable="USA" SeriesPointID="2"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="220.558" ArgumentSerializable="Indonesia" SeriesPointID="4"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="186.4049" ArgumentSerializable="Brazil" SeriesPointID="5"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="155.772" ArgumentSerializable="Pakistan" SeriesPointID="6"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="143.1136" ArgumentSerializable="Russia" SeriesPointID="7"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="141.8223" ArgumentSerializable="Bangladesh" SeriesPointID="8"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="131.5297" ArgumentSerializable="Nigeria" SeriesPointID="10"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="127.774" ArgumentSerializable="Japan" SeriesPointID="11"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="103.0891" ArgumentSerializable="Mexico" SeriesPointID="33"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="83.119" ArgumentSerializable="Vietnam" SeriesPointID="34"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="83.05448" ArgumentSerializable="Phillippines" SeriesPointID="35"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="82.4694" ArgumentSerializable="Germany" SeriesPointID="36"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="74.03288" ArgumentSerializable="Egypt" SeriesPointID="37"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="2162.64087139" ArgumentSerializable="Others" SeriesPointID="40"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:Pie3DSeriesView></dx:Pie3DSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:Pie3DSeriesLabel Position="TwoColumns" ColumnIndent="30" ResolveOverlappingMode="Default" TextPattern="{A}">
                    </dx:Pie3DSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Indent="10" Text="Population by Country"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.nationmaster.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:SimpleDiagram3D RotationMatrixSerializable="-0.89253893528903;-0.392212857522464;0.222583295391159;0;-0.416197740726783;0.526345796021228;-0.741444228263125;0;0.17364817766693;-0.754406506735489;-0.633022221559489;0;0;0;0;1" RuntimeRotation="True" LabelsResolveOverlappingMinIndent="5"></dx:SimpleDiagram3D>
        </DiagramSerializable>
    </dx:WebChartControl>
</asp:Content>
