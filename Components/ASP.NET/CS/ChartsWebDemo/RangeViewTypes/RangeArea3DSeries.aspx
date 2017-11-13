<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RangeArea3DSeries.aspx.cs" Inherits="RangeArea3DSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">   
            <table style="width: 100%;">
                <tr>
                    <td>
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show&nbsp;Labels" ClientInstanceName="chbShowLabels">
                            <ClientSideEvents CheckedChanged="function(s, e) { 
                                chart.PerformCallback(&quot;ShowLabels&quot;); 
                                labelLabelKind.SetEnabled(chbShowLabels.GetChecked());
	                            cboxLabelKind.SetEnabled(chbShowLabels.GetChecked());
                                }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap">
                        <dx:ASPxLabel ID="lblLabelKind" runat="server" Text="Label Kind:" ClientInstanceName="labelLabelKind"/>
                    </td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td style="width: 100%;">
                        <dx:ASPxComboBox ID="cbLabelKind" runat="server" ClientInstanceName="cboxLabelKind" ValueType="System.String" Width="120px">
                            <ClientSideEvents  SelectedIndexChanged="function(s, e) {
	                            chart.PerformCallback(&quot;LabelKind&quot;); 
                            }" />
                        </dx:ASPxComboBox>
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
        <Legend Visibility="False"></Legend>
        <Titles>
            <dx:ChartTitle Text="Crude Oil Prices in 2015"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.eia.gov" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <SeriesSerializable>
            <dx:Series Name="ANS West Coast" ArgumentScaleType="DateTime" LabelsVisibility="True"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Min;Max">                
                <ViewSerializable>
                    <dx:RangeArea3DSeriesView></dx:RangeArea3DSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:RangeArea3DSeriesLabel ResolveOverlappingMode="HideOverlapped" TextPattern="{V:F2}">
                    </dx:RangeArea3DSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <DiagramSerializable>
            <dx:XYDiagram3D RotationType="UseAngles" RotationOrder="XYZ" RotationAngleY="-20" ZoomPercent="170" VerticalScrollPercent="4">
                <AxisX>
                    <DateTimeScaleOptions MeasureUnit="Month" GridAlignment="Month" AutoGrid="False" GridSpacing="2"/>                     
                    <Label TextPattern="{A:MMMM}">
                    </Label>
                </AxisX>
                <AxisY>
                    <Label TextPattern="${V}" />
                    <WholeRange Auto="False" MinValueSerializable="30" MaxValueSerializable="70"  ></WholeRange>
                </AxisY>
            </dx:XYDiagram3D>
        </DiagramSerializable>
        <BorderOptions Visibility="False"></BorderOptions>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="SourceOfEnergy" SelectMethod="GetEuropeBrentPrices"></asp:ObjectDataSource>    
</asp:Content>
