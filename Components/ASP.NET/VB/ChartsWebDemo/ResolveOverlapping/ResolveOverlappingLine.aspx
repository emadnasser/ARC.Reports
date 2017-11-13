<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ResolveOverlappingLine.aspx.vb" Inherits="ResolveOverlappingLine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<script type="text/javascript">
		function updateControls() {
			var indentEnabled = cbMode.GetSelectedItem().text != 'None';
			labelIndent.SetEnabled(indentEnabled);
			spinIndent.SetEnabled(indentEnabled);
			var angleDisabled = cbMode.GetSelectedItem().text == 'Justify All Around Point';
			labelAngle.SetEnabled(!angleDisabled);
			spinAngle.SetEnabled(!angleDisabled);
		}
	</script>
	<dx:aspxglobalevents id="ASPxGlobalEvents1" runat="server">
		<ClientSideEvents ControlsInitialized="function(s, e) { updateControls(); }"></ClientSideEvents>
	</dx:aspxglobalevents>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
			<dx:PanelContent runat="server">  
				<table style="width: 100%;">
					<tr>
						<td class="NoWrap" style="width: 30px"><dx:ASPxLabel ID="lblMode" runat="server" Text="Mode:"/></td>
						<td><div class="Spacer" style="width: 5px;"></div></td>
						<td>
							<dx:ASPxComboBox ID="cbMode" runat="server" ClientInstanceName="cbMode" ValueType="System.String">
								<ClientSideEvents SelectedIndexChanged="function(s, e) {
									updateControls(); 
									chart.PerformCallback(); 
								}" />
							</dx:ASPxComboBox>
						</td>
						<td style="width: 100%;"></td>
						<td class="NoWrap"><dx:ASPxLabel ID="lblLineLength" runat="server" Text="Line Length:"/></td>
						<td><div class="Spacer" style="width: 5px;"></div></td>
						<td>
							<dx:ASPxSpinEdit ID="spnLineLength" runat="server" Height="21px" Number="0" width="100px" ClientInstanceName="spinLineLenght" NumberType="Integer" >
								<ClientSideEvents ValueChanged="function(s, e) { 
									chart.PerformCallback();
								}" />
							</dx:ASPxSpinEdit>
						</td>
					</tr>
					<tr><td><div class="Spacer" style="width: 100%;height: 5px"></div></td></tr>
					<tr>
						<td><dx:ASPxLabel ID="lblIndent" runat="server" Text="Indent:" ClientInstanceName="labelIndent"/></td>
						<td><div class="Spacer" style="width: 5px;"></div></td>
						<td>
							<dx:ASPxSpinEdit ID="spnIndent" runat="server" Height="21px" Number="0" width="60px" ClientInstanceName="spinIndent" NumberType="Integer" >
								<ClientSideEvents ValueChanged="function(s, e) { 
									chart.PerformCallback();
								}" />
							</dx:ASPxSpinEdit>
						</td>
						<td style="width: 100%;"></td>
						<td class="NoWrap"><dx:ASPxLabel ID="lblAngle" runat="server" Text="Lable Angle:" ClientInstanceName="labelAngle"/></td>
						<td><div class="Spacer" style="width: 5px;"></div></td>
						<td>
							<dx:ASPxSpinEdit ID="spnAngle" runat="server" Height="21px" Number="0" width="100px" ClientInstanceName="spinAngle" NumberType="Integer" >
								<ClientSideEvents ValueChanged="function(s, e) { 
									chart.PerformCallback();
								}" />
							</dx:ASPxSpinEdit>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl" runat="server" Height="400px"
		Width="700px" SaveStateOnCallbacks="False" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
		EnableViewState="False" OnCustomCallback="WebChartControl_CustomCallback"
		CrosshairEnabled="False" ToolTipEnabled="False">
		<SeriesSerializable>
			<dx:Series Name="Temperature Data" ArgumentScaleType="Numerical" LabelsVisibility="True">
				<Points>
					<dx:SeriesPoint Values="-28.2" ArgumentSerializable="2.466424"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-25.4" ArgumentSerializable="2.486035"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-23.4" ArgumentSerializable="2.505635"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-22.4" ArgumentSerializable="2.525235"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-21" ArgumentSerializable="2.544851"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-19.7" ArgumentSerializable="2.564458"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-15.9" ArgumentSerializable="2.584058"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-15.3" ArgumentSerializable="2.603669"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-15.3" ArgumentSerializable="2.623269"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-18.9" ArgumentSerializable="2.64288"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-21.1" ArgumentSerializable="2.66249"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-23.2" ArgumentSerializable="2.682092"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-26.9" ArgumentSerializable="2.701703"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-30.8" ArgumentSerializable="2.721314"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-43.8" ArgumentSerializable="2.760537"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-45.7" ArgumentSerializable="2.780148"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-49.1" ArgumentSerializable="2.79976"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-51.5" ArgumentSerializable="2.819371"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-55.5" ArgumentSerializable="2.838982"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-57.5" ArgumentSerializable="2.858594"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-61" ArgumentSerializable="2.878205"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-61.1" ArgumentSerializable="2.897816"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-64.5" ArgumentSerializable="2.917428"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-64.9" ArgumentSerializable="2.937039"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-67.8" ArgumentSerializable="2.976262"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-69.3" ArgumentSerializable="3.035084"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-70.4" ArgumentSerializable="3.074307"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-71.3" ArgumentSerializable="3.093918"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-71.9" ArgumentSerializable="3.11353"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-75" ArgumentSerializable="3.191964"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-76" ArgumentSerializable="3.211575"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:LineSeriesView>
						<LineMarkerOptions Kind="Hexagon"></LineMarkerOptions>
					</dx:LineSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:PointSeriesLabel LineLength="15" ResolveOverlappingMode="JustifyAllAroundPoint"></dx:PointSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<Legend Visibility="False"></Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Mars Pathfinder Temperature Data"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www-k12.atmos.washington.edu/k12" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram LabelsResolveOverlappingMinIndent="3">
				<AxisX Title-Text="Sol" Title-Visibility="True" VisibleInPanesSerializable="-1">    
				</AxisX>
				<AxisY Title-Text="Temperature, &#176;C" Title-Visibility="True" VisibleInPanesSerializable="-1">
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
</asp:Content>