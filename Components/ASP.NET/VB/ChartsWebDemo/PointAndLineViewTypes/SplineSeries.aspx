<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SplineSeries.aspx.vb" Inherits="SplineSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">  
			<table>
				<tr>
					<td style="width: 100%;"><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" ClientInstanceName="chbShowLabels">
						<ClientSideEvents CheckedChanged="function(s, e) {
	chart.PerformCallback(&quot;ShowLabels&quot;);
	labelLabelAngle.SetEnabled(chbShowLabels.GetChecked());
	cmbLabelAngle.SetEnabled(chbShowLabels.GetChecked());
}" />
					</dx:ASPxCheckBox></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
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
					<td>
						<dx:ASPxComboBox ID="cbMarkerSize" runat="server" Width="55px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerSize&quot;); }" />
						</dx:ASPxComboBox>
					</td>
				</tr>
				<tr>
					<td><div class="Spacer" style="width: 100%;height: 5px"></div></td>
				</tr>
				<tr>
					<td><div class="Spacer"></div></td>
					<td></td>
					<td></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblLineTension" runat="server" Text="Line Tension Percent:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbLineTension" runat="server" Width="130px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;LineTension&quot;); }" />
						</dx:ASPxComboBox>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblLabelAngle" runat="server" Text="Label Angle:" ClientInstanceName="labelLabelAngle"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbLabelAngle" runat="server" Width="55px" ValueType="System.String" ClientInstanceName="cmbLabelAngle">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;LabelAngle&quot;); }" />
						</dx:ASPxComboBox>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
		OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="True"
		ToolTipEnabled="False" DataSourceID="chartDataSource" SeriesDataMember="Branch">
		<Titles>
			<dx:ChartTitle Text="Power Consumption per Working Day"></dx:ChartTitle>
		</Titles>
		<SeriesTemplate ArgumentScaleType="DateTime" ArgumentDataMember="Time" ValueDataMembersSerializable="Power" LabelsVisibility="False">
			<ViewSerializable>
				<dx:SplineSeriesView LineTensionPercent="70"></dx:SplineSeriesView>
			</ViewSerializable>
		</SeriesTemplate>        
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Time of Day" Title-Visibility="True" VisibleInPanesSerializable="-1">
					<DateTimeScaleOptions ScaleMode="Continuous" />
					<GridLines Visible="True"></GridLines>
				</AxisX>
				<AxisY Interlaced="True" MinorCount="4" Title-Text="Power, kW" Title-Visibility="True" VisibleInPanesSerializable="-1">
					<WholeRange AlwaysShowZeroLevel="False"/>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
		<BorderOptions Visibility="False" />
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="PowerConsumption" SelectMethod="GetData"></asp:ObjectDataSource>
</asp:Content>