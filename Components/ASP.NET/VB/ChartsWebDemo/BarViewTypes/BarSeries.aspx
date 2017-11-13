<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BarSeries.aspx.vb" Inherits="BarSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">            
				<table style="width: 100%;">
					<tr>
						<td style="width: 100%;">
						<dx:ASPxCheckBox ID="chbShowLabels" runat="server" Text="Show Labels" ClientInstanceName="chbShowLabels">
							<ClientSideEvents CheckedChanged="function(s, e) {
								labelLabelPosition.SetEnabled(chbShowLabels.GetChecked());
								cboxLabelPosition.SetEnabled(chbShowLabels.GetChecked());
								labelTextOrientation.SetEnabled(chbShowLabels.GetChecked());
								cboxTextOrientation.SetEnabled(chbShowLabels.GetChecked());
								if (cboxLabelPosition.GetValue() == &quot;Top Inside&quot; || cboxLabelPosition.GetValue() == &quot;Bottom Inside&quot;){
									labelLabelIndent.SetEnabled(chbShowLabels.GetChecked());
									spinLabelIndent.SetEnabled(chbShowLabels.GetChecked());
								}
								chart.PerformCallback(&quot;ShowLabels&quot;);
							}" />
						</dx:ASPxCheckBox>
						</td>
						<td class="NoWrap">
							<dx:ASPxLabel ID="lblLabelPosition" runat="server" Text="Label Position:" ClientInstanceName="labelLabelPosition"/>
						</td>
						<td><div class="Spacer" style="width: 5px;"></div></td>
						<td>
							<dx:ASPxComboBox ID="cbLabelPosition" runat="server" ClientInstanceName="cboxLabelPosition" ValueType="System.String" Width="108px">
								<ClientSideEvents  SelectedIndexChanged="function(s, e) {
									if (cboxLabelPosition.GetValue() == &quot;Top&quot; || cboxLabelPosition.GetValue() == &quot;Center&quot;){
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
							<dx:ASPxLabel ID="lbTextOrientation" runat="server" Text="Orientation:" ClientInstanceName="labelTextOrientation"></dx:ASPxLabel>
						</td>
						<td ><div class="Spacer" style="width: 5px;"></div></td>
						<td>
							<dx:ASPxComboBox ID="cbTextOrientation" runat="server" ValueType="System.String" Width="108px" ClientInstanceName="cboxTextOrientation">
								<ClientSideEvents  SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;TextOrientation&quot;); }" />
							</dx:ASPxComboBox>
						</td>
					</tr>
					<tr>
						<td><div class="Spacer" style="width: 100%;height: 5px"></div></td>
					</tr>
					<tr>
						<td>
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
							<dx:ASPxLabel ID="lblLabelIndent" runat="server" Text="Label Indent:" ClientInstanceName="labelLabelIndent"/>
						</td>
						<td><div class="Spacer" style="width: 5px;"></div></td>
						<td>
							<dx:ASPxSpinEdit ID="spnLabelIndent" runat="server" Height="21px" Number="0" ClientInstanceName="spinLabelIndent" MaxValue="10000" NumberType="Integer" Width="108px">
								<ClientSideEvents   NumberChanged="function(s, e) { chart.PerformCallback(&quot;LabelIndent&quot;); }" />
							</dx:ASPxSpinEdit>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" CssClass="AlignCenter TopLargeMargin"
		Width="700px" ClientInstanceName="chart"
		OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="False"
		EnableClientSideAPI="True" ToolTipEnabled="False"
		SeriesDataMember = "Year" DataSourceID="chartDataSource">
		<SeriesTemplate  ArgumentDataMember="Region" ValueDataMembersSerializable="Sales" LabelsVisibility="True"
			CrosshairLabelPattern="Year: {S}<br/>GSP:   ${V}M">
			<LabelSerializable>
				<dx:SideBySideBarSeriesLabel TextPattern="${V:F2}">
				</dx:SideBySideBarSeriesLabel>
			</LabelSerializable>
		</SeriesTemplate>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="DevAV Sales by Regions"></dx:ChartTitle>
		</Titles>
		<Legend AlignmentHorizontal="Right"/>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX VisibleInPanesSerializable="-1">
				</AxisX>
				<AxisY Title-Text="Millions of Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1" Interlaced="True">
					<NumericScaleOptions AutoGrid="False" GridSpacing="1"/>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetSales"></asp:ObjectDataSource>
</asp:Content>