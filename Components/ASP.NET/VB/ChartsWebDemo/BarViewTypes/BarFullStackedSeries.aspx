<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BarFullStackedSeries.aspx.vb" Inherits="BarFullStackedSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">   
			<table style="width: 100%;">
				<tr>
					<td style="width: 100%;"><dx:ASPxCheckBox ID="chbShowLabels" runat="server" text="Show Labels" ClientInstanceName="chbShowLabels">
						<ClientSideEvents CheckedChanged="function(s, e) {
							labelLabelPosition.SetEnabled(chbShowLabels.GetChecked());
							cboxLabelPosition.SetEnabled(chbShowLabels.GetChecked());
							labelTextOrientation.SetEnabled(chbShowLabels.GetChecked());
							cboxTextOrientation.SetEnabled(chbShowLabels.GetChecked());
							chbValueAsPercent.SetEnabled(chbShowLabels.GetChecked());
							if (cboxLabelPosition.GetValue() == &quot;Top Inside&quot; || cboxLabelPosition.GetValue() == &quot;Bottom Inside&quot;){
								labelLabelIndent.SetEnabled(chbShowLabels.GetChecked());
								spinLabelIndent.SetEnabled(chbShowLabels.GetChecked());
							}
								chart.PerformCallback(&quot;ShowLabels&quot;); 
						}" />
					</dx:ASPxCheckBox></td>
					<td class="NoWrap">
						<dx:ASPxLabel ID="lblLabelPosition" runat="server" Text="Label Position:" ClientInstanceName="labelLabelPosition">
						</dx:ASPxLabel>
					</td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbLabelPosition" runat="server" ValueType="System.String" Width="108px" ClientInstanceName="cboxLabelPosition">
							<ClientSideEvents SelectedIndexChanged="function(s, e) {
								if (cboxLabelPosition.GetValue() == &quot;Center&quot;){
									labelLabelIndent.SetEnabled(false);
									spinLabelIndent.SetEnabled(false);
								}
								else {
									labelLabelIndent.SetEnabled(true);
									spinLabelIndent.SetEnabled(true);
								}
								chart.PerformCallback(&quot;LabelPosition&quot;); 
							}" />
						</dx:ASPxComboBox>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap">
						<dx:ASPxLabel ID="lbTextOrientation" runat="server" Text="Orientation:" ClientInstanceName="labelTextOrientation">
						</dx:ASPxLabel>
					</td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbTextOrientation" runat="server" ValueType="System.String" Width="108px" ClientInstanceName="cboxTextOrientation">
							<ClientSideEvents SelectedIndexChanged="function(s, e) {
								chart.PerformCallback(&quot;TextOrientation&quot;);
							}" />
						</dx:ASPxComboBox>
					</td>                </tr>
				<tr>
					<td><div class="Spacer" style="width: 100%;height: 5px"></div></td>
				</tr>
				<tr>
					<td>
						<dx:ASPxCheckBox ID="cbValueAsPercent" runat="server" Text="Value As Percent" Width="120px" ClientInstanceName="chbValueAsPercent">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ValueAsPercent&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td class="NoWrap">
						<dx:ASPxLabel ID="lblLabelIndent" runat="server" Text="Label Indent:" ClientInstanceName="labelLabelIndent">
						</dx:ASPxLabel>
					</td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxSpinEdit ID="spnLabelIndent" runat="server" Height="21px" Number="0"
							Width="108px" ClientInstanceName="spinLabelIndent" MaxValue="10000" NumberType="Integer">
							<ClientSideEvents NumberChanged="function(s, e) {
								chart.PerformCallback(&quot;LabelIndent&quot;);
							}" />
						</dx:ASPxSpinEdit>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
		OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="False"
		EnableClientSideAPI="True" ToolTipEnabled="False"
		SeriesDataMember="ProductCategory" DataSourceID="chartDataSource">
		<SeriesTemplate  ArgumentDataMember="Region" ValueDataMembersSerializable="Sales" LabelsVisibility="True"
			CrosshairLabelPattern="{S}: {V:0.0}">
			<ViewSerializable>
				<dx:FullStackedBarSeriesView></dx:FullStackedBarSeriesView>
			</ViewSerializable>
			<LabelSerializable>
				<dx:FullStackedBarSeriesLabel Font="Tahoma, 8pt, style=Bold" TextPattern="{VP:P0}">
				</dx:FullStackedBarSeriesLabel>
			</LabelSerializable>
		</SeriesTemplate>
		<Legend Direction="BottomToTop">
		</Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="DevAV Sales Mix by Region" Font="Tahoma, 14pt"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX VisibleInPanesSerializable="-1"></AxisX>
				<AxisY Title-Text="Percents" VisibleInPanesSerializable="-1">
					<WholeRange Auto="False" MinValueSerializable="0" MaxValueSerializable="1" AutoSideMargins="False" SideMarginsValue="0" ></WholeRange>
					<Label TextPattern="{V:P2}">
					</Label>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetSalesMixByRegion"></asp:ObjectDataSource>
</asp:Content>