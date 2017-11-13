<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Spline3DSeries.aspx.cs" Inherits="Spline3DSeries" %>
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
                    <td class="NoWrap"><dx:ASPxLabel ID="lblPerspectiveAngle" runat="server" Text="Perspective Angle:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbPerspectiveAngle" runat="server" Width="70px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;PerspectiveAngle&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>                            
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblZoomPercent" runat="server" Text="Zoom Percent:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbZoomPercent" runat="server" Width="50px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ZoomPercent&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>                                            
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
        DataSourceID="chartDataSource">
        <SeriesSerializable>
            <dx:Series Name="Russia" ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date"  ValueDataMembersSerializable="Russia">
                <ViewSerializable>
                    <dx:Spline3DSeriesView LineWidth="2"></dx:Spline3DSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel TextPattern="{V:F2}" ResolveOverlappingMode="HideOverlapped">
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="South Africa" ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date" ValueDataMembersSerializable="South Africa">
                <ViewSerializable>
                    <dx:Spline3DSeriesView LineWidth="2"></dx:Spline3DSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel TextPattern="{V:F2}" ResolveOverlappingMode="HideOverlapped">
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Poland" ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Poland">
                <ViewSerializable>
                    <dx:Spline3DSeriesView LineWidth="2"></dx:Spline3DSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel TextPattern="{V:F2}" ResolveOverlappingMode="HideOverlapped">
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Text="Coal Production, in Millions of Tonnes"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.quandl.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram3D RotationMatrixSerializable="0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.342020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;1" ZoomPercent="140" VerticalScrollPercent="7" RuntimeRotation="True" RuntimeZooming="True" RuntimeScrolling="True">
                <AxisX>
                    <DateTimeScaleOptions MeasureUnit="Year" GridAlignment="Year" GridSpacing="3"/>                     
                </AxisX>
                <AxisY>
                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                    <NumericScaleOptions GridSpacing="50" AutoGrid="False" />
                </AxisY>
            </dx:XYDiagram3D>
        </DiagramSerializable>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="SourceOfEnergy" SelectMethod="GetCoalProduction"></asp:ObjectDataSource>
</asp:Content>
