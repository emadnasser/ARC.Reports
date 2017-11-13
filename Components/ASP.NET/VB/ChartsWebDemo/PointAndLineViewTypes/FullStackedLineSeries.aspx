<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FullStackedLineSeries.aspx.vb" Inherits="FullStackedLineSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">  
			<table style="width: 100%;">
				<tr>
					<td><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="95px" ClientInstanceName="chbShowLabels">
						<ClientSideEvents CheckedChanged="function(s, e) {
							chart.PerformCallback(&quot;ShowLabels&quot;);
							chbValueAsPercent.SetEnabled(chbShowLabels.GetChecked()); 
						}" />
					</dx:ASPxCheckBox></td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td style="width: 100%;">
						<dx:ASPxCheckBox ID="cbValueAsPercent" runat="server" Text="Value As Percent" Width="120px" ClientInstanceName="chbValueAsPercent">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ValueAsPercent&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblMarkerKind" runat="server" Text="Marker Kind:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbMarkerKind" runat="server" Width="130px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerKind&quot;); }" />
						</dx:ASPxComboBox>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblMarkerSize" runat="server" Text="Marker Size:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td style="width: 100%;">
						<dx:ASPxComboBox ID="cbMarkerSize" runat="server" Width="50px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerSize&quot;); }" />
						</dx:ASPxComboBox>
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
			CrosshairLabelPattern="{S}: {V}">
			<ViewSerializable>
				<dx:FullStackedLineSeriesView></dx:FullStackedLineSeriesView>
			</ViewSerializable>
			<LabelSerializable>
				<dx:StackedLineSeriesLabel TextPattern="{VP:P0}">
					</dx:StackedLineSeriesLabel>
			</LabelSerializable>
		</SeriesTemplate>        
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Country" VisibleInPanesSerializable="-1">
					<WholeRange/>
					<Label>
					</Label>
				</AxisX>
				<AxisY Title-Text="Percent" VisibleInPanesSerializable="-1">
					<WholeRange Auto="False" MaxValueSerializable="1" MinValueSerializable="0"/>
					<Label TextPattern="{V:P0}">
					</Label>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
		<BorderOptions Visibility="False"></BorderOptions>
		<Legend Direction="BottomToTop"></Legend>
		<Titles>
			<dx:ChartTitle Text="Market Share Over Time"></dx:ChartTitle>
		</Titles>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetBranchesSales"></asp:ObjectDataSource>
</asp:Content>