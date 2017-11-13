<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SplineAreaFullStackedSeries.aspx.vb" Inherits="SplineAreaFullStackedSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">            
				<table style="width: 100%;">
					<tr>
						<td style="width: 100%;"><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" ClientInstanceName="chbShowLabels">
							<ClientSideEvents CheckedChanged="function(s, e) {
	chbValueAsPercent.SetEnabled(chbShowLabels.GetChecked());
	chart.PerformCallback(&quot;&quot;);
}" />
						</dx:ASPxCheckBox></td>
						<td>
							<dx:ASPxCheckBox ID="cbValueAsPercent" runat="server" Text="Value As Percent" Width="120px" ClientInstanceName="chbValueAsPercent">
								<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
							</dx:ASPxCheckBox>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
		ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
		DataSourceID="chartDataSource" SeriesDataMember="Company">
		<SeriesTemplate  ArgumentDataMember="Year" ValueDataMembersSerializable="Sales" LabelsVisibility="False"
			CrosshairLabelPattern="{S}: {V} ({VP:0.00%})">
			<ViewSerializable>
				<dx:FullStackedSplineAreaSeriesView></dx:FullStackedSplineAreaSeriesView>
			</ViewSerializable>
			<LabelSerializable>
				<dx:FullStackedAreaSeriesLabel TextPattern="{VP:P0}">
				</dx:FullStackedAreaSeriesLabel>
			</LabelSerializable>
		</SeriesTemplate>        
		<Legend Direction="BottomToTop"></Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Market Share Over Time"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX VisibleInPanesSerializable="-1">
					<DateTimeScaleOptions MeasureUnit="Year" GridAlignment="Year"/>
					<WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
					<Label TextPattern="{A:yyyy}">
					</Label>
				</AxisX>
				<AxisY VisibleInPanesSerializable="-1">
					<WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
					<Label TextPattern="{V:P0}">
					</Label>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetBranchesSales"></asp:ObjectDataSource>
</asp:Content>