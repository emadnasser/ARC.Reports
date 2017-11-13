<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DisplayPatterns.aspx.vb" Inherits="DisplayPatterns" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCallbackPanel ID="callbackPanel" runat="server" ClientInstanceName="callbackPanel" OnCallback="callbackPanel_Callback">
		<PanelCollection>
			<dx:PanelContent runat="server">
				<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
					<PanelCollection>
						<dx:PanelContent ID="PanelContent2" runat="server">
							<table style="width: 100%;">
								<tr>
									<td class="NoWrap">
										<dx:ASPxLabel ID="lblSeriesLabels" runat="server" Text="Series Labels:"/>
									</td>
									<td style="width: 11px">
										<div class="Spacer" style="width: 5px;"></div>
									</td>
									<td>
										<dx:ASPxComboBox ID="cbSeriesLabels" runat="server" ValueType="System.String" DropDownStyle="DropDown">
											<ClientSideEvents SelectedIndexChanged="function(s, e) { callbackPanel.PerformCallback(&quot;label&quot;); }" />
										</dx:ASPxComboBox>
									</td>
									<td style="height: 28px">
										<div class="Spacer" style="width: 10px;"></div>
									</td>
									<td class="NoWrap">
										<dx:ASPxLabel ID="lblSeriesLabelsPattern" runat="server" Text="Axis X:"/>
									</td>
									<td>
										<div class="Spacer" style="width: 5px;"></div>
									</td>
									<td style="width: 100%">
										<dx:ASPxComboBox ID="cbAxisX" runat="server" ValueType="System.String" DropDownStyle="DropDown">
											<ClientSideEvents SelectedIndexChanged="function(s, e) { callbackPanel.PerformCallback(&quot;axisx&quot;); }" />
										</dx:ASPxComboBox>
									</td>
								</tr>
								<tr>
									<td>
										<div class="Spacer" style="width: 100%;height: 5px"></div>
									</td>
								</tr>
								<tr>
									<td class="NoWrap">
										<dx:ASPxLabel ID="lblLegend" runat="server" Text="Legend:"/>
									</td>
									<td style="width: 11px">
										<div class="Spacer" style="width: 5px;"></div>
									</td>
									<td>
										<dx:ASPxComboBox ID="cbLegend" runat="server" ValueType="System.String" DropDownStyle="DropDown">
											<ClientSideEvents SelectedIndexChanged="function(s, e) { callbackPanel.PerformCallback(&quot;legend&quot;); }" />
										</dx:ASPxComboBox>
									</td>
									<td>
										<div class="Spacer" style="width: 10px;"></div>
									</td>
									<td class="NoWrap">
										<dx:ASPxLabel ID="lblLegendPattern" runat="server" Text="Axis Y:"/>
									</td>
									<td>
										<div class="Spacer" style="width: 5px;"></div>
									</td>
									<td style="width: 100%">
										<dx:ASPxComboBox ID="cbAxisY" runat="server" ValueType="System.String" DropDownStyle="DropDown">
											<ClientSideEvents SelectedIndexChanged="function(s, e) { callbackPanel.PerformCallback(&quot;axisy&quot;); }" />
										</dx:ASPxComboBox>
									</td>
								</tr>
							</table>
						</dx:PanelContent>
					</PanelCollection>
				</dx:ASPxRoundPanel>
				<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" 
					Width="700px" ClientInstanceName="chart" EnableViewState="False" CssClass="AlignCenter TopLargeMargin"
					SaveStateOnCallbacks="False" ToolTipEnabled="False">
					<Titles>
						<dx:ChartTitle Text="Area of Countries"></dx:ChartTitle>
						<dx:ChartTitle Alignment="Far" Dock="Bottom" Font="Tahoma, 8pt" Text="From www.nationmaster.com" TextColor="Gray"></dx:ChartTitle>
					</Titles>
					<DiagramSerializable>
						<dx:SimpleDiagram></dx:SimpleDiagram>
<dx:XYDiagram>
<AxisX VisibleInPanesSerializable="-1"></AxisX>
	<AxisY VisibleInPanesSerializable="-1" title-text="Millions of Square Kilometers" title-Visibility="True">
		<label textpattern="{V:#,0}">
		</label>
	</AxisY>
</dx:XYDiagram>
					</DiagramSerializable>
					<BorderOptions Visibility="False" />
					<SeriesSerializable>
						<dx:Series Name="Area of Countries" LabelsVisibility="True" LegendTextPattern="{A}">
							<Points>
								<dx:SeriesPoint Values="17075.2" ArgumentSerializable="Russian Federation" SeriesPointID="0"></dx:SeriesPoint>
								<dx:SeriesPoint Values="9984.67" ArgumentSerializable="Canada" SeriesPointID="1"></dx:SeriesPoint>
								<dx:SeriesPoint Values="9631.42" ArgumentSerializable="United States" SeriesPointID="2"></dx:SeriesPoint>
								<dx:SeriesPoint Values="9596.96" ArgumentSerializable="China" SeriesPointID="3"></dx:SeriesPoint>
								<dx:SeriesPoint Values="8511.965" ArgumentSerializable="Brazil" SeriesPointID="4"></dx:SeriesPoint>
								<dx:SeriesPoint Values="7686.85" ArgumentSerializable="Australia" SeriesPointID="5"></dx:SeriesPoint>
								<dx:SeriesPoint Values="3287.59" ArgumentSerializable="India" SeriesPointID="6"></dx:SeriesPoint>
							</Points>
							<ViewSerializable>
								<dx:SideBySideBarSeriesView ColorEach="True"></dx:SideBySideBarSeriesView>
							</ViewSerializable>
							<labelserializable>
								<dx:SideBySideBarSeriesLabel TextPattern="{V:## ##0.0}">
								</dx:SideBySideBarSeriesLabel>
							</labelserializable>
						</dx:Series>
					</SeriesSerializable>
				</dx:WebChartControl>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxCallbackPanel>
</asp:Content>