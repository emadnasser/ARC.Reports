<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BarAndLine.aspx.vb" Inherits="BarAndLine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">    
			<table style="width: 100%;">
				<tr>
					<td style="width: 100%;">
						<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
				</tr>
			</table>
		 </dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" CssClass="AlignCenter TopLargeMargin"
		ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
		CrosshairEnabled="True" SideBySideEqualBarWidth="True">
		<SeriesSerializable>
			<dx:Series Name="Annual">
				<Points>
					<dx:SeriesPoint Values="69.943" ArgumentSerializable="12/12/2011"></dx:SeriesPoint>
					<dx:SeriesPoint Values="73.723" ArgumentSerializable="12/12/2012"></dx:SeriesPoint>
					<dx:SeriesPoint Values="77.849" ArgumentSerializable="12/12/2013"></dx:SeriesPoint>
					<dx:SeriesPoint Values="86.833" ArgumentSerializable="12/12/2014"></dx:SeriesPoint>
					<dx:SeriesPoint Values="93.58" ArgumentSerializable="12/12/2015"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:SideBySideBarSeriesLabel TextPattern="{V:F2}">
					</dx:SideBySideBarSeriesLabel>
				</LabelSerializable>
			</dx:Series>
			<dx:Series Name="Summary">
				<Points>
					<dx:SeriesPoint Values="69.943" ArgumentSerializable="12/12/2011"></dx:SeriesPoint>
					<dx:SeriesPoint Values="143.666" ArgumentSerializable="12/12/2012"></dx:SeriesPoint>
					<dx:SeriesPoint Values="221.515" ArgumentSerializable="12/12/2013"></dx:SeriesPoint>
					<dx:SeriesPoint Values="308.348" ArgumentSerializable="12/12/2014"></dx:SeriesPoint>
					<dx:SeriesPoint Values="401.928" ArgumentSerializable="12/12/2015"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:LineSeriesView>
						<LineMarkerOptions Size="20"></LineMarkerOptions>
					</dx:LineSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:PointSeriesLabel Angle="70" LineLength="30" TextPattern="{V:F2}">
					</dx:PointSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Microsoft Corp. Annual Revenue"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.microsoft.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
		</Titles>
		<BorderOptions Visibility="False"></BorderOptions>
		<Legend AlignmentHorizontal="Left" AlignmentVertical="Top"></Legend>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Years" VisibleInPanesSerializable="-1">
					<Label TextPattern="{A:yyyy}">
					</Label>                     
					<GridLines Visible="True"></GridLines>
					<DateTimeScaleOptions GridAlignment="Year" MeasureUnit="Year"></DateTimeScaleOptions>
				</AxisX>
				<AxisY Title-Text="Millions of Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">                     
					<GridLines MinorVisible="True"></GridLines>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
		<CrosshairOptions GroupHeaderPattern="{A:yyyy}"/>
	</dx:WebChartControl>
</asp:Content>