<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ResolveOverlappingAxisLabel.aspx.cs" Inherits="ResolveOverlappingAxisLabel" %>
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
    <dx:WebChartControl ID="WebChartControl" runat="server" Height="400px"
        Width="700px" ClientInstanceName="chart" EnableViewState="False" CssClass="AlignCenter TopLargeMargin"
        OnCustomCallback="WebChartControl_CustomCallback" CrosshairEnabled="False"
        ToolTipEnabled="False">
        <Legend AlignmentHorizontal="Right" Direction="LeftToRight"></Legend>
        <Titles>
            <dx:ChartTitle Text="Weather in London"></dx:ChartTitle>
        </Titles>
        <SeriesSerializable>
            <dx:Series Name="Relative humidity (%)" ArgumentScaleType="DateTime" LabelsVisibility="False">
                <Points>
                    <dx:SeriesPoint Values="69" ArgumentSerializable="06/11/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="76" ArgumentSerializable="06/11/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="66" ArgumentSerializable="06/11/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="49" ArgumentSerializable="06/10/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="45" ArgumentSerializable="06/10/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="48" ArgumentSerializable="06/10/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="57" ArgumentSerializable="06/10/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="66" ArgumentSerializable="06/10/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="78" ArgumentSerializable="06/10/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="83" ArgumentSerializable="06/10/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="72" ArgumentSerializable="06/10/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="52" ArgumentSerializable="06/09/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="40" ArgumentSerializable="06/09/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="41" ArgumentSerializable="06/09/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="37" ArgumentSerializable="06/09/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="41" ArgumentSerializable="06/09/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="68" ArgumentSerializable="06/09/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="78" ArgumentSerializable="06/09/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="71" ArgumentSerializable="06/09/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="63" ArgumentSerializable="06/08/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="47" ArgumentSerializable="06/08/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="44" ArgumentSerializable="06/08/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="48" ArgumentSerializable="06/08/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="68" ArgumentSerializable="06/08/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="81" ArgumentSerializable="06/08/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="85" ArgumentSerializable="06/08/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="76" ArgumentSerializable="06/08/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="65" ArgumentSerializable="06/07/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="57" ArgumentSerializable="06/07/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="62" ArgumentSerializable="06/07/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="53" ArgumentSerializable="06/07/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="62" ArgumentSerializable="06/07/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="76" ArgumentSerializable="06/07/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="80" ArgumentSerializable="06/07/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="82" ArgumentSerializable="06/07/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="73" ArgumentSerializable="06/06/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="57" ArgumentSerializable="06/06/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="55" ArgumentSerializable="06/06/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="64" ArgumentSerializable="06/06/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="74" ArgumentSerializable="06/06/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="89" ArgumentSerializable="06/06/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="87" ArgumentSerializable="06/06/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="80" ArgumentSerializable="06/06/2008 00:00:00.000"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:SideBySideBarSeriesView BarWidth="1.5"></dx:SideBySideBarSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:SideBySideBarSeriesLabel Position="Center"></dx:SideBySideBarSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <DiagramSerializable>
            <dx:XYDiagram PaneDistance="4" AxisLabelsResolveOverlappingMinIndent="0">
                <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True">
                    <DateTimeScaleOptions MeasureUnit="Hour" GridAlignment="Hour" AutoGrid="False" GridSpacing="6"/>
                    <GridLines Visible="True"></GridLines>
                    <Label TextPattern="{A:dd/MM HH:mm}">
                    </Label>
                </AxisX>
                <AxisY Title-Text="Humidity, %" Title-Visibility="True" Title-Font="Tahoma, 9.75pt" VisibleInPanesSerializable="-1">
                    <WholeRange Auto="False" MinValueSerializable="0" MaxValueSerializable="120" AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                    <GridLines MinorVisible="True"></GridLines>
                </AxisY>
                <DefaultPane Weight="2"></DefaultPane>
            </dx:XYDiagram>
        </DiagramSerializable>
        <BorderOptions Visibility="False" />
    </dx:WebChartControl>
</asp:Content>
