<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ChartTitles.aspx.vb" Inherits="Miscellaneous_ChartTitles" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<script type="text/javascript">
<!--
	var selectedTitleIndex = 0;
	var textChanged = false;
	function UpdateControls() {
		textChanged = false;
		for (var i = 0;i < cmbAlignment.GetItemCount() ;i++)
			if (cmbAlignment.GetItem(i).value == chart.chart.titles[selectedTitleIndex].alignment)
				cmbAlignment.SetSelectedIndex(i);
		for (var i = 0;i < cmbDock.GetItemCount() ;i++)
			if (cmbDock.GetItem(i).value == chart.chart.titles[selectedTitleIndex].dock)
				cmbDock.SetSelectedIndex(i);
		var text = "";
		for (var i = 0;i < chart.chart.titles[selectedTitleIndex].lines.length;i++) {
			if (text != "")
				text += "\r\n";
			text += chart.chart.titles[selectedTitleIndex].lines[i];
		}
		mmoText.SetText(text);
		chbWordWrap.SetChecked(chart.cp_wordwrap);
	}
	function UpdateChart() {
		chart.PerformCallback("ChartTitle" + "|" + selectedTitleIndex + "|" + cmbAlignment.GetSelectedIndex() + "|" + cmbDock.GetSelectedIndex() + "|" + mmoText.GetText() + "|" + chbWordWrap.GetChecked());
	}
	//-->
	</script>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
			<dx:PanelContent runat="server">
				<table class="OptionsTable">
				<tr>
					<td><dx:ASPxLabel ID="lblAlignment" ClientInstanceName="lblAlignment" Text="Alignment:" Runat="server" /></td>
					<td>
						<dx:ASPxComboBox ID="cmbAlignment" ClientInstanceName="cmbAlignment" Width="80px" Runat="server" ValueType="System.String" SelectedIndex="0">
							<Items>
								<dx:ListEditItem Value="Near" Text="Near" />
								<dx:ListEditItem Value="Center" Text="Center" />
								<dx:ListEditItem Value="Far" Text="Far" />
							</Items>
							<ClientSideEvents SelectedIndexChanged="function(s, e) { UpdateChart(); }" CloseUp="function(s, e) { 
if (textChanged)
	UpdateChart();
}" />
						</dx:ASPxComboBox>
					</td>
					<td><dx:ASPxLabel ID="lblDock" ClientInstanceName="lblDock" Text="Dock:" Runat="server" /></td>
					<td
						><dx:ASPxComboBox ID="cmbDock" ClientInstanceName="cmbDock" Width="80px" Runat="server" ValueType="System.String" SelectedIndex="0">
							<Items>
								<dx:ListEditItem Value="Top" Text="Top" />
								<dx:ListEditItem Value="Bottom" Text="Bottom" />
								<dx:ListEditItem Value="Left" Text="Left" />
								<dx:ListEditItem Value="Right" Text="Right" />
							</Items>
							<ClientSideEvents SelectedIndexChanged="function(s, e) { UpdateChart(); }" CloseUp="function(s, e) { 
if (textChanged)
	UpdateChart();
}" />
						</dx:ASPxComboBox>
					</td>
					<td style="width: 100%; height: 35px">
						<dx:ASPxCheckBox ID="chbWordWrap" ClientInstanceName="chbWordWrap" Runat="server" Width="100px" Text="Word Wrap" >
							<ClientSideEvents CheckedChanged="function(s, e) { 
UpdateChart();
}" />
						</dx:ASPxCheckBox>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel ID="lblText" ClientInstanceName="lblText" Text="Text:" Runat="server" /></td>
					<td colspan="4"><dx:ASPxMemo ID="mmoText" ClientInstanceName="mmoText" Runat="server" Width="100%" Height="60px">
						<ClientSideEvents KeyDown="function(s, e) { 
textChanged = true;
btnOk.SetEnabled(textChanged); 
btnCancel.SetEnabled(textChanged);
}" />
					</dx:ASPxMemo></td>
				</tr>
				<tr>
					<td></td>
					<td colspan="4">
						<table><tr>
						<td>
							<dx:aspxbutton ID="btnOk" ClientInstanceName="btnOk" runat="server" text="OK" Width="80px" AutoPostBack="False" >
								<ClientSideEvents Click="function(s, e) { 
UpdateChart(); 
textChanged = false;
btnOk.SetEnabled(textChanged);
btnCancel.SetEnabled(textChanged);
}" Init="function(s, e) { btnOk.SetEnabled(false); }" />
							</dx:aspxbutton>
						</td>
						<td style="padding-left: 4px;">
							<dx:aspxbutton ID="btnCancel" ClientInstanceName="btnCancel" runat="server" text="Cancel" Width="80px" AutoPostBack="False" >
								<ClientSideEvents Click="function(s, e) { 
UpdateControls();
}" Init="function(s, e) { btnCancel.SetEnabled(false); }" />
							</dx:aspxbutton>
						</td></tr>
						</table>
					</td>
				</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" ClientInstanceName="chart" runat="server"
		Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
		OnCustomCallback="WebChartControl1_CustomCallback"
		OnObjectSelected="WebChartControl1_ObjectSelected" SelectionMode="Single"
		OnCustomJSProperties="WebChartControl1_CustomJSProperties"
		AlternateText="The Random Points chart." CrosshairEnabled="False"
		ToolTipEnabled="False">
		<SeriesSerializable>
			<dx:Series Name="Series 1" LabelsVisibility="False">
				<ViewSerializable>
					<dx:AreaSeriesView MarkerVisibility="False"></dx:AreaSeriesView>
				</ViewSerializable>
			</dx:Series>
		</SeriesSerializable>
		<ClientSideEvents ObjectSelected="function(s, e) {
											e.processOnServer = false;
											if (!textChanged) {
												oldSelectedTitleIndex = selectedTitleIndex;
												selectedTitleIndex = -1;
												if (e.hitInfo.inChartTitle)
													for (var i = 0; i &lt; chart.chart.titles.length; i++)
														if (e.hitObject === chart.chart.titles[i])
															selectedTitleIndex = i;
												if(selectedTitleIndex == -1)
													selectedTitleIndex = oldSelectedTitleIndex;
												e.processOnServer = selectedTitleIndex != oldSelectedTitleIndex;
											}
										 }"
			EndCallback="function(s, e) { UpdateControls(); }"
			ObjectHotTracked="function(s, e) { s.SetCursor(e.hitInfo.inChartTitle &amp;&amp; !textChanged ? 'pointer' : 'default'); }" />
		<Legend Visibility="False"></Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle WordWrap="True" Text="With XtraCharts, &lt;b&gt;you&lt;/b&gt; can display an &lt;u&gt;unlimited&lt;/u&gt; number of &lt;color=blue&gt;chart titles&lt;/color&gt;"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Text="&lt;size=14&gt;Title&lt;/size&gt; &lt;size=+2&gt;with &lt;size=+6&gt;a&lt;/size&gt;&lt;/size&gt; &lt;size=24&gt;variable&lt;/size&gt; &lt;size=14&gt;font &lt;size=+6&gt;size&lt;/size&gt;&lt;/size&gt;"></dx:ChartTitle>
			<dx:ChartTitle Dock="Left" Text="&lt;i&gt;Italicized&lt;/i&gt; title"></dx:ChartTitle>
			<dx:ChartTitle Dock="Right" Text="&lt;color=red&gt;Multi&lt;/color&gt;-&lt;color=green&gt;color&lt;/color&gt; &lt;color=blue&gt;title&lt;/color&gt;"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Visibility="False" VisibleInPanesSerializable="-1">
					<WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
				</AxisX>
				<AxisY Visibility="False" VisibleInPanesSerializable="-1"></AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
</asp:Content>