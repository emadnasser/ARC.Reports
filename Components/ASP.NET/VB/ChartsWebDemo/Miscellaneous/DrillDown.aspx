<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DrillDown.aspx.vb" Inherits="DrillDown" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<script type="text/javascript">
<!--
	function SetSummaryKindVisible(isVisible) {
		lblSummaryKind.SetVisible(isVisible);
		cbSummaryKind.SetVisible(isVisible);
		lblSummaryKind2.SetVisible(isVisible);
	}
	//-->
	</script>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">            
			<table style="width: 100%;">
				<tr style="height: 25px;">
					<td class="NoWrap"><dx:ASPxLabel ID="lblSummaryKind" runat="server" Text="Show" ClientInstanceName="lblSummaryKind"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbSummaryKind" runat="server" ValueType="System.String" Width="80px" ClientInstanceName="cbSummaryKind">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;SummaryKind&quot;); }" />
						</dx:ASPxComboBox>
					</td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td style="width: 100%;"><dx:ASPxLabel ID="lblSummaryKind2" runat="server" Text="product price in every category" ClientInstanceName="lblSummaryKind2"/></td>
					<td>
						<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="95px">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
		<ClientSideEvents Init="function(s, e) { SetSummaryKindVisible(chart.chart.series[0].points.length > 0); }" />
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" DataSourceID="AccessDataSource1" CssClass="AlignCenter TopLargeMargin"
		OnObjectSelected="WebChartControl1_ObjectSelected"
		OnCallbackStateLoad="WebChartControl1_CallbackStateLoad"
		ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
		CrosshairEnabled="False" ToolTipEnabled="False">
		<SeriesSerializable>
			<dx:Series LabelsVisibility="True" Name="Categories" SeriesPointsSorting="Ascending" LegendTextPattern="{A:G}">
				<ViewSerializable>
					<dx:PieSeriesView ExplodeMode="All" HeightToWidthRatio="0.7" RuntimeExploding="False" ></dx:PieSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:PieSeriesLabel BackColor="Transparent" Font="Tahoma, 8pt, style=Bold" Position="Inside" TextColor="Black" TextPattern="${V:F1}">
						<Border Visibility="False" />
					</dx:PieSeriesLabel>
				</LabelSerializable>
			</dx:Series>
			<dx:Series ArgumentDataMember="ProductName" LabelsVisibility="True" Name="Products" SeriesPointsSorting="Ascending" SeriesPointsSortingKey="Value_1" ValueDataMembersSerializable="UnitPrice">
				<DataFilters>
					<dx:DataFilter ColumnName="CategoryID" DataType="System.Int32" />
				</DataFilters>
				<ViewSerializable>
					<dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:SideBySideBarSeriesLabel>
					</dx:SideBySideBarSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<ClientSideEvents
			ObjectHotTracked="function(s, e) {
								var hitInCategory = e.hitInfo.inSeries &amp;&amp; e.chart.series[0].visible;
								var hitInBackTitle = e.hitInfo.inChartTitle &amp;&amp; !e.chart.series[0].visible;
								s.SetCursor((hitInCategory || hitInBackTitle) ? 'pointer' : 'default');    
							  }"
			ObjectSelected="function(s, e) {
								var hitInCategory = e.hitInfo.inSeries &amp;&amp; e.chart.series[0].visible;
								var hitInBackTitle = e.hitInfo.inChartTitle &amp;&amp; !e.chart.series[0].visible;
								if (hitInCategory)
									SetSummaryKindVisible(false);
								else if(hitInBackTitle)
									SetSummaryKindVisible(true);
								e.processOnServer = hitInCategory || hitInBackTitle;
							}" />
		<DiagramSerializable>
			<dx:SimpleDiagram EqualPieSize="False"></dx:SimpleDiagram>
		</DiagramSerializable>
		<Legend AlignmentVertical="Center"></Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle></dx:ChartTitle>
			<dx:ChartTitle Alignment="Near" Text="Back to the main view..." Visibility="False" Font="Tahoma, 10pt, style=Underline" TextColor="Blue" EnableAntialiasing="False"></dx:ChartTitle>
		</Titles>
	</dx:WebChartControl>
	<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
		SelectCommand="SELECT * FROM [Products]">
	</asp:AccessDataSource>
</asp:Content>