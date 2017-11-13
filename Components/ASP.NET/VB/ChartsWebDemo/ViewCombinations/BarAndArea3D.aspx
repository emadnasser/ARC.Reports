<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BarAndArea3D.aspx.vb" Inherits="BarAndArea3D" %>
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
		ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback">
		<SeriesSerializable>
			<dx:Series Name="Summary" LabelsVisibility="True">
				<Points>
					<dx:SeriesPoint Values="69.943" ArgumentSerializable="2011"></dx:SeriesPoint>
					<dx:SeriesPoint Values="143.666" ArgumentSerializable="2012"></dx:SeriesPoint>
					<dx:SeriesPoint Values="221.515" ArgumentSerializable="2013"></dx:SeriesPoint>
					<dx:SeriesPoint Values="308.348" ArgumentSerializable="2014"></dx:SeriesPoint>
					<dx:SeriesPoint Values="401.928" ArgumentSerializable="2015"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:Area3DSeriesView></dx:Area3DSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:Area3DSeriesLabel TextPattern="{V:F2}">
					</dx:Area3DSeriesLabel>
				</LabelSerializable>
			</dx:Series>
			<dx:Series Name="Annual" LabelsVisibility="True">
				<Points>
					<dx:SeriesPoint Values="69.943" ArgumentSerializable="2011"></dx:SeriesPoint>
					<dx:SeriesPoint Values="73.723" ArgumentSerializable="2012"></dx:SeriesPoint>
					<dx:SeriesPoint Values="77.849" ArgumentSerializable="2013"></dx:SeriesPoint>
					<dx:SeriesPoint Values="86.833" ArgumentSerializable="2014"></dx:SeriesPoint>
					<dx:SeriesPoint Values="93.58" ArgumentSerializable="2015"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:ManhattanBarSeriesView Transparency="100"></dx:ManhattanBarSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:Bar3DSeriesLabel TextPattern="{V:F2}">
					</dx:Bar3DSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Microsoft Corp. Annual Revenue"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.microsoft.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram3D RotationMatrixSerializable="0.866025403784439;0.171010071662834;-0.469846310392954;0;0;0.939692620785908;0.342020143325669;0;0.5;-0.296198132726024;0.813797681349374;0;0;0;0;1" ZoomPercent="140" VerticalScrollPercent="5">
				<AxisX>
					 <NumericScaleOptions GridSpacing="1" AutoGrid="False"></NumericScaleOptions>
				</AxisX>
				<AxisY>
					<Label TextPattern="${V}M"/>

				</AxisY>
			</dx:XYDiagram3D>
		</DiagramSerializable>
	</dx:WebChartControl>
</asp:Content>