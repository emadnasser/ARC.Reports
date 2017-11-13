<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PolarLineSeries.aspx.vb" Inherits="PolarLineSeries" %>
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
					<td class="NoWrap"><dx:ASPxLabel ID="lblDiagramType" runat="server" Text="Diagram Type:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>                    
					<td>
						<dx:ASPxComboBox ID="cbDiagramType" runat="server" Width="100px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;DiagramType&quot;); }" />
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
					<td class="NoWrap"><dx:ASPxLabel ID="lblFunctionType" runat="server" Text="Function Type:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbFunctionType" runat="server" Width="100px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;FunctionType&quot;); }" />
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
			<dx:Series Name="Function" ArgumentScaleType="Numerical" LabelsVisibility="False">
				<ViewSerializable>
					<dx:PolarLineSeriesView>
						<LineMarkerOptions Size="8"></LineMarkerOptions>
					</dx:PolarLineSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:RadarPointSeriesLabel ResolveOverlappingMode="HideOverlapped" TextPattern="{V:N2}">
					</dx:RadarPointSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<Legend AlignmentHorizontal="Right"></Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Function in Polar Coordinates"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:PolarDiagram>
				<AxisX>
					<Label TextPattern="{A:G0}">
					</Label>
				</AxisX>
				<AxisY>

				</AxisY>
			</dx:PolarDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
</asp:Content>