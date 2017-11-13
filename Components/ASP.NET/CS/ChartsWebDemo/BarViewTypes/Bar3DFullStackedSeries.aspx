<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Bar3DFullStackedSeries.aspx.cs" Inherits="Bar3DFullStackedSeries" %>
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
                    <td>
                        <dx:ASPxCheckBox ID="cbShowFacet" runat="server" ClientInstanceName="cbShowFacet" Text="Show Facet" Wrap="False">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowFacet&quot;); }" />
                        </dx:ASPxCheckBox>       
                    </td>
                    <td></td>
                    <td></td>
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
                    <td>
                        <dx:ASPxCheckBox ID="cbShowLabels" ClientInstanceName="cbShowLabels" runat="server" Text="Show Labels" Wrap="False">
                            <ClientSideEvents CheckedChanged="function(s, e) { 
                                chart.PerformCallback(&quot;ShowLabels&quot;); 
                                cbValueAsPercent.SetEnabled(cbShowLabels.GetChecked());
                            }" />
                        </dx:ASPxCheckBox>
                    </td>   
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap" style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbValueAsPercent" runat="server" Text="Value As Percent" ClientInstanceName="cbValueAsPercent">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ValueAsPercent&quot;); }" />
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
        DataSourceID="chartDataSource" SeriesDataMember="ProductCategory">
        <SeriesTemplate  ArgumentDataMember="Region" ValueDataMembersSerializable="Sales" LabelsVisibility="True">
            <ViewSerializable>
                <dx:FullStackedBar3DSeriesView Transparency="45"></dx:FullStackedBar3DSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:Bar3DSeriesLabel TextPattern="{VP:P0}">
                </dx:Bar3DSeriesLabel>
            </LabelSerializable>
        </SeriesTemplate>
        <Legend Direction="BottomToTop"></Legend>
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Text="DevAV Sales Mix by Region"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram3D RotationMatrixSerializable="0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.342020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;1" ZoomPercent="140" VerticalScrollPercent="4">
                <AxisX>
                    
                </AxisX>
                <AxisY>                    
                    <Label TextPattern="{V:P0}">
                    </Label>
                </AxisY>
            </dx:XYDiagram3D>
        </DiagramSerializable>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetSalesMixByRegion"></asp:ObjectDataSource>
</asp:Content>
