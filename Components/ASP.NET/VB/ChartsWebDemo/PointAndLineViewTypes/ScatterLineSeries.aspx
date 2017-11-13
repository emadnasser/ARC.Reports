<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ScatterLineSeries.aspx.vb" Inherits="ScatterLineSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">  
			<table style="width: 100%;">
				<tr>
					<td>
						<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="110px">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblMarkerKind" runat="server" Text="Marker Kind:" ClientInstanceName="labelMarkerKind"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td style="width: 100%;">
						<dx:ASPxComboBox ID="cbMarkerKind" runat="server" Width="130px" ClientInstanceName="cmbMarkerKind">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerKind&quot;); }" />
						</dx:ASPxComboBox>
					</td> 
					 <td class="NoWrap"><dx:ASPxLabel ID="lblFunctionType" runat="server" Text="Function Type:"/></td>
					<td style="width: 6px"><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbFunctionType" runat="server" Width="130px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;FunctionType&quot;); }" />
						</dx:ASPxComboBox>
					</td>                   
				</tr>
				<tr>
					<td><div class="Spacer" style="width: 100%; height: 5px;"></div></td>
				</tr>
				<tr>
					<td><dx:ASPxCheckBox ID="cbShowMarkers" runat="server" Text="Show Markers" Width="110px" ClientInstanceName="chbShowMarkers">
						<ClientSideEvents CheckedChanged="function(s, e) {
	labelMarkerKind.SetEnabled(chbShowMarkers.GetChecked());
	labelMarkerSize.SetEnabled(chbShowMarkers.GetChecked());
	cmbMarkerKind.SetEnabled(chbShowMarkers.GetChecked());
	cmbMarkerSize.SetEnabled(chbShowMarkers.GetChecked());
	chart.PerformCallback(&quot;ShowMarkers&quot;);
}" />
					</dx:ASPxCheckBox></td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblMarkerSize" runat="server" Text="Marker Size:" ClientInstanceName="labelMarkerSize"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td style="width: 100%;">
						<dx:ASPxComboBox ID="cbMarkerSize" runat="server" Width="130px" ClientInstanceName="cmbMarkerSize">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerSize&quot;); }" />
						</dx:ASPxComboBox>
					</td>                    
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
		OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="False"
		ToolTipEnabled="True">
		<SeriesSerializable>
			<dx:Series Name="Archimedean Spiral" ArgumentScaleType="Numerical" LabelsVisibility="False">
				<ViewSerializable>
					<dx:ScatterLineSeriesView>
						<LineMarkerOptions Size="8"></LineMarkerOptions>
					</dx:ScatterLineSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:PointSeriesLabel ResolveOverlappingMode="HideOverlapped" TextPattern="{V:F1}">
					</dx:PointSeriesLabel>
				</LabelSerializable>
			</dx:Series>
			<dx:Series Name="Cardioid" ArgumentScaleType="Numerical" LabelsVisibility="False">
				<ViewSerializable>
					<dx:ScatterLineSeriesView>
						<LineMarkerOptions Size="8"></LineMarkerOptions>
					</dx:ScatterLineSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:PointSeriesLabel ResolveOverlappingMode="HideOverlapped" TextPattern="{V:F1}">
					</dx:PointSeriesLabel>
				</LabelSerializable>
			</dx:Series>
			<dx:Series Name="Cartesian Folium" ArgumentScaleType="Numerical" LabelsVisibility="False">
				<ViewSerializable>
					<dx:ScatterLineSeriesView>
						<LineMarkerOptions Size="8"></LineMarkerOptions>
					</dx:ScatterLineSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:PointSeriesLabel ResolveOverlappingMode="HideOverlapped" TextPattern="{V:F1}">
					</dx:PointSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<BorderOptions Visibility="False"></BorderOptions>
		<Titles>
			<dx:ChartTitle Text="Function in Cartesian Coordinates"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram LabelsResolveOverlappingMinIndent="3">
				<AxisX Title-Text="Arguments" VisibleInPanesSerializable="-1" Alignment="Zero">                     
					<Tickmarks crossaxis="True" />
				</AxisX>
				<AxisY Title-Text="Values" VisibleInPanesSerializable="-1" Alignment="Zero">                     
					<Tickmarks crossaxis="True" />
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
</asp:Content>