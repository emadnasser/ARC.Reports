<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="StepAreaSeries.aspx.vb" Inherits="StepAreaSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server"> 
			<table style="width: 100%;">
				<tr>
					<td><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="95px" ClientInstanceName="chbShowLabels">
						<ClientSideEvents CheckedChanged="function(s, e) {
	chart.PerformCallback(&quot;ShowLabels&quot;);
	labelLabelAngle.SetEnabled(chbShowLabels.GetChecked());
	cmbLabelAngle.SetEnabled(chbShowLabels.GetChecked());
}" />
					</dx:ASPxCheckBox></td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblLabelAngle" runat="server" Text="Label Angle:" ClientInstanceName="labelLabelAngle"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbLabelAngle" runat="server" Width="50px" ValueType="System.String" ClientInstanceName="cmbLabelAngle">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;LabelAngle&quot;); }" />
						</dx:ASPxComboBox>
					</td>
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
		DataSourceID="chartDataSource">
		<Legend Visibility="False"></Legend>
		<Titles>
			<dx:ChartTitle Text="Fuel Prices"></dx:ChartTitle>
		</Titles>
		<SeriesSerializable>
			<dx:Series Name="Fuel Oil" ArgumentScaleType="DateTime"
				ArgumentDataMember="Date" ValueDataMembersSerializable="Price">
				<ViewSerializable>
					<dx:StepAreaSeriesView></dx:StepAreaSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:PointSeriesLabel TextPattern="{V:F2}">
					</dx:PointSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Corporation" VisibleInPanesSerializable="-1">
					<DateTimeScaleOptions GridAlignment="Month" MeasureUnit="Month"/>
				</AxisX>
				<AxisY Interlaced="True" 
					Title-Text="Euros Per Liter" Title-Visibility="True" 
					VisibleInPanesSerializable="-1">
					<WholeRange AlwaysShowZeroLevel="False"  ></WholeRange>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
		<BorderOptions Visibility="False"></BorderOptions>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="SourceOfEnergy" SelectMethod="GetFuelPrices"></asp:ObjectDataSource>
</asp:Content>