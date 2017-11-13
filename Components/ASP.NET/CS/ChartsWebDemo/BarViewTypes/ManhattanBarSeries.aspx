<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManhattanBarSeries.aspx.cs" Inherits="ManhattanBarSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <script type="text/javascript">
        function updateControls() {
            var showFacetEnabled = cb3DModel.GetSelectedItem().text == 'Cylinder' || cb3DModel.GetSelectedItem().text == 'Box';
            cbShowFacet.SetEnabled(showFacetEnabled);
        }
    </script>
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbShowFacet" runat="server" ClientInstanceName="cbShowFacet" Text="Show Facet">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowFacet&quot;); }" />
                        </dx:ASPxCheckBox>       
                    </td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lbl3DModel" runat="server" Text="3D Model:" /></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cb3DModel" runat="server" ClientInstanceName="cb3DModel" Width="70px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { 
                                updateControls();                        
	                            chart.PerformCallback(&quot;Bar3DModel&quot;); 
                            }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblTransparency" runat="server" Text="Transparency:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbTransparency" runat="server" Width="50px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Transparency&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                </tr>
                <tr>
                    <td><div class="Spacer" style="width: 100%; height: 5px;"></div></td>
                </tr>
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
        SeriesDataMember="Year" SeriesSorting="Descending" DataSourceID="chartDataSource">
        <SeriesTemplate  ArgumentDataMember="Region" ValueDataMembersSerializable="Sales" LabelsVisibility="True">
            <ViewSerializable>
                <dx:ManhattanBarSeriesView></dx:ManhattanBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:Bar3DSeriesLabel TextPattern="{V:n2}">
                </dx:Bar3DSeriesLabel>
            </LabelSerializable>
        </SeriesTemplate>        
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Text="DevAV Sales by Regions"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram3D RotationMatrixSerializable="0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.342020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;1" ZoomPercent="140" VerticalScrollPercent="6">
                <AxisY>
                    <Label TextPattern="${V}M"/>
                    <NumericScaleOptions GridSpacing="1" AutoGrid="False" />
                </AxisY>
            </dx:XYDiagram3D>
        </DiagramSerializable>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetSales"></asp:ObjectDataSource>
</asp:Content>
