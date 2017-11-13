<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ScaleBreaks.aspx.vb" Inherits="ScaleBreaks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<script type="text/javascript">
<!--
	function UpdateControlsState() {
		var enabled = checkShowScaleBreaks.GetChecked();
		labelMaxCount.SetEnabled(enabled);
		spinMaxCount.SetEnabled(enabled);
		labelStyle.SetEnabled(enabled);
		comboStyle.SetEnabled(enabled);
		labelSize.SetEnabled(enabled);
		spinSize.SetEnabled(enabled);
		labelColor.SetEnabled(enabled);
		comboColor.SetEnabled(enabled);
		buttonDefaultColor.SetEnabled(enabled && comboColor.GetColor() != null);
	}
	//-->
	</script>
	<dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
		<ClientSideEvents ControlsInitialized="function(s, e) {
		UpdateControlsState();
	}" />
	</dx:ASPxGlobalEvents>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">            
			<table style="width: 100%;">
				<tr>
					<td style="width: 100%;"><dx:ASPxCheckBox ID="chbShowLabels" runat="server" Text="Show Labels" ClientInstanceName="chbShowLabels">
						<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;);}" />
					</dx:ASPxCheckBox></td>
					<td class="NoWrap" colspan="3"><dx:ASPxCheckBox ID="chbShowScaleBreaks" width="124px" runat="server" Text="Show Scale Breaks" ClientInstanceName="checkShowScaleBreaks">
						<ClientSideEvents CheckedChanged="function(s, e) {
							UpdateControlsState();
							chart.PerformCallback(&quot;ShowScaleBreaks&quot;);                            
						}" />
					</dx:ASPxCheckBox></td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td><dx:ASPxLabel ID="lblStyle" runat="server" Text="Style:" ClientInstanceName="labelStyle"></dx:ASPxLabel></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td><dx:ASPxComboBox ID="cbStyle" width="80px" runat="server" ClientInstanceName="comboStyle">
						<ClientSideEvents SelectedIndexChanged="function(s, e) {chart.PerformCallback(&quot;ChangeStyle&quot;);}" />
					</dx:ASPxComboBox></td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td><dx:ASPxLabel ID="lblColor" runat="server" Text="Color:" ClientInstanceName="labelColor"></dx:ASPxLabel></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td><dx:ASPxColorEdit ID="ceColor" width="160px" runat="server" AllowUserInput="False" ClientInstanceName="comboColor">
						<ClientSideEvents ValueChanged="function(s, e) {chart.PerformCallback(&quot;ChangeColor&quot;);}" />
					</dx:ASPxColorEdit></td>
				</tr>
				<tr>
					<td><div class="Spacer" style="width: 100%;height: 5px"></div></td>
				</tr>
				<tr>
					<td></td>
					<td><dx:ASPxLabel ID="lblMaxCount" runat="server" Text="Max&nbsp;Count:" ClientInstanceName="labelMaxCount"></dx:ASPxLabel></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td><dx:ASPxSpinEdit ID="spnMaxCount" width="60px" runat="server" MinValue="1" MaxValue="4" NumberType="Integer" ClientInstanceName="spinMaxCount">
						<ClientSideEvents ValueChanged="function(s, e) {chart.PerformCallback(&quot;ChangeMaxCount&quot;);}" />
					</dx:ASPxSpinEdit></td>                    
					<td></td>                    
					<td><dx:ASPxLabel ID="lblSize" runat="server" Text="Size:" ClientInstanceName="labelSize"></dx:ASPxLabel></td>
					<td></td>
					<td><dx:ASPxSpinEdit ID="spnSize" width="80px" runat="server" MinValue="-1" MaxValue="50" NumberType="Integer" ClientInstanceName="spinSize">
						<ClientSideEvents ValueChanged="function(s, e) {chart.PerformCallback(&quot;ChangeSize&quot;);}" />
					</dx:ASPxSpinEdit></td>                    
					<td></td>
					<td></td>
					<td></td>
					<td><dx:ASPxButton ID="btnDefaultColor" width="160px" runat="server" Text="Restore&nbsp;Default&nbsp;Color" AutoPostBack="False" ClientInstanceName="buttonDefaultColor">
						<ClientSideEvents Click="function(s, e) {                
							comboColor.SetColor(null);
							UpdateControlsState();
							chart.PerformCallback(&quot;ResetColor&quot;);
						}" />
					</dx:ASPxButton></td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
		ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback">
		<SeriesSerializable>
			<dx:Series Name="Planets" LegendTextPattern="{A}: {V}">
				<Points>
					<dx:SeriesPoint Values="0.06" ArgumentSerializable="Mercury"></dx:SeriesPoint>
					<dx:SeriesPoint Values="0.82" ArgumentSerializable="Venus"></dx:SeriesPoint>
					<dx:SeriesPoint Values="1" ArgumentSerializable="Earth"></dx:SeriesPoint>
					<dx:SeriesPoint Values="0.11" ArgumentSerializable="Mars"></dx:SeriesPoint>
					<dx:SeriesPoint Values="318" ArgumentSerializable="Jupiter"></dx:SeriesPoint>
					<dx:SeriesPoint Values="95" ArgumentSerializable="Saturn"></dx:SeriesPoint>
					<dx:SeriesPoint Values="14.6" ArgumentSerializable="Uranus"></dx:SeriesPoint>
					<dx:SeriesPoint Values="17.2" ArgumentSerializable="Neptune"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:SideBySideBarSeriesView ColorEach="True"></dx:SideBySideBarSeriesView>
				</ViewSerializable>
			</dx:Series>
		</SeriesSerializable>
		<BorderOptions Visibility="False"></BorderOptions>
		<Titles>
			<dx:ChartTitle Text="Mass of Planets in the Solar System"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Planets" VisibleInPanesSerializable="-1">

				</AxisX>
				<AxisY Title-Text="Mass (Earth's)" Title-Visibility="True" VisibleInPanesSerializable="-1" Interlaced="True">
					<AutoScaleBreaks Enabled="True" MaxCount="4"></AutoScaleBreaks>

				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
</asp:Content>