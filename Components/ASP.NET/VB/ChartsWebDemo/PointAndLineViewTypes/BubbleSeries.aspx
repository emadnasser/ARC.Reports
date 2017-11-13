<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BubbleSeries.aspx.vb" Inherits="BubbleSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCallbackPanel ID="callbackPanel" runat="server" OnCallback="callbackPanel_Callback" ClientInstanceName="callbackPanel">
		<PanelCollection>
			<dx:PanelContent runat="server">
				<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
					<PanelCollection>
						<dx:PanelContent runat="server">
							<table class="OptionsTable">
								<tr>
									<td class="NoWrap">
										<dx:ASPxLabel ID="lblTransparency" runat="server" Text="Transparency:"/>
									</td>
									<td>
										<dx:ASPxComboBox ID="cbTransparency" runat="server" Width="120px" ValueType="System.String" ClientInstanceName="cbLabelPosition" SelectedIndex="2">
											<Items>
												<dx:ListEditItem Text="0" Value="0" />
												<dx:ListEditItem Text="45" Value="45" />
												<dx:ListEditItem Text="90" Value="90" />
												<dx:ListEditItem Text="135" Value="135" />
												<dx:ListEditItem Text="180" Value="180" />
												<dx:ListEditItem Text="225" Value="225" />
												<dx:ListEditItem Text="255" Value="255" />
											</Items>
											<ClientSideEvents SelectedIndexChanged="function(s, e) { callbackPanel.PerformCallback(&quot;Transparency&quot;); }" />
										</dx:ASPxComboBox>
									</td>
									<td class="NoWrap">
										<dx:ASPxLabel ID="lblMaxBubbleSize" runat="server" Text="Max Bubble Size:"/>
									</td>
									<td>
										<dx:ASPxSpinEdit ID="speMaxBubbleSize" runat="server" Height="21px" Width="54px" Number="3.5" Increment="0.1" MaxValue="5" MinValue="0.1" ClientInstanceName="speMaxBubbleSize" >
											<ClientSideEvents ValueChanged="function(s, e) { callbackPanel.PerformCallback(&quot;MaxSize&quot;); }" />
										</dx:ASPxSpinEdit>
									</td>
									<td style="width: 100%"></td>
									<td class="NoWrap">
										<dx:ASPxLabel ID="lblLabelPosition" runat="server" Text="Label Position:"/>
									</td>
									<td>
										<dx:ASPxComboBox ID="cbLabelPosition" runat="server" Width="80px" ValueType="System.String" ClientInstanceName="cbLabelPosition">
											<Items>
												<dx:ListEditItem Text="Center" Value="Center" />
												<dx:ListEditItem Text="Outside" Value="Outside" />
											</Items>
											<ClientSideEvents SelectedIndexChanged="function(s, e) { callbackPanel.PerformCallback(&quot;LabelPosition&quot;); }" />
										</dx:ASPxComboBox>
									</td>
								</tr>
								<tr>
									<td class="NoWrap">
										<dx:ASPxLabel ID="lblMarkerKind" runat="server" Text="Marker Kind:"/>
									</td>
									<td>
										<dx:ASPxComboBox ID="cbMarkerKind" runat="server" Width="120px" ValueType="System.String" ClientInstanceName="cbMarkerKind">
											<ClientSideEvents SelectedIndexChanged="function(s, e) { callbackPanel.PerformCallback(&quot;MarkerKind&quot;); }" />
										</dx:ASPxComboBox>
									</td>
									<td class="NoWrap">
										<dx:ASPxLabel ID="lblMinBubbleSize" runat="server" Text="Min Bubble Size:"/>
									</td>
									<td>
										<dx:ASPxSpinEdit ID="speMinBubbleSize" runat="server" Height="21px" Width="54px" Number="1.5" Increment="0.1" MaxValue="5" MinValue="0.1" ClientInstanceName="speMinBubbleSize" >
											<ClientSideEvents ValueChanged="function(s, e) { callbackPanel.PerformCallback(&quot;MinSize&quot;); }" />
										</dx:ASPxSpinEdit>
									</td>
									<td style="width: 100%"></td>
									<td colspan="2">
										<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="95px" ClientInstanceName="chbShowLabels">
											<ClientSideEvents CheckedChanged="function(s, e) { callbackPanel.PerformCallback(&quot;ShowLabels&quot;); }" />
										</dx:ASPxCheckBox>
									</td>
								</tr>
							</table>
						</dx:PanelContent>
					</PanelCollection>
				</dx:ASPxRoundPanel>
				<dx:WebChartControl ID="WebChartControl1" runat="server" Height="550px" 
					Width="700px"  ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
					OnCustomDrawSeriesPoint="WebChartControl1_CustomDrawSeriesPoint" 
					EnableViewState="False" SaveStateOnCallbacks="False" ToolTipEnabled="True"
					CrosshairEnabled ="False" DataSourceID="chartDataSource">
					<BorderOptions Visibility="False"></BorderOptions>
					<DiagramSerializable>
						<dx:XYDiagram >
							<AxisX Interlaced="True" Title-Text="Year" VisibleInPanesSerializable="-1">
								<DateTimeScaleOptions  GridAlignment="Year" MeasureUnit="Year" AggregateFunction="None" />
								<Tickmarks MinorVisible="False"></Tickmarks>
								<GridLines Visible="True"></GridLines>

								<Label TextPattern="{A:yyyy}">
								</Label>
							</AxisX>
							<AxisY Title-Text="Production Budget" Title-Visibility="True" VisibleInPanesSerializable="-1">
								<Label TextPattern="${V}M"></Label>
								<WholeRange Auto="False" MinValueSerializable="0" MaxValueSerializable="370"  ></WholeRange>
								<VisualRange  Auto="False" MinValueSerializable="130" MaxValueSerializable="310"></VisualRange>
							</AxisY>
						</dx:XYDiagram>
					</DiagramSerializable>
					<Legend AlignmentHorizontal="Center" AlignmentVertical="BottomOutside" Direction="LeftToRight"></Legend>
					<SeriesSerializable>
						<dx:Series Name="Top 10 Films by Worldwide Grosses " ArgumentScaleType="DateTime"
							ArgumentDataMember="Year" ValueDataMembersSerializable="Budget;Grosses"
							ToolTipHintDataMember="Title"
							ToolTipPointPattern = "Production budget: ${V}M<br/>Worldwide grosses: ${W}B">
							<ViewSerializable>
								<dx:BubbleSeriesView MaxSize="3.5" MinSize="1" Transparency="90" ColorEach="True" AutoSize="False"></dx:BubbleSeriesView>
							</ViewSerializable>
							<LabelSerializable>
								<dx:BubbleSeriesLabel textPattern="${W}B">
								</dx:BubbleSeriesLabel>
							</LabelSerializable>
						</dx:Series>
					</SeriesSerializable>
					<Titles>
						<dx:ChartTitle Text="Highest-Grossing Films by Year"></dx:ChartTitle>
						<dx:ChartTitle Alignment="Far" Dock="Bottom" Font="Tahoma, 8pt" Text="From www.boxofficemojo.com"
											TextColor="Gray">
						</dx:ChartTitle>
					</Titles>
				</dx:WebChartControl>
				<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="BubbleData" SelectMethod="GetData"></asp:ObjectDataSource>
			</dx:PanelContent>
		</PanelCollection>
		<Styles>
			<LoadingPanel HorizontalAlign="Center" VerticalAlign="Middle"></LoadingPanel>
		</Styles>
	</dx:ASPxCallbackPanel>
</asp:Content>