<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FullStackedStepAreaSeries.aspx.vb" Inherits="FullStackedStepAreaSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server"> 
			<table style="width: 100%;">
				<tr>
					<td style="width: 80px">
						<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="120px" ClientInstanceName="chbShowLabels" Height="19px">
							<ClientSideEvents CheckedChanged="function(s, e) { chbValueAsPercent.SetEnabled(chbShowLabels.GetChecked()); chart.PerformCallback(&quot;ShowLabels&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
					<td style="width: 100%">
						<dx:ASPxCheckBox ID="cbInverted" runat="server" Text="Inverted" Width="120px">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;Inverted&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
					<td>
						<dx:ASPxCheckBox ID="cbValueAsPercent" runat="server" Text="Value As Percent" Width="120px" ClientInstanceName="chbValueAsPercent" Height="19px">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ValueAsPercent&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
		ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="True">
		<Legend direction="LeftToRight" Visibility="True" alignmenthorizontal="Center" alignmentvertical="BottomOutside"></Legend>
		<Titles>
			<dx:ChartTitle Text="Statistics Comments in the Past Month" Visibility="True"></dx:ChartTitle>
		</Titles>
		<SeriesSerializable>
			<dx:Series Name="Negative">
				<points>
					<dx:SeriesPoint ArgumentSerializable="1/1/2016 12:00:00 AM" Values="13">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2/1/2016 12:00:00 AM" Values="16">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="3/1/2016 12:00:00 AM" Values="12">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="4/1/2016 12:00:00 AM" Values="23">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="5/1/2016 12:00:00 AM" Values="19">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="6/1/2016 12:00:00 AM" Values="19">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="7/1/2016 12:00:00 AM" Values="7">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="8/1/2016 12:00:00 AM" Values="34">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="9/1/2016 12:00:00 AM" Values="21">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="10/1/2016 12:00:00 AM" Values="9">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="11/1/2016 12:00:00 AM" Values="5">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="12/1/2016 12:00:00 AM" Values="3">
					</dx:SeriesPoint>
				</points>
				<viewserializable>
					<dx:FullStackedStepAreaSeriesView>
					</dx:FullStackedStepAreaSeriesView>
				</viewserializable>
			</dx:Series>
			<dx:Series Name="Neutral">
				<points>
					<dx:SeriesPoint ArgumentSerializable="1/1/2016 12:00:00 AM" Values="120">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2/1/2016 12:00:00 AM" Values="101">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="3/1/2016 12:00:00 AM" Values="91">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="4/1/2016 12:00:00 AM" Values="85">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="5/1/2016 12:00:00 AM" Values="101">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="6/1/2016 12:00:00 AM" Values="143">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="7/1/2016 12:00:00 AM" Values="145">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="8/1/2016 12:00:00 AM" Values="150">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="9/1/2016 12:00:00 AM" Values="111">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="10/1/2016 12:00:00 AM" Values="134">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="11/1/2016 12:00:00 AM" Values="107">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="12/1/2016 12:00:00 AM" Values="103">
					</dx:SeriesPoint>
				</points>
				<viewserializable>
					<dx:FullStackedStepAreaSeriesView>
					</dx:FullStackedStepAreaSeriesView>
				</viewserializable>
			</dx:Series>
			<dx:Series Name="Positive">
				<points>
					<dx:SeriesPoint ArgumentSerializable="1/1/2016 12:00:00 AM" Values="47">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2/1/2016 12:00:00 AM" Values="77">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="3/1/2016 12:00:00 AM" Values="45">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="4/1/2016 12:00:00 AM" Values="49">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="5/1/2016 12:00:00 AM" Values="63">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="6/1/2016 12:00:00 AM" Values="58">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="7/1/2016 12:00:00 AM" Values="56">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="8/1/2016 12:00:00 AM" Values="77">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="9/1/2016 12:00:00 AM" Values="105">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="10/1/2016 12:00:00 AM" Values="80">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="11/1/2016 12:00:00 AM" Values="91">
					</dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="12/1/2016 12:00:00 AM" Values="89">
					</dx:SeriesPoint>
				</points>
				<viewserializable>
					<dx:FullStackedStepAreaSeriesView>
					</dx:FullStackedStepAreaSeriesView>
				</viewserializable>
			</dx:Series>
		</SeriesSerializable>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Corporation" VisibleInPanesSerializable="-1">
					<tickmarks minorvisible="False" />
					<Label TextPattern="{A:MMMM}">
						<resolveoverlappingoptions allowhide="False" />
					</Label>
<VisualRange AutoSideMargins="False" SideMarginsValue="0"></VisualRange>
<WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
				</AxisX>
				<AxisY Interlaced="True" 
					Title-Text="Count" Title-Visibility="True" 
					VisibleInPanesSerializable="-1">
					<visualrange autosidemargins="False" sidemarginsvalue="0" />
					<wholerange autosidemargins="False" sidemarginsvalue="0" />
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
		<BorderOptions Visibility="False"></BorderOptions>
	</dx:WebChartControl>
</asp:Content>