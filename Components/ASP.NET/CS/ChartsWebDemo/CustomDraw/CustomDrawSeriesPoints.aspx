<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomDrawSeriesPoints.aspx.cs" Inherits="CustomDrawSeriesPoints" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">   
            <table style="width: 100%;">
                <tr>
                    <td>
                        <dx:ASPxButton ID="btnCreateBars" runat="server" Text="Create&nbsp;Bars" AutoPostBack="false" Width="125px">
                            <ClientSideEvents Click="function(s, e) { chart.PerformCallback(&quot;CreateBars&quot;); }" />
                        </dx:ASPxButton>
                    </td>                    
                    <td><div class="Spacer" style="width: 10px;"></div></td>                    
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbCustomDraw" runat="server" Text="Custom&nbsp;Draw" OnCheckedChanged="cbCustomDraw_CheckedChanged">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;CustomDraw&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td>
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show&nbsp;Labels">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
                        </dx:ASPxCheckBox>                        
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
        Width="700px" OnCustomDrawSeriesPoint="WebChartControl1_CustomDrawSeriesPoint" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
        AlternateText="The Random Points chart." CrosshairEnabled="False"
        ToolTipEnabled="False">
        <SeriesSerializable>
            <dx:Series Name="Series 1">
                <ViewSerializable>
                    <dx:SideBySideBarSeriesView>
                        <FillStyle FillMode="Gradient" />
                    </dx:SideBySideBarSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:SideBySideBarSeriesLabel TextPattern="{V:F1}">
                    </dx:SideBySideBarSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <Legend Visibility="False"></Legend>
        <BorderOptions Visibility="False" />
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Title-Text="Arguments" VisibleInPanesSerializable="-1">
                    
                </AxisX>
                <AxisY Title-Text="Values" VisibleInPanesSerializable="-1" Interlaced="True">
                    <Strips>
                        <dx:Strip Color="255, 181, 181" ShowAxisLabel="True" Name="High">
                            <MinLimit AxisValueSerializable="2"></MinLimit>
                            <MaxLimit AxisValueSerializable="3"></MaxLimit>
                            <FillStyle FillMode="Gradient">
                                <OptionsSerializable>
                                    <dx:RectangleGradientFillOptions></dx:RectangleGradientFillOptions>
                                </OptionsSerializable>
                            </FillStyle>
                        </dx:Strip>
                        <dx:Strip Color="255, 220, 113" ShowAxisLabel="True" Name="Middle">
                            <MinLimit AxisValueSerializable="1"></MinLimit>
                            <MaxLimit AxisValueSerializable="2"></MaxLimit>
                            <FillStyle FillMode="Gradient">
                                <OptionsSerializable>
                                    <dx:RectangleGradientFillOptions></dx:RectangleGradientFillOptions>
                                </OptionsSerializable>
                            </FillStyle>
                        </dx:Strip>
                        <dx:Strip Color="192, 227, 125" ShowAxisLabel="True" Name="Low">
                            <MinLimit AxisValueSerializable="0"></MinLimit>
                            <MaxLimit AxisValueSerializable="1"></MaxLimit>
                            <FillStyle FillMode="Gradient">
                                <OptionsSerializable>
                                    <dx:RectangleGradientFillOptions></dx:RectangleGradientFillOptions>
                                </OptionsSerializable>
                            </FillStyle>
                        </dx:Strip>
                    </Strips>                    
                    <WholeRange MinValueSerializable="0" MaxValueSerializable="3" autosidemargins="False" sidemarginsvalue="0.0" />
                    <NumericScaleOptions AutoGrid="False" GridSpacing="75"/>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>
</asp:Content>
