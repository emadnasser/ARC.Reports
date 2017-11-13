<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RadarPointSeries.aspx.vb" Inherits="RadarPointSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">  
			<table style="width: 100%;">
				<tr>
					<td>
						<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="95px">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblMarkerKind" runat="server" Text="Marker Kind:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td style="width: 100%;">
						<dx:ASPxComboBox ID="cbMarkerKind" runat="server" Width="130px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerKind&quot;); }" />
						</dx:ASPxComboBox>
					</td>                    
					<td class="NoWrap"><dx:ASPxLabel ID="lblDiagramType" runat="server" Text="Diagram Type:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>                    
					<td>
						<dx:ASPxComboBox ID="cbDiagramType" runat="server" Width="110px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;DiagramType&quot;); }" />
						</dx:ASPxComboBox>
					</td>
				</tr>
				<tr>
					<td><div class="Spacer" style="width: 100%; height: 5px;"></div></td>
				</tr>
				<tr>
					<td><div class="Spacer"></div></td>
					<td><div class="Spacer"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblMarkerSize" runat="server" Text="Marker Size:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td style="width: 100%;">
						<dx:ASPxComboBox ID="cbMarkerSize" runat="server" Width="130px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerSize&quot;); }" />
						</dx:ASPxComboBox>
					</td>                    
					<td class="NoWrap"><dx:ASPxLabel ID="lblTextDirection" runat="server" Text="Text Direction:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbTextDirection" runat="server" Width="110px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;TextDirection&quot;); }" />
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
			<dx:Series Name="Day (max)" ArgumentScaleType="DateTime" LabelsVisibility="False">
				<Points>
					<dx:SeriesPoint Values="6" ArgumentSerializable="01/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="7" ArgumentSerializable="02/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="10" ArgumentSerializable="03/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="14" ArgumentSerializable="04/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="18" ArgumentSerializable="05/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="21" ArgumentSerializable="06/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="22" ArgumentSerializable="07/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="22" ArgumentSerializable="08/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="19" ArgumentSerializable="09/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="15" ArgumentSerializable="10/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="10" ArgumentSerializable="11/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="7" ArgumentSerializable="12/01/2001 00:00:00.000"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:RadarPointSeriesView></dx:RadarPointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Night (min)" ArgumentScaleType="DateTime" LabelsVisibility="False">
				<Points>
					<dx:SeriesPoint Values="2" ArgumentSerializable="01/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="2" ArgumentSerializable="02/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="3" ArgumentSerializable="03/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="5" ArgumentSerializable="04/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="8" ArgumentSerializable="05/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="11" ArgumentSerializable="06/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="13" ArgumentSerializable="07/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="13" ArgumentSerializable="08/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="11" ArgumentSerializable="09/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="8" ArgumentSerializable="10/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="5" ArgumentSerializable="11/01/2001 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="3" ArgumentSerializable="12/01/2001 00:00:00.000"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:RadarPointSeriesView></dx:RadarPointSeriesView>
				</ViewSerializable>
			</dx:Series>
		</SeriesSerializable>
		<Legend AlignmentHorizontal="Right"></Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Average Temperature in London"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.weather.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:RadarDiagram>
				<AxisX>
					<DateTimeScaleOptions MeasureUnit="Month" GridAlignment="Month" AutoGrid="False"/>
					<Label TextPattern="{A:MMMM}">
					</Label>
				</AxisX>
				<AxisY>
					<Label TextPattern="{V}°C" />

				</AxisY>
			</dx:RadarDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
</asp:Content>