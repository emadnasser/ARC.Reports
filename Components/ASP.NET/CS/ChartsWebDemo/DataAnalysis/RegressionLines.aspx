<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RegressionLines.aspx.cs" Inherits="RegressionLines" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">    
            <table style="width: 100%;">
                <tr>
                    <td><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="95px">
                        <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
                    </dx:ASPxCheckBox></td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblColor" runat="server" Text="Color:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbColor" runat="server" Width="100px" ValueType="System.String">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Color&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblThickness" runat="server" Text="Thickness:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td style="width: 100%;">
                        <dx:ASPxSpinEdit ID="spnThickness" runat="server" Width="50px" MaxValue="10" MinValue="1">
                            <ClientSideEvents ValueChanged="function(s, e) { chart.PerformCallback(&quot;Thickness&quot;);}" />
                        </dx:ASPxSpinEdit>
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnCreatePoints" runat="server" Text="Create Points" Width="140px" AutoPostBack="False">
                            <ClientSideEvents Click="function(s, e) { chart.PerformCallback(&quot;CreatePoints&quot;); }" />
                        </dx:ASPxButton>
                    </td>
                </tr>
                <tr>
                    <td><div class="Spacer" style="width: 100%;height: 5px"></div></td>
                </tr>
                <tr>
                    <td><div class="Spacer"></div></td>
                    <td><div class="Spacer"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblDashStyle" runat="server" Text="Dash Style:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbDashStyle" runat="server" Width="100px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;DashStyle&quot;); }" />
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
            <dx:Series Name="Random points" ArgumentScaleType="Numerical" LabelsVisibility="False">
                <ViewSerializable>
                    <dx:PointSeriesView>
                        <Indicators>
                            <dx:RegressionLine></dx:RegressionLine>
                        </Indicators>
                    </dx:PointSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel ResolveOverlappingMode="JustifyAllAroundPoint"  TextPattern="{V:F2}">
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <Legend AlignmentHorizontal="Right" AlignmentVertical="TopOutside"></Legend>
        <BorderOptions Visibility="False"></BorderOptions>
        <Titles>
            <dx:ChartTitle Text="Random Points Generator"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram LabelsResolveOverlappingMinIndent="1">
                <AxisX Title-Text="Arguments" VisibleInPanesSerializable="-1">
                    <WholeRange Auto="False" MinValueSerializable="0" MaxValueSerializable="100"  ></WholeRange>
                </AxisX>
                <AxisY Title-Text="Values" VisibleInPanesSerializable="-1">
                    <WholeRange AlwaysShowZeroLevel="False"  ></WholeRange>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>
</asp:Content>
