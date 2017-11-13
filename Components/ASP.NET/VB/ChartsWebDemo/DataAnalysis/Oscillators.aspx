<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Oscillators.aspx.vb" Inherits="Oscillators" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
			<dx:PanelContent runat="server">
				<table>
					<tr>
						<td class="NoWrap"><dx:ASPxLabel ID="lblOscillator" runat="server" Text="Oscillator:" /></td>
						<td><div class="Spacer" style="width: 5px;"></div></td>
						<td>
							<dx:ASPxComboBox ID="cmbOscillator" runat="server" SelectedIndex="0" ValueType="System.String" ClientInstanceName="cmbOscillator">
								<Items>
									<dx:ListEditItem Value="0" Text="(ATR) Average True Range" />
									<dx:ListEditItem Value="1" Text="(CCI) Commodity Channel Index" />
									<dx:ListEditItem Value="2" Text="(DPO) Detrended Price Oscillator" />
									<dx:ListEditItem Value="3" Text="(MACD) Moving Average Convergence Divergence" />
									<dx:ListEditItem Value="4" Text="(RoC) Rate of Change" />
									<dx:ListEditItem Value="5" Text="(RSI) Relative Strength Index" />
									<dx:ListEditItem Value="6" Text="(CHV) Chaikins Volatility" />
									<dx:ListEditItem Value="7" Text="(%R) Williams %R" />
								</Items>
								<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Oscillator&quot;); }" />
							</dx:ASPxComboBox>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="420px" CssClass="AlignCenter TopLargeMargin"
		Width="700px"  ClientInstanceName="chart" EnableViewState="False" 
		SaveStateOnCallbacks="False" CrosshairEnabled="True" OnCustomCallback="WebChartControl1_CustomCallback"
		DataSourceID="chartDataSource">
		<borderoptions visibility="False" />
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Date" VisibleInPanesSerializable="0" Interlaced="True">
					<DateTimeScaleOptions GridAlignment="Month" WorkdaysOnly="True" AutoGrid="False" GridSpacing="0.5">
					</DateTimeScaleOptions>
					<visualrange auto="False" autosidemargins="False" maxvalueserializable="01/02/2015 00:00:00.000" minvalueserializable="06/30/2015 00:00:00.000" sidemarginsvalue="0.6" />
					<GridLines Visible="True"></GridLines>
				</AxisX>
				<AxisY Title-Text="US Dollars" VisibleInPanesSerializable="-1" alignment="Far">
					<%--<visualrange auto="False" maxvalueserializable="119.79" minvalueserializable="97.09" />--%>
					<WholeRange AlwaysShowZeroLevel="False"  ></WholeRange>
					<GridLines MinorVisible="True"></GridLines>
				</AxisY>
				<secondaryaxesy>
					<dx:SecondaryAxisY AxisID="0" Name="IndicatorAxis" VisibleInPanesSerializable="0">
						<wholerange alwaysshowzerolevel="False" />
						<gridlines minorvisible="True" visible="True">
						</gridlines>
					</dx:SecondaryAxisY>
				</secondaryaxesy>
				<panes>
					<dx:XYDiagramPane Name="Indicator Pane" PaneID="0">
					</dx:XYDiagramPane>
				</panes>
			</dx:XYDiagram>
		</DiagramSerializable>
		<legend alignmenthorizontal="Left">
			<margins bottom="10" left="10" right="10" top="10" />
		</legend>
		<annotationrepository>
			<dx:TextAnnotation ConnectorStyle="None" Text="(ATR) Average True Range" ShapeKind="Rectangle">
				<shapepositionserializable>
					<dx:FreePosition DockTargetName="Indicator Pane">
					</dx:FreePosition>
				</shapepositionserializable>
			</dx:TextAnnotation>
		</annotationrepository>
		<SeriesSerializable>
			<dx:Series Name="AUDUSD Daily" ArgumentScaleType="DateTime" LabelsVisibility="False"
				ArgumentDataMember="DateTimeArgument" ValueDataMembersSerializable="LowValue;HighValue;OpenValue;CloseValue">                
				<ViewSerializable>
					<dx:StockSeriesView LevelLineLength="0.3">
						<indicators>
							<dx:AverageTrueRange AxisYName="IndicatorAxis" Name="Average True Range" PaneName="Indicator Pane">
							</dx:AverageTrueRange>
						</indicators>
					</dx:StockSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:StockSeriesLabel ResolveOverlappingMode="Default"></dx:StockSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<Titles>
			<dx:ChartTitle Text="AUDUSD Daily"></dx:ChartTitle>
		</Titles>
		<crosshairoptions showonlyinfocusedpane="False">
		</crosshairoptions>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="FinancialData" SelectMethod="GetAUDUSDData"></asp:ObjectDataSource>    
</asp:Content>