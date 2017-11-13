<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DoughnutSeries.aspx.vb" Inherits="DoughnutSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">  
			<table style="width: 100%;">
				<tr>
					<td style="width: 100%;"><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" ClientInstanceName="chbShowLabels">
						<ClientSideEvents CheckedChanged="function(s, e) {
	chart.PerformCallback(&quot;ShowLabels&quot;);
	labelLabelPosition.SetEnabled(chbShowLabels.GetChecked());
	cmbLabelPosition.SetEnabled(chbShowLabels.GetChecked());
}" />
					</dx:ASPxCheckBox></td>                                                             
					<td class="NoWrap"><dx:ASPxLabel ID="lblHoleRadius" runat="server" Text="Hole Radius:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbHoleRadius" runat="server" width="110px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;HoleRadius&quot;); }" />
						</dx:ASPxComboBox>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblLabelPosition" runat="server" Text="Label Position:" ClientInstanceName="labelLabelPosition"/></td>                    
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbLabelPosition" runat="server" Width="100px" ClientInstanceName="cmbLabelPosition">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;LabelPosition&quot;); }" />                    
						</dx:ASPxComboBox>
					</td>
				</tr>
				<tr>
					<td><div class="Spacer" style="width: 100%;height: 5px"></div></td>
				</tr>
				<tr>
					<td style="width: 100%;">
						<dx:ASPxCheckBox ID="cbValueAsPercent" runat="server" Text="Value As Percent">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ValueAsPercent&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
					<td><div class="Spacer"></div></td>
					<td><div class="Spacer"></div></td>
					<td><div class="Spacer"></div></td>
					<td><div class="Spacer"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblExplodedPoints" runat="server" Text="Exploded Points:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbExplodedPoints" runat="server" Width="100px" ClientInstanceName="cbExplodedPoints">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ExplodedPoints&quot;); }" />
						</dx:ASPxComboBox>
					</td>
				</tr>
			</table>
	</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" OnObjectSelected="WebChartControl1_ObjectSelected" CssClass="AlignCenter TopLargeMargin"
		ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
		ToolTipEnabled="False">
		<SeriesSerializable>
			<dx:Series Name="Area of Countries" LegendTextPattern="{A}">
				<Points>
					<dx:SeriesPoint Values="17.0752" ArgumentSerializable="Russia" SeriesPointID="0"></dx:SeriesPoint>
					<dx:SeriesPoint Values="9.98467" ArgumentSerializable="Canada" SeriesPointID="1"></dx:SeriesPoint>
					<dx:SeriesPoint Values="9.63142" ArgumentSerializable="USA" SeriesPointID="2"></dx:SeriesPoint>
					<dx:SeriesPoint Values="9.59696" ArgumentSerializable="China" SeriesPointID="3"></dx:SeriesPoint>
					<dx:SeriesPoint Values="8.511965" ArgumentSerializable="Brazil" SeriesPointID="4"></dx:SeriesPoint>
					<dx:SeriesPoint Values="7.68685" ArgumentSerializable="Australia" SeriesPointID="5"></dx:SeriesPoint>
					<dx:SeriesPoint Values="3.28759" ArgumentSerializable="India" SeriesPointID="6"></dx:SeriesPoint>
					<dx:SeriesPoint Values="81.2" ArgumentSerializable="Others" SeriesPointID="7"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:DoughnutSeriesView Rotation="90" RuntimeExploding="True"></dx:DoughnutSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:DoughnutSeriesLabel Position="Radial" ColumnIndent="20" TextColor="Black" BackColor="Transparent" Font="Tahoma, 8pt, style=Bold" TextPattern="{VP:P0}">
						<Border Visibility="False"></Border>
					</dx:DoughnutSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<ClientSideEvents
			ObjectSelected="function(s, e) {
								var hitInDoughnut = e.hitInfo.inSeries &amp;&amp; !e.hitInfo.inLegend; 
								if(hitInDoughnut) {
									var itemCount = cbExplodedPoints.GetItemCount();
									cbExplodedPoints.SetSelectedIndex(itemCount - 1);
								}
								e.processOnServer = hitInDoughnut;
							}" 
			ObjectHotTracked="function(s, e) {
								var hitInPie = e.hitInfo.inSeries &amp;&amp; !e.hitInfo.inLegend;
								s.SetCursor(hitInPie ? 'pointer' : 'default');
							}" />
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Area of Countries"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.nationmaster.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:SimpleDiagram></dx:SimpleDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
</asp:Content>