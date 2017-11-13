<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="NestedDoughnutSeries.aspx.vb" Inherits="NestedDoughnutSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<table>
					<tr>
						<td class="NoWrap">
							<dx:ASPxLabel ID="lbSeriesArgument" runat="server" Text="Group Series By:"></dx:ASPxLabel>
						</td>
						<td>
							<div class="Spacer" style="width: 4px"></div>
						</td>
						<td>
							<dx:ASPxComboBox ID="cbSeriesArgument" runat="server" Width="72px">
								<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;SeriesArgument&quot;); }" />
							</dx:ASPxComboBox>
						</td>
						<td>
							<div class="Spacer" style="width: 8px"></div>
						</td>
						<td class="NoWrap">
							<dx:ASPxLabel ID="lbInnerIndent" runat="server" Text="Inner indent:"></dx:ASPxLabel>
						</td>
						<td>
							<div class="Spacer" style="width: 4px"></div>
						</td>
						<td>
							<dx:ASPxComboBox ID="cbInnerIndent" runat="server" Width="72px">
								<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;InnerIndent&quot;); }" />
							</dx:ASPxComboBox>
						</td>
					</tr>
					<tr><td><div class="Spacer" style="height: 4px"></div></td></tr>
					<tr>
						<td class="NoWrap">
							<dx:ASPxLabel ID="lbHoleRadius" runat="server" Text="Hole radius, %:"></dx:ASPxLabel>
						</td>
						<td>
							<div class="Spacer" style="width: 4px"></div>
						</td>
						<td>
							<dx:ASPxComboBox ID="cbHoleRadius" runat="server" Width="72px">
								<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;HoleRadius&quot;); }" />
							</dx:ASPxComboBox>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" CssClass="AlignCenter TopLargeMargin" DataSourceID="chartDataSource" SeriesDataMember="CountryAgeKey"
		ClientInstanceName="chart" OnBoundDataChanged="WebChartControl1_BoundDataChanged" ToolTipEnabled="True" OnCustomCallback="WebChartControl1_CustomCallback">
		<BorderOptions Visibility="False" />
		<Legend AlignmentHorizontal="Center" AlignmentVertical="Bottom" Direction="LeftToRight"></Legend>
		<Titles>
			<dx:ChartTitle Text="Population: Age Structure"></dx:ChartTitle>
			<dx:ChartTitle Text="Data estimate for end-2016" Font="Tahoma, 12pt"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.cia.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
		</Titles>
		<SeriesTemplate LabelsVisibility="False" ArgumentDataMember="Gender" DataFiltersConjunctionMode="Or"
			ShowInLegend="False" ToolTipHintDataMember="Age" ToolTipPointPattern="{HINT} : {VP:##.##%}"
			ValueDataMembersSerializable="Population" LegendTextPattern="{A}">
			<DataFilters>
				<dx:DataFilter ColumnName="Name" InvariantValueSerializable="United States" />
				<dx:DataFilter ColumnName="Name" InvariantValueSerializable="Brazil" />
				<dx:DataFilter ColumnName="Name" InvariantValueSerializable="Russia" />
			</DataFilters>
			<ViewSerializable>
				<dx:NestedDoughnutSeriesView RuntimeExploding="False">
				</dx:NestedDoughnutSeriesView>
			</ViewSerializable>
		</SeriesTemplate>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="AgeStructure" SelectMethod="GetPopulationAgeStructure"></asp:ObjectDataSource>
</asp:Content>